using System.Net.Http;
using System.Threading.Tasks;

namespace Collaboo.App.Recommendation.Helpers
{
    public class HttpRequestFactory
    {
        public static async Task<HttpResponseMessage> Get(string requestUri, string acceptHeader = "application/json")
        {
          var builder = new HttpRequestBuilder().AddMethod(HttpMethod.Get).AddAcceptHeader(acceptHeader).AddRequestUri(requestUri);
          return await  builder.SendAsync();
        }
}
}