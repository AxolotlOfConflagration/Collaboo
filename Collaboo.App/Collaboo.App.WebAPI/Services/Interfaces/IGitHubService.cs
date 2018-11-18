using System.Collections.Generic;
using System.Threading.Tasks;
using Octokit;

namespace Collaboo.App.WebAPI.Services.Interfaces
{
    public interface IGitHubService
    {
        Task<IEnumerable<string>> GetCommitsForRepo(int projectId);
    }
}