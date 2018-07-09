using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NA.Kinjo.DataAccess.Interfaces;
using NA.Kinjo.Entities;

namespace NA.Kinjo.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/AppUser")]
    public class AppUserController : Controller
    {
        private readonly IAppUserRepository  _appUserRepository ;

        public AppUserController(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        [HttpPost("[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody]NewAppUser user)
        {
            try
            {
                var appUser = new AppUser
                {
                    Username = user.Email,
                    Email = user.Email,
                    Password = user.Password
                };

                var result = await _appUserRepository.CreateAppUsers(appUser);
                return Ok(result);
            }
            catch (Exception ex)
            {
				var error = ex.ToString();
                return StatusCode(500);
            }
            
        }
    }
}