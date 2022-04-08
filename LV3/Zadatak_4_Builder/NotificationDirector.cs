using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_4_Builder
{
    class NotificationDirector
    {
        private NotificationManager builder;


        public NotificationDirector(NotificationManager builder) 
        {
            this.builder = builder;
        }

        public void CreateInfoNotification(string author) 
        {
            builder.SetAuthor(author)
                .SetTitle("Default info title")
                .SetText("Default title")
                .SetTime(DateTime.Now)
                .SetLevel(Category.INFO)
                .SetColor(ConsoleColor.White);
        }

        public void CreateAlertNotification(string author) 
        {
            builder.SetAuthor(author)
                .SetTitle("Default alert title")
                .SetText("Default title")
                .SetTime(DateTime.Now)
                .SetLevel(Category.ALERT)
                .SetColor(ConsoleColor.Yellow);
        }

        public void CreateErrorNotification(string author) 
        {
            builder.SetAuthor(author)
                .SetTitle("Default error title")
                .SetText("Default title")
                .SetTime(DateTime.Now)
                .SetLevel(Category.ERROR)
                .SetColor(ConsoleColor.Red);
        }
    }
}
