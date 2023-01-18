using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Escola.DB
{
    public class CursoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int MaximoAlunos { get; set; }
        public decimal Avaliacao { get; set; }
        public bool Ativo { get; set; }
        public DateTime Inclusao { get; set; }
    }
}
