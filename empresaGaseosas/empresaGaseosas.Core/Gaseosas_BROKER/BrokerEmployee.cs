using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresaGaseosas.Core.Gaseosas_BROKER
{
    class BrokerEmployee
    {
        MySqlConnection Connection;
        Gaseosas_BROKER.BrokerConnection InsConnection = new Gaseosas_BROKER.BrokerConnection();


        internal Dictionary<string, string> LeerEmpleado(string EmployeeSearch)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand transacLogeo = new MySqlCommand();
            transacLogeo.CommandText = string.Format("CALL LeerEmpleado( {0} )", EmployeeSearch);
            transacLogeo.Connection = Connection;
            Dictionary<string, string> ReturnLogin = new Dictionary<string, string>();
            MySqlDataReader ResultLogin = transacLogeo.ExecuteReader();
            while (ResultLogin.Read())
            {
                ReturnLogin.Add("DocNumber_Employee", ResultLogin[1].ToString());
                ReturnLogin.Add("Name_Employee", ResultLogin[2].ToString());
                ReturnLogin.Add("LName_Employee", ResultLogin[3].ToString());
                ReturnLogin.Add("Mail_Employee", ResultLogin[4].ToString());
                ReturnLogin.Add("Phone_Employee", ResultLogin[5].ToString());
                ReturnLogin.Add("HiringDate_Employee", ResultLogin[6].ToString());



                string docTypeCode = ResultLogin[0].ToString();
                switch (docTypeCode)
                {
                    case "1":
                        ReturnLogin.Add("DocType_Employee", "Cédula de Ciudadanía");
                        break;
                    case "2":
                        ReturnLogin.Add("DocType_Employee", "Tarjeta de Identidad");
                        break;
                    case "3":
                        ReturnLogin.Add("DocType_Employee", "Cédula de Extranjería");
                        break;
                    case "4":
                        ReturnLogin.Add("DocType_Employee", "Pasaporte");
                        break;
                    case "5":
                        ReturnLogin.Add("DocType_Employee", "NIT");
                        break;
                    case "6":
                        ReturnLogin.Add("DocType_Employee", "Registro Civil");
                        break;
                    case "7":
                        ReturnLogin.Add("DocType_Employee", "Libreta Militar");
                        break;
                    case "8":
                        ReturnLogin.Add("DocType_Employee", "Documento de Identidad");
                        break;
                    case "9":
                        ReturnLogin.Add("DocType_Employee", "DNI");
                        break;
                    default:
                        ReturnLogin.Add("DocType_Employee", "Otro");
                        break;
                }


                string workAreaCode = ResultLogin[7].ToString();
                switch (workAreaCode)
                {
                    case "1":
                        ReturnLogin.Add("WorkArea_Employee", "Ventas");
                        break;
                    case "2":
                        ReturnLogin.Add("WorkArea_Employee", "Administración");
                        break;
                    case "3":
                        ReturnLogin.Add("WorkArea_Employee", "Logística");
                        break;
                    case "4":
                        ReturnLogin.Add("WorkArea_Employee", "Operaciones");
                        break;
                    case "5":
                        ReturnLogin.Add("WorkArea_Employee", "Finanzas");
                        break;
                    case "6":
                        ReturnLogin.Add("WorkArea_Employee", "Recursos Humanos");
                        break;
                    case "7":
                        ReturnLogin.Add("WorkArea_Employee", "Marketing");
                        break;
                    case "8":
                        ReturnLogin.Add("WorkArea_Employee", "Tecnología");
                        break;
                    case "9":
                        ReturnLogin.Add("WorkArea_Employee", "Atención al Cliente");
                        break;
                    default:
                        ReturnLogin.Add("WorkArea_Employee", "Producción");
                        break;

                }


                string eduCode = ResultLogin[8].ToString();
                switch (eduCode)
                {
                    case "1":
                        ReturnLogin.Add("EducationLevel_Employee", "Primaria");
                        break;
                    case "2":
                        ReturnLogin.Add("EducationLevel_Employee", "Secundaria");
                        break;
                    case "3":
                        ReturnLogin.Add("EducationLevel_Employee", "Bachillerato");
                        break;
                    case "4":
                        ReturnLogin.Add("EducationLevel_Employee", "Técnico");
                        break;
                    case "5":
                        ReturnLogin.Add("EducationLevel_Employee", "Tecnólogo");
                        break;
                    case "6":
                        ReturnLogin.Add("EducationLevel_Employee", "Pregrado");
                        break;
                    case "7":
                        ReturnLogin.Add("EducationLevel_Employee", "Maestría");
                        break;
                    case "8":
                        ReturnLogin.Add("EducationLevel_Employee", "Doctorado");
                        break;
                    case "9":
                        ReturnLogin.Add("EducationLevel_Employee", "Postdoctorado");
                        break;
                    case "10":
                        ReturnLogin.Add("EducationLevel_Employee", "Sin estudio");
                        break;
                    default:
                        ReturnLogin.Add("EducationLevel_Employee", "Desconocido");
                        break;
                }

                if (ResultLogin[9].ToString() == "1")
                    ReturnLogin.Add("State_Employee", "Activo");
                else
                    ReturnLogin.Add("State_Employee", "Inactivo");
            }
            InsConnection.CloseConnection(Connection);
            return ReturnLogin;
        }



        internal bool InactivarEmpleado(string EmployeeInactivate)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand transacInactivate = new MySqlCommand();
            transacInactivate.CommandText = string.Format("update empleados set estadoEmpleado=2  where idEmpleado='{0}';", EmployeeInactivate);
            transacInactivate.Connection = Connection;
            int ResultInactivate = transacInactivate.ExecuteNonQuery();
            InsConnection.CloseConnection(Connection);
            if (ResultInactivate > 0)
                return true;
            else
                return false;
        }



        internal bool ActualizarEmpleado(Dictionary<string, string> ValuesEmpleado)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand transacUpdate = new MySqlCommand();
            transacUpdate.CommandText = string.Format("CALL  ActualizarEmpleado('{0}', '{8}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{9}', '{10}', '{11}');", 
                ValuesEmpleado.GetValueOrDefault("Id_Employee"), 
                ValuesEmpleado.GetValueOrDefault("DocNumber_Employee"),
                ValuesEmpleado.GetValueOrDefault("Name_Employee"),
                ValuesEmpleado.GetValueOrDefault("LName_Employee"),
                ValuesEmpleado.GetValueOrDefault("Mail_Employee"),
                ValuesEmpleado.GetValueOrDefault("Phone_Employee"),
                ValuesEmpleado.GetValueOrDefault("Password"),
                ValuesEmpleado.GetValueOrDefault("HiringDate_Employee"),
                ValuesEmpleado.GetValueOrDefault("DocType_Employee"),
                ValuesEmpleado.GetValueOrDefault("WorkArea_Employee"),
                ValuesEmpleado.GetValueOrDefault("EducationLevel_Employee"),
                ValuesEmpleado.GetValueOrDefault("State_Employee"));


            transacUpdate.Connection = Connection;
            int ResultLogin = transacUpdate.ExecuteNonQuery();
            InsConnection.CloseConnection(Connection);
            if (ResultLogin > 0)
                return true;
            else
                return false;
        }



        internal bool InsertarEmpleado(Dictionary<string, string> ValuesEmpleado)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand transacLogeo = new MySqlCommand();
            transacLogeo.CommandText = string.Format("INSERT INTO gaseosas.empleados VALUES ('{0}', '{8}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{9}', '{10}', '{11}');", 
                ValuesEmpleado.GetValueOrDefault("Id_Employee"), 
                ValuesEmpleado.GetValueOrDefault("DocNumber_Employee"),
                ValuesEmpleado.GetValueOrDefault("Name_Employee"),
                ValuesEmpleado.GetValueOrDefault("LName_Employee"),
                ValuesEmpleado.GetValueOrDefault("Mail_Employee"),
                ValuesEmpleado.GetValueOrDefault("Phone_Employee"),
                ValuesEmpleado.GetValueOrDefault("Password"),
                ValuesEmpleado.GetValueOrDefault("HiringDate_Employee"),
                ValuesEmpleado.GetValueOrDefault("DocType_Employee"),
                ValuesEmpleado.GetValueOrDefault("WorkArea_Employee"),
                ValuesEmpleado.GetValueOrDefault("EducationLevel_Employee"),
                ValuesEmpleado.GetValueOrDefault("State_Employee"));

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
