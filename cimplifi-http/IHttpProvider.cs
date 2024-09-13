using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimplifi_http
{
    public interface IHttpProvider
    {
        Task<string> FetchData(string url);
    }
}
