using System.Collections.Generic;
using Collaboo.App.WebAPI.DbContexts;
using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System;
using Collaboo.App.WebAPI.Models;
using System.Collections;

namespace Collaboo.App.WebAPI.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ApplicationDbContext _context;

        public ProjectService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateProjectAsync(Project projectToAdd)
        {
            _context.Projects.Add(projectToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<Project> GetProjectAsync(int projectId)
        {
            var project = await _context.Projects
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
            IQueryable<Project> projectForUser = _context.Projects
                .Include(p => p.Requirements)
                .Include(p => p.ProjectMembers);
            
            if(onlyOwner)
            {
                return projectForUser.Where(p => p.OwnerId == userId); 
            }

            return projectForUser
                .Where(p => p.OwnerId == userId || p.ProjectMembers.Any(pm => pm.UserId == userId));
        }

        public async Task UpdateProjectAsync(UpdateProjectDTO projectToUpdate, int projectId)
        {
            var project = await GetProjectAsync(projectId);
            UpdateProject(project, projectToUpdate);
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
        }

        public void UpdateProject(Project project, UpdateProjectDTO projectToUpdate)
        {
            if(!String.IsNullOrEmpty(projectToUpdate.Description))
            {
                project.Description = projectToUpdate.Description;
            }

            if(!String.IsNullOrEmpty(projectToUpdate.ProjectName))
            {
                project.ProjectName = projectToUpdate.ProjectName;
            }
            
            if(!String.IsNullOrEmpty(projectToUpdate.GitHubRepoUrl))
            {
                project.GitHubRepoUrl = projectToUpdate.GitHubRepoUrl;
            }
        }

        public async Task AddUserToProject(int projectId, int userId)
        {
            try
            {
                var project = await GetProjectAsync(projectId);
                var user = _context.Users.FirstOrDefaultAsync(u => u.Id == userId);

                if(user == null)
                {
                    throw new Exception("User doesn't exception");
                }

                project.ProjectMembers.Add(new ProjectMember 
                {
                    ProjectId = project.Id,
                    UserId = user.Id
                });

                await _context.SaveChangesAsync();
            } 
            catch (Exception)
            {
               throw; 
            }
        }

        public async Task<IEnumerable<User>> GetUsersFromProjectAsync(int projectId)
        {
            try
            {
                var project = await GetProjectAsync(projectId);
                var users = _context.ProjectMember
                    .Include(p => p.User)
                    .Where(p => p.ProjectId == projectId)
                    .Select(p => p.User)
                    .AsEnumerable();
                
                return users;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}