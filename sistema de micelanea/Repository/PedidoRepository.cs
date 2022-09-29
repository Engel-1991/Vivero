using sistema_de_micelanea.Data;
using sistema_de_micelanea.IRepository;
using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Repository   
{
    public class PedidoRepository : IPedidoRepository
    { 
    private readonly ApplicationDbContext _bd; 

    public PedidoRepository(ApplicationDbContext bd)
    {
        _bd = bd;
    }
        public bool ActualizarPedido(Pedido pedido)
        {
            _bd.Pedido.Update(pedido);
            return Guardar();
        }

        public bool BorrarPedido(Pedido pedido)
        {
            _bd.Pedido.Remove(pedido);
            return Guardar();
        }

        public bool CrearPedido(Pedido pedido)
        {
            _bd.Pedido.Add(pedido);
            return Guardar();
        }

        public bool ExistePedido(string nombre)
        {
            bool valor = _bd.Pedido.Any(c => c.ConfEntrega.ToLower().Trim() == nombre.ToLower().Trim());
            return valor;
        }

        public bool ExistePedido(int id)
        {
            return _bd.Pedido.Any(c => c.Id == id);
        }

        public Pedido GetPedido(int PedidoId)
        {
            return _bd.Pedido.FirstOrDefault(c => c.Id == PedidoId);
        }

        public ICollection<Pedido> GetPedidos()
        {
            return _bd.Pedido.OrderBy(c => c.ConfEntrega).ToList();
        }

        public bool Guardar()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }
    }
}
