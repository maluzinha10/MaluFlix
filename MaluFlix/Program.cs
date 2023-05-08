using MaluFlix.Data;
using MaluFlix.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Objetos auxiliares de Conexão
string conn = builder.Configuration.GetConnectionString("MaluFlix");
var version = ServerVersion.AutoDetect(conn);

//serviço de conexão com banco de dados
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseMySql(conn, version)

);

//servico de gestao de ususario - Identity
builder.Services.AddIdentity<AppUser, IdentityRole>() 
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();
     
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
