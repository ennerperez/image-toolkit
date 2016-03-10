using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Pictograms;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Toolkit.Forms
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();

            // openFileDialogImage
            openFileDialogImage.DefaultExt = Program.imageFiles[0];
            openFileDialogImage.Filter = string.Format(openFileDialogImage.Filter,
                string.Join(", *", Program.imageFiles.ToArray()),
                string.Join("; *", Program.imageFiles.ToArray()),
                string.Join(", *", Program.textFiles.ToArray()),
                string.Join("; *", Program.textFiles.ToArray()));

            // saveFileDialogImage
            saveFileDialogImage.DefaultExt = Program.imageFiles[0];
            saveFileDialogImage.Filter = string.Format(saveFileDialogImage.Filter,
                string.Join(", *", Program.imageFiles.ToArray()),
                string.Join("; *", Program.imageFiles.ToArray()));

            // Icons
            toolStripButtonOpen.Image = MaterialDesign.GetImage(MaterialDesign.IconType.folder_open, 48, Color.White);
            toolStripButtonClear.Image = MaterialDesign.GetImage(MaterialDesign.IconType.layers_clear, 48, Color.White);
            toolStripButtonCrop.Image = MaterialDesign.GetImage(MaterialDesign.IconType.crop, 48, Color.White);
            toolStripButtonRestore.Image = MaterialDesign.GetImage(MaterialDesign.IconType.restore, 48, Color.White);

            toolStripButtonToB64.Image = MaterialDesign.GetImage(MaterialDesign.IconType.keyboard_arrow_right, 48, Color.White);
            toolStripButtonFromB64.Image = MaterialDesign.GetImage(MaterialDesign.IconType.keyboard_arrow_left, 48, Color.White);

            toolStripButtonSave.Image = MaterialDesign.GetImage(MaterialDesign.IconType.save, 48, Color.White);

            toolStripButtonAbout.Image = MaterialDesign.GetImage(MaterialDesign.IconType.info, 48, Color.White);
            toolStripButtonClose.Image = MaterialDesign.GetImage(MaterialDesign.IconType.close, 48, Color.White);

            copyToolStripMenuItem.Image = MaterialDesign.GetImage(MaterialDesign.IconType.content_copy, 16, toolStripMenu.BackColor);
            pasteToolStripMenuItem.Image = MaterialDesign.GetImage(MaterialDesign.IconType.content_paste, 16, toolStripMenu.BackColor);

        }

        #region Properties & Events

        private Image _Image;
        public Image Image
        {
            get
            {
                return _Image;
            }
            set
            {
                _Image = value;
                OnImageChanged(EventArgs.Empty);
            }
        }

        public event EventHandler ImageChanged;

        private void OnImageChanged(EventArgs e)
        {
            if (ImageChanged != null)
                ImageChanged(this, e);

            labelDragDropPreview.Visible = Image == null;
            toolStripButtonToB64.Enabled = Image != null;
            toolStripButtonFromB64.Enabled = Image != null;
            toolStripButtonCrop.Enabled = Image != null;
            toolStripButtonSave.Enabled = Image != null;
            toolStripButtonRestore.Enabled = Image != null;

            bufferedPanelPreview.BackgroundImage = Image;
            //trackBarCompressRatio.Enabled = Image != null;

            toolStripButtonClear.Enabled = Image != null;

        }

        #endregion

        private void buttonAbout_Click(object sender, EventArgs e)
        {

        }

        #region ImageLoader

        public delegate void AssignImageDlgt();
        protected void LoadImage()
        {
            var fi = new System.IO.FileInfo(lastFilename);
            if (Program.textFiles.Contains(fi.Extension))
            {
                try
                {
                    var b64 = string.Join("", System.IO.File.ReadAllLines(lastFilename));
                    nextImage = new Bitmap(System.Drawing.Helpers.FromBase64(b64));
                    this.Invoke(new AssignImageDlgt(AssignImage));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                nextImage = new Bitmap(lastFilename);
                this.Invoke(new AssignImageDlgt(AssignImage));
            }

        }

        protected void AssignImage()
        {
            Image = nextImage;
        }

        #endregion

        #region Open

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogImage.ShowDialog();
        }

        private void openFileDialogImage_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                lastFilename = openFileDialogImage.FileName;
                LoadImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Save

 
        private void saveFileDialogImage_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var image = bufferedPanelPreview.BackgroundImage;
                image.Save(saveFileDialogImage.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Drag & Drop

        private bool validData;
        private string lastFilename;
        private Thread getImageThread;
        private Bitmap nextImage;

        protected bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;

            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileName") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();

                        if (Program.imageFiles.Contains(ext) || Program.textFiles.Contains(ext))
                            ret = true;
                    }
                }
            }
            return ret;
        }

        private void bufferedPanelPreview_DragDrop(object sender, DragEventArgs e)
        {
            if (validData)
            {
                while (getImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                Image = nextImage;
            }
        }

        private void bufferedPanelPreview_DragEnter(object sender, DragEventArgs e)
        {
            string filename;
            validData = GetFilename(out filename, e);
            if (validData)
            {
                if (lastFilename != filename)
                {
                    bufferedPanelPreview.BackgroundImage = null;
                    lastFilename = filename;
                    getImageThread = new Thread(new ThreadStart(LoadImage));
                    getImageThread.Start();
                }

                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        #endregion

        #region Compression

        private void trackBarCompressRatio_Scroll(object sender, EventArgs e)
        {
            //labelCompressRatioPercent.Text = trackBarCompressRatio.Value.ToString() + "%";
        }

        #endregion

        #region Clipboard

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Image = Clipboard.GetImage() as Bitmap;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bufferedPanelPreview.BackgroundImage != null)
            {
                Clipboard.SetImage(bufferedPanelPreview.BackgroundImage);
            }
        }

        private void contextMenuStripImage_Opening(object sender, CancelEventArgs e)
        {
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsImage();
            copyToolStripMenuItem.Enabled = bufferedPanelPreview.BackgroundImage != null;
        }
        
        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            var child = new FormAbout();
            child.ShowDialog();
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogImage.ShowDialog();
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            Image = null;
            nextImage = null;
            if (getImageThread != null)
                getImageThread.Abort();
            //trackBarCompressRatio.Value = 0;
            //labelCompressRatioPercent.Text = trackBarCompressRatio.Value.ToString() + "%";
        }

        private void toolStripButtonCrop_Click(object sender, EventArgs e)
        {
            var child = new FormCrop();
            child.Image = bufferedPanelPreview.BackgroundImage;
            if (child.ShowDialog() == DialogResult.OK)
                bufferedPanelPreview.BackgroundImage = child.Image;
        }

        private void toolStripButtonRestore_Click(object sender, EventArgs e)
        {
            if (Image != null)
                bufferedPanelPreview.BackgroundImage = Image;
        }

        private void toolStripButtonFromB64_Click(object sender, EventArgs e)
        {
            FormB64Editor editor = new FormB64Editor(FormB64Editor.Mode.Open);
            editor.StartPosition = FormStartPosition.Manual;
            editor.Height = this.Height;
            editor.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            editor.Process += (object s, EventArgs v) => bufferedPanelPreview.BackgroundImage = editor.Image;
            editor.Show();
        }

        private void toolStripButtonToB64_Click(object sender, EventArgs e)
        {
            if (bufferedPanelPreview.BackgroundImage != null)
            {
                FormB64Editor editor = new FormB64Editor(FormB64Editor.Mode.Save);
                editor.StartPosition = FormStartPosition.Manual;
                editor.Height = this.Height;
                editor.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                editor.Image = bufferedPanelPreview.BackgroundImage;
                editor.Show();
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (bufferedPanelPreview.BackgroundImage != null)
                saveFileDialogImage.ShowDialog();
        }
    }
}
