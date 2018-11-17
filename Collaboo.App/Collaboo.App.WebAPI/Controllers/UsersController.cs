using Collaboo.App.WebAPI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Octokit;
using Octokit.Internal;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<UserDTO>> GetUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var login = User.FindFirst(c => c.Type == "urn:github:login")?.Value;

                var user = new UserDTO();

                string accessToken = await HttpContext.GetTokenAsync("access_token");
                var github = new GitHubClient(new ProductHeaderValue("AspNetCoreGitHubAuth"), new InMemoryCredentialStore(new Credentials(accessToken)));

                var gitUser = await github.User.Get(login);

                user.AvatarUrl = gitUser.AvatarUrl;
                user.Id = gitUser.Id;
                user.Name = gitUser.Name;

                return user;
            }
            else
            {
                return BadRequest("Authentication Exception");
            }
        }

        [HttpGet("{login}")]
        public async Task<ActionResult<UserDTO>> GetUser(string login)
        {
            var user = new UserDTO();
            var github = new GitHubClient(new ProductHeaderValue("AspNetCoreGitHubAuth"));
            var gitUser = await github.User.Get(login);

            user.AvatarUrl = gitUser.AvatarUrl;
            user.Id = gitUser.Id;
            user.Name = gitUser.Name;

            return user;
        }
    }
}

