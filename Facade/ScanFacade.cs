using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ScanFacade
    {
        private QualityScanner qualityScanner = new QualityScanner();
        private SecuritScanner securitScanner = new SecuritScanner();
        private DependecnyScanner dependecnyScanner = new DependecnyScanner();
        private RaportGenerator raportGenerator = new RaportGenerator();
        public void Scan(string githubUrl)
        {
            Console.WriteLine("Scanning " + githubUrl);
            var qualityScanErrors = qualityScanner.QualityScan(githubUrl);
            var securityScanErrors = securitScanner.ScurityScan(githubUrl);
            var dependencyScanErrors = dependecnyScanner.DependencyScan(githubUrl);

            Console.WriteLine("Scan report: ");
            raportGenerator.GenerateReport(qualityScanErrors, securityScanErrors, dependencyScanErrors);
        }
    }
}
