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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veterinario_projeto
{
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {

        }

        private void btn_listarListar_Click(object sender, EventArgs e)
        {
            // Configurar a conexão com o banco de dados
            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();

            string lista = "Select * from users";
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
            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();
            string apaga = "Delete from users where user_id='" + txt_idListar.Text + "'";
            MySqlCommand cmd = new MySqlCommand(apaga, connection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Apagado com sucesso");
        }
    }
}
