using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.DB.Genio.DB.Base
{
    public class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=localhost;database=DesejoDB;uid=root;password=1234";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
