using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Api.Context
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {

        }

        public DbSet<Api.Models.Login> Login { get; set; }
        public DbSet<Api.Models.User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        
    }
}
