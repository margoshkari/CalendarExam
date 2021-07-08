using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewNoteForm form = new NewNoteForm();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
            if (Manager.notes.Count != 0)
            {
                notes.Add(new NoteControl(Manager.notes.Last().Text, Manager.notes.Last().NoteName, Manager.notes.Last().CreationData));
            }
            this.panel.Controls.Add(notes.Last());
        }
    }
}
