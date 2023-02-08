using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsuarioAPI.DTO;

namespace UsuarioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        public IActionResult CadastrarUsuario(CreateUsuarioDTO createUsuarioDTO) 
        {

            return Ok();
        }
    }
}
