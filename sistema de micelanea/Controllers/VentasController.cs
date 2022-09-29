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
    public class VentasController : Controller
    {
        private readonly IVentaRepository _ctRepo;

        public VentasController (IVentaRepository ctRepo)

        {
            _ctRepo = ctRepo;

        }
        [HttpGet]
        
        public IActionResult GetVenta()
        {
            var ListaVentas = _ctRepo.GetVentas();
            return Ok(ListaVentas);
        }
    }
}
