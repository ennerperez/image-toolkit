using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Platform.Support.Drawing
{
    public static partial class ImageExtensions
    {

        #region Image

        public static void FromFile(this Image @this, string filename, bool safe = true)
        {
            //_BackgroundWorker.RunWorkerAsync({this, uri.ToString})
            @this = ImageHelper.FromFile(filename, safe);
        }

        public static void FromURI(this Image @this, Uri uri)
        {
            //_BackgroundWorker.RunWorkerAsync({this, uri.ToString})
            @this = ImageHelper.FromURI(uri);
        }
        public static void FromURL(this Image @this, string url)
        {
            @this = ImageHelper.FromURL(url);
            //_BackgroundWorker.RunWorkerAsync({this, url})
        }

        public static void FromBytes(this Image @this, byte[] data)
        {
            @this = ImageHelper.FromBytes(data);
        }
        public static void FromBase64(this Image @this, string source)
        {
            @this = ImageHelper.FromBase64(source);
        }

        public static byte[] ToBytes(this Image @this)
        {
            return ImageHelper.ToBytes(@this);
        }
        public static string ToBase64(this Image @this, ImageFormat imageFormat = null)
        {
            return ImageHelper.ToBase64(@this, imageFormat);
        }
        public static string ToBase64ImageTag(this Image @this, ImageFormat imageFormat = null)
        {
            return ImageHelper.ToBase64ImageTag(@this, imageFormat);
        }
        public static bool DrawAdjustedImage(this Image @this, ColorMatrix cm)
        {
            return ImageHelper.DrawAdjustedImage(@this, cm);
        }
        public static void DrawInsetCircle(this Graphics @this, ref Rectangle r, Pen p)
        {
            GeometricHelper.DrawInsetCircle(ref @this, ref r, p);
        }

        public static void GrayScale(this Image @this)
        {
            ImageHelper.GrayScale(@this);
        }
        public static void Translate(this Image @this, float red, float green, float blue, float alpha = 0)
        {
            ImageHelper.Translate(@this, red, green, blue, alpha);
        }
        public static void Negative(this Image @this)
        {
            ImageHelper.Negative(@this);
        }

        public static Image ResizeImage(this Image @this, Size size, bool preserveAspectRatio = true)
        {
            return ImageHelper.ResizeImage(@this, size, preserveAspectRatio);
        }

        public static Color GetDominantColor(this Image @this)
        {
            return ImageHelper.GetDominantColor(@this);
        }
        public static Color[] GetPalette(this Image @this)
        {
            return ImageHelper.GetPalette(@this);
        }

        #endregion

    }
}
