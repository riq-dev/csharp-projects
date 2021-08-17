using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 1 1 2 3 5 8 13 21
            int a = 0, b = 1, c = 0;

            Console.WriteLine("enter a value: ");
            int values = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci sequence with: " + values + "values");

            for (int i = 0; i < values; i++)
            {
                if (i < values - 1)
                {
                    Console.WriteLine(a + ", ");
                }
                else
                {
                    Console.WriteLine(a);
                }
                
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
