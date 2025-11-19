using System;

namespace EventPlayground
{
    // Custom EventArgs class (required in Lab)
    public class ColorEventArgs : EventArgs
    {
        public string ColorName { get; }

        public ColorEventArgs(string colorName)
        {
            ColorName = colorName;
        }
    }

    // Custom delegates (Lab requirement: NOT using EventHandler)
    public delegate void ColorChangedEventHandler(object sender, ColorEventArgs e);
    public delegate void TextChangedEventHandler(object sender, EventArgs e);
}
