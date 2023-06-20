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



        }
    }
}
