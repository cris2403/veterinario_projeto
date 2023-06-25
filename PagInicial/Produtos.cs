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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string Cod = textBoxCodProd.Text;
            string Descricao = textBoxDescProd.Text;
            string Tipo = comboBoxTipoProd.Text;
            string Quantidade = textBoxQuant.Text;
            string Preco = textBoxPreco.Text; 

            string insertQuery = "INSERT INTO produtos (Cod, Descricao, Tipo, Quantidade, Preco) Values (@Cod, @Descricao, @Tipo, @Quantidade, @Preco)";
            if (Validate())
            {
                using (mySqlConnection)
                {
                    mySqlConnection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@Descricao", textBoxDescProd.Text);
                        command.Parameters.AddWithValue("@Tipo", comboBoxTipoProd.Text);
                        command.Parameters.AddWithValue("@Quantidade", Convert.ToInt32(textBoxQuant.Text));
                        command.Parameters.AddWithValue("@Preco", Convert.ToInt32(textBoxPreco.Text));
                        command.Parameters.AddWithValue("@Cod", Convert.ToInt32(textBoxCodProd.Text));
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registo bem sucedido!");

                    PaginaInicial paginaInicial = new PaginaInicial();

                    paginaInicial.Show();

                    this.Hide();
                }
            }
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            PaginaInicial paginaInicial = new PaginaInicial();

            paginaInicial.Show();

            this.Hide();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            ListarProdutos ListaProd = new ListarProdutos();

            ListaProd.Show();

            this.Hide();
        }
    }
}
