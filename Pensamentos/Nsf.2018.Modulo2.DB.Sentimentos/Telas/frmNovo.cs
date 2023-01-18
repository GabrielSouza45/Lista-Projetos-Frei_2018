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
    public partial class frmNovo : UserControl
    {
        public frmNovo()
        {
            InitializeComponent();
            LoadGpoSocial();
            lblErro.Text = string.Empty;
        }

        private void LoadGpoSocial()
        {
            List<string> gpoSocial = new List<string>();
            gpoSocial.Add("Grupo Social");
            gpoSocial.Add("Amigos");
            gpoSocial.Add("Bens materiais");
            gpoSocial.Add("Escola");
            gpoSocial.Add("Eu");
            gpoSocial.Add("Família");
            gpoSocial.Add("Meu próximo");
            gpoSocial.Add("Namorado(a)");
            gpoSocial.Add("Órgãos públicos e privados");
            gpoSocial.Add("Política");
            gpoSocial.Add("Religiosidade");
            gpoSocial.Add("Trabalho");
            gpoSocial.Add("Transporte");

            cboGpoSocial.DataSource = gpoSocial;
            cboGpoSocial.SelectedIndex = 0;
        }

        public void LoadScreen(bool positivo)
        {
            List<string> pensamentos = new List<string>();
            pensamentos.Add("Pensamento");

            if (positivo == true)
            {
                pensamentos.Add("Felicidade");
                pensamentos.Add("Alegria");
                pensamentos.Add("Abnegação");
                pensamentos.Add("Alegria");
                pensamentos.Add("Amor");
                pensamentos.Add("Caridade");
                pensamentos.Add("Compreensão");
                pensamentos.Add("Confiança");
                pensamentos.Add("Coragem");
                pensamentos.Add("Desprendimento");
                pensamentos.Add("Entusiasmo");
                pensamentos.Add("Esperança");
                pensamentos.Add("Gentileza");
                pensamentos.Add("Gratidão");
                pensamentos.Add("Humildade");
                pensamentos.Add("Otimismo");
                pensamentos.Add("Perdão");
                pensamentos.Add("Perseverança");
                pensamentos.Add("Renúncia");
                pensamentos.Add("Serenidade");
            }
            else
            {
                pensamentos.Add("Ansiedade");
                pensamentos.Add("Antipatia");
                pensamentos.Add("Apego");
                pensamentos.Add("Baixa estima");
                pensamentos.Add("Ciúme");
                pensamentos.Add("Egoismo");
                pensamentos.Add("Incompreensão");
                pensamentos.Add("Indiferença");
                pensamentos.Add("Inveja");
                pensamentos.Add("Mágoa");
                pensamentos.Add("Medo");
                pensamentos.Add("Orgulho");
                pensamentos.Add("Pessimismo");
                pensamentos.Add("Preguiça");
                pensamentos.Add("Raiva");
                pensamentos.Add("Solidão");
                pensamentos.Add("Tédio");
                pensamentos.Add("Timidez");
            }

            cboPensamento.DataSource = pensamentos;
            cboPensamento.SelectedIndex = 0;
        }




        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                PensamentoDTO pensamento = new PensamentoDTO();
                pensamento.Nick = txtNick.Text;
                pensamento.GpoSocial = cboGpoSocial.SelectedItem.ToString();
                pensamento.Pensamento = cboPensamento.SelectedItem.ToString();

                PensamentoBusiness business = new PensamentoBusiness();
                business.Salvar(pensamento);

                lblErro.Text = string.Empty;
                Parent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
            }
        }
    }
}
