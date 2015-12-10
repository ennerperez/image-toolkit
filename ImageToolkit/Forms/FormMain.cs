using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Toolkit.Forms
{
    public partial class FormMain : Form
    {

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
            buttonToB64.Enabled = Image != null;
            buttonFromB64.Enabled = Image != null;
            buttonCrop.Enabled = Image != null;
            buttonSaveAs.Enabled = Image != null;
            buttonRestore.Enabled = Image != null;

            bufferedPanelPreview.BackgroundImage = Image;
            trackBarCompressRatio.Enabled = Image != null;

        }

        #endregion

        public static List<string> imageFiles = new List<string>(new string[] { ".jpg", ".jpeg", ".jpe", ".jfif", ".png", ".gif" });
        public static List<string> textFiles = new List<string>(new string[] { ".txt", ".bin", ".b64" });

        public FormMain()
        {
            InitializeComponent();

            openFileDialogImage.DefaultExt = imageFiles[0];

            openFileDialogImage.Filter = string.Format(openFileDialogImage.Filter,
                string.Join(", *", imageFiles.ToArray()),
                string.Join("; *", imageFiles.ToArray()),
                string.Join(", *", textFiles.ToArray()),
                string.Join("; *", textFiles.ToArray()));

            saveFileDialogImage.DefaultExt = imageFiles[0];

            saveFileDialogImage.Filter = string.Format(saveFileDialogImage.Filter,
                string.Join(", *", imageFiles.ToArray()),
                string.Join("; *", imageFiles.ToArray()));

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout _FormAbout = new FormAbout();
            _FormAbout.ShowDialog();
        }

        #region ImageLoader

        public delegate void AssignImageDlgt();
        protected void LoadImage()
        {
            var fi = new System.IO.FileInfo(lastFilename);
            if (textFiles.Contains(fi.Extension))
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

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            if (bufferedPanelPreview.BackgroundImage != null)
                saveFileDialogImage.ShowDialog();
        }

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Image = null;
            nextImage = null;
            if (getImageThread != null)
                getImageThread.Abort();
            trackBarCompressRatio.Value = 0;
            labelCompressRatioPercent.Text = trackBarCompressRatio.Value.ToString() + "%";
            //_cropping = false;
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            if (Image != null)
            {
                bufferedPanelPreview.BackgroundImage = Image;
            }
        }

        #region Drag & Drop

        private bool validData;
        private string lastFilename;
        private Thread getImageThread;
        private Bitmap nextImage;
        //private Bitmap image;
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

                        if (FormMain.imageFiles.Contains(ext) || FormMain.textFiles.Contains(ext))
                        {
                            ret = true;
                        }
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
            labelCompressRatioPercent.Text = trackBarCompressRatio.Value.ToString() + "%";
        }

        #endregion

        #region Base64

        private void buttonFromB64_Click(object sender, EventArgs e)
        {
            FormB64Editor editor = new FormB64Editor(FormB64Editor.Mode.Open);
            editor.StartPosition = FormStartPosition.Manual;
            editor.Height = this.Height;
            editor.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            editor.Process += (object s, EventArgs v) => bufferedPanelPreview.BackgroundImage = editor.Image;
            editor.Show();
        }

        private void buttonToB64_Click(object sender, EventArgs e)
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

        #endregion

        #region Cropping

        private void buttonCrop_Click(object sender, EventArgs e)
        {
            var crop = new FormCrop();
            crop.Image = bufferedPanelPreview.BackgroundImage;
            if (crop.ShowDialog() == DialogResult.OK)
            {
                bufferedPanelPreview.BackgroundImage = crop.Image;
            }
            
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


    }
}
