using Microsoft.AspNetCore.Mvc;

namespace ProjectDenom.Controllers
{
    public class ContactusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
