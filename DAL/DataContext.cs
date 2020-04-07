using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using BudgetTool.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options)
            : base(options) {}

        //public DataContext([NotNullAttribute] DbContextOptions options) : base(options)
        //{
        //}

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
    }

    //public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    //{
    //    public DataContext CreateDbContext(string[] args)
    //    {
    //        IConfigurationRoot configuration = new ConfigurationBuilder()
    //            .SetBasePath(Directory.GetCurrentDirectory())
    //            .AddJsonFile(@Directory.GetCurrentDirectory() + "/../BudgetTool.API/appsettings.json")
    //            .Build();
    //        var builder = new DbContextOptionsBuilder<DataContext>();
    //        var connectionString = configuration.GetConnectionString("DefaultConnection");
    //        builder.UseSqlServer(connectionString);
    //        return new DataContext(builder.Options);
    //    }
    //}
}
