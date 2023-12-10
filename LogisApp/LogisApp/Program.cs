using LogisApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ServiceDbContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(ep =>
{
    ep.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
});

app.Run();
