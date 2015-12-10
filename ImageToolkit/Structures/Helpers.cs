using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace System
{
    public static class Helpers
    {
        public static String[] SpliceText(string text, int lineLength)
        {
            var maches = Regex.Matches(text, ".{1," + lineLength + "}");
            List<string> result = new List<string>();
            foreach (Match item in maches)
            {
                result.Add(item.Value);
            }

            return result.ToArray();
        }
    }

    namespace Drawing
    {
        public static class Helpers
        {

            public static System.Drawing.Image FromBase64(string source)
            {
                System.IO.MemoryStream memStream = new System.IO.MemoryStream(Convert.FromBase64String(source));
                System.Drawing.Image result = System.Drawing.Image.FromStream(memStream);
                memStream.Close();
                return result;
            }

            public static string ToBase64(System.Drawing.Image source, System.Drawing.Imaging.ImageFormat imageFormat = null)
            {
                System.IO.MemoryStream memStream = new System.IO.MemoryStream();
                if (imageFormat == null)
                    imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                source.Save(memStream, imageFormat);
                string result = Convert.ToBase64String(memStream.ToArray());
                memStream.Close();
                return result;
            }

            public static Image Crop(Image image, Rectangle selection)
            {
                try
                {


                    Bitmap bmp = image as Bitmap;

                    // Check if it is a bitmap:
                    if (bmp == null)
                        throw new ArgumentException("No valid bitmap");

                    // Crop the image:
                    Bitmap cropBmp = bmp.Clone(selection, bmp.PixelFormat);

                    // Release the resources:
                    image.Dispose();

                    return cropBmp;
                }
                catch (Exception)
                {
                    return image;
                }
            }

            public static Image Fit2Control(Image image, Control container)
            {
                Bitmap bmp = null;
                Graphics g;

                // Scale:
                double scaleY = (double)image.Width / container.Width;
                double scaleX = (double)image.Height / container.Height;
                double scale = scaleY < scaleX ? scaleX : scaleY;

                // Create new bitmap:
                bmp = new Bitmap(
                    (int)((double)image.Width / scale),
                    (int)((double)image.Height / scale));

                // Set resolution of the new image:
                bmp.SetResolution(
                    image.HorizontalResolution,
                    image.VerticalResolution);

                // Create graphics:
                g = Graphics.FromImage(bmp);

                // Set interpolation mode:
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                // Draw the new image:
                g.DrawImage(
                    image,
                    new Rectangle(            // Destination
                        0, 0,
                        bmp.Width, bmp.Height),
                    new Rectangle(            // Source
                        0, 0,
                        image.Width, image.Height),
                    GraphicsUnit.Pixel);

                // Release the resources of the graphics:
                g.Dispose();

                // Release the resources of the origin image:
                image.Dispose();

                return bmp;
            }
        }
    }
}
