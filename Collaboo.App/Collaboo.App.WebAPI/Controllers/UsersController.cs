using Collaboo.App.WebAPI.Models;
using Collaboo.App.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Octokit;
using Octokit.Internal;
using System;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly IUsersServices _usersServices;

        public UsersController(IUsersServices usersServices)
        {
            _usersServices = usersServices;
        }

        [HttpGet]
        public async Task<ActionResult<UserDTO>> GetUser()
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    var login = User.FindFirst(c => c.Type == "urn:github:login")?.Value;
                    var credentials = new Credentials(await HttpContext.GetTokenAsync("access_token"));

                    return await _usersServices.GetAuthUserAsync(login, credentials);
                }
                else
                {
                    return BadRequest("Authentication Exception");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{login}")]
        public async Task<ActionResult<UserDTO>> GetUser(string login)
        {
            try
            {
                return await _usersServices.GetUserAsync(login);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

