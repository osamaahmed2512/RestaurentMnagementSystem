using Microsoft.AspNetCore.Mvc;

namespace RestaurentMnagemntSytem.View.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
