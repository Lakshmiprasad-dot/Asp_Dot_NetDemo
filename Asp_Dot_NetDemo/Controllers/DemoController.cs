using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Dot_NetDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new string[] { "hello", "world" });
        }
    }
}
