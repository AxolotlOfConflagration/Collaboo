using System.Collections.Generic;
using System.Threading.Tasks;
using Collaboo.App.Recommendation;
using Collaboo.App.WebAPI.DbContexts;
using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Collaboo.App.WebAPI.Controllers
{
    public class FeedController : Controller
    {
        private readonly IRecommendationClient _recommendationClient;
        private readonly IGitHubService _gitHubService;
        private readonly ApplicationDbContext _context;
        private readonly IProjectService _projectService;

        public FeedController(IRecommendationClient recommendationClient, IGitHubService gitHubService, ApplicationDbContext context, IProjectService projectService)
        {
            _recommendationClient = recommendationClient;
            _gitHubService = gitHubService;
            _context = context;
            _projectService = projectService;
        }

        [HttpGet("api/feed")]
        public async Task<IActionResult> GetFeed(int userId)
        {
            var recommendations = await _recommendationClient.RecomendedProjectsForUser(userId);

            IList<Project> projects = new List<Project>();
            foreach (var recommendationId in recommendations)
            {
                var project = await _projectService.GetProjectAsync(recommendationId);
                projects.Add(project);
            }

            return Ok(recommendations);
        }
    }
}