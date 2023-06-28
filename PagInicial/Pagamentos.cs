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
    public partial class Pagamentos : Form
    {
        public Pagamentos()
        {
            InitializeComponent();
        }

        private void btn_inserirPagamentos_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string Ato = txt_atomedico.Text;
            string descricaoAtoMedico = txt_descricaoAtoMedico.Text;
            string custo = txt_AtoMedicoCusto.Text;
            string tipo = txt_tipoProduto.Text;
            string Descricao = txt_descricaoProduto.Text;
            string Quantidade = txt_QtdProduto.Text;
            string Preco = txt_PrecoProduto.Text;


            string insertprecario = "INSERT INTO precario (Ato, descricaoAtoMedico, custo, tipo, Descricao, Quantidade, Preco) " +
                                    "VALUES (@Ato, @descricaoAtoMedico, @custo, @tipo, @Descricao, @Quantidade, @Preco)";

            if (Validate())
            {
                mySqlConnection.Open();
                using (MySqlCommand quantidadeCmd = new MySqlCommand("SELECT * FROM produtos WHERE Quantidade = @Quantidade", mySqlConnection))
                {
                    quantidadeCmd.Parameters.AddWithValue("@Quantidade", Quantidade);

                    bool quantidaderegisto = false;

                    using (MySqlDataReader registoquantidade = quantidadeCmd.ExecuteReader())
                    {
                        quantidaderegisto = registoquantidade.Read();
                    }

                    if (quantidaderegisto)
                    {
                        using (MySqlCommand atoCmd = new MySqlCommand("SELECT * FROM atomedico WHERE Ato = @Ato", mySqlConnection))
                        {
                            atoCmd.Parameters.AddWithValue("@Ato", Ato);

                            bool atoregisto = false;

                            using (MySqlDataReader registoato = atoCmd.ExecuteReader())
                            {
                                atoregisto = registoato.Read();
                            }

                            if (atoregisto)
                            {
                                using (MySqlCommand command = new MySqlCommand(insertprecario, mySqlConnection))
                                {
                                    command.Parameters.AddWithValue("@Ato", Ato);
                                    command.Parameters.AddWithValue("@descricaoAtoMedico", descricaoAtoMedico);
                                    command.Parameters.AddWithValue("@custo", custo);
                                    command.Parameters.AddWithValue("@tipo", tipo);
                                    command.Parameters.AddWithValue("@Descricao", Descricao);
                                    command.Parameters.AddWithValue("@Quantidade", Quantidade);
                                    command.Parameters.AddWithValue("@Preco", Preco);
                                    command.ExecuteNonQuery();

                                }

                                MessageBox.Show("Atos e produtos adicionado aos pagamentos");
                            }
                            else
                            {
                                MessageBox.Show("Ato não registado");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto encontra-se inativo/fora de stock");
                    }
                }




                mySqlConnection.Close();
            }
        }

        private void btn_ListarPagamentos_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();

            string listaPagamentoProdutos = "Select Tipo, Descricao, Quantidade, Preco from produtos";
            MySqlCommand cmdProduto = new MySqlCommand(listaPagamentoProdutos, connection);
            MySqlDataReader readerProduto = cmdProduto.ExecuteReader();
            DataTable ListaPagamentosProduto = new DataTable();
            ListaPagamentosProduto.Load(readerProduto);
            data_ProdPreco.DataSource = ListaPagamentosProduto;

            string listaPagamentoAtoMedico = "Select Ato, Descricao, Custo from atomedico";
            MySqlCommand cmdAtoMedico = new MySqlCommand(listaPagamentoAtoMedico, connection);
            MySqlDataReader readerAtoMedico = cmdAtoMedico.ExecuteReader();
            DataTable ListaPagamentosAtoMedico = new DataTable();
            ListaPagamentosAtoMedico.Load(readerAtoMedico);
            data_AtoMedicoCusto.DataSource = ListaPagamentosAtoMedico;
            connection.Close();
        }

        private void btn_cancelarPagamentos_Click(object sender, EventArgs e)
        {
            PaginaInicial paginaInicial = new PaginaInicial();

            paginaInicial.Show();

            this.Hide();
        }

        private void data_AtoMedicoCusto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            string Ato = txt_atomedico.Text;
            string DescricaoAtoMedico = txt_descricaoAtoMedico.Text;
            string Custo = txt_AtoMedicoCusto.Text;

            txt_atomedico.Text = data_AtoMedicoCusto.CurrentRow.Cells[0].Value.ToString();
            txt_descricaoAtoMedico.Text = data_AtoMedicoCusto.CurrentRow.Cells[1].Value.ToString();
            txt_AtoMedicoCusto.Text = data_AtoMedicoCusto.CurrentRow.Cells[2].Value.ToString();
        }

        private void data_ProdPreco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            string tipo = txt_tipoProduto.Text;
            string Descricao = txt_descricaoProduto.Text;
            string Quantidade = txt_QtdProduto.Text;
            string Preco = txt_PrecoProduto.Text;

            txt_tipoProduto.Text = data_ProdPreco.CurrentRow.Cells[0].Value.ToString();
            txt_descricaoProduto.Text = data_ProdPreco.CurrentRow.Cells[1].Value.ToString();
            txt_QtdProduto.Text = data_ProdPreco.CurrentRow.Cells[2].Value.ToString();
            txt_PrecoProduto.Text = data_ProdPreco.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_pendentes_Click(object sender, EventArgs e)
        {
            ListarPagamentos listarpagamentos = new ListarPagamentos();

            listarpagamentos.Show();

            this.Hide();
        }
    }
}
