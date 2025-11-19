using System;

namespace EventPlayground1
{
    public class ColorEventArgs : EventArgs
    {
        public string ColorName { get; }

        public ColorEventArgs(string name)
        {
            ColorName = name;
        }
    }

    // Custom delegates
    public delegate void ColorChangedEventHandler(object sender, ColorEventArgs e);
    public delegate void TextChangedEventHandler(object sender, EventArgs e);
}
