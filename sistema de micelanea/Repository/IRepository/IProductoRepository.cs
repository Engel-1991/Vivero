using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.IRepository
{
    public interface IProductoRepository
    {
        ICollection<Producto> GetProductos();
        Producto GetProducto(int ProductoId);
        bool ExisteProducto(string nombre);
        bool ExisteProducto(int id);
        bool CrearProducto(Producto Producto);
        bool ActualizarProducto(Producto Producto);
        bool BorrarProducto(Producto Producto);
        bool Guardar();
    }
}

