using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Chat.DB
{
    public class ChatBusiness
    {
        ChatDatabase db = new ChatDatabase();


        public void Salvar(ChatDTO chat)
        {
            if (chat.Aluno.Trim() == string.Empty || chat.Aluno == "Seu nome aqui")
            {
                throw new ArgumentException("Nome do aluno é obrigatório.");
            }

            if (chat.Turma.Trim() == string.Empty || chat.Aluno == "Selecione a turma")
            {
                throw new ArgumentException("Nome do aluno é obrigatório.");
            }

            if (chat.Mensagem.Trim() == string.Empty)
            {
                throw new ArgumentException("Mensagem está vazia.");
            }


            db.Salvar(chat);
        }


        public List<ChatDTO> Consultar(string turma)
        {
            return db.Consultar(turma);
        }


    }
}
