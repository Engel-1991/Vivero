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
    public class CategoriasController : Controller
    {
        private readonly ICategoriaRepository _ctRepo;

        public CategoriasController (ICategoriaRepository ctRepo)

        {
            _ctRepo = ctRepo;

        }
        [HttpGet]
        
        public IActionResult GetCategoria()
        {
            var ListaCategorias = _ctRepo.GetCategorias();
            return Ok(ListaCategorias);
        }
    }
}
