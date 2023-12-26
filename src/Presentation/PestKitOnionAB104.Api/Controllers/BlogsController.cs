using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PestKitOnionAB104.Application.Abstractions.Services;
using PestKitOnionAB104.Application.DTOs.Author;
using PestKitOnionAB104.Application.DTOs.Blogs;

namespace PestKitOnionAB104.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _service;

        public BlogsController(IBlogService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int take = 3)
        {
            return Ok(await _service.GetAllAsync(page, take));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0) return StatusCode(StatusCodes.Status400BadRequest);

            return StatusCode(StatusCodes.Status200OK, await _service.GetAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] BlogCreateDto blogCreateDto)
        {
            await _service.CreateAsync(blogCreateDto);

            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] BlogUpdateDto blogUpdateDto)
        {
            if (id <= 0) return StatusCode(StatusCodes.Status400BadRequest);
            await _service.UpdateAsync(id, blogUpdateDto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return StatusCode(StatusCodes.Status400BadRequest);
            await _service.SoftDeleteAsync(id);
            return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}
