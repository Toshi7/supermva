using System;
using Microsoft.AspNetCore.Hosting;
using movingtotheweb;

namespace supermva
{
    class Program
    {
        static void Main(string[] args)
        {
			/*
        	String name;
            Console.WriteLine("Hello World!");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
			*/
			
			var host = new WebHostBuilder()
			.UseKestrel()
			.UseStartup<Startup>()
			.Build();
			
			host.Run();
			
        }
    }
}
