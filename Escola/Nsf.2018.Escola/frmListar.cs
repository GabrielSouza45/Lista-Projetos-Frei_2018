using Nsf._2018.Escola.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Escola
{
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();

            ListarCursos();
        }

        public void ListarCursos()
        {
            List<CursoDTO> cursos;

            CursoBusiness business = new CursoBusiness();
            cursos = business.Listar();

            gvCursos.AutoGenerateColumns = false;
            gvCursos.DataSource = cursos;
        }

        private void gvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    CursoDTO curso = gvCursos.Rows[e.RowIndex].DataBoundItem as CursoDTO;

                    frmAlterar tela = new frmAlterar();
                    tela.LoadScreen(curso);
                    tela.ShowDialog();
                }

                if (e.ColumnIndex == 8)
                {
                    CursoDTO curso = gvCursos.Rows[e.RowIndex].DataBoundItem as CursoDTO;

                    DialogResult resposta = MessageBox.Show("Quer mesmo remover o curso?", "Escola", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resposta == DialogResult.Yes)
                    {
                        CursoBusiness business = new CursoBusiness();
                        business.Remover(curso.Id);

                        MessageBox.Show("Curso removido com sucesso.");

                        ListarCursos();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro. Fale com o administrador.", "Escola", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            



        }
    }
}
