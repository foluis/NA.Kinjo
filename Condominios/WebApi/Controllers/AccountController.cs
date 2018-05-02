using DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace WebApi.Controllers
{   
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        private readonly IAppUserRepository _appUserRepository;

        public AccountController(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }        

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAppUser(string email)
        {
            try
            {
                if (email == null)
                    return BadRequest("Invalid E-Mail");

                var usersList = await _appUserRepository.GetAppUsersByEmail(email);
                if (usersList == null)
                    return NotFound();

                return Ok(usersList);
            }
            catch (Exception e)
            {
                //_logger.LogError(e.ToString());
                return StatusCode(500);
            }
        }
    }
}