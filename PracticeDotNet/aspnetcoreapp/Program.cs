﻿using System;
using Microsoft.AspNetCore.Hosting;

namespace aspnetcoreapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
			var host = new WebHostBuilder()
				.UseKestrel()
				.UseStartup<Startup>()
				.Build();
				
			host.Run();
        }
    }
}
