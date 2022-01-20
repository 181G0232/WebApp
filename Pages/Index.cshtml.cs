using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public IEnumerable<Tag> Tags { get; }
    public static string ConStr { get; }

    static IndexModel()
    {
        ConStr = System.Environment.GetEnvironmentVariable("MYSQLCONNSTR_localdb") ?? "No value";
        ConStr = ConStr.Replace("Database", "database");
        ConStr = ConStr.Replace("Data Source", "server");
        ConStr = ConStr.Replace("User Id", "id");
        ConStr = ConStr.Replace("Password", "password");
    }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
