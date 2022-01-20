using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public IEnumerable<Tag> Tags { get; }
    public string ConStr { get; }

    public IndexModel(ILogger<IndexModel> logger, TagsContext context)
    {
        _logger = logger;
        Tags = context.Tags.AsEnumerable();
        ConStr = System.Environment.GetEnvironmentVariable("MYSQLCONNSTR_localdb") ?? "No value";
    }

    public void OnGet()
    {

    }
}
