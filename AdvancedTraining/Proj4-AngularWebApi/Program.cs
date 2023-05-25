using AngularWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string policyName = "myPolicy";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();
            builder.Services.AddTransient<IEmpComponent, EmpComponent>();
            builder.Services.AddCors((options) =>
            {
                options.AddPolicy(policyName, options =>
                {
                    options.AllowAnyHeader();
                    options.AllowAnyOrigin();
                    options.AllowAnyMethod();
                });
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseAuthorization();
            app.UseCors(policyName);//For Cross Origin Requests...

            app.MapGet("/Employees", ([FromServices]IEmpComponent com) =>
            {
                return com.GetEmployees();
            });

            app.MapGet("/Employees/{id}", (int id, IEmpComponent com) =>
            {
                return com.GetEmployee(id);
            });

            app.MapPost("/Employees", (EmpClass emp, IEmpComponent com) =>
            {
                com.AddEmployee(emp);
                return "Employee Added Successfully";
            });

            app.Run();
        }
    }
}