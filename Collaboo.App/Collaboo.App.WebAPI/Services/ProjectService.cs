using System.Collections.Generic;
using Collaboo.App.WebAPI.DbContexts;
using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Collaboo.App.WebAPI.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ApplicationDbContext _conext;

        public ProjectService(ApplicationDbContext conext)
        {
            _conext = conext;
        }

        public void CreateProject()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Project> GetProject(int projectId)
        {
            var project = await _conext.Projects
                .Include(p => p.ProjectMembers)
                .Include(p => p.Requirements) 
                .FirstOrDefaultAsync(p => p.Id == projectId);
            
            if (project == null)
            {
                throw new Exception("Project doesnt't exist.");
            }
            return project;
        }

        public IEnumerable<Project> GetUserProjects(int userId, bool onlyOwner = false)
        {
            IQueryable<Project> projectForUser = _conext.Projects
                .Include(p => p.Requirements)
                .Include(p => p.ProjectMembers);
            
            if(onlyOwner)
            {
                return projectForUser.Where(p => p.OwnerId == userId); 
            }

            return projectForUser
                .Where(p => p.OwnerId == userId || p.ProjectMembers.Any(pm => pm.UserId == userId));
        }
    }
}