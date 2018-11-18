using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Collaboo.App.WebAPI.DbContexts;
using Collaboo.App.WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Octokit;

namespace Collaboo.App.WebAPI.Services
{
    public class GitHubService : IGitHubService
    {
        private readonly ApplicationDbContext _context;
        public GitHubService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<string>> GetCommitsForRepo(int projectId)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(p => p.Id == projectId);

            if(project == null)
            {
                throw new Exception("Project doesn't exist.");
            }

            if(String.IsNullOrEmpty(project.GitHubRepoUrl))
            {
                throw new Exception("No GitHubUrl");
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == project.OwnerId);
            
            if(user == null)
            {
                throw new Exception();
            }

            var gitHubRepoName = project.GitHubRepoUrl.Split('/').Last();

            var github = new GitHubClient(new ProductHeaderValue("githubapp"));
            
            var commits = await github.Repository.Commit.GetAll(user.Login, gitHubRepoName);
            return commits.Select(c => c.Commit.Message).Take(10);
        }
    }
}