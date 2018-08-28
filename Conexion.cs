using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace xtremgym
{
    public class Conexion
    {
        public MySqlConnection Con()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym;SslMode=none";
            
            return new MySqlConnection(connectionString);
        }
        public MySqlCommand Select(string comando,MySqlConnection C)
        {
            return new MySqlCommand(comando, C);
        }
    }
}
