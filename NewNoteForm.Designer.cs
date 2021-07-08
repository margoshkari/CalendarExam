
namespace CalendarExam
{
    partial class NewNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNoteForm));
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            resources.ApplyResources(this.titleTextBox, "titleTextBox");
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // noteTextBox
            // 
            resources.ApplyResources(this.noteTextBox, "noteTextBox");
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.TextChanged += new System.EventHandler(this.noteTextBox_TextChanged);
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // NewNoteForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Name = "NewNoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}