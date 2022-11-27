// See https://aka.ms/new-console-template for more information
using Core.Entity;
using EntityFramework.Connection;

Console.WriteLine("Hello, World!");
var context = new crmDbContext();
var user = new User();
context.User.Add(user);
context.SaveChanges();