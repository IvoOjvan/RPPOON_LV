using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_4_Builder
{
    class NotificationManager : IBuilder
    {
        private string author;
        private ConsoleColor color;
        private Category level;
        private string text;
        private DateTime time;
        private string title;
        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, time, level, color);
        }

        public IBuilder SetAuthor(string author)
        {
            this.author = author; return this;
        }

        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color; return this;
        }

        public IBuilder SetLevel(Category level)
        {
            this.level = level; return this;
        }

        public IBuilder SetText(string text)
        {
            this.text = text; return this;
        }

        public IBuilder SetTime(DateTime time)
        {
            this.time = time; return this;
        }

        public IBuilder SetTitle(string title)
        {
            this.title = title; return this;
        }
    }
}
