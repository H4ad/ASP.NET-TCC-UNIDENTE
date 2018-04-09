using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_TCC_UNIDENTE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
