using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DaoEntityProducto : IDaoProducto
    {
        public void Borrar(long id)
        {
            using (var db = new TiendaContext())
            {
                db.Productos.Remove(db.Productos.Find(id));
            }
        }

        public Producto Insertar(Producto producto)
        {
            using (var db = new TiendaContext())
            {
                db.Productos.Add(producto);
                db.SaveChanges();
                return producto;
            }
        }

        public Producto Modificar(Producto producto)
        {
            using (var db = new TiendaContext())
            {
                db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return producto;
            }
        }

        public Producto ObtenerPorId(long id)
        {
            using (var db = new TiendaContext())
            {
                return db.Productos.Find(id);
            }
        }

        public IEnumerable<Producto> ObtenerTodos()
        {
            using(var db = new TiendaContext())
            {
                return db.Productos.ToList();
            }
        }
    }
}
