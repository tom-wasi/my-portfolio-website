using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TomaszWasielewski.Homepage.Pages
{
    public class AboutMeModel : PageModel
    {
        private readonly ILogger<AboutMeModel> _logger;

        public AboutMeModel(ILogger<AboutMeModel> logger)
        {
            _logger = logger;
        }

    public void OnGet()
        {

        }
    }
}
