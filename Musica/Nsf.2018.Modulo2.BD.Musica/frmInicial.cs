using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Modulo2.BD.Musica
{
    public partial class frmInicial : Form
    {
        public static frmInicial Atual;
        
        public frmInicial()
        {
            InitializeComponent();
            Atual = this;
        }


        
        public void PlayMusic(string musica, string banda, string album, string caminho, decimal duracao)
        {
            lblMusica.Text = musica;
            lblBanda.Text = banda;
            lblAlbum.Text = album;
            lblCaminho.Text = caminho;
            lblDuracao.Text = duracao.ToString();

            mediaPlayer.URL = caminho;
            mediaPlayer.Ctlcontrols.play();

            btnPlay.Visible = false;
            btnPause.Visible = true;

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            decimal duracao = Convert.ToDecimal(lblDuracao.Text);
            duracao = duracao - 0.01m;

            lblDuracao.Text = duracao.ToString();
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






        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = true;
            btnPause.Visible = false;
            mediaPlayer.Ctlcontrols.pause();
            timer.Stop();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            btnPause.Visible = true;
            mediaPlayer.Ctlcontrols.play();
            timer.Start();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
        }
    }
}
