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
            string[] items;
            int init_size = 5;
            int count=0;
            int i;
            int size;
            int key;
            int ins=0;
            string resize = "manual";

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
                if (line.ToLower() == "ins") {
                    Console.WriteLine("Ins: {0}", ins);
                    continue;
                }                
                if (line.Length > 4) {
                    if (line.Substring(0,4).ToLower() == "add ") {
                        items = line.Substring(4,line.Length-4).Split(',');
                        if (count+items.Length-1 >= init_size) {
                            if (resize == "manual") {
                                Console.WriteLine("List full");
                                continue;
                            }    
                            if (resize == "auto") {
                                //resize;
                            }
                        }
                        if (ins==0) {
                            for (i=0; i<items.Length; i++) {
                                list[count+i] = items[i];
                            }    
                        }
                        if (ins>0) {
                            for (i=count; i>=ins; i--) {
                                list[i+items.Length-1] = list[i-1];
                            }  
                            for (i=0; i<items.Length; i++) {
                                list[ins-1+i] = items[i];
                            }    
                        }
                        count = count + items.Length;
                        ins = 0;
                        continue;
                    }
                    if (line.Substring(0,4).ToLower() == "del ") {
                        if (!Int32.TryParse(line.Substring(4,line.Length-4), out key)) {
                            Console.WriteLine("Please enter integer value.");
                            continue;
                        }
                        if ((key < 1)||(key > count)) {
                            Console.WriteLine("Please enter number between 1 and {0}.", count);
                            continue;
                        }
                        for (i=key-1; i<=count-2; i++) {
                            list[i] = list[i+1];
                        }
                        count--;
                        continue;
                    }    
                    if (line.Substring(0,4).ToLower() == "ins ") {
                        if (!Int32.TryParse(line.Substring(4,line.Length-4), out key)) {
                            Console.WriteLine("Please enter integer value.");
                            continue;
                        }
                        if ((key < 0)||(key > count)) {
                            Console.WriteLine("Please enter number between 0 and {0}.", count);
                            continue;
                        }      
                        ins=key;  
                        continue;                
                    }
                    if (line.Substring(0,5).ToLower() == "size ") {
                        if (!Int32.TryParse(line.Substring(5,line.Length-5), out size)) {
                            Console.WriteLine("Please enter integer value.");
                            continue;
                        }
                        if (size <= count) {
                            Console.WriteLine("Please enter number greater than {0}.", count);
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