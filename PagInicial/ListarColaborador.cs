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
    public partial class ListarColaborador : Form
    {
        public ListarColaborador()
        {
            InitializeComponent();
        }

        private void date_inicioColab_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();

            string lista = "Select * from registocolab";
            MySqlCommand cmd = new MySqlCommand(lista, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable ListarColab = new DataTable();
            ListarColab.Load(reader);
            dataGridViewColaborador.DataSource = ListarColab;
            connection.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            string Id = textBoxID.Text;
            string Nome = textBoxNome.Text;
            DateTime DataNascimento = dateTimePickerNascimento.Value;
            string NIF = textBoxNIF.Text;
            string Tipo = comboBox_tipoColab.Text;
            string Funcao = comboBox_funcaoColab.Text;
            string Contacto = textBoxContacto.Text;
            DateTime dataFimColab = date_fimColab.Value;
            DateTime dataInicioColab = date_inicioColab.Value;
            string Disponibilidade = textBoxDisp.Text;


            try
            {
                connection.Open();

                string query = "UPDATE registocolab SET nome = @Nome, DataNascimento = @DataNascimento, NIF = @NIF, Tipo = @Tipo, Funcao = @Funcao, Contacto = @Contacto, DataInicio = @DataInicio, DataFim = @DataFim, Disponibilidade = @Disponibilidade WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Substitua os parâmetros pelos valores das TextBox
                command.Parameters.AddWithValue("@Nome", textBoxNome.Text);
                command.Parameters.AddWithValue("@Tipo", Tipo);
                command.Parameters.AddWithValue("@Funcao", Funcao);
                command.Parameters.AddWithValue("@Disponibilidade", textBoxDisp.Text);
                command.Parameters.AddWithValue("@dataNascimento", DataNascimento);
                command.Parameters.AddWithValue("@DataInicio", dataInicioColab);
                command.Parameters.AddWithValue("@DataFim", dataFimColab);
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
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection connection = new MySqlConnection(mysqlconn);

            connection.Open();
            string apaga = "Delete from registocolab where id='" + textBoxID.Text + "'";
            MySqlCommand cmd = new MySqlCommand(apaga, connection);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Apagado com sucesso");
        }

        private void ListarColaborador_Load(object sender, EventArgs e)
        {

        }
    }
}
