using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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



        }
    }
}
