using Nsf._2018.Modulo2.BD.Musica.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Modulo2.BD.Musica
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            LoginBusiness business = new LoginBusiness();
            bool logou = business.Logar(usuario, senha);

            if (logou == true)
            {
                frmInicial tela = new frmInicial();
                tela.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas", "Music", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
