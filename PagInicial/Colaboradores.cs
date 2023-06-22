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

namespace veterinario_projeto.PagInicial
{
    public partial class Colaboradores : Form
    {
        public Colaboradores()
        {
            InitializeComponent();
        }

        private void btn_limparColab_Click(object sender, EventArgs e)
        {
            txt_idColab.Text = string.Empty;
            txt_nomeColab.Text = string.Empty;
            txt_nifColab.Text = string.Empty;
            txt_contactoColab.Text = string.Empty;
            comboBox_tipoColab.Text = string.Empty;
            comboBox_funcaoColab.Text = string.Empty;
            txt_disponibilidadeColab.Text = string.Empty;

        }

        private void btn_cancelarColab_Click(object sender, EventArgs e)
        {
            PaginaInicial paginaInicial = new PaginaInicial();

            paginaInicial.Show();

            this.Hide();
        }

        private void btn_salvarColab_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=colaboradores;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string Id = txt_idColab.Text;
            string Nome = txt_nomeColab.Text;
            DateTime DataNascimento = date_nascimentoColab.Value;
            string NIF = txt_nifColab.Text;
            string Tipo = comboBox_tipoColab.Text;
            string Funcao = comboBox_funcaoColab.Text;
            string Contacto = txt_contactoColab.Text;
            DateTime DataInicio = date_inicioColab.Value;
            DateTime DataFim = date_fimColab.Value;
            string Disponibilidade = txt_disponibilidadeColab.Text; ;

            string insertQuery = "Insert into registocolab (Id, Nome, DataNascimento,NIF, Tipo, Funcao, Contacto, DataInicio, DataFim, Disponibilidade) Values (@Id, @Nome, @DataNascimento, @NIF, @Tipo, @Funcao, @Contacto, @DataInicio, @DataFim, @Disponibilidade)";
            if (Validate())
            {
                using (mySqlConnection)
                {
                    mySqlConnection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Nome", Nome);
                        command.Parameters.AddWithValue("@DataNascimento", DataNascimento);
                        command.Parameters.AddWithValue("@NIF", NIF);
                        command.Parameters.AddWithValue("@Tipo", Tipo);
                        command.Parameters.AddWithValue("@Funcao", Funcao);
                        command.Parameters.AddWithValue("@Contacto", Contacto);
                        command.Parameters.AddWithValue("@DataInicio", DataInicio);
                        command.Parameters.AddWithValue("@DataFim", DataFim);
                        command.Parameters.AddWithValue("@Disponibilidade", Disponibilidade);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registo bem sucedido!");

                    PaginaInicial paginaInicial = new PaginaInicial();

                    paginaInicial.Show();

                    this.Hide();
                }
            }
        }
    }
}
