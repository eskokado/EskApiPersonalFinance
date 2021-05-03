using EskApiPersonalFinance.Domain.Interfaces.Services;
using EskApiPersonalFinance.Domain.ViewModels.Launches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EskApiPersonalFinance.Application.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LaunchersController : ControllerBase
    {
        private readonly ILaunchService _launchService;

        public LaunchersController(ILaunchService launchService)
        {
            _launchService = launchService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] LaunchViewModelInput launchViewModelInput)
        {
            try
            {
                _launchService.Add(launchViewModelInput);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("account/{accountId}/year/{year}/month/{month}")]
        public IActionResult FindByAccountIdAndYearAndMonth(
            [FromRoute] int accountId, [FromRoute] int year, [FromRoute] int month)
        {
            try
            {
                var lanchers = _launchService.FindByAccountIdAndYearAndMonth(accountId, year, month);
                return Ok(lanchers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var launchers = _launchService.GetAll();
                return Ok(launchers);
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
                var launch = _launchService.GetById(id);
                return Ok(launch);
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
                _launchService.Remove(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] LaunchViewModelInput launchViewModelInput)
        {
            try
            {
                var launch = _launchService.Update(id, launchViewModelInput);
                return Ok(launch);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
