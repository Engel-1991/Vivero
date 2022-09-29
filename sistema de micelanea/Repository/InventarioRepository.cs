using sistema_de_micelanea.Data;
using sistema_de_micelanea.IRepository;
using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Repository   
{
    public class InventarioRepository : IInventarioRepository
    { 
    private readonly ApplicationDbContext _bd; 

    public InventarioRepository(ApplicationDbContext bd)
    {
        _bd = bd;
    }
        public bool ActualizarInventario(Inventario inventario)
        {
            _bd.Inventario.Update(inventario);
            return Guardar();
        }

        public bool BorrarInventario(Inventario inventario)
        {
            _bd.Inventario.Remove(inventario);
            return Guardar();
        }

        public bool CrearInventario(Inventario inventario)
        {
            _bd.Inventario.Add(inventario);
            return Guardar();
        }

        public bool ExisteInventario(string nombre)
        {
            bool valor = _bd.Inventario.Any(c => c.Stock.ToLower().Trim() == nombre.ToLower().Trim());
            return valor;
        }

        public bool ExisteInventario(int id)
        {
            return _bd.Inventario.Any(c => c.Id == id);
        }

        public Inventario GetInventario(int InventarioId)
        {
            return _bd.Inventario.FirstOrDefault(c => c.Id == InventarioId);
        }

        public ICollection<Inventario> GetInventarios()
        {
            return _bd.Inventario.OrderBy(c => c.Stock).ToList();
        }

        public bool Guardar()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }
    }
}
