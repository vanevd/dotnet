using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Console1
{
    class Test4
    {
        public static void Run()
        {
            var context = new MyContext();
            var clients = context.clients
                //.Where(x => x.first_name == "Ivan")
                //.Where(x => x.email == "ivan@abv.bg")
                .ToList();
            foreach (var x in clients)
            {
                Console.WriteLine($"{ x.id } { x.first_name } { x.last_name } { x.phone } { x.email }");
            }            
            Console.WriteLine("");            
            var hotels = context.hotels.ToList();
            foreach (var x in hotels)
            {
                Console.WriteLine($"{ x.id } { x.name } { x.city }");
            }            

        }
    }
}
