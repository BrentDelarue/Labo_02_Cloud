
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
    public static class Post
    {
        [FunctionName("Post")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)]HttpRequest req, ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            Getallen data = JsonConvert.DeserializeObject<Getallen>(requestBody);

            Resultaat r = new Resultaat();
            r.Som = data.Getal1 + data.Getal2;

            int som = data.Getal1 + data.Getal2;
            return new OkObjectResult(som.ToString());
            //return new OkObjectResult(r);
        }
    }
}
