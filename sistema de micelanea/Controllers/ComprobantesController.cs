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
    public class ComprobantesController : Controller
    {
        private readonly IComprobanteRepository _ctRepo;

        public ComprobantesController (IComprobanteRepository ctRepo)

        {
            _ctRepo = ctRepo;

        }
        [HttpGet]
        
        public IActionResult GetComprobante()
        {
            var ListaComprobantes = _ctRepo.GetComprobantes();
            return Ok(ListaComprobantes);
        }
    }
}
