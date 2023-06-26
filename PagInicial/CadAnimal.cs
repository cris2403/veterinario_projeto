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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace veterinario_projeto.PagInicial
{
    public partial class CadAnimal : Form
    {
        public CadAnimal()
        {
            InitializeComponent();
        }

        private void CadAnimal_Load(object sender, EventArgs e)
        {

        }

        private void btn_salvarAnimal_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=projeto;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string Dono = txt_dono.Text;
            string DNome = txt_dono.Text;
            string Nome = txt_nome.Text;
            string Tipo = comboBoxTipo.Text;
            string Raca = txt_raca.Text;
            string Idade = txt_idade.Text;
            string Peso = txt_peso.Text;

            string insertQuery1 = "Insert into ranimal (Dono,Nome, Tipo, Raca, Idade, Peso) Values (@Dono,@Nome, @Tipo, @Raca, @Idade, @Peso)";
           // string insertQuery2 = "Insert into registo (DNome) Values (@DNome)";

            if (Validate())
            {
                using (mySqlConnection)
                {
                    mySqlConnection.Open();
                    
                    {
                        using (MySqlCommand dono = new MySqlCommand("SELECT * FROM registo", mySqlConnection))
                        {
                            using (MySqlDataReader reader = dono.ExecuteReader())
                            {
                                bool donoRegistrado = false;

                                while (reader.Read())
                                {
                                    if (DNome.Equals(reader.GetString("DNome")))
                                    {
                                        donoRegistrado = true;
                                        break;
                                    }
                                }

                                // Close the reader before executing the next command
                                reader.Close();

                                if (donoRegistrado)
                                {
                                    using (MySqlCommand command = new MySqlCommand(insertQuery1, mySqlConnection))
                                    {
                                        command.Parameters.AddWithValue("@Dono", Dono);
                                        command.Parameters.AddWithValue("@Nome", Nome);
                                        command.Parameters.AddWithValue("@Tipo", Tipo);
                                        command.Parameters.AddWithValue("@Raca", Raca);
                                        command.Parameters.AddWithValue("@Idade", Idade);
                                        command.Parameters.AddWithValue("@Peso", Peso);
                                        command.ExecuteNonQuery();
                                    }
                                    MessageBox.Show("Registo bem sucedido!");
                                }
                                else
                                {
                                    MessageBox.Show("Dono ainda não foi registado!");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_limparAnimal_Click(object sender, EventArgs e)
        {
            txt_dono.Text = string.Empty;
            txt_nome.Text = string.Empty;
            comboBoxTipo.Text = string.Empty;
            txt_raca.Text = string.Empty;
            txt_idade.Text = string.Empty;
            txt_peso.Text = string.Empty;
        }

        private void btn_cancelarAnimal_Click(object sender, EventArgs e)
        {
            PaginaInicial paginaInicial = new PaginaInicial();

            paginaInicial.Show();

            this.Hide();
        }

        private void CadAnimal_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            ListarAnimais listarAnimais = new ListarAnimais();

            listarAnimais.Show();

            this.Hide();
        }

        private void btn_pagDonoAnimal_Click(object sender, EventArgs e)
        {
            Donos dono = new Donos();

            dono.Show();

            this.Hide();
        }
    }
}

