using System.Threading.Tasks;
using AutoMapper;
using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Models;
using Collaboo.App.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Collaboo.App.WebAPI.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;

        public ProjectsController(IProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

        [HttpGet("api/projects/{projectId}")]
        public async Task<IActionResult> GetProject(int projectId)
        {
            var project = await _projectService.GetProject(projectId);
            var projectDto = _mapper.Map<Project, ProjectDTO>(project);
            return Ok(projectDto);
        }

        [HttpGet("api/users/{userId}/projects")]
        public IActionResult GetProjectsFroUser(int userId, [FromQuery] bool onlyOwner = false)
        {
            var projects = _projectService.GetUserProjects(userId, onlyOwner);

            return Ok(projects);
        }
    }
}