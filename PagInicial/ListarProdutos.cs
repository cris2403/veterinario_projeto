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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veterinario_projeto.PagInicial
{
    public partial class ListarProdutos : Form
    {
        public ListarProdutos()
        {
            InitializeComponent();
        }

        private void buttonLista_Click(object sender, EventArgs e)
        {

            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();

            string lista = "Select * from produtos";
            MySqlCommand cmd = new MySqlCommand(lista, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable ListarProd = new DataTable();
            ListarProd.Load(reader);
            dataGridViewProdutos.DataSource = ListarProd;
            connection.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            string Cod = textBoxCod.Text;
            string Descricao = textBoxDesc.Text;
            string Tipo = comboBoxTipo.Text;
            string Quantidade = textBoxQuant.Text;
            string Preco = textBoxPreco.Text;

            try
            {
                connection.Open();

                string query = "UPDATE produtos SET Descricao = @Descricao, Tipo = @Tipo, Quantidade = @Quantidade, Preco = @Preco WHERE Cod = @Cod";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Substitua os parâmetros pelos valores das TextBox
                command.Parameters.AddWithValue("@Descricao", textBoxDesc.Text);
                command.Parameters.AddWithValue("@Tipo", comboBoxTipo.Text);
                command.Parameters.AddWithValue("@Quantidade", Convert.ToInt32(textBoxQuant.Text));
                command.Parameters.AddWithValue("@Preco", Convert.ToInt32(textBoxPreco.Text));
                command.Parameters.AddWithValue("@Cod", Convert.ToInt32(textBoxCod.Text));
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

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();
            string apaga = "Delete from produtos where Cod='" + textBoxCod.Text + "'";
            MySqlCommand cmd = new MySqlCommand(apaga, connection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Apagado com sucesso");
        }
    }
}
