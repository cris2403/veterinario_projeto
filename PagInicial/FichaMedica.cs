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
    public partial class FichaMedica : Form
    {
        public FichaMedica()
        {
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string Id = textBoxId.Text;
            string Ato = comboBoxAto.Text;
            string Descricao = textBoxDescMed.Text;
            string Custo = textBoxPreco.Text;
            DateTime DataRegisto = dateTimePickerRegisto.Value;

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
                        command.Parameters.AddWithValue("@Descricao", Descricao);
                        command.Parameters.AddWithValue("@Custo", Custo);
                        command.Parameters.AddWithValue("@DataRegisto", DataRegisto);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registo bem sucedido!");
                }
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            ListaFichaMedica ListaMedica = new ListaFichaMedica();

            ListaMedica.Show();

            this.Hide();
        }

        private void FichaMedica_Load(object sender, EventArgs e)
        {

        }
    }
}
