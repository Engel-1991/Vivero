using sistema_de_micelanea.Data;
using sistema_de_micelanea.IRepository;
using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Repository   
{
    public class ComprobanteRepository : IComprobanteRepository
    { 
    private readonly ApplicationDbContext _bd; 

    public ComprobanteRepository(ApplicationDbContext bd)
    {
        _bd = bd;
    }
        public bool ActualizarComprobante(Comprobante comprobante)
        {
            _bd.Comprobante.Update(comprobante);
            return Guardar();
        }

        public bool BorrarComprobante(Comprobante comprobante)
        {
            _bd.Comprobante.Remove(comprobante);
            return Guardar();
        }

        public bool CrearComprobante(Comprobante comprobante)
        {
            _bd.Comprobante.Add(comprobante);
            return Guardar();
        }

        public bool ExisteComprobante(string nombre)
        {
            bool valor = _bd.Comprobante.Any(c => c.FormaPago.ToLower().Trim() == nombre.ToLower().Trim());
            return valor;
        }

        public bool ExisteComprobante(int id)
        {
            return _bd.Comprobante.Any(c => c.Id == id);
        }

        public Comprobante GetComprobante(int ComprobanteId)
        {
            return _bd.Comprobante.FirstOrDefault(c => c.Id == ComprobanteId);
        }

        public ICollection<Comprobante> GetComprobantes()
        {
            return _bd.Comprobante.OrderBy(c => c.FormaPago).ToList();
        }

        public bool Guardar()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }
    }
}
