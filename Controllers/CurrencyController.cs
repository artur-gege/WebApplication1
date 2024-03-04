using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CurrencyController : Controller
    {
        [HttpGet("currency/index")]
        public IActionResult Index()
        {
            var url = Url.Action("View", "Currency",
                new { code = "USD" });
            return Content($"The URL is {url}");
        }

    
    }


}


