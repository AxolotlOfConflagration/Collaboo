using Collaboo.App.Recommendation.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Collaboo.App.Recommendation
{
    public class RecommendationClient : IRecommendationClient
    {
        private readonly Uri _recomendationServerUri = new Uri(@"https://gentle-bastion-31804.herokuapp.com");
        private readonly Dictionary<string, string> _endpoints;

        public string MostPopularLanguagesEndpoint { get; } = "mpl";
        public string ProjectPerUserEndpoint { get; } = "ppu";
        public string ProjectsForUserEndpoint { get; } = "pfu";
        public string UserForProjcetsEndpoint { get; } = "ufp";

        public RecommendationClient()
        {
            _endpoints = new Dictionary<string, string>
            {
                {MostPopularLanguagesEndpoint, "mpl" },
                {ProjectPerUserEndpoint, "ppu/{0}" },
                {ProjectsForUserEndpoint, "usp/u/{0}" },
                {UserForProjcetsEndpoint, "usp/p/{0}" }
            };
        }

        private string GetEndpoint(string endpointName, params object[] args)
        {
            return string.Format($"{_recomendationServerUri}{_endpoints[endpointName]}", args);
        }

        public async Task<IEnumerable<dynamic>> MostPopularLanguages()
        {
            var request = GetEndpoint(MostPopularLanguagesEndpoint);
            var result = await HttpRequestFactory.Get(request);

            var content = await result.Content.ReadAsStringAsync();

            return JArray.Parse(content).ToObject<IEnumerable<dynamic>>();
        }

        public async Task<int[]> TopPojectsForUser(int id)
        {
            var request = GetEndpoint(ProjectPerUserEndpoint, id);
            var result = await HttpRequestFactory.Get(request);

            var content = await result.Content.ReadAsStringAsync();

            return JObject.Parse(content).ToObject<int[]>();
        }

        public async Task<int[]> RecomendedUsersForProject(int id)
        {
            var request = GetEndpoint(UserForProjcetsEndpoint, id);
            var result = await HttpRequestFactory.Get(request);

            var content = await result.Content.ReadAsStringAsync();

            return JObject.Parse(content).ToObject<int[]>();
        }

        public async Task<int[]> RecomendedProjectsForUser(int id)
        {
            var request = GetEndpoint(ProjectsForUserEndpoint, id);
            var result = await HttpRequestFactory.Get(request);

            var content = await result.Content.ReadAsStringAsync();

            return JObject.Parse(content).ToObject<int[]>();
        }
    }
}