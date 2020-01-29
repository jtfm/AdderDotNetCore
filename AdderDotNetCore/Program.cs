using System;

namespace AdderDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x = 2;
            int y = 2;

            Console.WriteLine($"{x} + {y} = {Adder.Add(x, y)}");
        }
    }
}
