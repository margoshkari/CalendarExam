using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarExam
{
    public class NoteControl : Control
    {

        private Label TitleLabel;
        private Label TextLabel;
        private Label TimeLabel;
        private string SelectedNote;
        public NoteControl()
        {
            TitleLabel = new Label();
            TextLabel = new Label();
            TimeLabel = new Label();

            SelectedNote = string.Empty;

            this.Click += NoteControl_Click;
        }

        private void NoteControl_Click(object sender, EventArgs e)
        {
            SelectedNote = this.TitleLabel.Text;
        }

        public NoteControl(string text, string name, DateTime time) : this()
        {
            this.Name = name;
            this.BackColor = Color.LightGray;
            this.Location = new Point(50, 70);
            this.Size = new Size(150, 100);
            this.Visible = true;

            TitleLabel.Text = name;
            TitleLabel.BackColor = Color.Gray;
            TitleLabel.Font = new Font("Times New Roman", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TitleLabel.Size = new Size(this.Width, 40);
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Visible = true;

            TextLabel.Text = text;
            TextLabel.Font = new Font("Times New Roman", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TextLabel.Size = new Size(this.Width, 80);
            TextLabel.Location = new Point(0, 40);
            TextLabel.Visible = true;

            TimeLabel.Text = time.Date.ToString();
            TimeLabel.Font = new Font("Times New Roman", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TimeLabel.Size = new Size(this.Width, 20);
            TimeLabel.Location = new Point(0, 120);
            TimeLabel.Visible = true;


            this.Controls.Add(TitleLabel);
            this.Controls.Add(TextLabel);
            this.Controls.Add(TimeLabel);
        }
    }
}
