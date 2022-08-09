using Microsoft.AspNetCore.Mvc;

namespace Sample.Web.Areas.Products.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
