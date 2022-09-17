using Microsoft.EntityFrameworkCore;
using Web.Context;
using Web.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICoupleRepository, MockCoupleRepository>();

var connectionString = builder.Configuration.GetConnectionString("Context");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
