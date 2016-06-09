using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RandomUser.Core.Interfaces.Service;
using RandomUser.Core.Utils;

namespace RandomUser.Core.Service
{
    public class HttpClientService : IHttpClientService
    {
        public async Task<HttpClientServiceResponse<string>> GetStringAsync(Uri uri, CancellationToken c)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri, c);
                var content = await response.Content.ReadAsStringAsync();

                return new HttpClientServiceResponse<string> { Content = content };
            }
        }
    }
}