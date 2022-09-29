using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.IRepository
{
    public interface IVentaRepository
    {
        ICollection<Venta> GetVentas();
        Venta GetVenta(int VentaId);
        bool ExisteVenta(string nombre);
        bool ExisteVenta(int id);
        bool CrearVenta(Venta venta);
        bool ActualizarVenta(Venta venta);
        bool BorrarVenta(Venta venta);
        bool Guardar();
    }
}

