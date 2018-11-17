using Collaboo.App.WebAPI.DbContexts;
using Collaboo.App.WebAPI.Models;
using Collaboo.App.WebAPI.Services.Interfaces;
using Octokit;
using Octokit.Internal;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Services
{
    public class UsersServices : IUsersServices
    {
        private readonly ISkillsServices _skillsServices;
        private readonly ApplicationDbContext _context;

        public async Task<UserDTO> GetAuthUserAsync(string login, Credentials gitCredentials)
        {
            var github = new GitHubClient(
                new ProductHeaderValue("AspNetCoreGitHubAuth"),
                new InMemoryCredentialStore(gitCredentials));
            var gitUser = await github.User.Get(login);
            var gitSkills = _skillsServices.GetSkillsForUser(gitUser.Id);
            var skills =

            var user = new UserDTO
            {
                AvatarUrl = gitUser.AvatarUrl,
                Id = gitUser.Id,
                Name = gitUser.Name,
                Skills = gitSkills
            };

            return user;
        }

        public async Task<UserDTO> GetUserAsync(string login)
        {
            var github = new GitHubClient(new ProductHeaderValue("AspNetCoreGitHubAuth"));
            var gitUser = await github.User.Get(login);
            var gitSkills = _skillsServices.GetSkillsForUser(gitUser.Id);

            var user = new UserDTO
            {
                AvatarUrl = gitUser.AvatarUrl,
                Id = gitUser.Id,
                Name = gitUser.Name,
                Skills = gitSkills
            };

            return user;
        }
    }
}
