﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Console1
{
    public class Client
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

    }
    public class MyContext : DbContext
    {
        public DbSet<Client> clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;database=testphp;uid=testphp;pwd=testphp;");
    }
    class Test4
    {
        public static void Run()
        {
            var context = new MyContext();
            var ret = context.clients.ToList();
            foreach (var x in ret)
            {
                Console.WriteLine($"{ x.id } { x.first_name } { x.last_name } { x.phone } { x.email }");
            }            

        }
    }
}