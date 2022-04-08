using System;

namespace Zadatak_4_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadatak 5
            /*
            ConsoleNotification notification = new ConsoleNotification("autor", "naslov", "text", DateTime.Now, Category.ERROR, ConsoleColor.Red);
            NotificationManager notificationManager = new NotificationManager();
            notificationManager.Display(notification);
            */

            NotificationManager builder = new NotificationManager();
            NotificationDirector director = new NotificationDirector(builder);
            director.CreateErrorNotification("ISO");                                  //set all values with setters
            ConsoleNotification errorNotification = builder.Build();                  //passes all set values into Const.

            Console.ForegroundColor = errorNotification.Color;
            Console.WriteLine(errorNotification);
            Console.ResetColor();
        }
    }
}
