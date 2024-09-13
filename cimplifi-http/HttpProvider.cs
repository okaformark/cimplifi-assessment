using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimplifi_http
{
    public class HttpProvider : IHttpProvider
    {
        private readonly HttpClient _httpClient;
        public HttpProvider(HttpClient httpClient) => _httpClient = httpClient;


        public async Task<string> FetchData(string url)
        {
            return await _httpClient.GetStringAsync(url);
        }
    }
}
