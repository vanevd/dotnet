using System;

namespace Console1
{
    class Test3
    {
        public static void Run() 
        {
            string line;
            string[] list;
            string[] list1;
            int init_size = 5;
            int count=0;
            int i;
            int size;
            int key;

            list = new string[init_size];
            Console.WriteLine("Test 3");
            while(true) {
                Console.WriteLine("Please enter a command:");
                line = Console.ReadLine();
                if (line.ToLower() == "end") {
                    break;
                }
                if (line.ToLower() == "list") {
                    for(i=0; i<count; i++) {                
                        Console.WriteLine("{0}. {1}", i+1, list[i]);
                    }
                    continue;
                }
                if (line.ToLower() == "count") {
                    Console.WriteLine("Count: {0}", count);
                    continue;
                }
                if (line.ToLower() == "size") {
                    Console.WriteLine("Size: {0}", init_size);
                    continue;
                }
                if (line.Length > 4) {
                    if (line.Substring(0,4).ToLower() == "add ") {
                        if (count<init_size) {
                        list[count] = line.Substring(4,line.Length-4);
                        count++;
                        } else {
                            Console.WriteLine("List full");
                        }
                        continue;
                    }
                    if (line.Substring(0,4).ToLower() == "del ") {
                        key = Int32.Parse(line.Substring(4,line.Length-4));
                        if ((key < 1)||(key > count)) {
                            Console.WriteLine("Invalid key.");
                            continue;
                        }
                        for (i=key-1; i<=count-2; i++) {
                            list[i] = list[i+1];
                        }
                        count--;
                        continue;
                    }    
                    if (line.Substring(0,5).ToLower() == "size ") {
                        size = Int32.Parse(line.Substring(5,line.Length-5));
                        if (size <= count) {
                            Console.WriteLine("Please enter greater size.");
                            continue;
                        }
                        list1 = new string[size];
                        for(i=0; i<count; i++) {                
                            list1[i] = list[i];
                        }                      
                        list = list1;  
                        init_size = size;
                        continue;
                    }    
                }
                Console.WriteLine("Unknown Command");
            }
        }
    }

}