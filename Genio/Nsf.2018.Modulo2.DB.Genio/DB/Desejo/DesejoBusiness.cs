using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.DB.Genio.DB.Desejo
{
    public class DesejoBusiness
    {
        public int Salvar(DesejoDTO desejo)
        {
            DesejoDatabase db = new DesejoDatabase();
            return db.Salvar(desejo);
        }

        public List<DesejoDTO> Listar()
        {
            DesejoDatabase db = new DesejoDatabase();
            return db.Listar();
        }
    }
}
