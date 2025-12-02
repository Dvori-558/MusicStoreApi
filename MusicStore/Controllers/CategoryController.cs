using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MusicStore.IRepositories;
using MusicStore.IServieces;
using MusicStore.Repositories;
using MusicStore.Servieses;

namespace MusicStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController:ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService categoryService)
        {
            _service=categoryService;
        }
        //get

        [HttpGet]
        [Route("ProductByCategory")]
        public IActionResult GetByCategory()
        {
            return Ok(_service.ProductByCategory());
        }
        //post
        //put
        //delete
    }
}
