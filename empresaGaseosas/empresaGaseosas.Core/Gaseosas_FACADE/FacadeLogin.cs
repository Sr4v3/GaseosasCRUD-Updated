using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresaGaseosas.Core.Gaseosas_FACADE
{
    public class FacadeLogin
    {
        public Dictionary<bool, string> ValidarLogin(string usuario, string password)
        {

            Gaseosas_MANAGER.ManagerLogin Logeo = new Gaseosas_MANAGER.ManagerLogin();
            Dictionary<bool, string> Results = new Dictionary<bool, string>();
            return Logeo.ValidarLogin(usuario, password);
        }

    }
}
