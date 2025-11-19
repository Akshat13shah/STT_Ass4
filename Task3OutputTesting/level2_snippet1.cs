using System;

namespace Task3OutputTesting
{
    internal class level2_snippet1
    {
        public static void Run()
        {
            Console.WriteLine("LEVEL 2 SNIPPET 1 OUTPUT:");

            // Code from the problem
            Notifier n = new Notifier();

            n.OnNotify += (s, e) =>
            {
                Console.Write("{" + e.Message + "}");
            };

            n.OnNotify += (s, e) =>
            {
                Console.Write("(Nested)");
                if (e.Message == "Ping")
                    ((Notifier)s).Trigger("Pong");
            };

            n.Trigger("Ping");

            Console.WriteLine("\n");
        }
    }

    class NotifyEventArgs : EventArgs
    {
        public string Message { get; }
        public NotifyEventArgs(string msg) => Message = msg;
    }

    class Notifier
    {
        public event EventHandler<NotifyEventArgs> OnNotify;

        public void Trigger(string msg)
        {
            Console.Write("[Start]");
            OnNotify?.Invoke(this, new NotifyEventArgs(msg));
            Console.Write("[End]");
        }
    }
}
