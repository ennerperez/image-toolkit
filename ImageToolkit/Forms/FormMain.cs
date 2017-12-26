﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Pictograms;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Pictograms;

namespace Toolkit.Forms
{
    public partial class FormMain : Form
    {
        private Image image;

        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                OnImageChanged(EventArgs.Empty);
            }
        }

        public FormMain()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetEntryAssembly().Location);

            // openFileDialogMain
            openFileDialogMain.DefaultExt = Program.imageFiles[0];

            // saveFileDialogMain
            saveFileDialogMain.DefaultExt = Program.imageFiles[0];

            // Icons
            toolStripButtonOpen.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.folder_open, 48, Color.White);
            toolStripButtonClear.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.layers_clear, 48, Color.White);
            toolStripButtonCrop.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.crop, 48, Color.White);
            toolStripButtonChromaKey.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.filter_frames, 48, Color.White);
            toolStripButtonRestore.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.restore, 48, Color.White);

            toolStripButtonToB64.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.keyboard_arrow_right, 48, Color.White);
            toolStripButtonFromB64.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.keyboard_arrow_left, 48, Color.White);

            toolStripButtonSave.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.save, 48, Color.White);

            toolStripButtonAbout.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.info, 48, Color.White);
            toolStripButtonClose.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.close, 48, Color.White);

            copyToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.content_copy, 16, toolStripMenu.BackColor);
            pasteToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.content_paste, 16, toolStripMenu.BackColor);

#if DEBUG
            FormHelper.ExtractResources(toolStripMenu);
#endif
        }

        #region Events

        public event EventHandler ImageChanged;

        private void OnImageChanged(EventArgs e)
        {
            ImageChanged?.Invoke(this, e);

            labelPreview.Visible = Image == null;
            toolStripButtonToB64.Enabled = Image != null;
            //toolStripButtonFromB64.Enabled = Image != null;
            toolStripButtonCrop.Enabled = Image != null;
            toolStripButtonChromaKey.Enabled = Image != null;
            toolStripButtonSave.Enabled = Image != null;
            toolStripButtonRestore.Enabled = Image != null;

            bufferedPanelPreview.BackgroundImage = Image;
            //trackBarCompressRatio.Enabled = Image != null;

            toolStripButtonClear.Enabled = Image != null;
        }

        #endregion Events

        public delegate void AssignImageDelegate();

        protected void AssignImage()
        {
            Image = nextImage;
        }

        #region Drag & Drop

        private bool validData;
        private Thread getFileThread;
        private Bitmap nextImage;

        private bool GetFileName(out string filename, DragEventArgs e)
        {
            var ret = false;
            filename = string.Empty;

            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                if (((IDataObject)e.Data).GetData("FileName") is Array data && ((data.Length == 1) && (data.GetValue(0) is string)))
                {
                    filename = ((string[])data)[0];
                    var ext = Path.GetExtension(filename).ToLower();
                    ret = (Program.imageFiles.Contains(ext) || Program.textFiles.Contains(ext));
                }
            }
            return ret;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            if (validData)
            {
                while (getFileThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                Image = nextImage;
            }
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            var fileName = string.Empty;
            validData = GetFileName(out fileName, e);
            if (validData && !string.IsNullOrEmpty(fileName))
            {
                bufferedPanelPreview.BackgroundImage = null;
                getFileThread = new Thread(new ParameterizedThreadStart(LoadFile));
                getFileThread.Start(fileName);

                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        #endregion Drag & Drop

        #region Clipboard

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
                Image = Clipboard.GetImage() as Bitmap;
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bufferedPanelPreview.BackgroundImage != null)
                Clipboard.SetImage(bufferedPanelPreview.BackgroundImage);
        }

        private void ContextMenuStripImage_Opening(object sender, CancelEventArgs e)
        {
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsImage();
            copyToolStripMenuItem.Enabled = bufferedPanelPreview.BackgroundImage != null;
        }

        #endregion Clipboard

        private void LoadFile(object item)
        {
            var fi = new FileInfo(item.ToString());
            if (Program.textFiles.Contains(fi.Extension))
            {
                try
                {
                    var b64 = string.Join("", File.ReadAllLines(item.ToString()));
                    nextImage = new Bitmap(Platform.Support.Drawing.ImageHelper.FromBase64(b64));
                    this.Invoke(new AssignImageDelegate(AssignImage));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                nextImage = new Bitmap(item.ToString());
                this.Invoke(new AssignImageDelegate(AssignImage));
            }
        }

        private void DisplayChild(Form child, int factor = 0)
        {
            if (factor > 0)
            {
                child.Width = this.Width * factor;
                child.Height = this.Height;
            }
            child.StartPosition = FormStartPosition.Manual;
            if (this.DesktopLocation.X > (FormHelper.GetWorkingArea().Width / 2))
                child.Location = new Point(this.Location.X - child.Width - this.Padding.Left, this.Location.Y);
            else
                child.Location = new Point(this.Location.X + this.Width + this.Padding.Left, this.Location.Y);
            child.Show();
        }

        private void OpenFileDialogMain_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                LoadFile(openFileDialogMain.FileName);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFileDialogMain_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var image = bufferedPanelPreview.BackgroundImage;
                image.Save(saveFileDialogMain.FileName);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region ToolStrip

        private void ToolStripButtonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogMain.ShowDialog();
        }

        private void ToolStripButtonClear_Click(object sender, EventArgs e)
        {
            Image = null;
            nextImage = null;
            if (getFileThread != null)
                getFileThread.Abort();
        }

        private void ToolStripButtonChromaKey_Click(object sender, EventArgs e)
        {
            var child = new FormChroma
            {
                Image = bufferedPanelPreview.BackgroundImage
            };
            if (child.ShowDialog() == DialogResult.OK)
                bufferedPanelPreview.BackgroundImage = child.Image;
        }

        private void ToolStripButtonCrop_Click(object sender, EventArgs e)
        {
            var child = new FormCrop
            {
                Image = bufferedPanelPreview.BackgroundImage
            };
            if (child.ShowDialog() == DialogResult.OK)
                bufferedPanelPreview.BackgroundImage = child.Image;
        }

        private void ToolStripButtonRestore_Click(object sender, EventArgs e)
        {
            if (Image != null)
                bufferedPanelPreview.BackgroundImage = Image;
        }

        private void ToolStripButtonFromB64_Click(object sender, EventArgs e)
        {
            var editor = new FormB64Editor(FormB64Editor.Mode.Open);
            editor.Process += (object s, EventArgs v) => bufferedPanelPreview.BackgroundImage = editor.Image;
            DisplayChild(editor, 1);
        }

        private void ToolStripButtonToB64_Click(object sender, EventArgs e)
        {
            if (bufferedPanelPreview.BackgroundImage != null)
            {
                var editor = new FormB64Editor(FormB64Editor.Mode.Save)
                {
                    Image = bufferedPanelPreview.BackgroundImage
                };
                DisplayChild(editor, 1);
            }
        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (bufferedPanelPreview.BackgroundImage != null)
                saveFileDialogMain.ShowDialog();
        }

        private void ToolStripButtonAbout_Click(object sender, EventArgs e)
        {
            var child = new FormAbout();
            child.ShowDialog();
        }

        private void ToolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion ToolStrip

        private async void FormMain_Load(object sender, System.EventArgs e)
        {
            await GitHubInfo.CheckForUpdateAsync();
        }
    }
}