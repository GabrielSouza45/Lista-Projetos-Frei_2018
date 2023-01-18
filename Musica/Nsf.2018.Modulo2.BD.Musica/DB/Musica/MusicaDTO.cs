using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Musica.DB
{
    public class MusicaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Banda { get; set; }
        public string Album { get; set; }
        public string Genero { get; set; }
        public DateTime Lancamento { get; set; }
        public decimal Duracao { get; set; }
        public string Caminho { get; set; }

    }
}
