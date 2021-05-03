using EskApiPersonalFinance.Domain.Interfaces.Services;
using EskApiPersonalFinance.Domain.ViewModels.Accounts;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EskApiPersonalFinance.Application.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var accounts = _accountService.GetAll();
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] AccountViewModelInput accountViewModelInput)
        {
            try
            {
                var account = _accountService.Add(accountViewModelInput);
                return Created($"/api/v1/accounts/{account?.AccountId}", account);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("user/{userId}")]
        public IActionResult FindByUserId([FromRoute] int userId)
        {
            try
            {
                var accounts = _accountService.FindByUserId(userId);
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("user/{userId}/agencia/{agency}/number/{number}")]
        public IActionResult FindByUserIdAndAgencyAndNumber(
            [FromRoute] int userId, [FromRoute] string agency, [FromRoute] string number)
        {
            try
            {
                var account = _accountService.FindByUserIdAndAgencyAndNumber(userId, agency, number);
                return Ok(account);
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
                var account = _accountService.GetById(id);
                return Ok(account);
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
                _accountService.Remove(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] AccountViewModelInput accountViewModelInput) 
        {
            try
            {
                var account = _accountService.Update(id, accountViewModelInput);
                return Ok(account);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
