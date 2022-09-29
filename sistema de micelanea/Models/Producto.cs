using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Models
{
    public class Producto

    { 
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PrecioUni { get; set; }
        public string PrecioVen { get; set; }

        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria{ get; set;}

        public int InventarioId { get; set; }
        [ForeignKey("InventarioId")]
        public Inventario Inventario{ get; set;}
  
    }
}
