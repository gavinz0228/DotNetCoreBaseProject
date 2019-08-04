using System;
using Microsoft.EntityFrameworkCore;
using App.Infrastructure.Data;

namespace App.Infrastructure.Data.Test{
    public class TestDataContext: DataContext
    {

        public TestDataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            //DbInitializer.Initialize(this);
        }
    }
}
