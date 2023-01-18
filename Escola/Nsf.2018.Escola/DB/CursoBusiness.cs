using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Escola.DB
{
    public class CursoBusiness
    {
        public int Salvar(CursoDTO curso)
        {
            if (curso.Nome == string.Empty)
            {
                throw new Exception("Nome do curso é obrigatório.");
            }
            if (curso.MaximoAlunos == 0)
            {
                throw new Exception("O total de alunos não pode ser zero.");
            }

            CursoDatabase cursoDB = new CursoDatabase();
            int id = cursoDB.Salvar(curso);
            return id;
        }


        public void Alterar(CursoDTO curso)
        {
            CursoDatabase cursoDB = new CursoDatabase();
            cursoDB.Alterar(curso);
        }

        public void Remover(int idCurso)
        {
            CursoDatabase cursoDB = new CursoDatabase();
            cursoDB.Remover(idCurso);
        }


        public List<CursoDTO> Listar()
        {
            CursoDatabase cursoDB = new CursoDatabase();
            List<CursoDTO> cursos = cursoDB.Listar();
            return cursos;
        }


    }
}
