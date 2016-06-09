using System;
using System.Threading;
using System.Threading.Tasks;
using RandomUser.Core.Utils;

namespace RandomUser.Core.Interfaces.Service
{
    public interface IHttpClientService
    {
        Task<HttpClientServiceResponse<string>> GetStringAsync(Uri uri, CancellationToken c);
    }
}