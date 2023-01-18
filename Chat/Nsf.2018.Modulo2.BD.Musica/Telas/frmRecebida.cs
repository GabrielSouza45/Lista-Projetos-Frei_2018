using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Modulo2.BD.Chat.Telas
{
    public partial class frmRecebida : UserControl
    {
        public frmRecebida()
        {
            InitializeComponent();
        }

        public void LoadScreen(string aluno, string turma, string msg, DateTime inclusao)
        {
            lblMensagem.Text = msg;
            lblUsuario.Text = "@" + aluno + " - " + turma;
            lblHorario.Text = inclusao.ToShortTimeString();
        }
    }
}
