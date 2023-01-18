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
    public partial class frmNovo : UserControl
    {
        public frmNovo()
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

        private void txtCaminho_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult r = dialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtCaminho.Text = dialog.FileName;
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                MusicaDTO musica = new MusicaDTO();
                musica.Nome = txtMusica.Text;
                musica.Banda = txtBanda.Text;
                musica.Album = txtAlbum.Text;
                musica.Caminho = txtCaminho.Text;
                musica.Genero = cboGenero.SelectedItem.ToString();
                musica.Duracao = nudDuracao.Value;
                musica.Lancamento = dtpLancamento.Value;

                MusicaBusiness business = new MusicaBusiness();
                business.Salvar(musica);

                EnviarMensagem("Música salva com sucesso.");
            }
            catch (ArgumentException ex)
            {
                EnviarMensagemErro(ex.Message);
            }
            catch (Exception ex)
            {
                EnviarMensagemErro("Ocorreu um erro ao salvar a música: " + ex.Message);
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
