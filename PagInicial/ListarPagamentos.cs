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

namespace veterinario_projeto.PagInicial
{
    public partial class ListarPagamentos : Form
    {
        public ListarPagamentos()
        {
            InitializeComponent();
        }

        private void btn_ListarPagamentos_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();

            string listapagamentos = "Select * from precario";
            MySqlCommand cmd = new MySqlCommand(listapagamentos, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable ListaPagamentos = new DataTable();
            ListaPagamentos.Load(reader);
            dataGridView_ListarPagamentos.DataSource = ListaPagamentos;
            connection.Close();
        }

        private void btn_SalvarListarPagamentos_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            string Id = txt_idListarPagamentos.Text;
            string Ato = comboBox_Ato.Text;
            string descricaoAtoMedico = txt_descricaomedicaListarPagamentos.Text;
            string custo = txt_custoListarPagamentos.Text;
            string tipo = comboBox_tipo.Text;
            string descricao = txt_descricaoprodutoListarPagamentos.Text;
            string quantidade = txt_qtdListarPagamentos.Text;
            string preco = txt_precoListarPagamentos.Text;

            try
            {
                connection.Open();

                string query = "UPDATE precario SET Id = @Id, Ato = @Ato, descricaoAtoMedico = @descricaoAtoMedico, tipo = @tipo, descricao = @descricao, quantidade = @quantidade, preco = @preco WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Ato", Ato);
                command.Parameters.AddWithValue("@descricaoAtoMedico", descricaoAtoMedico);
                command.Parameters.AddWithValue("@custo", custo);
                command.Parameters.AddWithValue("@tipo", tipo);
                command.Parameters.AddWithValue("@descricao", descricao);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@preco", preco);
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

        private void btn_ApagarListarPagamentos_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();
            string apaga = "Delete from precario where Id='" + txt_idListarPagamentos.Text + "'";
            MySqlCommand cmd = new MySqlCommand(apaga, connection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Apagado com sucesso");
        }

        private void btn_CancelarListarPagamentos_Click(object sender, EventArgs e)
        {
            Pagamentos p = new Pagamentos();

            p.Show();

            this.Hide();
        }
    }
}
