using Microsoft.AspNetCore.Mvc;

namespace BikeStore.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
