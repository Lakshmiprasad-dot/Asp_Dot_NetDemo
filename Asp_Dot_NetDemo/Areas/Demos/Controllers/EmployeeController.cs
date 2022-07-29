using Microsoft.AspNetCore.Mvc;

namespace Asp_Dot_NetDemo.Areas.Demos.Controllers
{
    public class EmployeeController : Controller
    {
        [Area("Demos")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
