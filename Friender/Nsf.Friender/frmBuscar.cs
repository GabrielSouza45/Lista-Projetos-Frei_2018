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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
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

        private void button4_Click(object sender, EventArgs e)
        {
            List<Aluno> alunos = new List<Aluno>();

            Aluno b = new Aluno();
            b.Nome = "Bruno";
            b.Ano = 2005;
            b.Turma = "Informática C";

            alunos.Add(b);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = alunos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChat tela = new frmChat();
            tela.Show();
            Hide();
        }
    }

    class Aluno
    {
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Turma { get; set; }
    }
}
