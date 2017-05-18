using Microsoft.AspNetCore.Mvc;

namespace Repro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
