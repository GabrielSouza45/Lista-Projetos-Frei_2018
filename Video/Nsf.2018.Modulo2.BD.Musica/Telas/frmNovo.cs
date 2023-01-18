using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nsf._2018.Modulo2.BD.Video.DB;

namespace Nsf._2018.Modulo2.BD.Video
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
            List<string> categorias = new List<string>();
            categorias.Add("Selecione");
            categorias.Add("Ação");
            categorias.Add("Comédia");
            categorias.Add("Romance");
            categorias.Add("Suspense");
            categorias.Add("Drama");
            categorias.Add("Terror");
            categorias.Add("Aventura");
            categorias.Add("Desenho");

            cboCategoria.DataSource = categorias;
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
                /// A tela irá criar o DTO e carregá-lo com os valores dos controles.

                FilmeDTO filme = new FilmeDTO();
                // 8º Leia o campo Nome do DTO pelo controle txtNome
                filme.Nome = txtfilme.Text;
                filme.Sinopse = txtSinopse.Text;
                filme.Caminho = txtCaminho.Text;
                filme.Categoria = cboCategoria.SelectedItem.ToString();
                filme.Duracao = nudDuracao.Value;
                filme.Avaliacao = nudAvaliacao.Value;
                filme.QtdTemporadas = Convert.ToInt32(nudQtdTemp.Value);
                filme.Lancamento = dtpLancamento.Value;
                filme.MaiorIdade = chkMaioridade.Checked;


                /// Aqui é a chamada para a função Salvar(dto) da Business
                FilmeBusiness business = new FilmeBusiness();
                business.Salvar(filme);

                EnviarMensagem("Filme salvo com sucesso.");
            }
            catch (ArgumentException ex)
            {
                EnviarMensagemErro(ex.Message);
            }
            catch (Exception ex)
            {
                EnviarMensagemErro("Ocorreu um erro ao salvar o filme: " + ex.Message);
            }
        }



        private void EnviarMensagem(string mensagem)
        {
            MessageBox.Show(mensagem, "Nsf Flix",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
        }

        private void EnviarMensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Nsf Flix",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
        }



    }
}
