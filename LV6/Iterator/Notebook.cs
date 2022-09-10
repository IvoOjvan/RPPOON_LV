﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Notebook : IAbstractCollection
    {
        private List<Note> notes;
        public Notebook()
        {
            notes = new List<Note>();
        }
        public Notebook(List<Note> notes)
        {
            this.notes = new List<Note>(notes.ToArray());
        }

        public void AddNote(Note note)
        {
            this.notes.Add(note);
        }
        public void RemoveNote(Note note)
        { 
            for(int i = notes.Count - 1; i >= 0; i--) 
            {
                if(notes[i].Text == note.Text && notes[i].Title == note.Title) 
                {
                    notes.RemoveAt(i);
                }
            }
        }
        public void Clear()
        {
            notes.Clear();
        }
        public int Count { get { return this.notes.Count; } }
        public Note this[int index] { get { return this.notes[index]; } }
        public IAbstractIterator GetIterator() { return new Iterator(this); }
    }
}
