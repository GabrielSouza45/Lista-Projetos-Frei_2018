using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Escola
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrar form = new frmCadastrar();
            form.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListar form = new frmListar();
            form.Show();
        }

        private void filtrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltrar form = new frmFiltrar();
            form.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
