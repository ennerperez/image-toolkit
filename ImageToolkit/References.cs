// ----------------------------------------
// References
// Version 1.0.0
// Updated 2016-12-28
// ----------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

#if DEBUG

namespace System.Drawing
{

    /// <summary>
    /// Provides helper methods for imaging
    /// </summary>
    internal static partial class ImageHelper
    {
        /// <summary>
        /// Converts a PNG image to a icon (ico)
        /// </summary>
        /// <param name="input">The input stream</param>
        /// <param name="output">The output stream</param>
        /// <param name="size">The size (16x16 px by default)</param>
        /// <param name="preserveAspectRatio">Preserve the aspect ratio</param>
        /// <returns>Wether or not the icon was succesfully generated</returns>
        internal static bool ConvertToIcon(Stream input, Stream output, int size = 16, bool preserveAspectRatio = false)
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
        internal static bool ConvertToIcon(string inputPath, string outputPath, int size = 16, bool preserveAspectRatio = false)
        {
            using (FileStream inputStream = new FileStream(inputPath, FileMode.Open))
            using (FileStream outputStream = new FileStream(outputPath, FileMode.OpenOrCreate))
            {
                return ConvertToIcon(inputStream, outputStream, size, preserveAspectRatio);
            }
        }

        internal static bool GetEditorIcon(Image img)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            using (Graphics gfx = Graphics.FromImage(bmp))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(43, 43, 43)))
            {
                gfx.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
                gfx.DrawImage(img, 0, 0);
            }

            bmp.Save(@"..\..\..\.editoricon.png");
            ConvertToIcon(@"..\..\..\.editoricon.png", @"..\..\App.ico", (img.Width + img.Height) / 2, true);

            return true;

        }
    }

}

namespace System.Windows.Forms
{

    internal static partial class FormHelper
    {
        public static void ExtractResources(Image image, string name)
        {
            if (image != null)
            {
                if (!System.IO.Directory.Exists(@"..\..\Resources\"))
                    System.IO.Directory.CreateDirectory(@"..\..\Resources\");
                image.Save(string.Format(@"..\..\Resources\{0}.png", name));
            }
        }
        public static void ExtractResources(ToolStrip source)
        {
            foreach (var item in source.Items.OfType<ToolStripButton>().Where(i => i.Image != null))
                ExtractResources(item.Image, item.Name);
            foreach (var item in source.Items.OfType<ToolStripDropDownButton>().Where(i => i.Image != null))
                ExtractResources(item.Image, item.Name);
        }

    }

}

#endif

namespace System
{
    internal static class ApplicationInfo
    {
        public static Version Version { get { return Assembly.GetCallingAssembly().GetName().Version; } }

        public static string Title
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title.Length > 0) return titleAttribute.Title;
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public static string ProductName
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string Description
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string CopyrightHolder
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string CompanyName
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

    }

}

namespace Platform.Support.Drawing
{

    //internal static partial class Helper
    //{
    //    public static string ToHEX(System.Drawing.Color source)
    //    {
    //        try
    //        {
    //            return ColorTranslator.ToHtml(source);
    //        }
    //        catch (Exception)
    //        {
    //            return string.Empty;
    //        }
    //    }
    //    public static Color FromHEX(string hex)
    //    {
    //        try
    //        {
    //            return ColorTranslator.FromHtml(hex);
    //        }
    //        catch (Exception)
    //        {
    //            return ColorTranslator.FromHtml("#0");
    //        }
    //    }

    //    public static Tuple<double, double, double> ToHSV(Color color)
    //    {

    //        double Hue, Saturation, Value;

    //        int Max, Min;

    //        if (color.R > color.G)
    //        {
    //            Max = color.R;
    //            Min = color.G;
    //        }
    //        else
    //        {
    //            Max = color.G;
    //            Min = color.R;
    //        }

    //        if (color.B > Max) Max = color.B;
    //        else if (color.B < Min) Min = color.B;

    //        int Diff = Max - Min;

    //        Value = (double)Max / 255;

    //        if (Max == 0) Saturation = 0;
    //        else Saturation = (double)Diff / Max;

    //        double q;
    //        if (Diff == 0) q = 0;
    //        else q = (double)60 / Diff;

    //        if (Max == color.R)
    //        {
    //            if (color.G < color.B) Hue = (360 + q * (color.G - color.B)) / 360;
    //            else Hue = q * (color.G - color.B) / 360;
    //        }
    //        else if (Max == color.G) Hue = (120 + q * (color.B - color.R)) / 360;
    //        else if (Max == color.B) Hue = (240 + q * (color.R - color.G)) / 360;
    //        else Hue = 0.0;

