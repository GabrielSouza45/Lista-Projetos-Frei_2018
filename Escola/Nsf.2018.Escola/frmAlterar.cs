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
    public partial class frmAlterar : Form
    {
        public frmAlterar()
        {
            InitializeComponent();
        }

        CursoDTO curso;

        public void LoadScreen(CursoDTO curso)
        {
            this.curso = curso;

            txtNome.Text = curso.Nome;
            txtSigla.Text = curso.Sigla;
            nudMaxAlunos.Value = curso.MaximoAlunos;
            cboAvaliacao.SelectedItem = curso.Avaliacao.ToString("0.#");
            chkAtivo.Checked = curso.Ativo;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.curso.Nome = txtNome.Text;
                this.curso.Sigla = txtSigla.Text;
                this.curso.MaximoAlunos = Convert.ToInt32(nudMaxAlunos.Value);
                this.curso.Avaliacao = Convert.ToDecimal(cboAvaliacao.SelectedItem);
                this.curso.Ativo = chkAtivo.Checked;

                CursoBusiness business = new CursoBusiness();
                business.Alterar(curso);

                MessageBox.Show("Curso alterado com sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro. Fale com o administrador.", "Escola", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
