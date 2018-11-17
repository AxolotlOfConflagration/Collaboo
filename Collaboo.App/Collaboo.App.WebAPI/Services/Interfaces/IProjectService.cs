using System.Collections.Generic;
using System.Threading.Tasks;
using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Models;

namespace Collaboo.App.WebAPI.Services.Interfaces
{
    public interface IProjectService
    {
         Task CreateProjectAsync(Project projectToAdd);
         Task<Project> GetProjectAsync(int projectId);
         IEnumerable<Project> GetUserProjects(int userId, bool onlyOwner = false);
         Task UpdateProjectAsync(UpdateProjectDTO projectToUpdate, int projectId);
    }
}