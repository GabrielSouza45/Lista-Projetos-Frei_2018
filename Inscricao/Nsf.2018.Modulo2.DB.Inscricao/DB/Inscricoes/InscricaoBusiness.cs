using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.DB.Inscricao.DB.Inscricoes
{
    class InscricaoBusiness
    {
        public int Salvar(InscricaoDTO dto)
        {
            InscricaoDatabase db = new InscricaoDatabase();
            return db.Salvar(dto);
        }

        public List<InscricaoDTO> Listar()
        {
            InscricaoDatabase db = new InscricaoDatabase();
            return db.Listar();
        }
    }
}
