using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using App.Core.Entities;

namespace App.Infrastructure.Data{
    public class DataContext: DbContext
    {
        public DbSet<User> Users {get;set;}
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureUser(modelBuilder);
            /* 
            List<User> users = new List<User>();
            for(var i = 1; i <= 10; i++)
            {
                users.Add(new User() { Id = i, UserName = $"TestUser{i.ToString()}" });
            }
            modelBuilder.Entity<User>().HasData(users.ToArray());
            */
            
        }
        protected void ConfigureUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.Id).IsRequired();
            modelBuilder.Entity<User>().HasKey(u => u.Id);
        }
    }
}