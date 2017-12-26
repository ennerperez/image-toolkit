using System;
using System.Drawing;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    public partial class FormCrop : Form
    {
        public FormCrop()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Program.Assembly.Location);
        }

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
            ImageChanged?.Invoke(this, e);

            numericUpDownX.Maximum = (decimal)(Image.PhysicalDimension.Width + 1);
            numericUpDownY.Maximum = (decimal)(Image.PhysicalDimension.Height + 1);
            numericUpDownWidth.Maximum = (decimal)(Image.PhysicalDimension.Width + 1);
            numericUpDownHeight.Maximum = (decimal)(Image.PhysicalDimension.Height + 1);

            imageCropControl.Bitmap = new Bitmap(Image);
        }

        private void ImageCropControl_CropRectangleChanged(object sender, EventArgs e)
        {
            if (Image != null)
            {
                numericUpDownX.Value = imageCropControl.CropRectangle.X;
                numericUpDownY.Value = imageCropControl.CropRectangle.Y;
                numericUpDownWidth.Value = imageCropControl.CropRectangle.Width;
                numericUpDownHeight.Value = imageCropControl.CropRectangle.Height;
            }
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            imageCropControl.CropRectangleChanged -= ImageCropControl_CropRectangleChanged;
            imageCropControl.CropRectangleChanged += ImageCropControl_CropRectangleChanged;
        }

        private void ButtonCrop_Click(object sender, EventArgs e)
        {
            buttonOk.Enabled = true;
            imageCropControl.Crop();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Image = imageCropControl.Bitmap;
            DialogResult = DialogResult.OK;
        }
    }
}