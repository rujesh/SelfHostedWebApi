using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SelfHostedWebApi.Client
{
    class Program
    {
        static string webApiAddress = "http://localhost:8080";
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            client.BaseAddress = new Uri(webApiAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            /* Option 1: Start */
            /* does not block rest of the code */
            //client.GetStringAsync("api/Hello").ContinueWith(
            //    getTask =>
            //    {
            //        if (getTask.IsCanceled)
            //        {
            //            Console.WriteLine("Request was canceled");
            //        }
            //        else if (getTask.IsFaulted)
            //        {
            //            Console.WriteLine("Request failed: {0}", getTask.Exception);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Client received: {0}", getTask.Result);
            //        }
            //    }
            //);
            /* Option 1: End */

            /* Option 2: Start */
            /* .Result blocks rest of the code */
            var response = client.GetAsync("api/Hello").Result;
            //response.EnsureSuccessStatusCode(); // throws an exception if HTTP response status is an error code
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Success");
                var result = response.Content.ReadAsAsync<string>().Result;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failure");
            }
            /* Option 2: End */

            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }
    }
}
