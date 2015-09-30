using System.Windows.Forms;

namespace System.Windows.Forms
{

    internal class BufferedPanel : Panel
    {
        #region Public Constructors

        public BufferedPanel()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
        }

        #endregion
    }

}