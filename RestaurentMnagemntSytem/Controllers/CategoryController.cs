using Microsoft.AspNetCore.Mvc;
using RestaurentMnagemntSytem.View.Models.ViewModel;

namespace RestaurentMnagemntSytem.View.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> create([FromBody] CategoryViewModel model)
        //{
            
        //}
    }
}
