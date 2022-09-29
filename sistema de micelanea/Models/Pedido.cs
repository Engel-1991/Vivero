using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Models
{
    public class Pedido
   
    { 
        [Key]
        public int Id { get; set; }
        public string ConfEntrega { get; set; }
        public DateTime FechaPed { get; set; }
        public DateTime FechaEntrega { get; set; } 

        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario{ get; set;}
    }
}
