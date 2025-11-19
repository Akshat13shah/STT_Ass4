using System;

namespace Task3OutputTesting
{
    internal class level0_snippet1
    {
        
        delegate int Calc(int x, int y);

        public static void Run()
        {
            Console.WriteLine("LEVEL 0 SNIPPET 1 OUTPUT:");

            int Add(int a, int b) { Console.Write("A"); return a + b; }
            int Mul(int a, int b) { Console.Write("M"); return a * b; }
            int Sub(int a, int b) { Console.Write("S"); return a - b; }

            Calc c = Add;
            c += Mul;
            c += Sub;
            c -= Add;

            int res = c(2, 3);
            Console.WriteLine(":" + res);
        }
    }
}
