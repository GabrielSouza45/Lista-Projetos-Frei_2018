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
    public partial class frmBuscar : UserControl
    {
        public frmBuscar()
        {
            InitializeComponent();

            CarregarGenero();
        }

        private void CarregarGenero()
        {
            List<string> categorias = new List<string>();
            categorias.Add("Todos");
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





        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }




        public void CarregarGrid()
        {
            try
            {
                /// Os filtros da tela são lidos em variáveis
                string filme = txtfilme.Text;
                string genero = cboCategoria.SelectedItem.ToString();


                /// Aqui é a chamada para a função Consultar(filme, genero) da Business
                FilmeBusiness business = new FilmeBusiness();
                List<FilmeDTO> filmes = business.Consultar(filme, genero);

                /// A resposta da business é atribuída na Grid
                gvfilmes.AutoGenerateColumns = false;
                gvfilmes.DataSource = filmes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao consultar filmes: " + ex.Message, "Nsf Flix",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }




        private void gvfilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /// SE a coluna de índice 3 (play) for clicada, o filme é iniciado
            if (e.ColumnIndex == 3)
            {
                FilmeDTO filme = gvfilmes.CurrentRow.DataBoundItem as FilmeDTO;
                frmInicial.Atual.PlayMusic(filme.Caminho);
            }


            /// SE a coluna de índice 4 (alterar) for clicada, a tela de alterar é exibida
            if (e.ColumnIndex == 4)
            {
                FilmeDTO filme = gvfilmes.CurrentRow.DataBoundItem as FilmeDTO;

                frmAlterar tela = new frmAlterar();
                tela.LoadScreen(filme);

                frmInicial.Atual.OpenScreen(tela);
            }


            /// SE a coluna de índice 5 (excluir) for clicada, o filme será removido
            if (e.ColumnIndex == 5)
            {
                FilmeDTO filme = gvfilmes.CurrentRow.DataBoundItem as FilmeDTO;

                DialogResult r = MessageBox.Show("Deseja excluir o filme?", "Nsf Flix",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    FilmeBusiness business = new FilmeBusiness();
                    business.Remover(filme.Id);

                    CarregarGrid();
                }
            }
        }




        private void gvfilmes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FilmeDTO filme = gvfilmes.CurrentRow.DataBoundItem as FilmeDTO;

            frmInicial.Atual.PlayMusic(filme.Caminho);
        }



    }
}
