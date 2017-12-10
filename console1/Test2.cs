using System;

namespace Console1
{
    class Test2
    {
        public static void Run()
        {
            string line;
            int a, b;

            while (true) {
                Console.WriteLine("Please enter First Value: ");   
                line = Console.ReadLine();
                if (line.ToLower() == "end") {
                    break;
                }    
                a = Int32.Parse(line);
                Console.WriteLine("Please enter Second Value: ");   
                line = Console.ReadLine();
                if (line.ToLower() == "end") {
                    break;
                }    
                b = Int32.Parse(line);
                Console.WriteLine("Sum: {0}", a + b);
                Console.WriteLine();
            }
        }
    }
}
