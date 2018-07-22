using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NA.Kinjo.DataAccess.Interfaces;
using NA.Kinjo.Entities;
using NA.Kinjo.Entities.ViewModel;
using System;
using System.Threading.Tasks;

namespace NA.Kinjo.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Company")]
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _appCompanyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _appCompanyRepository = companyRepository;
        }

        [HttpPost("[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody]AddCompany company)
        {
            try
            {
                if (company == null)
                {
                    return BadRequest();
                }

                var newCompany = new AddCompany
                {
                };

                var result = await _appCompanyRepository.CreateCompany(company);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = ex.ToString();
                return StatusCode(500);
            }

        }

        [HttpGet("[action]/{email}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetCompanyByEmail(string email)
        {
            try
            {
                if (email == null)
                {
                    return BadRequest();
                }

                var result = await _appCompanyRepository.GetCompanyByEmail(email);
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = ex.ToString();
                return StatusCode(500);
            }
        }


        [HttpPost("[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateCompany([FromBody]Company company)
        {
            try
            {
                if (company == null)
                {
                    return BadRequest();
                }

                var result = await _appCompanyRepository.UpdateCompany(company);
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