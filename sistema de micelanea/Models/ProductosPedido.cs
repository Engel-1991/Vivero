using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Models
{
    public class ProductosPedido
   
    { 
        [Key]
        public int Id { get; set; }
        
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto Producto{ get; set;}  

        public int PedidoId { get; set; }
        [ForeignKey("PedidoId")]
        public Pedido Pedido{ get; set;}

    


    }
}
