using Nsf._2018.Modulo2.BD.Chat.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf._2018.Modulo2.BD.Chat
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
            cboTurma.SelectedIndex = 0;
            txtNome.Select(0, 0);
        }



        private void Salvar()
        {
            // É AQUI QUE VOCÊ VAI PROGRAMAR
            ChatDTO chat = new ChatDTO();
            chat.Aluno = txtNome.Text;
            chat.Mensagem = txtMensagem.Text;
            chat.Turma = cboTurma.SelectedItem.ToString();
            chat.Inclusao = DateTime.Now;

            ChatBusiness business = new ChatBusiness();
            business.Salvar(chat);
        }






        private void txtMensagem_KeyUp(object sender, KeyEventArgs e)
        {
            // Evento KeyUP:: Se o usuário apertar [Enter] envia a mensagem

            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    Salvar();
                    txtMensagem.Clear();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar: " + ex.Message, "Chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }






        int lastId = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            //  Evento Timer Tick:: A cada 5seg as mensagens são atualizadas
            try
            {
                string turma = cboTurma.SelectedItem.ToString();

                // Chama a business para consultar todas as mensagens da turma
                ChatBusiness business = new ChatBusiness();
                List<ChatDTO> mensagens = business.Consultar(turma);


                // Adiciona apenas as mensagens novas
                mensagens = mensagens.Where(x => x.Id > lastId).ToList();
                lastId = mensagens.LastOrDefault()?.Id ?? (lastId > 0 ? lastId : 0);

                // Percorre todas as mensagens da turma para adicionar na conversa
                foreach (ChatDTO msg in mensagens)
                {
                    // Se a mensagem for do próprio usuário, mostra balão verde, senão branco.
                    if (msg.Aluno == txtNome.Text && msg.Turma == turma)
                    {
                        Telas.frmEnviado mensagem = new Telas.frmEnviado();
                        mensagem.LoadScreen(msg.Mensagem, msg.Inclusao);

                        mensagem.Dock = DockStyle.Top;
                        panelMensagens.Controls.Add(mensagem);
                    }
                    else
                    {
                        Telas.frmRecebida mensagem = new Telas.frmRecebida();
                        mensagem.LoadScreen(msg.Aluno, msg.Turma, msg.Mensagem, msg.Inclusao);

                        mensagem.Dock = DockStyle.Top;
                        panelMensagens.Controls.Add(mensagem);
                    }
                }

                lblErro.Visible = false;
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
            }
        }

        private void cboTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastId = 0;
            panelMensagens.Controls.Clear();
        }
    }
}
