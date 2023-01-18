using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.BD.Video.DB
{
    public class Connection
    {
        public MySqlConnection Create()
        {
            // 1º Conectar com o banco de dados
            // Na connectionString você informa o nome do DB, o usuário e a senha de conexão

            string connectionString = "server=localhost;database=FilmeDB;uid=root;password=1234";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }

    }
}
