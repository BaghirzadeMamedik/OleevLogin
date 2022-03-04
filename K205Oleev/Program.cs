using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using Services;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectingString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<OleevDbContext>
    (options => options.UseSqlServer(connectingString));

builder.Services.AddDefaultIdentity<K205User>().AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<OleevDbContext>();


builder.Services.AddScoped<AboutServices>();

builder.Services.AddControllersWithViews();

builder.Services.ConfigureApplicationCookie(option =>
{
    option.LoginPath = "/auth/login";
    option.AccessDeniedPath = "/auth/login";
});

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
