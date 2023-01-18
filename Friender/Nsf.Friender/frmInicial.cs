using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.Friender
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNovo tela = new frmNovo();
            tela.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBuscar tela = new frmBuscar();
            tela.Show();
            Hide();
        }
    }
}
