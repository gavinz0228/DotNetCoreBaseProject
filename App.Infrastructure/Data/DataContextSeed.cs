using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using App.Core.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
namespace App.Infrastructure.Data{
    public class DataContextSeeding
    {
        public static void Seed(DataContext dbContext)
        {
            if( dbContext.Users.CountAsync().Result == 0)
            {
                List<User> users = new List<User>();
                for(var i = 1; i <= 10; i++)
                {
                    var user = new User() { Id = i, UserName = $"TestUser{i.ToString()}" };
                    dbContext.SaveChanges();
                }
            }
            
            Console.WriteLine("Data seeding completed.");
            
        }      
    }
}