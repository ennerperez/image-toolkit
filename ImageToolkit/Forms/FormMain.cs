using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Pictograms;
using System.IO;
using System.Linq;
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
                if (image != value)
                {
                    image = value;
                    OnImageChanged(EventArgs.Empty);
                }
            }
        }

        public FormMain()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Program.Assembly.Location);

            // openFileDialogMain
            openFileDialogMain.DefaultExt = Program.Formats.FirstOrDefault();

            // saveFileDialogMain
            saveFileDialogMain.DefaultExt = Program.Formats.FirstOrDefault();

            // Icons
            toolStripButtonFile.SetImage(MaterialDesign.Instance, Program.Icon, 48, SystemColors.Control);

            newToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.insert_drive_file, 48, toolStripMenu.BackColor);
            openToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.folder_open, 48, toolStripMenu.BackColor);
            saveToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.save, 48, toolStripMenu.BackColor);
            saveAsToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.save, 48, toolStripMenu.BackColor);

            toolStripButtonClear.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.layers_clear, 48, SystemColors.Control);
            toolStripButtonCrop.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.crop, 48, SystemColors.Control);
            toolStripButtonChromaKey.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.filter_frames, 48, SystemColors.Control);
            toolStripButtonRestore.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.restore, 48, SystemColors.Control);

            toolStripButtonToB64.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.keyboard_arrow_right, 48, SystemColors.Control);
            toolStripButtonFromB64.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.keyboard_arrow_left, 48, SystemColors.Control);

            toolStripButtonUpdates.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.system_update_alt, 48, SystemColors.Control);

            toolStripButtonAbout.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.info, 48, SystemColors.Control);
            toolStripButtonClose.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.close, 48, SystemColors.Control);

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
            saveAsToolStripMenuItem.Enabled = Image != null;
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
                    ret = (Program.Formats.Contains(ext) || Program.Texts.Contains(ext));
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
            if (Program.Texts.Contains(fi.Extension))
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

        private async void FormMain_Load(object sender, EventArgs e)
        {
            toolStripButtonUpdates.Checked = Properties.Settings.Default.CheckForUpdates;

            if (Properties.Settings.Default.CheckForUpdates)
                await GitHubInfo.CheckForUpdateAsync();
        }

        private void ToolStripButtonUpdates_Click(object sender, EventArgs e)
        {
            var checkForUpdates = !toolStripButtonUpdates.Checked;
            toolStripButtonUpdates.Checked = checkForUpdates;
            Properties.Settings.Default.CheckForUpdates = checkForUpdates;
            Properties.Settings.Default.Save();
        }

        private void ToolStripButtonNew_Click(object sender, EventArgs e)
        {
        }

        private void ToolStripButtonPrint_Click(object sender, EventArgs e)
        {
        }

        private void ToolStripButtonExport_Click(object sender, EventArgs e)
        {
        }
    }
}