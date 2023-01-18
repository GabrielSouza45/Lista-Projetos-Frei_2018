using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Musica.DB
{
    public class LoginDatabase
    {
        public bool Logar(string usuario, string senha)
        {
            string script =
                @"select * 
                    from tb_login
                   where nm_usuario = @nm_usuario
                     and ds_senha   = @ds_senha";


            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("nm_usuario", usuario));
            parametros.Add(new MySqlParameter("ds_senha", senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parametros);

            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
