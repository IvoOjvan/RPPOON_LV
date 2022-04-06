using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_4_Builder
{
    class NotificationDirector
    {

        public ConsoleNotification CreateInfoNotification(string author) 
        {
            return new ConsoleNotification(author, "", "",DateTime.Now, Category.INFO, ConsoleColor.White);
        }

        public ConsoleNotification CreateAlertNotification(string author) 
        {
            return new ConsoleNotification(author, "", "", DateTime.Now, Category.ALERT, ConsoleColor.Yellow);
        }

        public ConsoleNotification CreateErrorNotification(string author) 
        {
            return new ConsoleNotification(author, "", "", DateTime.Now, Category.ERROR, ConsoleColor.Red);
        }
    }
}
