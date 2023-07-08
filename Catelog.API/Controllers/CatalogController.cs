using Catelog.API.Contracts;
using Catelog.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catelog.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogService _catalogService;

        public CatalogController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           return Ok(await _catalogService.GetAllAsync());

        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _catalogService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            return Ok(await _catalogService.CreateAsync(product));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            return Ok(await _catalogService.UpdateAsync(product));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok(await _catalogService.DeleteAsync(id));
        }
    }
}