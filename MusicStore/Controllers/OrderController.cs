using Microsoft.AspNetCore.Mvc;
using MusicStore.Servieses;

namespace MusicStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private readonly OrderService _orderService = new();

        //get
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orderService.OrderList()); 
        }
        //post
        //put
        //delete
    }
}
