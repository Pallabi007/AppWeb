using AppWeb.Models;
using AppWeb.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Graph;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.Configure<StudentStoreDatabaseSettings>(
//                builder.Configuration.GetSection(nameof(StudentStoreDatabaseSettings)));

//builder.Services.AddSingleton<IStudentStoreDatabaseSettings>(sp =>
//    sp.GetRequiredService<IOptions<StudentStoreDatabaseSettings>>().Value);

//builder.Services.AddSingleton<IMongoClient>(s =>
//        new MongoClient(builder.Configuration.GetValue<string>("StudentStoreDatabaseSettings:ConnectionString")));

//builder.Services.AddScoped<IStudentService, StudentService>();

namespace AppWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
