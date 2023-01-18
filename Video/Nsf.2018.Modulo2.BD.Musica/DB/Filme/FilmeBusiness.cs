using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Video.DB
{
    public class FilmeBusiness
    {
        /// Variável do Database é criada aqui
        FilmeDatabase db = new FilmeDatabase();



        public int Salvar(FilmeDTO filme)
        {
            /// Para cada campo validado na função SALVAR, usamos um IF.
            /// Se não for validado, uma excessão é enviada.


            // 6º Descomente para validar
            if (filme.Nome == string.Empty)
            {
                throw new ArgumentException("Filme é obrigatória.");
            }
            


            /// Aqui é a chamada para a função Salvar(dto) do Database
            return db.Salvar(filme);
        }



        public void Alterar(FilmeDTO filme)
        {
            /// Para cada campo validado na função ALTERAR, usamos um IF.
            /// Se não for validado, uma excessão é enviada.


            // 7º Descomente para validar
            if (filme.Nome == string.Empty)
            {
                throw new ArgumentException("Filme é obrigatória.");
            }


            /// Aqui é a chamada para a função Alterar(dto) do Database
            db.Alterar(filme);
        }



        public void Remover(int id)
        {
            /// Aqui é a chamada para a função Remover(id) do Database
            db.Remover(id);
        }


        
        public List<FilmeDTO> Consultar(string filme, string categoria)
        {
            if (categoria == "Todos")
            {
                categoria = string.Empty;
            }

            /// Aqui é a chamada para a função Consultar(filme, categoria) do Database
            return db.Consultar(filme, categoria);
        }


    }
}
