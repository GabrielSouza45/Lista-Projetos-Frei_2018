using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Modulo2.DB.Filosofia.Telas
{
    public partial class frmNovo : UserControl
    {
        public frmNovo()
        {
            InitializeComponent();
            cboAutor.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DB.Filosofia.FilosofiaDTO filosofia = new DB.Filosofia.FilosofiaDTO();
                filosofia.Autor = cboAutor.SelectedItem.ToString();
                filosofia.Mensagem = txtMensagem.Text;


                DB.Filosofia.FilosofiaBusiness business = new DB.Filosofia.FilosofiaBusiness();
                business.Salvar(filosofia);


                MessageBox.Show("Salvo com sucesso.", "Filosofia",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro." + ex.Message, 
                    "Filosofia",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
    }
}
