using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.HTTP
{
    public class HttpClientOptions
    {
        public string Type { get; set; }
        public int Retries { get; set; }
        public IDictionary<string, string> Services { get; set; }
    }
}
