using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public static string ConStr { get; }
    public static ServerVersion Version { get; }

    static IndexModel()
    {
        ConStr = System.Environment.GetEnvironmentVariable("MYSQLCONNSTR_localdb") ?? "No value";
        ConStr = ConStr.Replace("Database", "database");
        ConStr = ConStr.Replace("Data Source", "server");
        ConStr = ConStr.Replace("User Id", "user");
        ConStr = ConStr.Replace("Password", "password");
        ConStr = ConStr.Replace("127.0.0.1", "localhost");
        ConStr = ConStr.Replace(":", ";port=");
        //
        Version = ServerVersion.AutoDetect(ConStr);
    }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
