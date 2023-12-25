using Microsoft.AspNetCore.Mvc;
using PestKitOnionAB104.Application.Abstractions.Services;

namespace PestKitOnionAB104.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeesController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int take = 3)
        {
            return Ok(await _service.GetAllPaginatedAsync(page, take));
        }
        [HttpGet("id")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }
        //[HttpPost]
        //public async Task<IActionResult> Create([FromForm] EmployeeCreateDto employeeCreateDto)
        //{
        //    await _service.CreateAsync(employeeCreateDto);
        //    return StatusCode(StatusCodes.Status201Created);
        //}
    }
}