    //        //hsb.Alpha = color.A;

    //        return new Tuple<double, double, double>(Hue, Saturation, Value);
    //    }

    //    public static Color FromHSV(params double[] value)
    //    {
    //        return FromHSV(new Tuple<double, double, double>(value[0], value[1], value[2]));
    //    }

    //    public static Color FromHSV(Tuple<double, double, double> value, int Alpha = 0)
    //    {
    //        int Mid;
    //        int Max = (int)Math.Round(value.Item3 * 255);
    //        int Min = (int)Math.Round((1.0 - value.Item2) * (value.Item3 / 1.0) * 255);
    //        double q = (double)(Max - Min) / 255;

    //        if (value.Item1 >= 0 && value.Item1 <= (double)1 / 6)
    //        {
    //            Mid = (int)Math.Round(((value.Item1 - 0) * q) * 1530 + Min);
    //            return Color.FromArgb(Alpha, Max, Mid, Min);
    //        }

    //        if (value.Item1 <= (double)1 / 3)
    //        {
    //            Mid = (int)Math.Round(-((value.Item1 - (double)1 / 6) * q) * 1530 + Max);
    //            return Color.FromArgb(Alpha, Mid, Max, Min);
    //        }

    //        if (value.Item1 <= 0.5)
    //        {
    //            Mid = (int)Math.Round(((value.Item1 - (double)1 / 3) * q) * 1530 + Min);
    //            return Color.FromArgb(Alpha, Min, Max, Mid);
    //        }

    //        if (value.Item1 <= (double)2 / 3)
    //        {
    //            Mid = (int)Math.Round(-((value.Item1 - 0.5) * q) * 1530 + Max);
    //            return Color.FromArgb(Alpha, Min, Mid, Max);
    //        }

    //        if (value.Item1 <= (double)5 / 6)
    //        {
    //            Mid = (int)Math.Round(((value.Item1 - (double)2 / 3) * q) * 1530 + Min);
    //            return Color.FromArgb(Alpha, Mid, Min, Max);
    //        }

    //        if (value.Item1 <= 1.0)
    //        {
    //            Mid = (int)Math.Round(-((value.Item1 - (double)5 / 6) * q) * 1530 + Max);
    //            return Color.FromArgb(Alpha, Max, Min, Mid);
    //        }

    //        return Color.FromArgb(Alpha, 0, 0, 0);
    //    }


    //    public static string ToRGB(System.Drawing.Color source)
    //    {
    //        return string.Join(",", new string[] { source.R.ToString(), source.G.ToString(), source.B.ToString() });
    //    }
    //    public static string ToRGBA(System.Drawing.Color source)
    //    {
    //        return string.Join(",", new string[] { source.R.ToString(), source.G.ToString(), source.B.ToString(), source.A.ToString() });
    //    }

    //    public static Color ChangeColorBrightness(Color color, float correctionFactor)
    //    {
    //        float red = (float)color.R;
    //        float green = (float)color.G;
    //        float blue = (float)color.B;

    //        if (correctionFactor < 0)
    //        {
    //            correctionFactor = 1 + correctionFactor;
    //            red *= correctionFactor;
    //            green *= correctionFactor;
    //            blue *= correctionFactor;
    //        }
    //        else
    //        {
    //            red = (255 - red) * correctionFactor + red;
    //            green = (255 - green) * correctionFactor + green;
    //            blue = (255 - blue) * correctionFactor + blue;
    //        }

    //        return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
    //    }

    //    public static Color LightenBy(Color color, int percent)
    //    {
    //        return ChangeColorBrightness(color, (float)(percent / 100.0));
    //    }
    //    public static Color DarkenBy(Color color, int percent)
    //    {
    //        return ChangeColorBrightness(color, (float)(-1 * percent / 100.0));
    //    }

    //    public static Color GetDominantColor(Image image)
    //    {
    //        //Used for tally
    //        int r = 0;
    //        int g = 0;
    //        int b = 0;

    //        int total = 0;

    //        for (int x = 0; x < image.Width; x++)
    //        {
    //            for (int y = 0; y < image.Height; y++)
    //            {
    //                Color clr = (image as Bitmap).GetPixel(x, y);

    //                r += clr.R;
    //                g += clr.G;
    //                b += clr.B;

    //                total++;
    //            }
    //        }

    //        //Calculate average
    //        r /= total;
    //        g /= total;
    //        b /= total;

    //        return Color.FromArgb(r, g, b);
    //    }

    //    public static List<Color> GetPalette(Image image)
    //    {

