using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NA.Kinjo.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Account")]
    public class AuthController : ControllerBase
    {
        [HttpPost("[action]")]
        [AllowAnonymous]
        public string GetValues()
        {
            return "Resource";
        }
        //Get Anonymous Resource
        //Get Authorized Resource
        //Log in (authenticate)
        //Get Authorized Resource Rol Admin
        //Get Authorized Resource Rol Supervisor
    }
}