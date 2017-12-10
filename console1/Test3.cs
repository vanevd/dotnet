using System;

namespace Console1
{
    class Test3
    {
        public static void Run() 
        {
            string line;
            string[] list;
            int count=0;
            int i;

            list = new string[10];
            Console.WriteLine("Test 3");
            while(true) {
                Console.WriteLine("Please enter a command:");
                line = Console.ReadLine();
                if (line.ToLower() == "end") {
                    break;
                }
                if (line.ToLower() == "list") {
                    for(i=0; i<count; i++) {                
                        Console.WriteLine(list[i]);
                    }
                    continue;
                }
                if (line.Length > 4) {
                    if (line.Substring(0,4).ToLower() == "add ") {
                        if (count<10) {
                        list[count] = line.Substring(4,line.Length-4);
                        count++;
                        } else {
                            Console.WriteLine("List full");
                        }
                        continue;
                    }
                }
                Console.WriteLine("Unknown Command");
            }
        }
    }

}