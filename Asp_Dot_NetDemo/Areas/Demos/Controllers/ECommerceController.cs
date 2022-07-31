using Microsoft.AspNetCore.Mvc;

namespace Asp_Dot_NetDemo.Areas.Demos.Controllers
{
    public class ECommerceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
