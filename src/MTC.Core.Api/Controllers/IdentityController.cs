using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MTC.Model.DTOs;
using MTC.Model.Identity;

namespace MTC.Core.Api.Controllers
{
    [ApiController]
    [Route("identity")]
    public class IdentityController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public IdentityController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult>Create(ApplicationUserRegisterDto model)
        {
           var result = await _userManager.CreateAsync(new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Email
            }, model.Password);

           if (!result.Succeeded)
           {
               throw new Exception("No se pudo crear el usuario.");
           }

           return Ok();
        }
    }
}
