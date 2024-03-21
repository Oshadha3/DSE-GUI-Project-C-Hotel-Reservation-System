using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TestProject
{
    internal class DBConnection
    {
        public static MySqlConnection connectDB()
        {
            string connection_string = @"server=localhost;userid=root;Pwd=;database=hrsdb";
            MySqlConnection con = new MySqlConnection(connection_string);
            return con;
        }
    }
}
