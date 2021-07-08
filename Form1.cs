﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
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
                    notes.ForEach(item => item.Visible = false);
                    notes.First().Visible = true;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewNoteForm form = new NewNoteForm();
            form.ShowDialog();

            if (Manager.notes.Count != 0)
                notes.Add(new NoteControl(Manager.notes.Last().Text, Manager.notes.Last().NoteName, Manager.notes.Last().Date));

            this.panel.Controls.Add(notes.Last());
        }
    }
}
