using System;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
            int p,month;
            int[] a1 = new int[5];
            string[] a2 = new string[5];

            double width, height;

            width = 10.256;
            height = 20.789;

            month = 6;

            Console.WriteLine("height = {1:n}, width = {0:f2}, month = {2:d2}", width, height, month);
            
            p = 10;

            Console.WriteLine(p);
        }
    }
}
