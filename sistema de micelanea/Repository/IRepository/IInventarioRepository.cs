using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.IRepository
{
    public interface IInventarioRepository
    {
        ICollection<Inventario> GetInventarios();
        Inventario GetInventario(int InventarioId);
        bool ExisteInventario(string nombre);
        bool ExisteInventario(int id);
        bool CrearInventario(Inventario inventario);
        bool ActualizarInventario(Inventario inventario);
        bool BorrarInventario(Inventario inventario);
        bool Guardar();
    }
}