    //        List<Color> colors;
    //        using (var b = new Bitmap(image))
    //        {
    //            var bd = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
    //            byte[] arr = new byte[bd.Width * bd.Height * 3];
    //            colors = new List<Color>();
    //            Marshal.Copy(bd.Scan0, arr, 0, arr.Length);
    //            b.UnlockBits(bd);

    //            for (int i = 0; i < ((bd.Width * bd.Height)); i++)
    //            {
    //                var start = i * 3;
    //                colors.Add(Color.FromArgb(arr[start], arr[start + 1], arr[start + 2]));
    //            }
    //        }

    //        return colors;

    //    }

    //}

    //public struct HSV
    //{
    //    private double hue;
    //    private double saturation;
    //    private double brightness;
    //    private int alpha;

    //    public double Hue
    //    {
    //        get
    //        {
    //            return hue;
    //        }
    //        set
    //        {
    //            hue = Helper.ValidColor(value);
    //        }
    //    }

    //    public double Hue360
    //    {
    //        get
    //        {
    //            return hue * 360;
    //        }
    //        set
    //        {
    //            hue = Helper.ValidColor(value / 360);
    //        }
    //    }

    //    public double Saturation
    //    {
    //        get
    //        {
    //            return saturation;
    //        }
    //        set
    //        {
    //            saturation = Helper.ValidColor(value);
    //        }
    //    }

    //    public double Saturation100
    //    {
    //        get
    //        {
    //            return saturation * 100;
    //        }
    //        set
    //        {
    //            saturation = Helper.ValidColor(value / 100);
    //        }
    //    }

    //    public double Brightness
    //    {
    //        get
    //        {
    //            return brightness;
    //        }
    //        set
    //        {
    //            brightness = Helper.ValidColor(value);
    //        }
    //    }

    //    public double Brightness100
    //    {
    //        get
    //        {
    //            return brightness * 100;
    //        }
    //        set
    //        {
    //            brightness = Helper.ValidColor(value / 100);
    //        }
    //    }

    //    public int Alpha
    //    {
    //        get
    //        {
    //            return alpha;
    //        }
    //        set
    //        {
    //            alpha = Helper.ValidColor(value);
    //        }
    //    }

    //    public HSV(double hue, double saturation, double brightness, int alpha = 255)
    //        : this()
    //    {
    //        Hue = hue;
    //        Saturation = saturation;
    //        Brightness = brightness;
    //        Alpha = alpha;
    //    }

    //    public HSV(int hue, int saturation, int brightness, int alpha = 255)
    //        : this()
    //    {
    //        Hue360 = hue;
    //        Saturation100 = saturation;
    //        Brightness100 = brightness;
    //        Alpha = alpha;
    //    }

    //    public HSV(Color color)
    //    {
    //        this = Helper.ToHSB(color);
    //    }

    //    public static implicit operator HSV(Color color)
    //    {
    //        return Helper.ToHSB(color);
    //    }

    //    public static implicit operator Color(HSV color)
    //    {
    //        return color.ToColor();
    //    }

    //    public static implicit operator CMYK(HSV color)
    //    {
    //        return color.ToColor();
    //    }

    //    public static bool operator ==(HSV left, HSV right)
    //    {
    //        return (left.Hue == right.Hue) && (left.Saturation == right.Saturation) && (left.Brightness == right.Brightness);
    //    }

    //    public static bool operator !=(HSV left, HSV right)
    //    {
    //        return !(left == right);
    //    }

    //    public override string ToString()
    //    {
    //        //return String.Format(Resources.HSB_ToString_, Hue360, Saturation100, Brightness100);
    //        return string.Format("Hue: {0:0.0}°, Saturation: {1:0.0}%, Brightness: {2:0.0}%", Hue360, Saturation100, Brightness100);
    //    }

    //    public Color ToColor()
    //    {
    //        return Helper.ToColor(this);
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        return base.Equals(obj);
    //    }
    //}

}

namespace System.Windows.Forms
{

    internal static partial class FormHelper
    {
        public static Rectangle GetWorkingArea()
        {
            int minx, miny, maxx, maxy;
            minx = miny = int.MaxValue;
            maxx = maxy = int.MinValue;

            foreach (Screen screen in Screen.AllScreens)
            {
                var bounds = screen.Bounds;
                minx = Math.Min(minx, bounds.X);
                miny = Math.Min(miny, bounds.Y);
                maxx = Math.Max(maxx, bounds.Right);
                maxy = Math.Max(maxy, bounds.Bottom);
            }

            return new System.Drawing.Rectangle(0, 0, (maxx - minx), (maxy - miny));
        }
    }

    internal class BufferedPanel : Panel
    {
        #region Public Constructors

        public BufferedPanel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
        }

        #endregion
    }

}