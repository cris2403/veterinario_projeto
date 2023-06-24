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
    public partial class ListarDonos : Form
    {
        public ListarDonos()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {

            string mysqlconn = "server=127.0.0.1;user=root;database=dono;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();

            string lista = "Select * from registo";
            MySqlCommand cmd = new MySqlCommand(lista, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable listarDono = new DataTable();
            listarDono.Load(reader);
            dataGridViewDonos.DataSource = listarDono;
            connection.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=dono;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            string Id = textBoxID.Text;
            string Nome = textBoxNome.Text;
            DateTime DataNascimento = dateTimePickerNascimento.Value;
            string NIF = textBoxNIF.Text;
            string Contacto = textBoxContacto.Text;

            try
            {
                connection.Open();

                string query = "UPDATE registo SET nome = @Nome, DataNascimento = @DataNascimento, NIF = @NIF, Contacto = @Contacto WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Substitua os parâmetros pelos valores das TextBox
                command.Parameters.AddWithValue("@Nome", textBoxNome.Text);
                command.Parameters.AddWithValue("@dataNascimento", DataNascimento );
                command.Parameters.AddWithValue("@NIF", Convert.ToInt32(textBoxNIF.Text));
                command.Parameters.AddWithValue("@Contacto", Convert.ToInt32(textBoxContacto.Text));
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(textBoxID.Text));

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
            string mysqlconn = "server=127.0.0.1;user=root;database=dono;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();
            string apaga = "Delete from registo where Id='" + textBoxID.Text + "'";
            MySqlCommand cmd = new MySqlCommand(apaga, connection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Apagado com sucesso");
        }
    }
}
