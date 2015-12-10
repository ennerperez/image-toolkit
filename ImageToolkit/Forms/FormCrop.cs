using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    public partial class FormCrop : Form
    {
        public FormCrop()
        {
            InitializeComponent();
        }

        private Bitmap _Image;

        public Bitmap Image
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


            numericUpDownX.Maximum = (decimal)(Image.PhysicalDimension.Width + 1);
            numericUpDownY.Maximum = (decimal)(Image.PhysicalDimension.Height + 1);
            numericUpDownWidth.Maximum = (decimal)(Image.PhysicalDimension.Width + 1);
            numericUpDownHeight.Maximum = (decimal)(Image.PhysicalDimension.Height + 1);

            imageCropControl.Bitmap = this.Image;

        }

        private void imageCropControl_CropRectangleChanged(object sender, EventArgs e)
        {
            if (Image != null)
            {
                numericUpDownX.Value = imageCropControl.CropRectangle.X;
                numericUpDownY.Value = imageCropControl.CropRectangle.Y;
                numericUpDownWidth.Value = imageCropControl.CropRectangle.Width;
                numericUpDownHeight.Value = imageCropControl.CropRectangle.Height;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

            imageCropControl.CropRectangleChanged -= imageCropControl_CropRectangleChanged;
            
            //Rectangle cropRectangle = new Rectangle(
            //    (int)(numericUpDownX.Value),
            //    (int)(numericUpDownY.Value),
            //    (int)(numericUpDownWidth.Value),
            //    (int)(numericUpDownHeight.Value));
            //imageCropControl.CropRectangle = cropRectangle;
            
            imageCropControl.CropRectangleChanged += imageCropControl_CropRectangleChanged;

        }

        private void buttonCrop_Click(object sender, EventArgs e)
        {
            buttonOk.Enabled = true;
            imageCropControl.Crop();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Image = imageCropControl.Bitmap;
            DialogResult = DialogResult.OK;
        }
    }
}
