using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Models
{
    public class Venta

    { 
        [Key]
        public int Id { get; set; }
        public string VentaDir { get; set; }
        public string VentaOnl { get; set; }

        public int ComprobanteId { get; set; }
        [ForeignKey("ComprobanteId")]
        public Comprobante Comprobante{ get; set;}
    }
}
