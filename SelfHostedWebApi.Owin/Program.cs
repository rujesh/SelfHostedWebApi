using Microsoft.Owin.Hosting;
using System;

namespace SelfHostedWebApi.Owin
{
    class Program
    {
        static string baseAddress = "http://localhost:8080";
        
        static void Main(string[] args)
        {
            WebApp.Start<Startup>(baseAddress);
            Console.WriteLine("Listening on server " + baseAddress + ". Press enter to quit.");
            Console.ReadLine();
        }
    }
}
