using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            saveFileDialogB64.DefaultExt = FormMain.textFiles[0];
            saveFileDialogB64.Filter = string.Format(saveFileDialogB64.Filter,
                string.Join(", *", FormMain.textFiles.ToArray()),
                string.Join("; *", FormMain.textFiles.ToArray()));

            OpenMode = mode;
            switch (OpenMode)
            {
                case Mode.Open:
                    buttonAction.Text = "&Process";
                    break;
                case Mode.Save:
                    buttonAction.Text = "&Save...";

                    break;
                default:
                    break;
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            switch (OpenMode)
            {
                case Mode.Open:
                    try
                    {
                        if (!string.IsNullOrEmpty(textBoxB64.Text))
                        {
                            Image = System.Drawing.Helpers.FromBase64(textBoxB64.Text);
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

        private void saveFileDialogB64_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText(saveFileDialogB64.FileName, textBoxB64.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormB64Editor_Load(object sender, EventArgs e)
        {

            numericUpDownColumns.Visible = OpenMode != Mode.Open;
            labelColumns.Visible = numericUpDownColumns.Visible;

            if (OpenMode != Mode.Open)
            {
                try
                {
                    base64 = System.Drawing.Helpers.ToBase64(Image);
                    numericUpDownColumns_ValueChanged(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        private void numericUpDownColumns_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownColumns.Value > 0)
            {
                StringBuilder sb = new StringBuilder();
                int c = (int)numericUpDownColumns.Value;

                foreach (var item in System.Helpers.SpliceText(base64, c))
                {
                    sb.AppendLine(item);
                }

                //for (int i = 0; i < base64.Length; i = i + 1 +c)
                //{
                //    if (base64.Substring(i).Length >= c)
                //    {
                //        sb.AppendLine(base64.Substring(i, c));
                //    }
                //    else
                //    {
                //        sb.AppendLine(base64.Substring(i));
                //    }
                //}

                textBoxB64.Text = sb.ToString();
            }
            else
            {
                textBoxB64.Text = base64;
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        public event EventHandler Process;

    }
}
