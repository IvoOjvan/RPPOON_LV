using System;
using System.Collections.Generic;
using System.Text;

namespace Most
{
    class CoolNote : Note
    {
        public CoolNote(string message, ITheme theme) : base(message, theme) { }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("COOL: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
