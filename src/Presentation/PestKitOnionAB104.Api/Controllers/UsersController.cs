using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PestKitOnionAB104.Application.Abstractions.Services;
using PestKitOnionAB104.Application.DTOs.Users;

namespace PestKitOnionAB104.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAuthenticationService _service;

        public UsersController(IAuthenticationService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegisterDto dto)
        {
            await _service.Register(dto);
            return NoContent();
        }
    }
}
