using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresaGaseosas.Core.Gaseosas_FACADE
{
    public class FacadeEmployee
    {
        public Dictionary<string, string> LeerEmpleado(string EmployeeSearch)
        {

            Gaseosas_MANAGER.ManagerEmployee ReadEmployee = new Gaseosas_MANAGER.ManagerEmployee();
            return ReadEmployee.LeerEmpleado(EmployeeSearch);
        }


        public bool InactivarEmpleado(string ValuesEmpleado)
        {
            Gaseosas_MANAGER.ManagerEmployee InactivateEmployee = new Gaseosas_MANAGER.ManagerEmployee();
            return InactivateEmployee.InactivarEmpleado(ValuesEmpleado);

        }


        public bool ActualizarEmpleado(Dictionary<string, string> ValuesEmpleado)
        {
            Gaseosas_MANAGER.ManagerEmployee UpdateEmployee = new Gaseosas_MANAGER.ManagerEmployee();
            return UpdateEmployee.ActualizarEmpleado(ValuesEmpleado);

        }


        public bool InsertarEmpleado(Dictionary<string, string> ValuesEmpleado)
        {
            Gaseosas_MANAGER.ManagerEmployee InsertEmployee = new Gaseosas_MANAGER.ManagerEmployee();
            return InsertEmployee.InsertarEmpleado(ValuesEmpleado);

        }

    }
}
