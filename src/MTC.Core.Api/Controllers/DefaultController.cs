using Microsoft.AspNetCore.Mvc;

namespace MTC.Core.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : Controller
    {
        public string Index()
        {
            return "Running Api Services ...";
        }
    }
}