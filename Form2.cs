using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void buttonRegisto_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string username = textBoxUsername.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            string insertQuery = "Insert into users (username, email, password) Values (@username, @email, @password)";

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
            }
        }
    }
}
