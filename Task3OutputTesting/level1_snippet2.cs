using System;

namespace Task3OutputTesting
{
    internal class level1_snippet2
    {
        public static void Run()
        {
            Console.WriteLine("LEVEL 1 SNIPPET 2 OUTPUT:");

            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureChanged += (s, e) =>
                Console.WriteLine($"Temperature changed from {e.OldTemperature}°C to {e.NewTemperature}°C");

            sensor.TemperatureChanged += (s, e) =>
            {
                if (Math.Abs(e.NewTemperature - e.OldTemperature) > 10)
                    Console.WriteLine(" Warning: Sudden change detected!");
            };

            // Trigger events
            sensor.UpdateTemperature(28);
            sensor.UpdateTemperature(30);
            sensor.UpdateTemperature(46);
            sensor.UpdateTemperature(52);

            Console.WriteLine();
        }
    }

    // ---------------- Helper classes ----------------

    class TemperatureEventArgs : EventArgs
    {
        public int OldTemperature { get; }
        public int NewTemperature { get; }

        public TemperatureEventArgs(int oldTemp, int newTemp)
        {
            OldTemperature = oldTemp;
            NewTemperature = newTemp;
        }
    }

    class TemperatureSensor
    {
        public event EventHandler<TemperatureEventArgs> TemperatureChanged;

        private int temperature = 25;

        public void UpdateTemperature(int newTemp)
        {
            int oldTemp = temperature;
            temperature = newTemp;

            if (Math.Abs(newTemp - oldTemp) > 5)
            {
                TemperatureChanged?.Invoke(this, new TemperatureEventArgs(oldTemp, newTemp));
            }
        }
    }
}
