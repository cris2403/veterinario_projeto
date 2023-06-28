using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
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

            string Id_RDono = textBoxId.Text; // Da tabela registo (dono)
            string IdRegisto = textBoxId.Text; // Da tabela ranimal (animal)
            string Animal = textBoxAnimal.Text; // Da tabela registo (dono)
            string NomeAnimal = textBoxAnimal.Text; // Da tabela ranimal (animal)
            string Colaborador = textBoxColaborador.Text; // Da tabela ranimal (animal)
            string NomeColaborador = textBoxColaborador.Text; // Da tabela ranimal (animal)
            string TipoConsulta = comboBoxTipo.Text; // Da tabela consulta (consulta)
            string Peso = textBoxPeso.Text; // Da tabela registocolab (colaboradores)
            string Diagnostico = textBoxDiagnostico.Text; // da tabela registo (dono)
            DateTime DataAM = dateTimePickerConsulta.Value; // da tabela consulta (consulta)
            DateTime DataPVisita = dateTimePickerPVisita.Value; // da tabela consulta (consulta)
            string Observacoes = textBoxExtra.Text; // da tabela consulta (consulta)
            string PrescricaoMedica = textBoxPrescricaoMedica.Text; // da tabela consulta (consulta)

            string insertconsulta = "INSERT INTO fichamedica (NomeAnimal, DataAM, TipoConsulta, NomeColaborador, Diagnostico, Peso, Observacoes, PrescricaoMedica, DataPVisita, Id_RDono) " +
                                    "VALUES (@NomeAnimal, @DataAM, @TipoConsulta, @NomeColaborador, @Diagnostico, @Peso, @Observacoes, @PrescricaoMedica, @DataPVisita ,@Id_RDono)";

            if (Validate())
            {
                mySqlConnection.Open();
                using (MySqlCommand donoCmd = new MySqlCommand("SELECT * FROM registo WHERE Id_RDono = @Id_RDono", mySqlConnection))
                {
                    donoCmd.Parameters.AddWithValue("@Id_RDono", Id_RDono);

                    bool donoRegistado = false;

                    using (MySqlDataReader registo = donoCmd.ExecuteReader())
                    {
                        donoRegistado = registo.Read();
                    }

                    if (donoRegistado)
                    {
                        using (MySqlCommand animalCmd = new MySqlCommand("SELECT * FROM ranimal WHERE Nome = @Nome", mySqlConnection))
                        {
                            animalCmd.Parameters.AddWithValue("@Nome", NomeAnimal);

                            bool animalRegistado = false;

                            using (MySqlDataReader registoAnimal = animalCmd.ExecuteReader())
                            {
                                animalRegistado = registoAnimal.Read();
                            }

                            if (animalRegistado)
                            {
                                using (MySqlCommand command = new MySqlCommand(insertconsulta, mySqlConnection))
                                {
                                    command.Parameters.AddWithValue("@TipoConsulta", TipoConsulta);
                                    command.Parameters.AddWithValue("@NomeColaborador", NomeColaborador);
                                    command.Parameters.AddWithValue("@DataAM", DataAM.ToString("yyyy-MM-dd"));
                                    command.Parameters.AddWithValue("@DataPVisita", DataPVisita);
                                    command.Parameters.AddWithValue("@Id_RDono", Id_RDono);
                                    command.Parameters.AddWithValue("@Diagnostico", Diagnostico);
                                    command.Parameters.AddWithValue("@NomeAnimal", NomeAnimal);
                                    command.Parameters.AddWithValue("@Peso", Peso);
                                    command.Parameters.AddWithValue("@Observacoes", Observacoes);
                                    command.Parameters.AddWithValue("@PrescricaoMedica", PrescricaoMedica);

                                    command.ExecuteNonQuery();

                                }
                            }
                            else
                            {
                                MessageBox.Show("Dados do Animal ainda não se encontram registados!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dados do Dono ainda não se encontram registados!");
                    }
                }




                mySqlConnection.Close();
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            PaginaInicial paginaInicial = new PaginaInicial();

            paginaInicial.Show();

            this.Hide();
        }
    }
}
