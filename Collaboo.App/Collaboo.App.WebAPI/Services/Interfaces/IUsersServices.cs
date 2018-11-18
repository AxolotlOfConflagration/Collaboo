using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Models;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Services.Interfaces
{
    public interface IUsersServices
    {
        Task<UserDTO> GetAuthUserAsync(string login, Credentials gitCredentials);
        Task<UserDTO> GetUserAsync(string login);
        Task<UserDTO> GetUserAsync(int id);
        Task AddUserSkillAsync(AddUserSkillDTO userSkill, int userId);
        Task<int> AddUserAsync(Entities.User user);
    }
}
