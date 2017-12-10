using System;

namespace Console1
{
    class Test1
    {
        public static void Run()
        {
            string line;

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
