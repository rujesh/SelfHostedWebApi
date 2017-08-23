using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace SelfHostedWebApi.Simple
{
    class Program
    {
        static string baseAddress = "http://localhost:8080";
        
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration(baseAddress);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            using (var server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine("Listening on server " + baseAddress + ". Press enter to quit.");
                Console.ReadLine();
            }
        }
    }
}
