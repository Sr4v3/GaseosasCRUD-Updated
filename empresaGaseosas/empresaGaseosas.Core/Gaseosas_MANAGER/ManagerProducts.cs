using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresaGaseosas.Core.Gaseosas_MANAGER
{
    class ManagerProducts
    {

        internal Dictionary<string, string> LeerProducto(string ProductSearch)
        {

            Gaseosas_BROKER.BrokerProducts ReadProduct = new Gaseosas_BROKER.BrokerProducts();
            return ReadProduct.LeerProducto(ProductSearch);
        }

        internal bool InactivarProducto(string ValuesProducto)
        {
            
            Gaseosas_BROKER.BrokerProducts InactivateProducto = new Gaseosas_BROKER.BrokerProducts();
            return InactivateProducto.InactivarProducto(ValuesProducto);

        }

        internal bool ActualizarProducto(Dictionary<string, string> ValuesProducto)
        {
            Gaseosas_BROKER.BrokerProducts UpdateProduct = new Gaseosas_BROKER.BrokerProducts();
            ChangeValuesStateAndPresentation(ValuesProducto);

            return UpdateProduct.ActualizarProducto(ValuesProducto);

        }


        internal bool InsertarProducto(Dictionary<string, string> ValuesProducto)
        {
            Gaseosas_BROKER.BrokerProducts InsertProduct = new Gaseosas_BROKER.BrokerProducts();
            ChangeValuesStateAndPresentation(ValuesProducto);

            return InsertProduct.InsertarProducto(ValuesProducto);

        }

        private static void ChangeValuesStateAndPresentation(Dictionary<string, string> ValuesProducto)
        {
            string Estado = ValuesProducto.GetValueOrDefault("State_Product");
            string Presentacion = ValuesProducto.GetValueOrDefault("Presentation_Product");
            if (Estado == "Activo")
                ValuesProducto["State_Product"] = "1";
            else
                ValuesProducto["State_Product"] = "2";

            if (Presentacion == "350mL")
                ValuesProducto["Presentation_Product"] = "1";
            else
                ValuesProducto["Presentation_Product"] = "2";
        }


    }
}
