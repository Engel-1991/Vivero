using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Models
{
    public class Inventario

    { 
        [Key]
        public int Id { get; set; }
        public string CantEnt { get; set; }
        public string CanSal { get; set; }
        public string Stock { get; set; }
        public DateTime FechaEnt { get; set; }
        public DateTime FechaSal { get; set; }
    }
}
