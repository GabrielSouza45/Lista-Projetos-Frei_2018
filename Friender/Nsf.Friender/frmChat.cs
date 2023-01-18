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
    public partial class frmChat : Form
    {
        public frmChat()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pp;
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

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("");
            listBox1.Items.Add("Eu: " + textBox1.Text);
        }
    }
}
