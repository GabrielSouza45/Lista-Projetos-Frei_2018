using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Musica.DB
{
    public class MusicaBusiness
    {
        MusicaDatabase db = new MusicaDatabase();

        public int Salvar(MusicaDTO musica)
        {
            if (musica.Nome == string.Empty)
            {
                throw new ArgumentException("Música é obrigatória.");
            }
            if (musica.Duracao == 0)
            {
                throw new ArgumentException("Duração é obrigatória.");
            }

            return db.Salvar(musica);
        }

        public void Alterar(MusicaDTO musica)
        {
            if (musica.Nome == string.Empty)
            {
                throw new ArgumentException("Música é obrigatória.");
            }
            if (musica.Duracao == 0)
            {
                throw new ArgumentException("Duração é obrigatória.");
            }

            db.Alterar(musica);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }

        public List<MusicaDTO> Consultar(string musica, string genero)
        {
            if (genero == "Todos")
            {
                genero = string.Empty;
            }

            return db.Consultar(musica, genero);
        }
    }
}
