using Microsoft.AspNetCore.Mvc;

namespace locadora.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
