using Microsoft.AspNetCore.Mvc;

namespace locadora.Controllers
{
    public class FilmeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
