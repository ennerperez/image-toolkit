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
            System.Drawing.ImageHelper.GetEditorIcon(MaterialDesign.GetImage(MaterialDesign.IconType.color_lens, 256, Color.White));
#endif
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormMain());
        }
    }

}
