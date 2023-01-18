using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class RaportGenerator
    {
        public void GenerateReport(IEnumerable<string> qualityErrors, 
            IEnumerable<string> securityErrors,
            IEnumerable<string> dependencyErrors)
        {
            Console.WriteLine("Quality Scan Errors:");
            Console.WriteLine(String.Join(", ", qualityErrors));
            Console.WriteLine("Security Scan Errors:");
            Console.WriteLine(String.Join(", ", securityErrors));
            Console.WriteLine("Dependency Scan Errors:");
            Console.WriteLine(String.Join(", ", dependencyErrors));
        }
    }
}
