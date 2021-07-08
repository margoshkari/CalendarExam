using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Logic;

namespace CalendarExam
{
    public partial class Form1 : Form
    {
        List<NoteControl> notes = new List<NoteControl>();
        string searchingNoteName = string.Empty;
        NoteControl selectedNote = new NoteControl();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
            this.panel.Click += Form1_Click;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.SaveAllNotes("AllNotes.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("AllNotes.txt"))
            {
                Manager.ReadNotesFromFile("AllNotes.txt");
                for (int i = 0; i < Manager.notes.Count; i++)
                {
                    this.notes.Add(new NoteControl(Manager.notes[i].Text, Manager.notes[i].NoteName, Manager.notes[i].Date));
                }
                if (Manager.notes.Count != 0)
                {
                    this.panel.Controls.AddRange(notes.ToArray());
                    notes.All(item => item.Visible = false);
                    notes.First().Visible = true;
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            selectedNote = notes.Find(item => item.Visible == true);
            this.deleteButton.Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewNoteForm form = new NewNoteForm();
            form.ShowDialog();

            if (Manager.notes.Count != 0)
                notes.Add(new NoteControl(Manager.notes.Last().Text, Manager.notes.Last().NoteName, Manager.notes.Last().Date));

            this.panel.Controls.Add(notes.Last());
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            int index = notes.FindIndex(item => item.Visible == true);
            if(index - 1 >= 0)
            {
                notes[index].Visible = false;
                notes[--index].Visible = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int index = notes.FindIndex(item => item.Visible == true);
            if (index + 1 < notes.Count())
            {
                notes[index].Visible = false;
                notes[++index].Visible = true;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchingNoteName = this.searchTextBox.Text; 
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int index = notes.FindIndex(item => item.Visible == true);
            notes[index].Visible = false;
            index = notes.FindIndex(item => item.TitleLabel.Text == searchingNoteName);
            if (index != -1)
            {
                notes[index].Visible = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(notes.FindIndex(item => item.TitleLabel.Text == selectedNote.TitleLabel.Text) != -1)
            {
                notes.RemoveAt(notes.FindIndex(item => item.TitleLabel.Text == selectedNote.TitleLabel.Text));
                Manager.notes.RemoveAt(Manager.notes.FindIndex((item => item.NoteName == selectedNote.TitleLabel.Text)));
            }
            this.deleteButton.Visible = false;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (notes.Find(item => item.TimeLabel.Text == this.monthCalendar.SelectionStart.ToString()) == null)
                MessageBox.Show("Not found");
            else
            {
                notes.All(item => item.Visible = false);
                notes.Find(item => item.TimeLabel.Text.Equals(this.monthCalendar.SelectionRange.End.ToString())).Visible = true;
            }
        }
    }
}
