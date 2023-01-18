using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Chat.DB
{
    public class ChatDTO
    {
        public int Id { get; set; }
        public string Aluno { get; set; }
        public string Mensagem { get; set; }
        public string Turma { get; set; }
        public DateTime Inclusao { get; set; }
    }
}
