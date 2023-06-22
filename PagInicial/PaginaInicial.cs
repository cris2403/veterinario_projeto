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

        private void button_cAnimal_Click(object sender, EventArgs e)
        {
            CadAnimal c1 = new CadAnimal();

            c1.Show();

            this.Hide();
        }

        private void button_cAnimal_Click_1(object sender, EventArgs e)
        {
            ListarCao cao = new ListarCao();

            cao.Show();

            this.Hide();
        }
    }
}
