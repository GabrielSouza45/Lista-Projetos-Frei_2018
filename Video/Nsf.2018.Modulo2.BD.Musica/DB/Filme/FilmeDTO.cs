using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Video.DB
{
    public class FilmeDTO
    {
        /// A mesma qtd de campos da tabela, é a qtd propriedades no DTO


        public int Id { get; set; }

        // 2º O campo nome precisa ser adicionado
        public string Nome { get; set; }

        public string Sinopse { get; set; }
        public string Categoria { get; set; }
        public string Caminho { get; set; }
        public decimal Avaliacao { get; set; }
        public decimal Duracao { get; set; }
        public int QtdTemporadas { get; set; }
        public bool MaiorIdade { get; set; }
        public DateTime Lancamento { get; set; }
        

    }
}
