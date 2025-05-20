using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace empresaGaseosas.Core.Gaseosas_BROKER
{
    internal class BrokerLogin
    {
        MySqlConnection Connection;
        BrokerConnection InsConnection = new BrokerConnection();



        internal List<string> ValidarLogin(string usuario)
        {

            Connection = InsConnection.OpenConnection();
            MySqlCommand transacLogeo = new MySqlCommand();
            transacLogeo.CommandText = string.Format("SELECT  UsuarioLoginContrasena('{0}'), UsuarioLoginEstado('{0}');", usuario);
            transacLogeo.Connection = Connection;

            List<string> ReturnLogin = new List<string>();
            MySqlDataReader ResultLogin = transacLogeo.ExecuteReader();

            if (ResultLogin.Read())
            {
                ReturnLogin.Add(!ResultLogin.IsDBNull(0) ? ResultLogin.GetString(0) : null);
                ReturnLogin.Add(!ResultLogin.IsDBNull(1) ? ResultLogin.GetInt32(1).ToString() : null);
            }

            ResultLogin.Close();
            InsConnection.CloseConnection(Connection);
            return ReturnLogin;


        }
    }
}
