using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Chat.DB
{
    public class ChatDatabase
    {
        public int Salvar(ChatDTO chatDTO)
        {
            /// O comando de INSERT é gerado aqui.
            /// O comando possui parâmetros '@' para receber as informações da tela, através do DTO.

            string script =
            @"INSERT INTO tb_chat
            (
                nm_aluno,
                ds_turma,
                ds_mensagem,
                dt_inclusao
            )
            VALUES
            (
                @nm_aluno,
                @ds_turma,
                @ds_mensagem,
                @dt_inclusao
            )";

            /// Aqui ocorrem as substituições dos parâmetros
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_aluno", chatDTO.Aluno)); 
            parms.Add(new MySqlParameter("ds_turma", chatDTO.Turma));
            parms.Add(new MySqlParameter("ds_mensagem", chatDTO.Mensagem));
            parms.Add(new MySqlParameter("dt_inclusao", chatDTO.Inclusao));


            /// Aqui ocorre a execução do comando no bd
            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }



        public List<ChatDTO> Consultar(string turma)
        {
            /// O comando de SELECT é gerado aqui.
            /// O comando possui parâmetros '@' para receber as informações da tela, pelo parâmetro turma.

            string script =
            @"SELECT * 
                FROM tb_chat 
               WHERE ds_turma = @ds_turma";


            /// Aqui ocorrem as substituições dos parâmetros
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_turma", turma));


            /// Aqui ocorre a execução do comando no bd
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);


            /// Por ser um SELECT, pode voltar mais de 1 registro, então usamos uma Lista
            List<ChatDTO> mensagens = new List<ChatDTO>();

            /// Enquanto houver registros no BD, vamos lê-los no DTO e adicionar na lista
            while (reader.Read())
            {
                ChatDTO chat = new ChatDTO();
                chat.Id = reader.GetInt32("id_chat");
                chat.Aluno = reader.GetString("nm_aluno");
                chat.Turma = reader.GetString("ds_turma");
                chat.Mensagem = reader.GetString("ds_mensagem");
                chat.Inclusao = reader.GetDateTime("dt_inclusao");
                
                mensagens.Add(chat);
            }
            reader.Close();

            /// retorna a lista de DTOs
            return mensagens;
        }



    }
}
