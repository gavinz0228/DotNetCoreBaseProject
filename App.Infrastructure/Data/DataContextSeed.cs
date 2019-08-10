using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using App.Core.Entities;

namespace App.Infrastructure.Data{
    public class DataContextSeed 
    {
        public static void Seed(DataContext dbContext)
        {
            List<User> users = new List<User>();
            for(var i = 1; i <= 10; i++)
            {
                users.Add(new User() { Id = i, UserName = $"TestUser{i.ToString()}" });
            }
            dbContext.Users.AddRange(users);
            dbContext.SaveChanges();
        }      
    }
}