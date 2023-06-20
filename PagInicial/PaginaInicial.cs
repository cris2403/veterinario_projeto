using System;
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

        private void btn_colab_Click(object sender, EventArgs e)
        {

        }

        private void btn_donos_Click(object sender, EventArgs e)
        {
        }

        private void btn_canimal_Click(object sender, EventArgs e)
        {
            veterinario_projeto.PagInicial.CadAnimal registoAnimal = new veterinario_projeto.PagInicial.CadAnimal();

            registoAnimal.Show();

            this.Hide();
        }
    }
}
