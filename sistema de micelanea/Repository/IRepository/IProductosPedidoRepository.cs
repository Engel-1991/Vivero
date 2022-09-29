using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.IRepository
{
    public interface IProductosPedidoRepository
    {
       // ICollection<ProductosPedido> bool GetProductosPedidos();
        ProductosPedido GetProductosPedido(int ProductosPedidoId);
        bool ExisteProductosPedido(int id);
        bool CrearProductosPedido(ProductosPedido productosPedido);
        bool ActualizarProductosPedido(ProductosPedido productosPedido);
        bool BorrarProductosPedido(ProductosPedido productosPedido);
        bool Guardar();
        //object GetProductosPedidos();
    }
}

