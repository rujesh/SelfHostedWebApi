using System.Web.Http;

namespace SelfHostedWebApi.Owin.Controllers
{
    public class HelloController : ApiController
    {
        public string Get()
        {
            return "Hello, Hola, Namaste Owin Web Api!";
        }
    }
}
