using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Video.DB
{
    public class FilmeDatabase
    {
        public int Salvar(FilmeDTO filme)
        {
            /// O comando de INSERT é gerado aqui.
            /// O comando possui parâmetros '@' para receber as informações da tela, através do DTO.

            string script =
            @"INSERT INTO tb_filme 
            (
                nm_filme,
                ds_sinopse,
                ds_categoria,
                ds_caminho,
                vl_avaliacao,
                vl_duracao,
                qt_temporadas,
                bt_maioridade,
                dt_lancamento
            )
            VALUES
            (
                @nm_filme,
                @ds_sinopse,
                @ds_categoria,
                @ds_caminho,
                @vl_avaliacao,
                @vl_duracao,
                @qt_temporadas,
                @bt_maioridade,
                @dt_lancamento
            )";

            /// Aqui ocorrem as substituições dos parâmetros
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_filme", filme.Nome));          // 3º Passe o valor do campo Nome do DTO
            parms.Add(new MySqlParameter("ds_sinopse", filme.Sinopse));
            parms.Add(new MySqlParameter("ds_categoria", filme.Categoria));
            parms.Add(new MySqlParameter("ds_caminho", filme.Caminho));
            parms.Add(new MySqlParameter("vl_avaliacao", filme.Avaliacao));
            parms.Add(new MySqlParameter("vl_duracao", filme.Duracao));
            parms.Add(new MySqlParameter("qt_temporadas", filme.QtdTemporadas));
            parms.Add(new MySqlParameter("bt_maioridade", filme.MaiorIdade));
            parms.Add(new MySqlParameter("dt_lancamento", filme.Lancamento));


            /// Aqui ocorre a execução do comando no bd
            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }



        public void Alterar(FilmeDTO filme)
        {
            /// O comando de UPDATE é gerado aqui.
            /// O comando possui parâmetros '@' para receber as informações da tela, através do DTO.

            string script =
            @"UPDATE tb_filme 
                 SET nm_filme       = @nm_filme,
                     ds_sinopse     = @ds_sinopse,
                     ds_categoria   = @ds_categoria,
                     ds_caminho     = @ds_caminho,
                     vl_avaliacao   = @vl_avaliacao,
                     vl_duracao     = @vl_duracao,
                     qt_temporadas  = @qt_temporadas,
                     bt_maioridade  = @bt_maioridade,
                     dt_lancamento  = @dt_lancamento
               WHERE id_filme = @id_filme";


            /// Aqui ocorrem as substituições dos parâmetros
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_filme", filme.Id));
            parms.Add(new MySqlParameter("nm_filme", filme.Nome));          // 4º Passe o valor do campo Nome do DTO 
            parms.Add(new MySqlParameter("ds_sinopse", filme.Sinopse));
            parms.Add(new MySqlParameter("ds_categoria", filme.Categoria));
            parms.Add(new MySqlParameter("ds_caminho", filme.Caminho));
            parms.Add(new MySqlParameter("vl_avaliacao", filme.Avaliacao));
            parms.Add(new MySqlParameter("vl_duracao", filme.Duracao));
            parms.Add(new MySqlParameter("qt_temporadas", filme.QtdTemporadas));
            parms.Add(new MySqlParameter("bt_maioridade", filme.MaiorIdade));
            parms.Add(new MySqlParameter("dt_lancamento", filme.Lancamento));


            /// Aqui ocorre a execução do comando no bd
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }



        public void Remover(int id)
        {
            /// O comando de DELETE é gerado aqui.
            /// O comando possui parâmetros '@' para receber as informações da tela, pelo parâmetro id.

            string script =
            @"DELETE FROM tb_filme WHERE id_filme = @id_filme";


            /// Aqui ocorrem as substituições dos parâmetros
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_filme", id));


            /// Aqui ocorre a execução do comando no bd
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }



        public List<FilmeDTO> Consultar(string filme, string categoria)
        {
            /// O comando de SELECT é gerado aqui.
            /// O comando possui parâmetros '@' para receber as informações da tela, pelos parâmetros filme e categoria.

            string script =
            @"SELECT * 
                FROM tb_filme 
               WHERE nm_filme like @nm_filme 
                 AND ds_categoria like @ds_categoria";


            /// Aqui ocorrem as substituições dos parâmetros
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_filme", "%" + filme + "%"));         // 5º Substitua pelo parâmetro filme
            parms.Add(new MySqlParameter("ds_categoria", "%" + categoria + "%"));


            /// Aqui ocorre a execução do comando no bd
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);


            /// Por ser um SELECT, pode voltar mais de 1 registro, então usamos uma Lista
            List<FilmeDTO> filmes = new List<FilmeDTO>();

            /// Enquanto houver registros no BD, vamos lê-los no DTO e adicionar na lista
            while (reader.Read())
            {
                FilmeDTO novafilme = new FilmeDTO();
                novafilme.Id = reader.GetInt32("id_filme");
                // 5º Leia o campo Nome do DTO, pelo campo do banco de dados
                novafilme.Nome = reader.GetString("nm_filme");
                novafilme.Sinopse = reader.GetString("ds_sinopse");
                novafilme.Categoria = reader.GetString("ds_categoria");
                novafilme.Caminho = reader.GetString("ds_caminho");
                novafilme.Duracao = reader.GetDecimal("vl_duracao");
                novafilme.Avaliacao = reader.GetDecimal("vl_avaliacao");
                novafilme.QtdTemporadas = reader.GetInt32("qt_temporadas");
                novafilme.MaiorIdade = reader.GetBoolean("bt_maioridade");
                novafilme.Lancamento = reader.GetDateTime("dt_lancamento");
                
                filmes.Add(novafilme);
            }
            reader.Close();

            /// retorna a lista de DTOs
            return filmes;
        }



    }
}
