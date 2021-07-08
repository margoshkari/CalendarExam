using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Note
    {
        public string NoteName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Note()
        {
            NoteName = string.Empty;
            Text = string.Empty;
            Date = new DateTime();
        }

        public Note(string noteName, string text, DateTime creationData)
        {
            Text = text;
            NoteName = noteName;
            Date = creationData;
        }
    }
}
