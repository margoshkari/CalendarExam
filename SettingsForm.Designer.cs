
namespace CalendarExam
{
    partial class SettingsForm
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
            this.languageLabel = new System.Windows.Forms.Label();
            this.backColorLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.languageLabel.Location = new System.Drawing.Point(43, 87);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(82, 20);
            this.languageLabel.TabIndex = 0;
            this.languageLabel.Text = "Language";
            // 
            // backColorLabel
            // 
            this.backColorLabel.AutoSize = true;
            this.backColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backColorLabel.Location = new System.Drawing.Point(43, 159);
            this.backColorLabel.Name = "backColorLabel";
            this.backColorLabel.Size = new System.Drawing.Size(87, 20);
            this.backColorLabel.TabIndex = 2;
            this.backColorLabel.Text = "BackColor";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "en-US",
            "ru",
            "uk"});
            this.languageComboBox.Location = new System.Drawing.Point(165, 87);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(121, 24);
            this.languageComboBox.TabIndex = 3;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(185, 159);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 5;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 297);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.backColorLabel);
            this.Controls.Add(this.languageLabel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label backColorLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Button colorButton;
    }
}