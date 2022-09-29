using Microsoft.EntityFrameworkCore;
using sistema_de_micelanea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
        }
    public DbSet<Categoria> Categoria { get; set; }
    public DbSet<Comprobante> Comprobante { get; set; }
    public DbSet<Inventario> Inventario { get; set; }
    public DbSet<Pedido> Pedido { get; set; }
    public DbSet<Producto> Producto { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Venta> Venta { get; set; } 
    public DbSet<ProductosPedido> ProductosPedido { get; set; }
            
    }
}
