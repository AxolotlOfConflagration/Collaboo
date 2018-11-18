using Collaboo.App.Recommendation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Controllers
{
    [Route("api/recommendation")]
    public class RecommendationController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> MostPopularLanguages()
        {
            var clinet = new RecommendationClient();
            return Ok(await clinet.MostPopularLanguages());
        }
    }
}
