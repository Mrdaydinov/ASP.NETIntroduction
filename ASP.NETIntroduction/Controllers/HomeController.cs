using Microsoft.AspNetCore.Mvc;

namespace ASP.NETIntroduction.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
