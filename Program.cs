using Microsoft.EntityFrameworkCore;
using WebApp.Models;

System.Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<TagsContext>(optionsBuilder =>
{
    var constr = System.Environment.GetEnvironmentVariable("MYSQLCONNSTR_localdb");
    optionsBuilder.UseMySql(constr, ServerVersion.Parse(constr));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
