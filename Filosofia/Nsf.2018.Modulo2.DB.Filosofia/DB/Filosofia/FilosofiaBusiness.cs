using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.DB.Filosofia.DB.Filosofia
{
    public class FilosofiaBusiness
    {
        FilosofiaDatabase db = new FilosofiaDatabase();

        public List<FilosofiaDTO> Consultar(string autor)
        {
            if (autor == "Todos")
                autor = "%";

            return db.Consultar(autor);
        }

        public void Salvar(FilosofiaDTO filosofia)
        {
            if (filosofia.Autor == "Selecione")
            {
                throw new ArgumentException("O campo Autor é obrigatório.");
            }

            if (filosofia.Mensagem == string.Empty)
            {
                throw new ArgumentException("O campo Mensagem é obrigatório.");
            }

            db.Salvar(filosofia);
        }
    }
}
