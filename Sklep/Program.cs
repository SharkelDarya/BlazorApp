using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Sklep.Context;
using Sklep.Service;
using Sklep.Shared;
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();


        builder.Services.AddScoped<ProductsService>();
        builder.Services.AddScoped<AccountService>();


        //Podłączenie do bazy danych
        builder.Services.AddDbContext<ApplicationDBContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        
        
        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }
}