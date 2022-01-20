using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public IEnumerable<Tag> Tags { get; }

    public PrivacyModel(ILogger<PrivacyModel> logger, TagsContext context)
    {
        _logger = logger;
        Tags = context.Tags.AsEnumerable();

    }

    public void OnGet()
    {
    }
}

