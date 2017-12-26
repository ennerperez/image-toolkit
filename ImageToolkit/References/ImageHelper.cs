using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace Platform.Support.Drawing
{
    public static partial class ImageHelper
    {
        public static Image FromFile(string filename, bool safe = true)
        {
            if (safe)
            {
                using (var sourceImage = (Bitmap)Image.FromFile(filename))
                {
                    var targetImage = new Bitmap(sourceImage.Width, sourceImage.Height,
                      sourceImage.PixelFormat);
                    var sourceData = sourceImage.LockBits(
                      new Rectangle(0, 0, sourceImage.Width, sourceImage.Height),
                      ImageLockMode.ReadOnly, sourceImage.PixelFormat);
                    var targetData = targetImage.LockBits(
                      new Rectangle(0, 0, sourceImage.Width, sourceImage.Height),
                      ImageLockMode.WriteOnly, targetImage.PixelFormat);
                    NativeMethods.CopyMemory(targetData.Scan0, sourceData.Scan0,
                      (uint)sourceData.Stride * (uint)sourceData.Height);
                    sourceImage.UnlockBits(sourceData);
                    targetImage.UnlockBits(targetData);
                    try
                    {
                        targetImage.Palette = sourceImage.Palette;
                    }
                    catch
                    {
                    }

                    return targetImage;
                }
            }
            else
            {
                return Image.FromFile(filename);
            }
        }

        public static Image FromURI(Uri uri)
        {
            Image _return;

            System.Net.HttpWebRequest _HttpWebRequest = null;
            System.Net.HttpWebResponse _HttpWebResponse = null;

            System.IO.Stream _Stream = null;

            try
            {
                _HttpWebRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(uri);
                _HttpWebRequest.AllowWriteStreamBuffering = true;

                _HttpWebResponse = (System.Net.HttpWebResponse)_HttpWebRequest.GetResponse();
                _Stream = _HttpWebResponse.GetResponseStream();
                _return = Image.FromStream(_Stream);
            }
            finally
            {
                _Stream.Close();
                _HttpWebResponse.Close();
            }
            return _return;
        }

        public static Image FromURL(string url)
        {
            return FromURI(new Uri(url));
        }

        public static Image FromBytes(byte[] data)
        {
            Image _return;

            try
            {
                if (data == null)
                {
                    throw new ArgumentNullException("Image Binary Data Cannot be Null or Empty", "data");
                }
                _return = Image.FromStream(new System.IO.MemoryStream(data));
            }
            catch
            {
                _return = null;
            }

            return _return;
        }

        public static byte[] ToBytes(Image source)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (source != null)
            {
                source.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
            else
            {
                return null;
            }
        }

        #region Base64

        public static Image FromBase64(string source)
        {
            System.IO.MemoryStream memStream = new System.IO.MemoryStream(Convert.FromBase64String(source));
            Image result = Image.FromStream(memStream);
            memStream.Close();
            memStream = null;
            return result;
        }

        public static string ToBase64(Image source, ImageFormat imageFormat = null)
        {
            System.IO.MemoryStream memStream = new System.IO.MemoryStream();
            if (imageFormat == null)
                imageFormat = ImageFormat.Jpeg;
            source.Save(memStream, imageFormat);
            string result = Convert.ToBase64String(memStream.ToArray());
            memStream.Close();
            memStream = null;
            return result;
        }

        public static string ToBase64ImageTag(Image source, ImageFormat imageFormat = null)
        {
            string imgTag = string.Empty;
            string base64String = string.Empty;

            base64String = source.ToBase64(imageFormat);

            imgTag = "<img src=\"data:image/" + imageFormat.ToString() + ";base64,";
            imgTag += base64String + "\" ";
            imgTag += "width=\"" + source.Width.ToString() + "\" ";
            imgTag += "height=\"" + source.Height.ToString() + "\" />";

            return imgTag;
        }

        #endregion Base64

        public static Color GetDominantColor(Image source)
        {
            int totalR = 0;
            int totalG = 0;
            int totalB = 0;

            Bitmap bmp = new Bitmap(source);

            for (int x = 0; x <= source.Width - 1; x++)
            {
                for (int y = 0; y <= source.Height - 1; y++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    totalR += pixel.R;
                    totalG += pixel.G;
                    totalB += pixel.B;
                }
            }

            int totalPixels = source.Height * source.Width;
            int averageR = totalR / totalPixels;
            int averageg = totalG / totalPixels;
            int averageb = totalB / totalPixels;
            return Color.FromArgb(averageR, averageg, averageb);
        }

        public static Color[] GetPalette(Image image)
        {
            List<Color> colors;
            using (var b = new Bitmap(image))
            {
                var bd = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                byte[] arr = new byte[bd.Width * bd.Height * 3];
                colors = new List<Color>();
                Marshal.Copy(bd.Scan0, arr, 0, arr.Length);
                b.UnlockBits(bd);

                for (int i = 0; i < ((bd.Width * bd.Height)); i++)
                {
                    var start = i * 3;
                    colors.Add(Color.FromArgb(arr[start], arr[start + 1], arr[start + 2]));
                }
            }

            return colors.ToArray();
        }

        public static bool DrawAdjustedImage(Image img, ColorMatrix cm)
        {
            try
            {
                Bitmap bmp = new Bitmap(img);
                // create a copy of the source image
                ImageAttributes imgattr = new ImageAttributes();
                Rectangle rc = new Rectangle(0, 0, img.Width, img.Height);
                Graphics g = Graphics.FromImage(img);

                // associate the ColorMatrix object with an ImageAttributes object
                imgattr.SetColorMatrix(cm);

                // draw the copy of the source image back over the original image,
                //applying the ColorMatrix
                g.DrawImage(bmp, rc, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgattr);

                g.Dispose();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void GrayScale(Image img)
        {
            ColorMatrix cm = new ColorMatrix(new float[][] {
            new float[] {
                0.299F,
                0.299F,
                0.299F,
                0,
                0
            },
            new float[] {
                0.587F,
                0.587F,
                0.587F,
                0,
                0
            },
            new float[] {
                0.114F,
                0.114F,
                0.114F,
                0,
                0
            },
            new float[] {
                0,
                0,
                0,
                1,
                0
            },
            new float[] {
                0,
                0,
                0,
                0,
                1
            }
        });

            DrawAdjustedImage(img, cm);
        }

        public static void Translate(Image img, float red, float green, float blue, float alpha = 0)
        {
            float sr;
            float sg;
            float sb;
            float sa;

            // noramlize the color components to 1
            sr = red / 255;
            sg = green / 255;
            sb = blue / 255;
            sa = alpha / 255;

            // create the color matrix
            ColorMatrix cm = new ColorMatrix(new float[][] {
            new float[] {
                1,
                0,
                0,
                0,
                0
            },
            new float[] {
                0,
                1,
                0,
                0,
                0
            },
            new float[] {
                0,
                0,
                1,
                0,
                0
            },
            new float[] {
                0,
                0,
                0,
                1,
                0
            },
            new float[] {
                sr,
                sg,
                sb,
                sa,
                1
            }
        });

            // apply the matrix to the image
            DrawAdjustedImage(img, cm);
        }

        public static void Negative(Image img)
        {
            ColorMatrix cm = new ColorMatrix(new float[][] {
            new float[] {
                -1,
                0,
                0,
                0,
                0
            },
            new float[] {
                0,
                -1,
                0,
                0,
                0
            },
            new float[] {
                0,
                0,
                -1,
                0,
                0
            },
            new float[] {
                0,
                0,
                0,
                1,
                0
            },
            new float[] {
                0,
                0,
                0,
                0,
                1
            }
        });

            DrawAdjustedImage(img, cm);
        }

        public static Image ResizeImage(Image image, Size size, bool preserveAspectRatio = true)
        {
            int newWidth;
            int newHeight;
            if (preserveAspectRatio)
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = (float)size.Width / (float)originalWidth;
                float percentHeight = (float)size.Height / (float)originalHeight;
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;
            }

            Image newImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

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

        public static Bitmap CopyToSquareCanvas(Bitmap sourceBitmap, Color canvasBackground)
        {
            int maxSide = sourceBitmap.Width > sourceBitmap.Height ? sourceBitmap.Width : sourceBitmap.Height;
            Bitmap bitmapResult = new Bitmap(maxSide, maxSide, PixelFormat.Format32bppArgb);
            using (Graphics graphicsResult = Graphics.FromImage(bitmapResult))
            {
                graphicsResult.Clear(canvasBackground);
                int xOffset = (sourceBitmap.Width - maxSide) / 2;
                int yOffset = (sourceBitmap.Height - maxSide) / 2;
                graphicsResult.DrawImage(sourceBitmap, new Point(xOffset, xOffset));
            }
            return bitmapResult;
        }

        public static Icon CreateIcon(Bitmap sourceBitmap, int iconSize)
        {
            Bitmap squareCanvas = CopyToSquareCanvas(sourceBitmap, Color.Transparent);
            squareCanvas = (Bitmap)squareCanvas.GetThumbnailImage(iconSize, iconSize, null, new IntPtr());

            Icon iconResult = Icon.FromHandle(squareCanvas.GetHicon());

            return iconResult;
        }
    }
}