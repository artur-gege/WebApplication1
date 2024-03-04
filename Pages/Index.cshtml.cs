using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            var url = Url.Page("Currency/View", new { code = "USD"});
        }
        

    }

}


