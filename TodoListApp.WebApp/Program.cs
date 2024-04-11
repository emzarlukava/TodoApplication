using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApp.Models;
using Microsoft.AspNetCore.Identity;
using TodoListApp.WebApp.Data;
using TodoListApp.WebApp.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//Add EF core Di
builder.Services.AddDbContext<ToDoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ToDoContext")));
builder.Services.AddDbContext<TodoListAppWebAppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TodoListAppWebAppContextConnection")));

builder.Services.AddDefaultIdentity<TodoListAppWebAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<TodoListAppWebAppContext>();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
