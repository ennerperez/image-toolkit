using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Platform.Support.Drawing
{
    public static partial class GeometricHelper
    {

        public static bool IsPointInRectangle(Point p, Rectangle r)
        {
            bool flag = false;
            if ((p.X > r.X & p.X < r.X + r.Width & p.Y > r.Y & p.Y < r.Y + r.Height))
            {
                flag = true;
            }
            return flag;
        }

        public static void DrawInsetCircle(ref Graphics g, ref Rectangle r, Pen p)
        {
            int i;
            Pen p1 = new Pen(p.Color); //GetDarkColor(p.Color, 50));
            Pen p2 = new Pen(p.Color); //GetLightColor(p.Color, 50));

            for (i = 0; i <= p.Width; i++)
            {
                Rectangle r1 = new Rectangle(r.X + i, r.Y + i, r.Width - i * 2, r.Height - i * 2);

                g.DrawArc(p2, r1, -45, 180);
                g.DrawArc(p1, r1, 135, 180);
            }
        }


    }
}
