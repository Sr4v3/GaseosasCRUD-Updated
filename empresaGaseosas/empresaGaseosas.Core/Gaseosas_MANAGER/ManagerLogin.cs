using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresaGaseosas.Core.Gaseosas_MANAGER
{
    class ManagerLogin
    {
        internal Dictionary<bool, string> ValidarLogin(string usuario, string password)
        {
            Gaseosas_BROKER.BrokerLogin broker = new Gaseosas_BROKER.BrokerLogin();
            List<string> retorno = broker.ValidarLogin(usuario);

            Dictionary<bool, string> resultado = new Dictionary<bool, string>();

            if (retorno == null || retorno.Count < 2 || string.IsNullOrEmpty(retorno[0]))
            {
                resultado.Add(false, "El usuario no existe, por favor valide el usuario ingresado.");
                return resultado;
            }

            int estadoUsuario;
            bool okParse = Int32.TryParse(retorno[1], out estadoUsuario);
            if (!okParse || estadoUsuario != 1)
            {
                resultado.Add(false, "El usuario está inactivo, por favor valide el usuario ingresado.");
                return resultado;
            }

            string pwdEnBd = retorno[0];
            if (!pwdEnBd.Equals(password))
            {
                resultado.Add(false, "Contraseña incorrecta, por favor valide la contraseña ingresada.");
                return resultado;
            }

            resultado.Add(true, "Login Correcto");
            return resultado;
        }

    }
}
