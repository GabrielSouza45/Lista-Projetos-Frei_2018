using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.DB.Sentimentos.DB.Pensamentos
{
    public class PensamentoBusiness
    {
        
        public int Salvar(PensamentoDTO pensamento)
        {
            if (pensamento.GpoSocial == "Grupo Social")
                throw new ArgumentException("* Campo grupo social obrigatório.");

            if (pensamento.Pensamento == "Pensamento")
                throw new ArgumentException("* Campo pensamento obrigatório.");

            PensamentoDatabase db = new PensamentoDatabase();
            return db.Salvar(pensamento);
        }

        public List<PensamentoDTO> Consultar(string nick)
        {
            PensamentoDatabase db = new PensamentoDatabase();
            return db.Consultar(nick);
        }
    }
}
