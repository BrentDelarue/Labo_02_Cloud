
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace NMCT.IoTCloud.MyFirstServices
{
//    public static class Oefening2
//    {
//        [FunctionName("Oefening2")]
//        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "rekenmachine/delen/{getal1}/{getal2}")]HttpRequest req, int getal1, int getal2, ILogger log)
//        {
//            try
//            {
//                log.LogInformation("C# HTTP trigger function processed a request.");
//                if (getal2 == 0)
//                {
//                    return new BadRequestResult();
//                }
//                int get1 = getal1;
//                int get2 = getal2;

//                float deling = get1 / get2;
//            }
//            catch (Exception)
//            {
//                return new OkObjectResult($"De deling van {get1} en {get2} = {deling}");
//            }


//            return new OkObjectResult($"De deling van {get1} en {get2} = {deling}");
//         }
//    }
}
