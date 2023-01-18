using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Escola.DB
{
    public class CursoDatabase
    {
        public int Salvar(CursoDTO curso)
        {
            string script =
            @"INSERT INTO tb_curso (nm_curso, ds_sigla, nr_maximo_alunos, vl_avaliacao, bt_ativo, dt_inclusao)  
				            VALUES (@nm_curso, @ds_sigla, @nr_maximo_alunos, @vl_avaliacao, @bt_ativo, @dt_inclusao)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_curso", curso.Nome));
            parms.Add(new MySqlParameter("ds_sigla", curso.Sigla));
            parms.Add(new MySqlParameter("nr_maximo_alunos", curso.MaximoAlunos));
            parms.Add(new MySqlParameter("vl_avaliacao", curso.Avaliacao));
            parms.Add(new MySqlParameter("dt_inclusao", curso.Inclusao));
            parms.Add(new MySqlParameter("bt_ativo", curso.Ativo));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }


        public void Alterar(CursoDTO curso)
        {
            string script =
		    @"UPDATE tb_curso SET nm_curso = @nm_curso,
                                  ds_sigla = @ds_sigla,
                                  nr_maximo_alunos = @nr_maximo_alunos,
                                  vl_avaliacao = @vl_avaliacao,
                                  bt_ativo = @bt_ativo,
                                  dt_inclusao = @dt_inclusao
              WHERE id_curso = @id_curso";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_curso", curso.Id));
            parms.Add(new MySqlParameter("nm_curso", curso.Nome));
            parms.Add(new MySqlParameter("ds_sigla", curso.Sigla));
            parms.Add(new MySqlParameter("nr_maximo_alunos", curso.MaximoAlunos));
            parms.Add(new MySqlParameter("vl_avaliacao", curso.Avaliacao));
            parms.Add(new MySqlParameter("dt_inclusao", curso.Inclusao));
            parms.Add(new MySqlParameter("bt_ativo", curso.Ativo));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int idCurso)
        {
            string script =
            @"DELETE FROM tb_curso WHERE id_curso = @id_curso";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_curso", idCurso));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }


        public List<CursoDTO> Listar()
        {
            string script =
            @"SELECT * FROM tb_curso";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<CursoDTO> cursos = new List<CursoDTO>();
            while (reader.Read())
            {
                CursoDTO curso = new CursoDTO();
                curso.Id = reader.GetInt32("id_curso");
                curso.Nome = reader.GetString("nm_curso");
                curso.Sigla = reader.GetString("ds_sigla");
                curso.MaximoAlunos = reader.GetInt32("nr_maximo_alunos");
                curso.Avaliacao = reader.GetDecimal("vl_avaliacao");
                curso.Inclusao = reader.GetDateTime("dt_inclusao");
                curso.Ativo = reader.GetBoolean("bt_ativo");

                cursos.Add(curso);
            }
            reader.Close();

            return cursos;
        }


    }
}
