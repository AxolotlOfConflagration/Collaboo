using Microsoft.AspNetCore.Mvc;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Controllers
{
    [Route("api/github")]
    public class GitHubInfoController : Controller
    {
        [HttpGet("{login}/{repo}")]
        public async Task<IActionResult> GetCommitsForRepo(string login = "BartMiki", string repo = "GraphWidth")
        {
            var github = new GitHubClient(new ProductHeaderValue("githubapp"));
            var commits = await github.Repository.Commit.GetAll(login, repo);
            return Ok();
        }
    }
}
