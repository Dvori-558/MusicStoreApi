using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Dto;
using MusicStore.Models;
using MusicStore.Servieses;

namespace MusicStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly UserService _userService = new();
        //get
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.GetUsers());
        }
        //post
        [HttpPost]
        public IActionResult CreateUser(CreateUserDto user)
        {
            return Ok(_userService.CreateUser(user));
        }
        //put
        //delete

    }
}
