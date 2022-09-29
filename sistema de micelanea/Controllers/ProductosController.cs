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
    public class ProductosController : Controller
    {
        private readonly IProductoRepository _ctRepo;

        public ProductosController (IProductoRepository ctRepo)

        {
            _ctRepo = ctRepo;

        }
        [HttpGet]
        [Route("Obtener")]

        public IActionResult GetProducto()
        {
            var ListaProductos = _ctRepo.GetProductos();
            return Ok(ListaProductos);
        }
    }
}
