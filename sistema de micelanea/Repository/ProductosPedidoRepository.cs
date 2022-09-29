using sistema_de_micelanea.Data;
using sistema_de_micelanea.IRepository;
using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Repository   
{
    public class ProductosPedidoRepository : IProductosPedidoRepository
    { 
    private readonly ApplicationDbContext _bd; 

    public ProductosPedidoRepository(ApplicationDbContext bd)
    {
        _bd = bd;
    }
        public bool ActualizarProductosPedido(ProductosPedido productosPedido)
        {
            _bd.ProductosPedido.Update(productosPedido);
            return Guardar();
        }

        public bool BorrarProductosPedido(ProductosPedido productosPedido)
        {
            _bd.ProductosPedido.Remove(productosPedido);
            return Guardar();
        }

        public bool CrearProductosPedido(ProductosPedido productosPedido)
        {
            _bd.ProductosPedido.Add(productosPedido);
            return Guardar();
        }

      

        public bool ExisteProductosPedido(int id)
        {
            return _bd.ProductosPedido.Any(c => c.Id == id);
        }

        public ProductosPedido GetProductosPedido(int ProductosPedidoId)
        {
            return _bd.ProductosPedido.FirstOrDefault(c => c.Id == ProductosPedidoId);
        }


        public bool Guardar()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }
    }
}
