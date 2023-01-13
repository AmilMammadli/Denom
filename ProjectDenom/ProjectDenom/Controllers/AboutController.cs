using Microsoft.AspNetCore.Mvc;

namespace ProjectDenom.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
