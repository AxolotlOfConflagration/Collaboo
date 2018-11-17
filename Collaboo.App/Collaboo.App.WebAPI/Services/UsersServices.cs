using AutoMapper;
using Collaboo.App.WebAPI.DbContexts;
using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Models;
using Collaboo.App.WebAPI.Services.Interfaces;
using Octokit;
using Octokit.Internal;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Collaboo.App.WebAPI.Services
{
    public class UsersServices : IUsersServices
    {
        private readonly ISkillsServices _skillsServices;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UsersServices(ISkillsServices skillsServices, ApplicationDbContext context, IMapper mapper)
        {
            _skillsServices = skillsServices;
            _context = context;
            _mapper = mapper;
        }

        public async Task AddUserAsync(Entities.User user)
        {
            var dbUser = _context.Users.FirstOrDefault(u => u.GitHubId == user.GitHubId);
            if(dbUser == null)
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AddUserSkillAsync(AddUserSkillDTO userSkill, int userId)
        {
            await _skillsServices.AddSkillForUser(userSkill, userId);
        }

        public async Task<UserDTO> GetAuthUserAsync(string login, Credentials gitCredentials)
        {
            //var github = new GitHubClient(
            //    new ProductHeaderValue("AspNetCoreGitHubAuth"),
            //    new InMemoryCredentialStore(gitCredentials));

            var dbUser = await _context.Users
                .Include(u => u.UserSkills)
                .ThenInclude(us => us.Skill)
                .FirstOrDefaultAsync(u => u.Login == login);

            //var gitUser = await github.User.Get(login);
            //var gitSkills = _skillsServices.GetSkillsForUser(gitUser.Id);
            //var skills = Mapper.Map<IEnumerable<UserSkillDTO>>(gitSkills);

            var user = _mapper.Map<UserDTO>(dbUser);

            return user;
        }

        public async Task<UserDTO> GetUserAsync(string login)
        {
            var github = new GitHubClient(new ProductHeaderValue("AspNetCoreGitHubAuth"));
            var gitUser = await github.User.Get(login);
            var gitSkills = _skillsServices.GetSkillsForUser(gitUser.Id);
            var skills = _mapper.Map<IEnumerable<UserSkillDTO>>(gitSkills);

            var user = new UserDTO
            {
                AvatarUrl = gitUser.AvatarUrl,
                Id = gitUser.Id,
                Login = gitUser.Name,
                Skills = skills
            };

            return user;
        }
    }
}
