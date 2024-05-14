using Microsoft.AspNetCore.Mvc;

namespace ASP.NETIntroduction.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {

            ViewData["Name"] = "SomeName1";
            ViewData["Surname"] = "SomeSurname1";
            ViewData["Age"] = "SomeAge1";
            ViewData["Country"] = "SomeCountry1";
            ViewData["PhoneNumber"]= "SomePhoneNumber1";

            ViewBag.DataRowList = new List<string> { "SomeName2", "SomeSurname2", "SomeAge2", "SomeCountry2", "SomePhoneNumber2" };

            return View();
        }
        
    }
}
