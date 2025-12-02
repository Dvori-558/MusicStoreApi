using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Dto;
using MusicStore.IServieces;
using MusicStore.Models;
using MusicStore.Servieses;

namespace MusicStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _service;
        public UserController(IUserService userService)
        {
            _service=userService;
        }
        //get
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetUsers());
        }
        //post
        [HttpPost]
        public IActionResult CreateUser(CreateUserDto user)
        {
            return Ok(_service.CreateUser(user));
        }
        //put
        //delete

    }
}
