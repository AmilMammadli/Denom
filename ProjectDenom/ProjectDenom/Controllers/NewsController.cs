using Microsoft.AspNetCore.Mvc;

namespace ProjectDenom.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
