using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using App.Core.Enties;

namespace App.Infrastructure.Data{
    public class DataContext: DbContext
    {
        public DbSet<User> Users {get;set;}
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){

        }
    }
}