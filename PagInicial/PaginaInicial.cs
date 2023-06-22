﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veterinario_projeto.PagInicial;

namespace veterinario_projeto
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void button_cAnimal_Click(object sender, EventArgs e)
        {
            CadAnimal c1 = new CadAnimal();

            c1.Show();

            this.Hide();
        }

        private void btn_donos_Click(object sender, EventArgs e)
        {
            Donos d1 = new Donos();

            d1.Show();

            this.Hide();
        }

        private void btn_colaboradores_Click(object sender, EventArgs e)
        {
            Colaboradores c2 = new Colaboradores();

            c2.Show();

            this.Hide();
        }
    }
}
