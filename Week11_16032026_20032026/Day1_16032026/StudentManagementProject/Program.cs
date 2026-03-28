using StudentManagementProject.Filters;

namespace StudentManagementProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add<CustomExceptionFilter>();
            });

            // Enable session
            builder.Services.AddSession();

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseRouting();

            // Use session
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Login}/{id?}");

            app.Run();
        }
        }
}
