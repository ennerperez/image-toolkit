using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    public partial class FormChroma : Form
    {
        public FormChroma()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetEntryAssembly().Location);

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
            if (ImageChanged != null)
                ImageChanged(this, e);

            pictureBoxImage.Image  = new Bitmap(Image);
        }
 
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Image = pictureBoxImage.Image;
            DialogResult = DialogResult.OK;
        }

        private void buttonKey_Click(object sender, EventArgs e)
        {
            if (colorDialogKey.ShowDialog() == DialogResult.OK)
                buttonKey.BackColor = colorDialogKey.Color;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialogKey.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = colorDialogKey.Color;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            var image = new MagickImage(new Bitmap(this.Image));
            image.ColorFuzz = new Percentage((Double)numericUpDownPercentage.Value);
            image.TransparentChroma(new MagickColor(buttonKey.BackColor), new MagickColor(buttonColor.BackColor));
            pictureBoxImage .Image = image.ToBitmap( System.Drawing.Imaging.ImageFormat.Png);
            //image.Write("test_result.jpg");
        }
    }
}
