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
    public partial class ListaFichaMedica : Form
    {
        public ListaFichaMedica()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();

            string lista = "Select * from fichamedica";
            MySqlCommand cmd = new MySqlCommand(lista, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable ListaFichaMedica = new DataTable();
            ListaFichaMedica.Load(reader);
            dataGridViewFichaMedica.DataSource = ListaFichaMedica;
            connection.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            string Id = textBoxID.Text;
            string Observacoes = textBoxObservacoes.Text;
            string PrescricaoMedica = textBoxPrescricao.Text;
            string Diagnostico = textBoxDiagnostico.Text;
            string Peso = textBoxPeso.Text;
            DateTime DataPVisita = dateTimePickerPVisita.Value;

            try
            {
                connection.Open();

                string query = "UPDATE fichamedica SET Observacoes = @Observacoes, PrescricaoMedica = @PrescricaoMedica, Diagnostico = @Diagnostico, Peso = @Peso, DataPVisita = @DataPVisita WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Observacoes", Observacoes);
                command.Parameters.AddWithValue("@PrescricaoMedica", PrescricaoMedica);
                command.Parameters.AddWithValue("@Diagnostico", Diagnostico);
                command.Parameters.AddWithValue("@Peso", Peso);
                command.Parameters.AddWithValue("@DataPVisita", DataPVisita);
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
            string apaga = "Delete from fichamedica where Id='" + textBoxID.Text + "'";
            MySqlCommand cmd = new MySqlCommand(apaga, connection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Apagado com sucesso");
        }

        private void DataPVISITA_Click(object sender, EventArgs e)
        {

        }

        private void Pesquisa_Click(object sender, EventArgs e)
        {

        }
    }
}
