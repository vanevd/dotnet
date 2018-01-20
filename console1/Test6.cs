using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Console1
{
    class Test6
    {
        public static void Run()
        {
            MyContext context;

            context =  new MyContext();

            //Update
            /*
            var client = context.clients.Single(x => x.id == 6);
            client.first_name = "Todor";
            context.SaveChanges();
            */

            //Delete single record
            /*
            var client = context.clients.Single(x => x.id == 6);
            context.clients.Remove(client);
            context.SaveChanges();
            */
            
            //Delete multiple records
            var clients = context.clients
                .Where(x => x.first_name == "Ivan");
            context.clients.RemoveRange(clients);
            context.SaveChanges();
        }
    }
}
