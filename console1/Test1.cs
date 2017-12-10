using System;

namespace Console1
{
    class Test1
    {
        public static void Run()
        {
            string line;

            Console.WriteLine("Test 1");
            while (true) {
                Console.WriteLine("Please enter Name: ");   
                line = Console.ReadLine();
                if (line.ToLower() == "end") {
                    break;
                }    
                Console.WriteLine("Name: {0}", line);
            }

        }
    }
}
