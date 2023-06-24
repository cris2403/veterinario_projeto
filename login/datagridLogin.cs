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

namespace veterinario_projeto.login
{
    public partial class datagridLogin : Form
    {
        public datagridLogin()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            // Configurar a conexão com o banco de dados
            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();

            string lista = "Select * from users";
            MySqlCommand cmd = new MySqlCommand(lista, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable listarLogin= new DataTable();
            listarLogin.Load(reader);
            dataGridView1.DataSource = listarLogin;        
            connection.Close();

            
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();
            string apaga = "Delete from users where user_id='"+textBoxID.Text+"'";
            MySqlCommand cmd = new MySqlCommand(apaga, connection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Apagado com sucesso");

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string username = textBoxUsername.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);
            
            try
            {
                connection.Open();

                string query = "UPDATE users SET username = @username, email = @email, password = @password WHERE user_id = @user_id";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Substitua os parâmetros pelos valores das TextBox
                command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@password", textBoxPassword.Text);
                command.Parameters.AddWithValue("@user_id", Convert.ToInt32(textBoxID.Text));

                command.ExecuteNonQuery();

                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar os dados: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            string username = textBoxUsername.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxEmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPassword.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
