using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewBackend.Application.IService;
using NewBackend.Domain.Entity;

namespace NewBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;

        }

        [HttpGet("GetDetails")]
        public async Task<IActionResult> GetDetails()
        {
            return Ok(await _userService.GetDetails());
        }

        [HttpPost("AddUser")]
         public async Task<IActionResult> CreateSignup(UserModel userModel)
        {
            return Ok(await _userService.CreateSignup(userModel));
        }


        }

    } 
