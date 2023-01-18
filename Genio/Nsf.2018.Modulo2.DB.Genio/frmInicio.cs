using Nsf._2018.Modulo2.DB.Genio.DB.Desejo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Modulo2.DB.Genio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            Listar();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Listar()
        {
            DesejoBusiness business = new DesejoBusiness();
            List<DesejoDTO> desejos =  business.Listar();

            gvDesejos.AutoGenerateColumns = false;
            gvDesejos.DataSource = desejos;
        }

        private void txtDesejo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                DesejoDTO desejo = new DesejoDTO();
                desejo.Desejo = txtDesejo.Text;

                DesejoBusiness business = new DesejoBusiness();
                business.Salvar(desejo);

                Listar();
                txtDesejo.Clear();
            }
        }

        
    }
}
