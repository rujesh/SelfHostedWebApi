using System.Web.Http;

namespace SelfHostedWebApi.Simple
{
    public class HelloController : ApiController
    {
        public string Get()
        {
            return "Hello, Hola, Namaste Simple Web Api!";
        }
    }
}
