using Microsoft.EntityFrameworkCore;
using RabbitMQWithApiNet6.Model;
using System.Collections.Generic;

namespace RabbitMQWithApiNet6.Data
{
    public class DbContextClass: DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Product> Products
        {
            get;
            set;
        }
    }
}
