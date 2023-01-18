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
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CursoDTO curso = new CursoDTO();
                curso.Nome = txtNome.Text;
                curso.Sigla = txtSigla.Text;
                curso.MaximoAlunos = Convert.ToInt32(nudMaxAlunos.Value);
                curso.Avaliacao = Convert.ToDecimal(cboAvaliacao.SelectedItem);
                curso.Inclusao = DateTime.Now;
                curso.Ativo = chkAtivo.Checked;

                CursoBusiness business = new CursoBusiness();
                curso.Id = business.Salvar(curso);

                MessageBox.Show("Curso " + curso.Id + "inserido com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador. " + ex.Message, 
                    "Escola", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
        }
    }
}
