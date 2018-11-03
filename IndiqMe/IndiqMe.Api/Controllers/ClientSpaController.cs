using Microsoft.AspNetCore.Mvc;

namespace IndiqMe.Api.Controllers
{
    public class ClientSpaController : Controller
    {
        public IActionResult Index()
        {
            return File("~/index.html", "text/html");
        }
    }
}