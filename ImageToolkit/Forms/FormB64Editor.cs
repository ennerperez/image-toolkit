﻿using Platform.Support;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    public partial class FormB64Editor : Form
    {
        public enum Mode
        {
            Open,
            Save
        }

        private string base64;

        public Image Image { get; set; }
        public Mode OpenMode { get; set; }

        public FormB64Editor(Mode mode = Mode.Save)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Program.Assembly.Location);

            // saveFileDialogB64
            saveFileDialogB64.DefaultExt = Program.Texts[0];

            OpenMode = mode;
            switch (OpenMode)
            {
                case Mode.Open:
                    buttonAction.Text = "&Process"; //TODO: Translate
                    break;

                case Mode.Save:
                    buttonAction.Text = "&Save..."; //TODO: Translate

                    break;

                default:
                    break;
            }
        }

        private void ButtonAction_Click(object sender, EventArgs e)
        {
            switch (OpenMode)
            {
                case Mode.Open:
                    try
                    {
                        if (!string.IsNullOrEmpty(textBoxB64.Text))
                        {
                            Image = Platform.Support.Drawing.ImageHelper.FromBase64(textBoxB64.Text.Replace("\r\n", ""));
                            DialogResult = DialogResult.OK;
                            if (Process != null)
                                Process.Invoke(this, new EventArgs());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case Mode.Save:
                    saveFileDialogB64.ShowDialog();
                    break;

                default:
                    break;
            }
        }

        private void SaveFileDialogB64_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                File.WriteAllText(saveFileDialogB64.FileName, textBoxB64.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormB64Editor_Load(object sender, EventArgs e)
        {
            numericUpDownColumns.Visible = OpenMode != Mode.Open;
            labelColumns.Visible = numericUpDownColumns.Visible;

            if (OpenMode != Mode.Open)
                try
                {
                    base64 = Platform.Support.Drawing.ImageHelper.ToBase64(Image);
                    NumericUpDownColumns_ValueChanged(sender, e);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
        }

        private void NumericUpDownColumns_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownColumns.Value > 0)
            {
                StringBuilder sb = new StringBuilder();
                int c = (int)numericUpDownColumns.Value;

                foreach (var item in base64.SpliceText(c))
                    sb.AppendLine(item);

                textBoxB64.Text = sb.ToString();
            }
            else
                textBoxB64.Text = base64;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public event EventHandler Process;
    }
}