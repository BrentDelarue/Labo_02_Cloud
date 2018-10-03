
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
    public static class Oefening4
    {
        [FunctionName("Oefening4")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequest req, ILogger log)
        {
            string leeftijd = string.Empty;
            string drankje = string.Empty;
            string approval = "";

            foreach (var key in req.Query.Keys)
            {
                if (key == "leeftijd")
                {
                    leeftijd = req.Query["leeftijd"];
                }
                if (key == "drankje")
                {
                    drankje = req.Query["drankje"];
                }
            }

            if (drankje == "wijn" || drankje == "gin" || drankje == "bier" && Convert.ToInt32(leeftijd) < 18)
            {
                approval = $"Je bent niet toegelaten om als {leeftijd} jarige {drankje} te drinken.";
            }
            else
            {
                approval = $"Je bent toegelaten om als {leeftijd} jarige {drankje} te drinken.";
            }
            return new OkObjectResult(approval);
        }
    }
}
