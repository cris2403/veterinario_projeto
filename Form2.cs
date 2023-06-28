using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace veterinario_projeto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form1 Login = new Form1();

            Login.Show();

            this.Hide();
        }

        private void buttonRegisto_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string username = textBoxUsername.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            string insertQuery = "Insert into users (username, email, password) Values (@username, @email, @password)";
            if (ValidarEmail(email))
            {
                using (mySqlConnection)
                {
                    mySqlConnection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registo bem sucedido!");

                    PaginaInicial paginaInicial = new PaginaInicial();

                    paginaInicial.Show();

                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Email inválido. Por favor, insira um email válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        public bool ValidarEmail(string email)
        {
            // Expressão regular para validar o formato de email
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Verificar se o email fornecido corresponde ao padrão
            Match match = Regex.Match(email, pattern);

            // Retorna true se o email for válido, false caso contrário
            return match.Success;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
