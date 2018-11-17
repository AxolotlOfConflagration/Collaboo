using Collaboo.App.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Octokit;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUsersServices _usersServices;

        public AuthController(IUsersServices usersServices)
        {
            _usersServices = usersServices;
        }

        [HttpGet("api/login")]
        public IActionResult Login(string returnUrl = "/api/register")
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
        }

        [HttpGet("api/register")]
        public async Task<IActionResult> RegisterUser()
        {
            var login = User.FindFirst(c => c.Type == "urn:github:login")?.Value;
            var credentials = new Credentials(await HttpContext.GetTokenAsync("access_token"));

            var github = new GitHubClient(new ProductHeaderValue("AspNetCoreGitHubAuth"));
            var gitUser = await github.User.Get(login);

            var user = new Entities.User
            {
                GitHubId = gitUser.Id,
                Login = gitUser.Login,
            };

            await _usersServices.AddUserAsync(user);
            return NoContent();
        }
    }
}