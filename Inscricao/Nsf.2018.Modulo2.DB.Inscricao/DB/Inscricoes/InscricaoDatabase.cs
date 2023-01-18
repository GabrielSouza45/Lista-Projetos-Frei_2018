using MySql.Data.MySqlClient;
using Nsf._2018.Modulo2.DB.Inscricao.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.DB.Inscricao.DB.Inscricoes
{
    class InscricaoDatabase
    {
        public int Salvar(InscricaoDTO dto)
        {
            string script = @"INSERT INTO tb_inscricao (nm_pessoa, nm_faculdade)
	                               VALUES (@nm_pessoa, @nm_faculdade)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_pessoa", dto.Nome));
            parms.Add(new MySqlParameter("nm_faculdade", dto.Faculdade));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<InscricaoDTO> Listar()
        {
            string script = @"select * from tb_inscricao";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<InscricaoDTO> lista = new List<InscricaoDTO>();
            while (reader.Read())
            {
                InscricaoDTO dto = new InscricaoDTO();
                dto.Id = reader.GetInt32("id_inscricao");
                dto.Nome = reader.GetString("nm_pessoa");
                dto.Faculdade = reader.GetString("nm_faculdade");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
