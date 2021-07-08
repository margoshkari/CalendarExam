using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Manager
    {
        public static List<Note> notes { get; private set; } = new List<Note>();


        public static void CreateNote(string noteName, string text, DateTime date)
        {
            notes.Add(new Note(noteName, text, date));
        }
        public static string TakeTextNote(string notename)
        {
            return notes.Find(x => x.NoteName == notename).Text;
        }
        public static void DeleteNote(string noteName)
        {
            if(notes.FindIndex(item => item.NoteName == noteName) != null)
                notes.RemoveAt(notes.FindIndex(item => item.NoteName == noteName));
        }
        public static void SaveAllNotes(string path)
        {

            if (path.EndsWith(".txt"))
            {
                NoteFileOperations.SaveNotes(path, notes.ToArray());
            }
            else
            {
                path += ".txt";
                NoteFileOperations.SaveNotes(path, notes.ToArray());
            }
        }
        public static void SaveNote(string noteName, string path)
        {
            NoteFileOperations.SaveNote(path, notes.Find(item => item.NoteName == noteName));
        }
        public static void ReadNotesFromFile(string path)
        {
            notes = NoteFileOperations.ReadFromFile(path);
        }
    }
}
