using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak 1.
            Notebook notebook = new Notebook();
            notebook.AddNote(new Note("title1", "text1"));
            notebook.AddNote(new Note("title2", "text2"));
            notebook.AddNote(new Note("title3", "text3"));

            Iterator iterator = (Iterator)notebook.GetIterator();

            for(Note note = iterator.First(); iterator.IsDone == false; note = iterator.Next()) 
            {
                note.Show();
            }

            //Zadatak 2.

        }
    }
}
