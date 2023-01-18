using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nsf._2018.Modulo2.BD.Musica.DB;

namespace Nsf._2018.Modulo2.BD.Musica
{
    public partial class frmAlterar : UserControl
    {
        public frmAlterar()
        {
            InitializeComponent();
            CarregarGenero();
        }

        private void CarregarGenero()
        {
            List<string> generos = new List<string>();
            generos.Add("Selecione");
            generos.Add("MPB");
            generos.Add("Rock");
            generos.Add("Pop");
            generos.Add("Hip-Hop");
            generos.Add("Funk");
            generos.Add("Sertanejo");
            generos.Add("Forró");
            generos.Add("Clássica");
            generos.Add("Samba");
            generos.Add("Outro");

            cboGenero.DataSource = generos;
        }



        MusicaDTO musica;


        public void LoadScreen(MusicaDTO musica)
        {
            this.musica = musica;

            lblId.Text = musica.Id.ToString();
            txtMusica.Text = musica.Nome;
            txtBanda.Text = musica.Banda;
            txtAlbum.Text = musica.Album;
            txtCaminho.Text = musica.Caminho;
            cboGenero.SelectedItem = musica.Genero;
            nudDuracao.Value = musica.Duracao;
            dtpLancamento.Value = musica.Lancamento;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                musica.Nome = txtMusica.Text;
                musica.Banda = txtBanda.Text;
                musica.Album = txtAlbum.Text;
                musica.Caminho = txtCaminho.Text;
                musica.Genero = cboGenero.SelectedItem.ToString();
                musica.Duracao = nudDuracao.Value;
                musica.Lancamento = dtpLancamento.Value;

                MusicaBusiness business = new MusicaBusiness();
                business.Alterar(musica);

                EnviarMensagem("Música alterada com sucesso.");
            }
            catch (ArgumentException ex)
            {
                EnviarMensagemErro(ex.Message);
            }
            catch (Exception ex)
            {
                EnviarMensagemErro("Ocorreu um erro ao alterar a música: " + ex.Message);
            }
        }


        private void EnviarMensagem(string mensagem)
        {
            MessageBox.Show(mensagem, "Nsf Jam",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
        }

        private void EnviarMensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Nsf Jam",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
        }


    }
}
