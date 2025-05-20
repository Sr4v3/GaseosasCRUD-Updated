using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresaGaseosas.Core.Gaseosas_BROKER
{
    class BrokerConnection
    {

        internal MySqlConnection OpenConnection()
        {
            MySqlConnection con;

            try
            {
                string StringConnection = string.Empty;
                StringConnection = "server=127.0.0.1;uid=root;pwd=12345678;database=gaseosas";
               
                con = new MySqlConnection(StringConnection);
                con.Open();

            }
            catch (Exception exc)
            {
                throw exc;
            }
            return con;
        }

        /// <param name="Connection"></param>
        internal void CloseConnection(MySqlConnection Connection)
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }

    }
}
