using sistema_de_micelanea.Data;
using sistema_de_micelanea.IRepository;
using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Repository   
{
    public class ProductoRepository : IProductoRepository
    { 
    private readonly ApplicationDbContext _bd; 

    public ProductoRepository(ApplicationDbContext bd)
    {
        _bd = bd;
    }
        public bool ActualizarProducto(Producto Producto)
        {
            _bd.Producto.Update(Producto);
            return Guardar();
        }

        public bool BorrarProducto(Producto Producto)
        {
            _bd.Producto.Remove(Producto);
            return Guardar();
        }

        public bool CrearProducto(Producto Producto)
        {
            _bd.Producto.Add(Producto);
            return Guardar();
        }

        public bool ExisteProducto(string nombre)
        {
            bool valor = _bd.Producto.Any(c => c.Nombre.ToLower().Trim() == nombre.ToLower().Trim());
            return valor;
        }

        public bool ExisteProducto(int id)
        {
            return _bd.Producto.Any(c => c.Id == id);
        }

        public Producto GetProducto(int ProductoId)
        {
            return _bd.Producto.FirstOrDefault(c => c.Id == ProductoId);
        }

        public ICollection<Producto> GetProductos()
        {
            return _bd.Producto.OrderBy(c => c.Nombre).ToList();
        }

        public bool Guardar()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }
    }
}
