using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp.Pages;

System.Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<TagsContext>(optionsBuilder =>
{
    string constr = IndexModel.ConStr;
    optionsBuilder.UseMySql(constr, ServerVersion.Parse("5.7.9-mysql"), options =>
    {
        options.EnableRetryOnFailure(5);
    });
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
