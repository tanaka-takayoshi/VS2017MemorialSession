using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp
{
    class Program
    {
        static public IConfigurationRoot Configuration { get; set; }
        
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            Console.WriteLine($"option1 = {Configuration["option1"]}");
            Console.WriteLine($"option2 = {Configuration["option2"]}");
            Console.WriteLine(
                $"option1 = {Configuration["subsection:suboption1"]}");
        }
    }
}
