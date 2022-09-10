using System;
using System.Collections.Generic;
using System.Text;

namespace Most
{
    class DarkTheme : ITheme
    {
        public string GetFooter(int width)
        {
            return new string('_', width);
        }

        public string GetHeader(int width)
        {
            return new string('+', width);
        }

        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}
