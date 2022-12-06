using Microsoft.AspNetCore.Mvc.RazorPages;
using TomaszWasielewski.Homepage.Models;
using TomaszWasielewski.Homepage.Services;

namespace TomaszWasielewski.Homepage.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
}