using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.IRepository
{
    public interface IPedidoRepository
    {
        ICollection<Pedido> GetPedidos();
        Pedido GetPedido(int PedidoId);
        bool ExistePedido(string nombre);
        bool ExistePedido(int id);
        bool CrearPedido(Pedido pedido);
        bool ActualizarPedido(Pedido pedido);
        bool BorrarPedido(Pedido pedido);
        bool Guardar();
    }
}

