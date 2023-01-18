using MySql.Data.MySqlClient;
using Nsf._2018.Modulo2.DB.Sentimentos.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.DB.Sentimentos.DB.Pensamentos
{
    public class PensamentoDatabase
    {
        public int Salvar(PensamentoDTO pensamento)
        {
            string script =
                @"INSERT
                    INTO tb_pensamento
                 (
                     nm_nick,
                     ds_pensamento,
                     ds_gposocial
                 )
                 VALUES 
                 (
                     @nm_nick,
                     @ds_pensamento,
                     @ds_gposocial
                 )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nick", pensamento.Nick));
            parms.Add(new MySqlParameter("ds_pensamento", pensamento.Pensamento));
            parms.Add(new MySqlParameter("ds_gposocial", pensamento.GpoSocial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<PensamentoDTO> Consultar(string nick)
        {
            string script =
                @"SELECT *
                    FROM tb_pensamento
                   WHERE nm_nick = @nm_nick";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nick", nick));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PensamentoDTO> pensamentos = new List<PensamentoDTO>();

            while (reader.Read())
            {
                PensamentoDTO novoPensamento = new PensamentoDTO();
                novoPensamento.Id = reader.GetInt32("id_pensamento");
                novoPensamento.Nick = reader.GetString("nm_nick");
                novoPensamento.Pensamento = reader.GetString("ds_pensamento");
                novoPensamento.GpoSocial = reader.GetString("ds_gposocial");

                pensamentos.Add(novoPensamento);
            }
            reader.Close();

            return pensamentos;
        }

    }
}
