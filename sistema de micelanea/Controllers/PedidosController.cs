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
    public class PedidosController : Controller
    {
        private readonly IPedidoRepository _ctRepo;

        public PedidosController (IPedidoRepository ctRepo)

        {
            _ctRepo = ctRepo;

        }
        [HttpGet]
        
        public IActionResult GetPedido()
        {
            var ListaPedidos = _ctRepo.GetPedidos();
            return Ok(ListaPedidos);
        }
    }
}
