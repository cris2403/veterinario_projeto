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

namespace veterinario_projeto.PagInicial
{
    public partial class AtoMedico : Form
    {
        public AtoMedico()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            ListarAtoMedico listaatomedico = new ListarAtoMedico();

            listaatomedico.Show();

            this.Hide();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            PaginaInicial paginaInicial = new PaginaInicial();

            paginaInicial.Show();

            this.Hide();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string Id = textBoxId.Text;
            string Ato = comboBoxAtoMedico.Text;
            DateTime DataRegisto = dateTimePickerDataRegisto.Value;
            string Descricao = textBoxDesc.Text;
            string Custo = textBoxCusto.Text;

            string insertQuery = "Insert into atomedico (Id, Ato, Descricao, Custo, DataRegisto) Values (@Id, @Ato, @Descricao, @Custo, @DataRegisto)";
            if (Validate())
            {
                using (mySqlConnection)
                {
                    mySqlConnection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Ato", Ato);
                        command.Parameters.AddWithValue("@DataRegisto", DataRegisto);
                        command.Parameters.AddWithValue("@Descricao", Descricao);
                        command.Parameters.AddWithValue("@Custo", Custo);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registo bem sucedido!");
                }
            }
        }
    }
}
