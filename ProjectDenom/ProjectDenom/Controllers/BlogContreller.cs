using Microsoft.AspNetCore.Mvc;

namespace ProjectDenom.Controllers
{
    public class BlogContreller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
