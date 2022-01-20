using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string SQLENVVAL { get; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        SQLENVVAL = System.Environment.GetEnvironmentVariable("MYSQLCONNSTR_localdb") ?? "No Value";
    }

    public void OnGet()
    {

    }
}
