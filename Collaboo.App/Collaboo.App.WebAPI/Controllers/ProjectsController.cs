using System.Threading.Tasks;
using AutoMapper;
using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Models;
using Collaboo.App.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Collaboo.App.WebAPI.Controllers
{
    [Route("")]
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
            var project = await _projectService.GetProjectAsync(projectId);
            var projectDto = _mapper.Map<Project, ProjectDTO>(project);
            return Ok(projectDto);
        }

        [HttpGet("api/users/{userId}/projects")]
        public IActionResult GetProjectsFroUser(int userId, [FromQuery] bool onlyOwner = false)
        {
            var projects = _projectService.GetUserProjects(userId, onlyOwner);

            return Ok(projects);
        }

        [HttpPost("api/users/{userId}/projects")]
        public async Task<IActionResult> AddProject([FromRoute] int userId, [FromBody] AddProjectDTO projectToAdd)
        {
            var project = _mapper.Map<AddProjectDTO, Project>(projectToAdd);
            project.OwnerId = userId;
            await _projectService.CreateProjectAsync(project);
            return NoContent();
        }
    }
}