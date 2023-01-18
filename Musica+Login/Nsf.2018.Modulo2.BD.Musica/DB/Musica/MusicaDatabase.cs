using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Musica.DB
{
    public class MusicaDatabase
    {
        public int Salvar(MusicaDTO musica)
        {
            string script =
            @"INSERT INTO tb_musica 
            (
	            nm_musica,
	            ds_banda,
	            ds_album,
	            ds_caminho,
	            ds_genero,
	            vl_duracao,
	            dt_lancamento
            )
            VALUES
            (
	            @nm_musica,
	            @ds_banda,
	            @ds_album,
	            @ds_caminho,
	            @ds_genero,
	            @vl_duracao,
	            @dt_lancamento
            )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_musica", musica.Nome));
            parms.Add(new MySqlParameter("ds_banda", musica.Banda));
            parms.Add(new MySqlParameter("ds_album", musica.Album));
            parms.Add(new MySqlParameter("ds_caminho", musica.Caminho));
            parms.Add(new MySqlParameter("ds_genero", musica.Genero));
            parms.Add(new MySqlParameter("vl_duracao", musica.Duracao));
            parms.Add(new MySqlParameter("dt_lancamento", musica.Lancamento));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(MusicaDTO musica)
        {
            string script =
            @"UPDATE tb_musica 
                 SET nm_musica  = @nm_musica,
	                 ds_banda   = @ds_banda,
	                 ds_album   = @ds_album,
	                 ds_caminho = @ds_caminho,
	                 ds_genero  = @ds_genero,
	                 vl_duracao = @vl_duracao,
	                 dt_lancamento = @dt_lancamento
               WHERE id_musica = @id_musica";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_musica", musica.Id));
            parms.Add(new MySqlParameter("nm_musica", musica.Nome));
            parms.Add(new MySqlParameter("ds_banda", musica.Banda));
            parms.Add(new MySqlParameter("ds_album", musica.Album));
            parms.Add(new MySqlParameter("ds_caminho", musica.Caminho));
            parms.Add(new MySqlParameter("ds_genero", musica.Genero));
            parms.Add(new MySqlParameter("vl_duracao", musica.Duracao));
            parms.Add(new MySqlParameter("dt_lancamento", musica.Lancamento));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_musica WHERE id_musica = @id_musica";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_musica", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<MusicaDTO> Consultar(string musica, string genero)
        {
            string script =
            @"SELECT * 
                FROM tb_musica 
               WHERE nm_musica like @nm_musica 
                 AND ds_genero like @ds_genero";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_musica", "%" + musica + "%"));
            parms.Add(new MySqlParameter("ds_genero", "%" + genero + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<MusicaDTO> musicas = new List<MusicaDTO>();

            while (reader.Read())
            {
                MusicaDTO novaMusica = new MusicaDTO();
                novaMusica.Id = reader.GetInt32("id_musica");
                novaMusica.Nome = reader.GetString("nm_musica");
                novaMusica.Banda = reader.GetString("ds_banda");
                novaMusica.Album = reader.GetString("ds_album");
                novaMusica.Genero = reader.GetString("ds_genero");
                novaMusica.Caminho = reader.GetString("ds_caminho");
                novaMusica.Lancamento = reader.GetDateTime("dt_lancamento");
                novaMusica.Duracao = reader.GetDecimal("vl_duracao");

                musicas.Add(novaMusica);
            }
            reader.Close();

            return musicas;
        }

    }
}
