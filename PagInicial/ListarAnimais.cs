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
    public partial class ListarAnimais : Form
    {
        public ListarAnimais()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();
            string lista = "SELECT ranimal.Id_RAnimal, registo.DNome,ranimal.Nome, ranimal.Tipo, ranimal.Raca, ranimal.Idade, ranimal.Peso " +
                           "FROM registo " +
                           "INNER JOIN ranimal ON registo.DNOME = ranimal.Dono";


            MySqlCommand cmd = new MySqlCommand(lista, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable listarAnimais = new DataTable();
            listarAnimais.Load(reader);
            dataGridViewAnimais.DataSource = listarAnimais;
            connection.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string Id = textBoxID.Text;
            string dono = textBoxDono.Text;
            string nome = textBoxNome.Text;
            string tipo = comboBoxTipo.Text;
            string raca = textBoxRaca.Text;
            string idade = textBoxIdade.Text;
            string peso = textBoxPeso.Text;


            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            try
            {
                connection.Open();

                string query = "UPDATE ranimal SET dono = @Dono, nome = @Nome, tipo = @Tipo, raca = @Raca, Idade = @Idade, peso = @Peso WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Substitua os parâmetros pelos valores das TextBox
                command.Parameters.AddWithValue("@Dono", textBoxDono.Text);
                command.Parameters.AddWithValue("@Nome", textBoxNome.Text);
                command.Parameters.AddWithValue("@Tipo", comboBoxTipo.Text);
                command.Parameters.AddWithValue("@Raca", textBoxPeso.Text);
                command.Parameters.AddWithValue("@Idade", textBoxIdade.Text);
                command.Parameters.AddWithValue("@Peso", textBoxPeso.Text);
                command.Parameters.AddWithValue("@Id_RAnimal", Convert.ToInt32(textBoxID.Text));

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
            string apaga = "Delete from ranimal where Id_RAnimal='" + textBoxID.Text + "'";
            MySqlCommand cmd = new MySqlCommand(apaga, connection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Apagado com sucesso");
        }

        private void ListarAnimais_Load(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void Raça_Click(object sender, EventArgs e)
        {

        }

        private void Dono_Click(object sender, EventArgs e)
        {

        }

        private void Idade_Click(object sender, EventArgs e)
        {

        }

        private void Peso_Click(object sender, EventArgs e)
        {

        }

        private void Tipo_Click(object sender, EventArgs e)
        {

        }
    }
}
