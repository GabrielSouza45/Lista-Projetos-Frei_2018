using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nsf._2018.Modulo2.DB.Sentimentos.DB.Pensamentos;

namespace Nsf._2018.Modulo2.DB.Sentimentos.Telas
{
    public partial class frmBuscar : UserControl
    {
        public frmBuscar()
        {
            InitializeComponent();
            lblErro.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                PensamentoBusiness business = new PensamentoBusiness();
                List<PensamentoDTO> pensamentos = business.Consultar(txtNick.Text);

                gvPensamentos.AutoGenerateColumns = false;
                gvPensamentos.DataSource = pensamentos;

                lblErro.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
            }
        }
    }
}
