﻿using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace CalendarExam
{
    public partial class SettingsForm : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
        private CultureInfo ci;
        private string language = string.Empty;
        public SettingsForm()
        {
            InitializeComponent();
            ci = new CultureInfo(File.ReadAllText("language.txt"));
            this.languageComboBox.Text = ci.ToString();
            ChangeLanguage();
        }
        private void ChangeLanguage()
        {
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, ci);
            }
            resources.ApplyResources(this, "$this");
        }
        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ci = new CultureInfo(languageComboBox.SelectedItem.ToString());
            language = ci.ToString();
            File.WriteAllText("language.txt", language);
            ChangeLanguage();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            using(ColorDialog dialog = new ColorDialog())
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = dialog.Color;
                    File.WriteAllText("BackColor.txt", $"{dialog.Color.A}:{dialog.Color.R}:{dialog.Color.G}:{dialog.Color.B}");
                }
            }
        }
    }
}
