using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Collaboo.App.WebAPI.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet("api/login")]
        public IActionResult Login(string returnUrl = "/api/register")
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
        }

        [HttpGet("api/register")]
        public IActionResult RegisterUser()
        {
            return NoContent();
        }
    }
}