using System;
using System.Windows.Forms;
using Logic;

namespace CalendarExam
{
    public partial class NewNoteForm : Form
    {
        public NewNoteForm()
        {
            InitializeComponent();
            this.FormClosed += NewNoteForm_FormClosed;
        }

        private void NewNoteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.SaveAllNotes("AllNotes.txt");
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            Manager.CreateNote(this.titleTextBox.Text, this.noteTextBox.Text, this.dateTimePicker.Value);
        }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Manager.notes.Find(item => item.NoteName == this.titleTextBox.Text) != null)
                Manager.notes.Find(item => item.NoteName == this.titleTextBox.Text).Text = this.noteTextBox.Text;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (Manager.notes.Find(item => item.NoteName == this.titleTextBox.Text) != null)
                Manager.notes.Find(item => item.NoteName == this.titleTextBox.Text).Date = this.dateTimePicker.Value;
        }
    }
}
