using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimplifi_http
{
    public class FetchData
    {
       
        private readonly IHttpProvider _provider;

        public FetchData(IHttpProvider provider) => _provider = provider;

        public async Task<string[]> FetchDataConcurrently(string url1, string url2)
        {
            
            Task<string> fetchUrl1Task = _provider.FetchData(url1);
            Task<string> fetchUrl2Task = _provider.FetchData(url2);

            string[] results = await Task.WhenAll(fetchUrl1Task, fetchUrl2Task);

            return results;
           
        }

    }
}
