using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using locadora.Repositorio;

internal class Program
{
    private static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();



        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<IFilmeRepositorio, FilmeRepositorio>();
        builder.Services.AddEntityFrameworkSqlServer()
            .AddDbContext<locadora.Data.BancoContext>(o =>
            {
                o.UseSqlServer(configuration.GetConnectionString("DataBase"));
            });
        builder.Services.AddScoped<IFilmeRepositorio, FilmeRepositorio>();

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
    }
}