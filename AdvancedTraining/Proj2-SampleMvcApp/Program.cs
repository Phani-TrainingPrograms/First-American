using AspNetCore.Unobtrusive.Ajax;
using SampleMvcApp.Models;

namespace SampleMvcApp
{
    //WebApplication is a static class that represents the Application Statei of the Web App.
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddUnobtrusiveAjax();
            builder.Services.AddTransient<IDBFirstComponent, DBFirstComponent>();
            builder.Services.AddTransient<ILoanComponent, LoanComponent>();//Creates the single instance of the LoanComponent object and returns its reference thru the Interface object for every call U make in the Application. This feature is called as Dependency Injection of ASP.NET CORE.

            builder.Services.AddMvc((options) =>
            {
                options.MaxModelValidationErrors= 50;
            });//Makes ur App go thru MVC pipeline.
            builder.Services.AddControllersWithViews();
            //Additional dependencies can be created here...
            
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseUnobtrusiveAjax();
            app.MapControllerRoute(
                name:"default", 
                pattern: "{controller=Validation}/{action=RegisterEmployee}/{id?}"
            );
            
            app.Run();
        }
    }
}