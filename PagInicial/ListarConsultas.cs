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
    public partial class ListarConsultas : Form
    {
        public ListarConsultas()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();

            string lista = "Select * from consulta";
            MySqlCommand cmd = new MySqlCommand(lista, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable ListaConsultas = new DataTable();
            ListaConsultas.Load(reader);
            dataGridViewConsultas.DataSource = ListaConsultas;
            connection.Close();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();
            string apaga = "Delete from consulta where Id='" + textBoxId.Text + "'";
            MySqlCommand cmd = new MySqlCommand(apaga, connection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Apagado com sucesso");
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            string Id = textBoxId.Text;
            string TipoConsulta = comboBoxTipo.Text;
            string Colaborador = comboBoxColab.Text;
            DateTime DataConsulta = dateTimePickerConsulta.Value;
            string HoraConsulta = textBoxHoraConsulta.Text;

            try
            {
                connection.Open();

                string query = "UPDATE consulta SET TipoConsulta = @TipoConsulta, DataConsulta = @DataConsulta, HoraConsulta = @HoraConsulta, Colaborador = @Colaborador WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Substitua os parâmetros pelos valores das TextBox
                command.Parameters.AddWithValue("@HoraConsulta", HoraConsulta);
                command.Parameters.AddWithValue("@HoraConsulta", DataConsulta);
                command.Parameters.AddWithValue("@TipoConsulta", TipoConsulta);
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(Id));

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
    }
}
