using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Modulo2.BD.Video
{
    public partial class frmInicial : Form
    {
        public static frmInicial Atual;
        
        public frmInicial()
        {
            InitializeComponent();
            Atual = this;
        }


        
        public void PlayMusic(string caminho)
        {
            if (panelConteudo.Controls.Count == 1)
                panelConteudo.Controls.RemoveAt(0);
            panelConteudo.Controls.Add(mediaPlayer);

            mediaPlayer.Visible = true;
            mediaPlayer.Dock = DockStyle.Fill;

            mediaPlayer.URL = caminho;
            mediaPlayer.Ctlcontrols.play();
        }






        public void OpenScreen(UserControl control)
        {
            if (panelConteudo.Controls.Count == 1)
                panelConteudo.Controls.RemoveAt(0);
            panelConteudo.Controls.Add(control);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovo tela = new frmNovo();
            OpenScreen(tela);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar tela = new frmBuscar();
            OpenScreen(tela);
        }





        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_Click(object sender, EventArgs e)
        {
            if (panelConteudo.Controls.Count == 1)
                panelConteudo.Controls.RemoveAt(0);
            mediaPlayer.Ctlcontrols.stop();
        }
    }
}
