using Microsoft.AspNetCore.Mvc;

namespace RestaurentMnagemntSytem.View.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
