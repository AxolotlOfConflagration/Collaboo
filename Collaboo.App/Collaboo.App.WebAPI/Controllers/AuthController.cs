using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Collaboo.App.WebAPI.Controllers
{
    [Route("api/login")]
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login(string returnUrl = "/")
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
        }
    }
}