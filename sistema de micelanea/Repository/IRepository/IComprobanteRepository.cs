using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.IRepository
{
    public interface IComprobanteRepository
    {
        ICollection<Comprobante> GetComprobantes();
        Comprobante GetComprobante(int ComprobanteId);
        bool ExisteComprobante(string nombre);
        bool ExisteComprobante(int id);
        bool CrearComprobante(Comprobante comprobante);
        bool ActualizarComprobante(Comprobante comprobante);
        bool BorrarComprobante(Comprobante comprobante);
        bool Guardar();
    }
}

