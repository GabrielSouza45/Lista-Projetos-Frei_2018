using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Modulo2.DB.Filosofia
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
            ConfigurarPosicao();
        }

        private void ConfigurarPosicao()
        {
            this.Width = 325;
            this.Height = 230;

            Left = (Screen.PrimaryScreen.WorkingArea.Width - 850) / 2;
            Top = (Screen.PrimaryScreen.WorkingArea.Height - 600) / 2;
        }


        private void btnExpand_Click(object sender, EventArgs e)
        {
            AnimacaoTimer.Start();

            lblMessage.Visible = false;
            btnExpand.Visible = false;
        }

        
        private void AnimacaoTimer_Tick(object sender, EventArgs e)
        {
            this.Width += 40;
            this.Height += 30;

            if (this.Width > 850)
                this.Width = 850;

            if (this.Height > 600)
                this.Height = 600;

            if (this.Width == 850 && this.Height == 600)
            {
                AnimacaoTimer.Stop();
                AbrirTela(new Telas.frmBuscar());
            }
        }


        public void AbrirTela(UserControl tela)
        {
            if (panelConteudo.Controls.Count == 1)
            {
                panelConteudo.Controls.RemoveAt(0);
            }

            panelConteudo.Controls.Add(tela);
        }


        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            AbrirTela(new Telas.frmNovo());
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbrirTela(new Telas.frmBuscar());
        }
    }
}
