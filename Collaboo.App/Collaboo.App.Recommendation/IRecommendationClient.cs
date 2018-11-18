using System.Collections.Generic;
using System.Threading.Tasks;

namespace Collaboo.App.Recommendation
{
    public interface IRecommendationClient
    {
        Task<IEnumerable<dynamic>> MostPopularLanguages();
        Task<int[]> TopPojectsForUser(int id);
        Task<int[]> RecomendedUsersForProject(int id);
        Task<int[]> RecomendedProjectsForUser(int id);
    }
}