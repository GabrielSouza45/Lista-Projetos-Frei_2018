using Nsf._2018.Modulo2.DB.Inscricao.DB.Inscricoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Modulo2.DB.Inscricao
{
    public partial class frmInscricao : Form
    {
        public frmInscricao()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            InscricaoDTO dto = new InscricaoDTO();
            dto.Nome = txtNome.Text;
            dto.Faculdade = txtFaculdade.Text;

            InscricaoBusiness business = new InscricaoBusiness();
            business.Salvar(dto);

            MessageBox.Show("Inscrição realizada.", "Inscrições", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            InscricaoBusiness business = new InscricaoBusiness();
            List<InscricaoDTO> inscricoes = business.Listar();

            dgvInscricoes.AutoGenerateColumns = false;
            dgvInscricoes.DataSource = inscricoes;
        }
    }
}
