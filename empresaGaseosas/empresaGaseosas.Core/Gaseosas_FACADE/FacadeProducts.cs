using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresaGaseosas.Core.Gaseosas_FACADE
{
    public class FacadeProducts
    {
        public Dictionary<string, string> LeerProducto(string ProductSearch)
        {

            Gaseosas_MANAGER.ManagerProducts ReadProduct = new Gaseosas_MANAGER.ManagerProducts();
            return ReadProduct.LeerProducto(ProductSearch);
        }


        public bool InactivarProducto(string ValuesProducto)
        {
            Gaseosas_MANAGER.ManagerProducts InactivateProduct = new Gaseosas_MANAGER.ManagerProducts();
            return InactivateProduct.InactivarProducto(ValuesProducto);

        }


        public bool ActualizarProducto(Dictionary<string, string> ValuesProducto)
        {
            Gaseosas_MANAGER.ManagerProducts UpdateProduct = new Gaseosas_MANAGER.ManagerProducts();
            return UpdateProduct.ActualizarProducto(ValuesProducto);

        }


        public bool InsertarProducto(Dictionary<string, string> ValuesProducto)
        {
            Gaseosas_MANAGER.ManagerProducts InsertProduct = new Gaseosas_MANAGER.ManagerProducts();
            return InsertProduct.InsertarProducto(ValuesProducto);

        }


    }
}
