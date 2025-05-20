using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresaGaseosas.Core.Gaseosas_MANAGER
{
    class ManagerEmployee
    {

        internal Dictionary<string, string> LeerEmpleado(string EmployeeSearch)
        {

            Gaseosas_BROKER.BrokerEmployee ReadEmployee = new Gaseosas_BROKER.BrokerEmployee();
            return ReadEmployee.LeerEmpleado(EmployeeSearch);
        }


        internal bool InactivarEmpleado(string ValuesEmpleado)
        {

            Gaseosas_BROKER.BrokerEmployee InactivateEmployee = new Gaseosas_BROKER.BrokerEmployee();
            return InactivateEmployee.InactivarEmpleado(ValuesEmpleado);

        }


        internal bool ActualizarEmpleado(Dictionary<string, string> ValuesEmpleado)
        {
            Gaseosas_BROKER.BrokerEmployee UpdateEmployee = new Gaseosas_BROKER.BrokerEmployee();
            ChangeValuesDocTypeWorkAreaEduLevel(ValuesEmpleado);

            return UpdateEmployee.ActualizarEmpleado(ValuesEmpleado);

        }


        internal bool InsertarEmpleado(Dictionary<string, string> ValuesEmpleado)
        {
            Gaseosas_BROKER.BrokerEmployee InsertEmployee = new Gaseosas_BROKER.BrokerEmployee();
            ChangeValuesDocTypeWorkAreaEduLevel(ValuesEmpleado);

            return InsertEmployee.InsertarEmpleado(ValuesEmpleado);

        }


        private static void ChangeValuesDocTypeWorkAreaEduLevel(Dictionary<string, string> ValuesEmpleado)
        {
            string Estado = ValuesEmpleado.GetValueOrDefault("State_Employee");
            string TipoDoc = ValuesEmpleado.GetValueOrDefault("DocType_Employee");
            string AreaTrabajo = ValuesEmpleado.GetValueOrDefault("WorkArea_Employee");
            string NivelEducativo = ValuesEmpleado.GetValueOrDefault("EducationLevel_Employee");

            if (Estado == "Activo")
                ValuesEmpleado["State_Employee"] = "1";
            else
                ValuesEmpleado["State_Employee"] = "2";

            if (TipoDoc == "Cédula de Ciudadanía")
                ValuesEmpleado["DocType_Employee"] = "1";
            else if (TipoDoc == "Tarjeta de Identidad")
                ValuesEmpleado["DocType_Employee"] = "2";
            else if (TipoDoc == "Cédula de Extranjería")
                ValuesEmpleado["DocType_Employee"] = "3";
            else if (TipoDoc == "Pasaporte")
                ValuesEmpleado["DocType_Employee"] = "4";
            else if (TipoDoc == "NIT")
                ValuesEmpleado["DocType_Employee"] = "5";
            else if (TipoDoc == "Registro Civil")
                ValuesEmpleado["DocType_Employee"] = "6";
            else if (TipoDoc == "Libreta Militar")
                ValuesEmpleado["DocType_Employee"] = "7";
            else if (TipoDoc == "Documento de Identidad")
                ValuesEmpleado["DocType_Employee"] = "8";
            else if (TipoDoc == "DNI")
                ValuesEmpleado["DocType_Employee"] = "9";
            else
                ValuesEmpleado["DocType_Employee"] = "10";


            if (AreaTrabajo == "Ventas")
                ValuesEmpleado["WorkArea_Employee"] = "1";
            else if (AreaTrabajo == "Administración")
                ValuesEmpleado["WorkArea_Employee"] = "2";
            else if (AreaTrabajo == "Logística")
                ValuesEmpleado["WorkArea_Employee"] = "3";
            else if (AreaTrabajo == "Operaciones")
                ValuesEmpleado["WorkArea_Employee"] = "4";
            else if (AreaTrabajo == "Finanzas")
                ValuesEmpleado["WorkArea_Employee"] = "5";
            else if (AreaTrabajo == "Recursos Humanos")
                ValuesEmpleado["WorkArea_Employee"] = "6";
            else if (AreaTrabajo == "Marketing")
                ValuesEmpleado["WorkArea_Employee"] = "7";
            else if (AreaTrabajo == "Tecnología")
                ValuesEmpleado["WorkArea_Employee"] = "8";
            else if (AreaTrabajo == "Atención al Cliente")
                ValuesEmpleado["WorkArea_Employee"] = "9";
            else
                ValuesEmpleado["WorkArea_Employee"] = "10";


            if (NivelEducativo == "Primaria")
                ValuesEmpleado["EducationLevel_Employee"] = "1";
            else if (NivelEducativo == "Secundaria")
                ValuesEmpleado["EducationLevel_Employee"] = "2";
            else if (NivelEducativo == "Bachillerato")
                ValuesEmpleado["EducationLevel_Employee"] = "3";
            else if (NivelEducativo == "Técnico")
                ValuesEmpleado["EducationLevel_Employee"] = "4";
            else if (NivelEducativo == "Tecnólogo")
                ValuesEmpleado["EducationLevel_Employee"] = "5";
            else if (NivelEducativo == "Pregrado")
                ValuesEmpleado["EducationLevel_Employee"] = "6";
            else if (NivelEducativo == "Maestría")
                ValuesEmpleado["EducationLevel_Employee"] = "7";
            else if (NivelEducativo == "Doctorado")
                ValuesEmpleado["EducationLevel_Employee"] = "8";
            else if (NivelEducativo == "Postdoctorado")
                ValuesEmpleado["EducationLevel_Employee"] = "9";
            else
                ValuesEmpleado["EducationLevel_Employee"] = "10";

        }

    }
}
