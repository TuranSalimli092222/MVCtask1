using Microsoft.EntityFrameworkCore;


namespace MVCTask1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

      
            var app = builder.Build();
            
            app.UseStaticFiles();


            app.MapControllerRoute(
                name: "Default",
               pattern:"{controller=Home}/{action=index}/{id?}"
                );

            app.Run();
        }
    }
}
