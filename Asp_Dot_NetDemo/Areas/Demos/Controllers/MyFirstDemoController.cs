using Microsoft.AspNetCore.Mvc;

namespace Asp_Dot_NetDemo.Areas.Demos.Controllers
{
    [Area("Demos")]
    public class MyFirstDemoController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello World");
        }
        public IActionResult Index2()
        {
            return View();
        }
    }
}
