using sistema_de_micelanea.Data;
using sistema_de_micelanea.IRepository;
using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Repository   
{
    public class VentaRepository : IVentaRepository
    { 
    private readonly ApplicationDbContext _bd; 

    public VentaRepository(ApplicationDbContext bd)
    {
        _bd = bd;
    }
        public bool ActualizarVenta(Venta venta)
        {
            _bd.Venta.Update(venta);
            return Guardar();
        }

        public bool BorrarVenta(Venta venta)
        {
            _bd.Venta.Remove(venta);
            return Guardar();
        }

        public bool CrearVenta(Venta venta)
        {
            _bd.Venta.Add(venta);
            return Guardar();
        }

        public bool ExisteVenta(string nombre)
        {
            bool valor = _bd.Venta.Any(c => c.VentaOnl.ToLower().Trim() == nombre.ToLower().Trim());
            return valor;
        }

        public bool ExisteVenta(int id)
        {
            return _bd.Venta.Any(c => c.Id == id);
        }

        public Venta GetVenta(int VentaId)
        {
            return _bd.Venta.FirstOrDefault(c => c.Id == VentaId);
        }

        public ICollection<Venta> GetVentas()
        {
            return _bd.Venta.OrderBy(c => c.VentaOnl).ToList();
        }

        public bool Guardar()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }
    }
}
