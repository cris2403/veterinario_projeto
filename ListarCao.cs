using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veterinario_projeto
{
    public partial class ListarCao : Form
    {
        public ListarCao()
        {
            InitializeComponent();
        }

        private void btn_listarListar_Click(object sender, EventArgs e)
        {
            // Configurar a conexão com o banco de dados
            string mysqlconn = "server=127.0.0.1;user=root;database=canimal;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();

            string lista = "SELECT * FROM `ranimal`";
            MySqlCommand cmd = new MySqlCommand(lista, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable listarLogin = new DataTable();
            listarLogin.Load(reader);
            dataGridView1.DataSource = listarLogin;
            connection.Close();
        }

        private void btn_apagarListar_Click(object sender, EventArgs e)
        {
            // configurar a conexao com o banco de dados
            string mysqlconn = "server=127.0.0.1;user=root;database=canimal;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();
            string apaga = "Delete from ranimal where Dono = '" + txt_dono.Text + "'";
            MySqlCommand cmd = new MySqlCommand(apaga, connection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Apagado com sucesso");
        }
    }
}
