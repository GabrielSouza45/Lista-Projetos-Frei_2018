using MySql.Data.MySqlClient;
using Nsf._2018.Modulo2.DB.Filosofia.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.DB.Filosofia.DB.Filosofia
{
    public class FilosofiaDatabase
    {
        public List<FilosofiaDTO> Consultar(string autor)
        {
            string script =
                @"SELECT *
                    FROM tb_filosofia
                   WHERE nm_autor like @nm_autor";



            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_autor", autor));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);


            List<FilosofiaDTO> mensagens = new List<FilosofiaDTO>();
            while (reader.Read())
            {
                FilosofiaDTO msgm = new FilosofiaDTO();
                msgm.Id = reader.GetInt32("id_filosofia");
                msgm.Autor = reader.GetString("nm_autor");
                msgm.Mensagem = reader.GetString("ds_mensagem");

                mensagens.Add(msgm);
            }
            reader.Close();

            return mensagens;
        }

        public void Salvar(FilosofiaDTO filosofia)
        {
            string script =
                @"INSERT INTO tb_filosofia 
                  (
                    nm_autor, 
                    ds_mensagem
                  )
                  VALUES
                  (
                    @nm_autor,
                    @ds_mensagem
                  )";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_autor", filosofia.Autor));
            parms.Add(new MySqlParameter("ds_mensagem", filosofia.Mensagem));


            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);
        }

    }
}
