using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            while (true) {
                Console.WriteLine("Please enter Test Number: ");   
                line = Console.ReadLine();
                if (line.ToLower() == "end") {
                    break;
                }    
                if (line == "1") {
                    Test1.Run();
                }
                if (line == "2") {
                    Test2.Run();
                }
            }
            

        }
    }
}
