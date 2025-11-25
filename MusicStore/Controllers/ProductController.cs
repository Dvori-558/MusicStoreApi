using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Dto;
using MusicStore.Models;
using MusicStore.Servieses;

namespace MusicStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //get
        public readonly ProductService _ProductService = new();
        [HttpGet]
        [Route("ProductOrderByTitle")]
        public IActionResult GetByCategory()
        {
            return Ok(_ProductService.ProductOrderByTitle());
        }

        [HttpGet]
        [Route("ProductWithCategory")]
        public IActionResult ProductWithCategory()
        {
            return Ok(_ProductService.ProductWithCategory());
        }

        //post
        [HttpPost]
        public IActionResult Post([FromBody] List<CreateProductDto> products)
        {
            _ProductService.AddRange(products);
            return Ok("success");
        }

        //put
        [HttpPut]
        [Route("delete")]
        public IActionResult Delete(int id)
        {
            return Ok(_ProductService.DeleteProduct(id));
        }
        //delete
    }
}

