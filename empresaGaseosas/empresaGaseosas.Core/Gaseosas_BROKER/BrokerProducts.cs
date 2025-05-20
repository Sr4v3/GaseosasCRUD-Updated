using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresaGaseosas.Core.Gaseosas_BROKER
{
    class BrokerProducts
    {
        MySqlConnection Connection;
        Gaseosas_BROKER.BrokerConnection InsConnection = new Gaseosas_BROKER.BrokerConnection();



        internal Dictionary<string, string> LeerProducto(string ProductSearch)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand transacLogeo = new MySqlCommand();
            transacLogeo.CommandText = string.Format("CALL LeerProducto( {0} )", ProductSearch);
            transacLogeo.Connection = Connection;
            Dictionary<string, string> ReturnLogin = new Dictionary<string, string>();
            MySqlDataReader ResultLogin = transacLogeo.ExecuteReader();
            while (ResultLogin.Read())
            {
                ReturnLogin.Add("Value_Product", ResultLogin[0].ToString());
                ReturnLogin.Add("Descrip_Value", ResultLogin[2].ToString());
                if (ResultLogin[3].ToString() == "1")
                    ReturnLogin.Add("State_Product", "Activo");
                else
                    ReturnLogin.Add("State_Product", "Inactivo");
                if (ResultLogin[1].ToString() == "1")
                    ReturnLogin.Add("Presentation_Product", "350mL");
                else
                    ReturnLogin.Add("Presentation_Product", "3L");
            }
            InsConnection.CloseConnection(Connection);
            return ReturnLogin;
        }



        internal bool InactivarProducto(string ProductInactivate)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand transacInactivate = new MySqlCommand();
            transacInactivate.CommandText = string.Format("update productos set estadoProducto=2  where idProducto='{0}';", ProductInactivate);
            transacInactivate.Connection = Connection;
            int ResultInactivate = transacInactivate.ExecuteNonQuery();
            InsConnection.CloseConnection(Connection);
            if (ResultInactivate > 0)
                return true;
            else
                return false;
        }



        internal bool ActualizarProducto(Dictionary<string, string> ValuesProducto)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand transacUpdate = new MySqlCommand();
            transacUpdate.CommandText = string.Format("CALL  ActualizarProducto( {0} , {1} , {3} , {2} , {4});",
                    string.IsNullOrEmpty(ValuesProducto.GetValueOrDefault("Id_Product")) ? null : ValuesProducto.GetValueOrDefault("Id_Product"),
                    string.IsNullOrEmpty(ValuesProducto.GetValueOrDefault("Value_Product")) ? null : ValuesProducto.GetValueOrDefault("Value_Product"),
                    string.IsNullOrEmpty(ValuesProducto.GetValueOrDefault("Descrip_Value")) ? null : string.Concat("'", ValuesProducto.GetValueOrDefault("Descrip_Value"), "'"),
                    string.IsNullOrEmpty(ValuesProducto.GetValueOrDefault("Presentation_Product")) ? null : ValuesProducto.GetValueOrDefault("Presentation_Product"),
                    string.IsNullOrEmpty(ValuesProducto.GetValueOrDefault("State_Product")) ? null : ValuesProducto.GetValueOrDefault("State_Product"));
            transacUpdate.Connection = Connection;
            int ResultLogin = transacUpdate.ExecuteNonQuery();
            InsConnection.CloseConnection(Connection);
            if (ResultLogin > 0)
                return true;
            else
                return false;
        }



        internal bool InsertarProducto(Dictionary<string, string> ValuesProducto)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand transacLogeo = new MySqlCommand();
            transacLogeo.CommandText = string.Format("INSERT INTO gaseosas.productos VALUES ('{0}','{1}','{3}','{2}','{4}');", ValuesProducto.GetValueOrDefault("Id_Product"),
                ValuesProducto.GetValueOrDefault("Value_Product"), ValuesProducto.GetValueOrDefault("Descrip_Value"),
                ValuesProducto.GetValueOrDefault("Presentation_Product"), ValuesProducto.GetValueOrDefault("State_Product"));
            transacLogeo.Connection = Connection;
            int ResultLogin = transacLogeo.ExecuteNonQuery();
            InsConnection.CloseConnection(Connection);
            if (ResultLogin > 0)
                return true;
            else
                return false;
        }
    }
}
