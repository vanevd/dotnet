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
                if (line == "3") {
                    Test3.Run();
                }
                if (line == "4") {
                    Test4.Run();
                }
                if (line == "5") {
                    Test5.Run();
                }
            }
            

        }
    }
}
