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
    public partial class frmEnviado : UserControl
    {
        public frmEnviado()
        {
            InitializeComponent();
        }

        public void LoadScreen(string msg, DateTime inclusao)
        {
            lblMensagem.Text = msg;
            lblHorario.Text = inclusao.ToShortTimeString();
        }
    }
}
