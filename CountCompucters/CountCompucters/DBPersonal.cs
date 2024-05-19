using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCompucters
{
    internal class DBPersonal
    {
        MySqlConnection connection = new MySqlConnection("server=www.db4free.net;port=3306;username=mimikss;password=13133535;database=housevop");

        public void openConnetion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            { 
                connection.Open(); 
            }
        }
        public void closeConnetion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;  
        }
    }
}
