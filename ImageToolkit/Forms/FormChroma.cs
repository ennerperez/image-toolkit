using ImageMagick;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    public partial class FormChroma : Form
    {
        public FormChroma()
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

            pictureBoxImage.Image = new Bitmap(Image);
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Image = pictureBoxImage.Image;
            DialogResult = DialogResult.OK;
        }

        private void ButtonKey_Click(object sender, EventArgs e)
        {
            if (colorDialogKey.ShowDialog() == DialogResult.OK)
                buttonKey.BackColor = colorDialogKey.Color;
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            if (colorDialogKey.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = colorDialogKey.Color;
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            var image = new MagickImage(new Bitmap(this.Image))
            {
                ColorFuzz = new Percentage((Double)numericUpDownPercentage.Value)
            };
            image.TransparentChroma(new MagickColor(buttonKey.BackColor), new MagickColor(buttonColor.BackColor));
            pictureBoxImage.Image = image.ToBitmap(System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}