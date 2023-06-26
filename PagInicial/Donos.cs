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
    public partial class Donos : Form
    {
        public Donos()
        {
            InitializeComponent();
        }

        private void btn_salvarDono_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string Id_RDono = txt_idDono.Text;
            string DNome = txt_nomeDono.Text;
            DateTime DataNascimento = dateTimePickerDataNascimento.Value;
            string NIF = txt_nifDono.Text;
            string Contacto = txt_contactoDono.Text;

            string insertQuery = "Insert into registo (Id_RDono, DNome, DataNascimento, NIF, Contacto) Values (@Id_RDono, @DNome, @DataNascimento, @NIF, @Contacto)";
            if (Validate())
            {
                using (mySqlConnection)
                {
                    mySqlConnection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@Id_RDono", Id_RDono);
                        command.Parameters.AddWithValue("@DNome", DNome);
                        command.Parameters.AddWithValue("@DataNascimento", DataNascimento);
                        command.Parameters.AddWithValue("@NIF", NIF);
                        command.Parameters.AddWithValue("@Contacto", Contacto);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registo bem sucedido!");
                }
            }
        }

        private void btn_limparDono_Click(object sender, EventArgs e)
        {
            txt_idDono.Text = string.Empty;
            txt_nomeDono.Text = string.Empty;
            txt_nifDono.Text = string.Empty;
            txt_contactoDono.Text = string.Empty;
        }

        private void btn_cancelarDono_Click(object sender, EventArgs e)
        {
            PaginaInicial paginaInicial = new PaginaInicial();

            paginaInicial.Show();

            this.Hide();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            ListarDonos listarDono = new ListarDonos();

            listarDono.Show();

            this.Hide();
        }

        private void Donos_Load(object sender, EventArgs e)
        {

        }
    }
}
