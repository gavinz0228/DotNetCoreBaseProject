using System;
using Microsoft.EntityFrameworkCore;
using App.Infrastructure.Data;
using App.Core.Entities;
namespace App.Infrastructure.Data.Test{
    public class DbInitializer{
        public static void Initialize(TestDataContext dbContext)
        {
            for(int i = 0; i< 10; i++)
            {
                dbContext.Users.Add(new User(){ UserName="TestUser"+ i.ToString(), Email ="TestEmail" + i.ToString()});
            }
            dbContext.SaveChanges();
        }
    }
}