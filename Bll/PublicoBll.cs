using Dal;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class PublicoBll
    {
        private readonly static IDaoProducto dao = FabricaDaos.ObtenerDaoProducto(Tipos.Entity);
        public static IEnumerable<Producto> ObtenerProductos()
        {
            return dao.ObtenerTodos();
        }

        public static object BuscarProductoPorId(long id)
        {
            return dao.ObtenerPorId(id);
        }

        public static decimal PrecioConDescuento(Producto producto)
        {
            return producto.Precio - (producto.Precio * (producto.Descuento / 100));
        }
    }
}
