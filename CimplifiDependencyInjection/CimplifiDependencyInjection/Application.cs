using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimplifiDependencyInjection
{
    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger logger)
        {
           _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log(message);
        }

      
    }
}
