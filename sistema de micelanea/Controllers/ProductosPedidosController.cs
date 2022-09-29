using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sistema_de_micelanea.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoPedidosController : Controller
    {
        private readonly IProductosPedidoRepository _ctRepo;

        public ProductoPedidosController (IProductosPedidoRepository ctRepo)

        {
            _ctRepo = ctRepo;

        }
        //[HttpGet]
        
        //public IActionResult GetProductoPedido()
        //{
        //    var ListaProductoPedidos = _ctRepo.GetProductosPedidos();
        //    return Ok(ListaProductoPedidos);
        //}
    }
}
