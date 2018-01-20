using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Console1
{
    class Test5
    {
        public static void Run()
        {
            MyContext context;
            Client client;

            context =  new MyContext();

            client = new Client { first_name = "Ivan", last_name = "Ivanov", phone = "088555888", email = "ivan@abv.bg"};
            context.Add(client);
            client = new Client { first_name = "Peter", last_name = "Petrov", phone = "088444777", email = "peter@abv.bg"};
            context.Add(client);
            context.SaveChanges();
        }
    }
}
