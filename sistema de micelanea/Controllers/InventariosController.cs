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
    public class InventariosController : Controller
    {
        private readonly IInventarioRepository _ctRepo;

        public InventariosController (IInventarioRepository ctRepo)

        {
            _ctRepo = ctRepo;

        }
        [HttpGet]
        
        public IActionResult GetInventario()
        {
            var ListaInventarios = _ctRepo.GetInventarios();
            return Ok(ListaInventarios);
        }
    }
}
