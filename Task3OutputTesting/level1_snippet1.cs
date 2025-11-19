using System;

namespace Task3OutputTesting
{
    internal class level1_snippet1
    {
        public static void Run()
        {
            Console.WriteLine("LEVEL 1 SNIPPET 1 OUTPUT:");

            Counter c = new Counter();

            // Subscribers for LimitReached
            c.LimitReached += (s, e) => Console.Write("[L" + e.CurrentValue + "]");
            c.LimitReached += (s, e) => Console.Write("(Reset)");

            // Subscribers for MilestoneReached
            c.MilestoneReached += (s, e) =>
            {
                Console.Write("[M" + e.CurrentValue + "]");
                if (e.CurrentValue == 4)
                    Console.Write("{Alert}");
            };

            for (int i = 0; i < 6; i++)
                c.Increment();

            Console.WriteLine("\n");
        }
    }

    // Supporting Classes (must be in same file OR separate file)

    class LimitEventArgs : EventArgs
    {
        public int CurrentValue { get; }
        public LimitEventArgs(int val) => CurrentValue = val;
    }

    class Counter
    {
        public event EventHandler<LimitEventArgs> LimitReached;
        public event EventHandler<LimitEventArgs> MilestoneReached;

        private int value = 0;

        public void Increment()
        {
            value++;
            Console.Write(">" + value);

            if (value % 2 == 0)
                MilestoneReached?.Invoke(this, new LimitEventArgs(value));

            if (value % 3 == 0)
                LimitReached?.Invoke(this, new LimitEventArgs(value));
        }
    }
}
