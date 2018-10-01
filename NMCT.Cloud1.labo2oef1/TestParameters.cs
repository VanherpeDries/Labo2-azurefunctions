
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

namespace NMCT.Cloud1.labo2oef1
{
    public static class TestParameters
    {
        [FunctionName("TestParameters")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "som/{getal1}/{getal2")]HttpRequest req,int getal1 , int getal2, ILogger log)
        {
            
            log.LogInformation("C# HTTP trigger function processed a request.");
            int som = getal2 + getal1;
            return new OkObjectResult(som);
               
        }
    }
}
