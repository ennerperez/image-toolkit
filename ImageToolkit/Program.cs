using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Pictograms;
using System.IO;
using System.Windows.Forms;

namespace Toolkit
{
    static class Program
    {

        internal static List<string> imageFiles = new List<string>(new string[] { ".jpg", ".jpeg", ".jpe", ".jfif", ".png", ".gif" });
        internal static List<string> textFiles = new List<string>(new string[] { ".txt", ".bin", ".b64" });

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

#if DEBUG
            Bitmap bmp = new Bitmap(256, 256);
            using (Graphics gfx = Graphics.FromImage(bmp))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(43, 43, 43)))
            {
                gfx.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
                var img = MaterialDesign.GetImage(MaterialDesign.IconType.image, 256, Color.White);
                gfx.DrawImage(img, 0, 0);
            }

            bmp.Save(@"..\..\..\.editoricon.png");
            ImagingHelper.ConvertToIcon(@"..\..\..\.editoricon.png", @"..\..\App.ico", 256, true);
            
#endif

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormMain());
        }
    }

#if DEBUG

    /// <summary>
    /// Provides helper methods for imaging
    /// </summary>
    public static class ImagingHelper
    {
        /// <summary>
        /// Converts a PNG image to a icon (ico)
        /// </summary>
        /// <param name="input">The input stream</param>
        /// <param name="output">The output stream</param>
        /// <param name="size">The size (16x16 px by default)</param>
        /// <param name="preserveAspectRatio">Preserve the aspect ratio</param>
        /// <returns>Wether or not the icon was succesfully generated</returns>
        public static bool ConvertToIcon(Stream input, Stream output, int size = 16, bool preserveAspectRatio = false)
        {
            Bitmap inputBitmap = (Bitmap)Bitmap.FromStream(input);
            if (inputBitmap != null)
            {
                int width, height;
                if (preserveAspectRatio)
                {
                    width = size;
                    height = inputBitmap.Height / inputBitmap.Width * size;
                }
                else
                {
                    width = height = size;
                }
                Bitmap newBitmap = new Bitmap(inputBitmap, new Size(width, height));
                if (newBitmap != null)
                {
                    // save the resized png into a memory stream for future use
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        newBitmap.Save(memoryStream, ImageFormat.Png);

                        BinaryWriter iconWriter = new BinaryWriter(output);
                        if (output != null && iconWriter != null)
                        {
                            // 0-1 reserved, 0
                            iconWriter.Write((byte)0);
                            iconWriter.Write((byte)0);

                            // 2-3 image type, 1 = icon, 2 = cursor
                            iconWriter.Write((short)1);

                            // 4-5 number of images
                            iconWriter.Write((short)1);

                            // image entry 1
                            // 0 image width
                            iconWriter.Write((byte)width);
                            // 1 image height
                            iconWriter.Write((byte)height);

                            // 2 number of colors
                            iconWriter.Write((byte)0);

                            // 3 reserved
                            iconWriter.Write((byte)0);

                            // 4-5 color planes
                            iconWriter.Write((short)0);

                            // 6-7 bits per pixel
                            iconWriter.Write((short)32);

                            // 8-11 size of image data
                            iconWriter.Write((int)memoryStream.Length);

                            // 12-15 offset of image data
                            iconWriter.Write((int)(6 + 16));

                            // write image data
                            // png data must contain the whole png data file
                            iconWriter.Write(memoryStream.ToArray());

                            iconWriter.Flush();

                            return true;
                        }
                    }
                }
                return false;
            }
            return false;
        }

        /// <summary>
        /// Converts a PNG image to a icon (ico)
        /// </summary>
        /// <param name="inputPath">The input path</param>
        /// <param name="outputPath">The output path</param>
        /// <param name="size">The size (16x16 px by default)</param>
        /// <param name="preserveAspectRatio">Preserve the aspect ratio</param>
        /// <returns>Wether or not the icon was succesfully generated</returns>
        public static bool ConvertToIcon(string inputPath, string outputPath, int size = 16, bool preserveAspectRatio = false)
        {
            using (FileStream inputStream = new FileStream(inputPath, FileMode.Open))
            using (FileStream outputStream = new FileStream(outputPath, FileMode.OpenOrCreate))
            {
                return ConvertToIcon(inputStream, outputStream, size, preserveAspectRatio);
            }
        }
    }

#endif

}
