using System;

namespace Task3OutputTesting
{
    internal class level2_snippet2
    {
        public static void Run()
        {
            Console.WriteLine("LEVEL 2 SNIPPET 2 OUTPUT:");

            // Original snippet logic:
            Sensor s = new Sensor();

            s.ThresholdReached += (sender, e) =>
            {
                Console.Write("{" + e.Info + "}");
                if (e.Info == "High")
                    ((Sensor)sender).Check(30);
            };

            s.ThresholdReached += (sender, e) =>
                Console.Write("(Alert)");

            s.Check(80);

            Console.WriteLine("\n");
        }
    }


    // -------- Supporting Classes (copied from question) --------

    class AlertEventArgs : EventArgs
    {
        public string Info { get; }
        public AlertEventArgs(string info) => Info = info;
    }

    class Sensor
    {
        public event EventHandler<AlertEventArgs> ThresholdReached;

        public void Check(int value)
        {
            Console.Write("[Check]");
            if (value > 50)
                ThresholdReached?.Invoke(this, new AlertEventArgs("High"));
            Console.Write("[Done]");
        }
    }
}

