using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class SecuritScanner
    {
        public IEnumerable<string> ScurityScan(string githubUrl)
        {
            Console.WriteLine("Security scan");

            return new List<string>() { "Security Error1" };
        }
    }
}
