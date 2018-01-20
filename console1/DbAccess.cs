using System;
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
    public class Hotel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
    }
    public class MyContext : DbContext
    {
        public DbSet<Client> clients { get; set; }
        public DbSet<Hotel> hotels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;database=testphp;uid=testphp;pwd=testphp;");
    }
    
}
