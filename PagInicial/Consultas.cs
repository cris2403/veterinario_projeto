using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace veterinario_projeto.PagInicial
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string Id_RDono = textBoxId.Text; // Da tabela registo (dono)
            string IdRegisto = textBoxId.Text; // Da tabela ranimal (animal)
            string Dono = textBoxDono.Text; // Da tabela registo (dono)
            string DNome = textBoxDono.Text; // Da tabela registo (dono)
            string Nome = textBoxAnimal.Text; // Da tabela ranimal (animal)
            string Animal = textBoxAnimal.Text; // Da tabela ranimal (animal)
            string TipoConsulta = comboBoxTipo.Text; // Da tabela consulta (consulta)
            string Colaborador = comboBoxColab.Text; // Da tabela registocolab (colaboradores)
            string Contacto = textBoxContacto.Text; // da tabela registo (dono)
            DateTime DataConsulta = dateTimePickerConsulta.Value; // da tabela consulta (consulta)
            string HoraConsulta = textBoxHoraConsulta.Text; // da tabela consulta (consulta)

            string insertconsulta = "INSERT INTO consulta (TipoConsulta, Colaborador, DataConsulta, HoraConsulta, IdRegisto, Dono, Animal, Contacto) " +
                                    "VALUES (@TipoConsulta, @Colaborador, @DataConsulta, @HoraConsulta, @IdRegisto, @Dono, @Animal, @Contacto)";

            if (Validate())
            {
               mySqlConnection.Open();
                    using (MySqlCommand donoCmd = new MySqlCommand("SELECT * FROM registo WHERE DNome = @DNome AND Id_RDono = @Id_RDono AND Contacto = @Contacto", mySqlConnection))
                    {
                        donoCmd.Parameters.AddWithValue("@DNome", DNome);
                        donoCmd.Parameters.AddWithValue("@Id_RDono", Id_RDono);
                        donoCmd.Parameters.AddWithValue("@Contacto", Contacto);

                        bool donoRegistado = false;

                        using (MySqlDataReader registo = donoCmd.ExecuteReader())
                        {
                            donoRegistado = registo.Read();
                        }

                        if (donoRegistado)
                        {
                            using (MySqlCommand command = new MySqlCommand(insertconsulta, mySqlConnection))
                            {
                                command.Parameters.AddWithValue("@TipoConsulta", TipoConsulta);
                                command.Parameters.AddWithValue("@Colaborador", Colaborador);
                                command.Parameters.AddWithValue("@DataConsulta", DataConsulta);
                                command.Parameters.AddWithValue("@HoraConsulta", HoraConsulta);
                                command.Parameters.AddWithValue("@IdRegisto", IdRegisto);
                                command.Parameters.AddWithValue("@Dono", Dono);
                                command.Parameters.AddWithValue("@Animal", Animal);
                                command.Parameters.AddWithValue("@Contacto", Contacto);

                                command.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dados do Dono ainda não se encontram registados!");
                        }
                    }

                    using (MySqlCommand animalCmd = new MySqlCommand("SELECT * FROM ranimal WHERE Nome = @Nome", mySqlConnection))
                    {
                        animalCmd.Parameters.AddWithValue("@Nome", Nome);

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
                                command.Parameters.AddWithValue("@Colaborador", Colaborador);
                                command.Parameters.AddWithValue("@DataConsulta", DataConsulta);
                                command.Parameters.AddWithValue("@HoraConsulta", HoraConsulta);
                                command.Parameters.AddWithValue("@IdRegisto", IdRegisto);
                                command.Parameters.AddWithValue("@Dono", Dono);
                                command.Parameters.AddWithValue("@Animal", Animal);
                                command.Parameters.AddWithValue("@Contacto", Contacto);

                                command.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dados do Animal ainda não se encontram registados!");
                        }
                    }

                using (MySqlCommand colabCmd = new MySqlCommand("SELECT * FROM registocolab WHERE Colaborador = @Colaborador", mySqlConnection))
                {
                    colabCmd.Parameters.AddWithValue("@Colaborador", Colaborador);

                    bool colabRegistado = false;

                    using (MySqlDataReader registarColab = colabCmd.ExecuteReader())
                    {
                        colabRegistado = registarColab.Read();
                    }

                    if (colabRegistado)
                    {
                        using (MySqlCommand command = new MySqlCommand(insertconsulta, mySqlConnection))
                        {
                            command.Parameters.AddWithValue("@TipoConsulta", TipoConsulta);
                            command.Parameters.AddWithValue("@Colaborador", Colaborador); 
                            command.Parameters.AddWithValue("@DataConsulta", DataConsulta);
                            command.Parameters.AddWithValue("@HoraConsulta", HoraConsulta);
                            command.Parameters.AddWithValue("@IdRegisto", IdRegisto);
                            command.Parameters.AddWithValue("@Dono", Dono);
                            command.Parameters.AddWithValue("@Animal", Animal);
                            command.Parameters.AddWithValue("@Contacto", Contacto);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Registo bem sucedido!");
                    }
                    else
                    {
                        MessageBox.Show("Não se encontra registado niguém com essa função na base de Dados! Por favor, Registe um colaborador.");
                    }
                }
                mySqlConnection.Close();
            }
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            ListarConsultas listaConsulta = new ListarConsultas();

            listaConsulta.Show();

            this.Hide();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            PaginaInicial paginaInicial = new PaginaInicial();

            paginaInicial.Show();

            this.Hide();
        }
    }
}
