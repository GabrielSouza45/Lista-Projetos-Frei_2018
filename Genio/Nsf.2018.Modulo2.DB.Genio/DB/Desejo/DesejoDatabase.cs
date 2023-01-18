using MySql.Data.MySqlClient;
using Nsf._2018.Modulo2.DB.Genio.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.DB.Genio.DB.Desejo
{
    public class DesejoDatabase
    {
        public int Salvar(DesejoDTO desejo)
        {
            string script =
                @"INSERT INTO tb_desejo 
                 (
                     ds_desejo
                 )
                 VALUES
                 (
                     @ds_desejo
                 )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_desejo", desejo.Desejo));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<DesejoDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_desejo ORDER BY id_desejo desc";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<DesejoDTO> desejos = new List<DesejoDTO>();

            while (reader.Read())
            {
                DesejoDTO novoDesejo = new DesejoDTO();
                novoDesejo.Id = reader.GetInt32("id_desejo");
                novoDesejo.Desejo = reader.GetString("ds_desejo");

                desejos.Add(novoDesejo);
            }
            reader.Close();

            return desejos;
        }
    }
}
