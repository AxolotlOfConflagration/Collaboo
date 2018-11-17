using System.Collections.Generic;
using System.Threading.Tasks;
using Collaboo.App.WebAPI.Entities;

namespace Collaboo.App.WebAPI.Services.Interfaces
{
    public interface IProjectService
    {
         void CreateProject();
         Task<Project> GetProject(int projectId);
         IEnumerable<Project> GetUserProjects(int userId, bool onlyOwner = false);
    }
}