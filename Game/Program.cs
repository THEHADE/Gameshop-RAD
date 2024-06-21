using GameShop.Models.Dal;
using GameShop.Models.Entities;
using GameShop.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["ConnectionStrings:cnn"];
builder.Services.AddDbContext<GameShopDbContext>(p => p.UseSqlServer(connection));

builder.Services.AddScoped<IGameRepository,GameRepo>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddIdentity<User, IdentityRole>(c =>
{
    c.Password.RequiredLength = 8;
    c.Password.RequireDigit = false;
    c.Password.RequireUppercase = false;
    c.Password.RequireNonAlphanumeric = false;
    c.Password.RequireLowercase = false;

}).AddEntityFrameworkStores<GameShopDbContext>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=Index}/{id?}");

app.Run();
