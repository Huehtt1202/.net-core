using System;
using Core.Entity;
using EntityFramework.Connection;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Linq;

namespace EntityFramework
{
    class program
    {
        static void Main(string[] agrs)
        {
            List<User> users = new List<User>()
            {
                new User() {UserName="Admin", DisplayUserName="ADMIN", Password = "123123"}
            };
            var user = from us in users
                       select new
                       {
                           UserName = us.UserName,
                           Display = us.DisplayUserName
                       };

            foreach (var item in user)
            {
                Console.Write(item.UserName + item.Display);

            }
        }
    }
}