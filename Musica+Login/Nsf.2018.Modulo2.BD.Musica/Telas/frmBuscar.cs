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
    public partial class frmBuscar : UserControl
    {
        public frmBuscar()
        {
            InitializeComponent();

            CarregarGenero();
        }

        private void CarregarGenero()
        {
            List<string> generos = new List<string>();
            generos.Add("Todos");
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





        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            try
            {
                string musica = txtMusica.Text;
                string genero = cboGenero.SelectedItem.ToString();

                MusicaBusiness business = new MusicaBusiness();
                List<MusicaDTO> musicas = business.Consultar(musica, genero);

                gvMusicas.AutoGenerateColumns = false;
                gvMusicas.DataSource = musicas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar a música: " + ex.Message, "Nsf Jam",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void gvMusicas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                MusicaDTO musica = gvMusicas.CurrentRow.DataBoundItem as MusicaDTO;
                frmInicial.Atual.PlayMusic(musica.Nome, musica.Banda, musica.Album, musica.Caminho, musica.Duracao);
            }

            if (e.ColumnIndex == 4)
            {
                MusicaDTO musica = gvMusicas.CurrentRow.DataBoundItem as MusicaDTO;

                frmAlterar tela = new frmAlterar();
                tela.LoadScreen(musica);

                frmInicial.Atual.OpenScreen(tela);
            }

            if (e.ColumnIndex == 5)
            {
                MusicaDTO musica = gvMusicas.CurrentRow.DataBoundItem as MusicaDTO;

                DialogResult r = MessageBox.Show("Deseja excluir a música?", "Nsf Jam",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    MusicaBusiness business = new MusicaBusiness();
                    business.Remover(musica.Id);

                    CarregarGrid();
                }
            }
        }

        private void gvMusicas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MusicaDTO musica = gvMusicas.CurrentRow.DataBoundItem as MusicaDTO;

            frmInicial.Atual.PlayMusic(musica.Nome, musica.Banda, musica.Album, musica.Caminho, musica.Duracao);
        }
    }
}
