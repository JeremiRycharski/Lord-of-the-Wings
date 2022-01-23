using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LordOftheWings.DAL.Context
{
    public class AppContextFactory
    {
		private DbContextOptionsBuilder<MyAppContext> _options { get; set; }

		public AppContextFactory()
		{
			IConfiguration configuration;

			string environmentName = System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

			if (string.IsNullOrEmpty(environmentName))
			{
				configuration = new ConfigurationBuilder()
					 .AddJsonFile("appsettings.json")
					 .Build();
			}
			else
			{
				configuration = new ConfigurationBuilder()
					 .AddJsonFile("appsettings.json")
					 .AddJsonFile($"appsettings.{environmentName}.json", optional: false)
					 .Build();
			}

			_options = new DbContextOptionsBuilder<MyAppContext>();
			_options.UseSqlServer(configuration.GetConnectionString("TransportalConnection"));
		}


		public AppContextFactory(string environmentName)
		{
			IConfigurationRoot configuration;

			if (string.IsNullOrEmpty(environmentName))
			{
				configuration = new ConfigurationBuilder()
					 .AddJsonFile("appsettings.json")
					 .Build();
			}
			else
			{


				configuration = new ConfigurationBuilder()
					 .AddJsonFile("appsettings.json")
					 .AddJsonFile($"appsettings.{environmentName}.json", optional: false)
					 .Build();


			}


			_options = new DbContextOptionsBuilder<MyAppContext>();
			_options.UseSqlServer(configuration.GetConnectionString("TransportalConnection"));
		}

		public MyAppContext CreateDbContext(string[] args)
			 => new MyAppContext(_options.Options);
	}
}
