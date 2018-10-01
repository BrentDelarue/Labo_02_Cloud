
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
    public static class Oefening1
    {
        [FunctionName("Oefening1")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "rekenmachine/som/{getal1}/{getal2}")]HttpRequest req, int getal1, int getal2, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            int get1 = getal1;
            int get2 = getal2;
            string name = "ok";

            int som = get1 + get2;

            return name != null
                ? (ActionResult)new OkObjectResult($"De som van {get1} en {get2} = {som}")
                : new BadRequestObjectResult("Please pass two numbers on the query string or in the request body");
        }
    }
}
