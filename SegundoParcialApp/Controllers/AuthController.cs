using Microsoft.AspNetCore.Mvc;
using SegundoParcialApp.Services;
using SegundoParcialApp.DTOs;

namespace SegundoParcialApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        // POST api/auth/login
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserDTO userDTO)
        {
            // Aquí deberías validar las credenciales del usuario (por ejemplo, con la base de datos)
            // Por simplicidad, asumimos que las credenciales son correctas
            var token = _authService.GenerateJwtToken(userDTO.Username);
            return Ok(new { Token = token });
        }
    }
}