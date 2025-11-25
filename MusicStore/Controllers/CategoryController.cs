using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Repositories;
using MusicStore.Servieses;

namespace MusicStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController:ControllerBase
    {
        //get
        public readonly CategoryService _categoryService = new();
        [HttpGet]
        [Route("ProductByCategory")]
        public IActionResult GetByCategory()
        {
            return Ok(_categoryService.ProductByCategory());
        }
        //post
        //put
        //delete

    }
}
