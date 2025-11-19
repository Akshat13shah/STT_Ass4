using System;

namespace Task3OutputTesting
{
    internal class level0_snippet2
    {
        // Correct: declare delegate ONCE
        delegate void ActionHandler(ref int x);

        public static void Run()
        {
            Console.WriteLine("LEVEL 0 SNIPPET 2 OUTPUT:");

            void Inc(ref int a) { a += 2; Console.Write("I" + a + " "); }
            void Dec(ref int a) { a--; Console.Write("D" + a + " "); }

            int val = 3;

            ActionHandler act = Inc;
            act += Dec;

            act(ref val);

            Console.Write("F" + val);
            Console.WriteLine("\n");
        }
    }
}
