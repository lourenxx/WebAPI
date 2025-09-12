using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Api.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly Data.UsuariosDbContext _context;

        public UsuarioController(Data.UsuariosDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            var usuarios = _context.Usuarios.ToList();
            return Ok(usuarios);
        }
    }
}
