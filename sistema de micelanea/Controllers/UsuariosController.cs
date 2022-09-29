using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sistema_de_micelanea.IRepository;
using sistema_de_micelanea.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _ctRepo;

        public UsuariosController (IUsuarioRepository ctRepo)

        {
            _ctRepo = ctRepo;

        }
        [HttpGet]
        
        public IActionResult GetUsuario()
        {
            var ListaUsuarios = _ctRepo.GetUsuarios ();
            return Ok(ListaUsuarios);
        }
    }
}
