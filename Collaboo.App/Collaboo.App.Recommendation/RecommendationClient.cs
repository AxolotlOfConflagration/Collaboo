using Collaboo.App.Recommendation.Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Collaboo.App.Recommendation
{
    public class RecommendationClient
    {
        private readonly Uri _recomendationServerUri = new Uri(@"https://gentle-bastion-31804.herokuapp.com");
        private readonly Dictionary<string, string> _endpoints;

        public string MostPopularLanguagesEndpoint { get; } = "mpl";
        public string ProjectPerUserEndpoint { get; } = "ppu";
        public string ProjcetsForUserEndpoint { get; } = "pfu";
        public string UserForProjcetsEndpoint { get; } = "ufp";

        public RecommendationClient()
        {
            _endpoints = new Dictionary<string, string>
            {
                {MostPopularLanguagesEndpoint, "mpl" },
                {ProjectPerUserEndpoint, "ppu/{0}" },
                {ProjcetsForUserEndpoint, "usp/u/{0}" },
                {UserForProjcetsEndpoint, "usp/p/{0}" }
            };
        }

        private string GetEndpoint(string endpointName, params object[] args)
        {
            return string.Format($"{_recomendationServerUri}/{_endpoints[endpointName]}", args);
        }

        public async void MostPopularLanguages()
        {
            var request = GetEndpoint(MostPopularLanguagesEndpoint);
            var result = await HttpRequestFactory.Get(request);

            var content = await result.Content.ReadAsStringAsync();

            var json = JArray.Parse(content);
        }
    }
}