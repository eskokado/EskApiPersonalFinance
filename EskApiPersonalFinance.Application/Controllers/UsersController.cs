using EskApiPersonalFinance.Domain.Interfaces.Services;
using EskApiPersonalFinance.Domain.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EskApiPersonalFinance.Application.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var users = _userService.GetAll();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Register([FromBody] RegisterViewModelInput registerViewModelInput)
        {
            try
            {
                var user = _userService.Add(registerViewModelInput);
                return Created($"/api/v1/users/{user?.UserId}", user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] RegisterViewModelInput registerViewModelInput)
        {
            try
            {
                var user = _userService.Update(id, registerViewModelInput);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            try
            {
                var user = _userService.GetById(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remove([FromRoute] int id)
        {
            try
            {
                _userService.Remove(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("email")]
        public IActionResult FindByEmail([FromQuery] string email)
        {
            try
            {
                var user = _userService.FindByEmail(email);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("name")]
        public IActionResult FindByName([FromQuery] string name)
        {
            try
            {
                var users = _userService.FindByName(name);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("username")]
        public IActionResult FindByUsername([FromQuery] string username)
        {
            try
            {
                var user = _userService.FindByUsername(username);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
