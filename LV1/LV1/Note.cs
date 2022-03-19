using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    class Note
    {
        public string Content { get; private set; }
        public string Author { get; }
        public int PriorityLevel { get; private set; }

        public Note(string content, string author, int priorityLevel) 
        {
            Content = content;
            Author = author;
            PriorityLevel = priorityLevel;
        }

        public Note() : this("", "", 1) { }

        public Note(string content, string author) 
        {
            Content = content;
            Author = author;
            PriorityLevel = 1;
        }

        public void SetContent(string content) 
        {
            Content = content;
        }

        public void SetPriorityLevel(int priorityLevel) 
        {
            PriorityLevel = priorityLevel;
        }

        
    }
}
