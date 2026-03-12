using Microsoft.EntityFrameworkCore;
using MVCdemoBook.Models;

namespace MVCdemoBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //var bk1 = builder.Configuration.GetConnectionString("Bk1");
            builder.Services.AddDbContext<BookDbContext>(options =>
         options.UseSqlServer(builder.Configuration.GetConnectionString("BK1")));
            // builder.Services.AddDbContext<BookDbContext> (options=>options.UseSqlServer(bk1));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=BookController1}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}