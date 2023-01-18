using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nsf._2018.Modulo2.DB.Filosofia.DB.Filosofia;

namespace Nsf._2018.Modulo2.DB.Filosofia.Telas
{
    public partial class frmBuscar : UserControl
    {
        public frmBuscar()
        {
            InitializeComponent();
            AnimacaoEntrada();
        }

        public void AnimacaoEntrada()
        {
            lblMessage.Left = lblMessage.Left - 500;
            btnAnterior.Visible = false;
            btnProximo.Visible = false;
            btnEmail.Visible = false;

            Consultar(rdnTodos.Text);
            AnimacaoTimer.Start();
        }


        private void AnimacaoTimer_Tick(object sender, EventArgs e)
        {
            lblMessage.Left += 10;

            if (lblMessage.Left >= 20)
            {
                lblMessage.Left = 20;
                btnAnterior.Visible = true;
                btnProximo.Visible = true;
                btnEmail.Visible = true;

                AnimacaoTimer.Stop();
            }
        }



        // Variáveis Escopo de Classe
        int atual = -1;
        List<FilosofiaDTO> mensagens;



        public void Consultar(string autor)
        {
            try
            {
                FilosofiaBusiness business = new FilosofiaBusiness();
                List<FilosofiaDTO> msgs = business.Consultar(autor);

                this.atual = -1;
                this.mensagens = msgs;

                btnProximo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro." + ex.Message, 
                    "Freilosofia", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }



        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (mensagens != null && mensagens.Count > 0)
            {
                atual = atual + 1;

                if (atual == mensagens.Count)
                {
                    atual = 0;
                }

                FilosofiaDTO proxima = mensagens[atual];
                lblMessage.Text = proxima.Mensagem + "\n" + proxima.Autor;
            }
            else
            {
                lblMessage.Text = "Não há mensagens cadastradas para esse autor.";
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (mensagens != null && mensagens.Count > 0)
            {
                atual = atual - 1;

                if (atual == -1)
                {
                    atual = mensagens.Count - 1;
                }

                FilosofiaDTO anterior = mensagens[atual];
                lblMessage.Text = anterior.Mensagem + "\n\n" + anterior.Autor;
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Visible = !txtEmail.Visible;
            btnEnviar.Visible = !btnEnviar.Visible;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string emailPara = txtEmail.Text;
            string mensagem = lblMessage.Text;

            Plugin.Email email = new Plugin.Email();
            email.Enviar(emailPara, mensagem);

            txtEmail.Visible = false;
            btnEnviar.Visible = false;
        }


        private void btnRadioButtons_Click(object sender, EventArgs e)
        {
            if (rdnBuda.Checked)
            {
                Consultar(rdnBuda.Text);
            }
            else if (rdnEinstein.Checked)
            {
                Consultar(rdnEinstein.Text);
            }
            else if (rdnJesus.Checked)
            {
                Consultar(rdnJesus.Text);
            }
            else if (rdnMachado.Checked)
            {
                Consultar(rdnMachado.Text);
            }
            else if (rdnRousseau.Checked)
            {
                Consultar(rdnRousseau.Text);
            }
            else if (rdnSocrates.Checked)
            {
                Consultar(rdnSocrates.Text);
            }
            else if (rdnNossos.Checked)
            {
                Consultar(rdnNossos.Text);
            }
            else if (rdnTodos.Checked)
            {
                Consultar(rdnTodos.Text);
            }
        }

        
    }
}
