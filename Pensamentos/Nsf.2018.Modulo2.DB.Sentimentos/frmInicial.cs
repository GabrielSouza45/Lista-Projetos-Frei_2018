using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Modulo2.DB.Sentimentos
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        public void AbrirTela(UserControl tela)
        {
            if (panelConteudo.Controls.Count > 5)
            {
                panelConteudo.Controls.RemoveAt(0);
            }
            panelConteudo.Controls.Add(tela);
            panelConteudo.Controls.SetChildIndex(tela, 0);
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            if (panelConteudo.Controls.Count > 5)
            {
                panelConteudo.Controls.RemoveAt(0);
            }
        }


        private void btnPositivo_Click(object sender, EventArgs e)
        {
            Telas.frmNovo tela = new Telas.frmNovo();
            tela.LoadScreen(true);

            AbrirTela(tela);
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            Telas.frmNovo tela = new Telas.frmNovo();
            tela.LoadScreen(false);

            AbrirTela(tela);
        }

        private void btnVerPensamentos_Click(object sender, EventArgs e)
        {
            AbrirTela(new Telas.frmBuscar());
        }
    }
}
