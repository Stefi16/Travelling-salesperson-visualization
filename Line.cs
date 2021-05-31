using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace courseProjectTSP
{
    class Line
    {
        public Color MyColor { get; set; }
        public Point FirstPoint { get; private set; }
        public Point SecondPoint { get; private set; }

        public Line(Point firstPoint, Point secondPoint)
        {
            this.FirstPoint = firstPoint;
            this.SecondPoint = secondPoint;
            this.MyColor = Color.Blue;
        }

        public void Paint(Graphics graphy)
        {
            using (Pen pen = new Pen(MyColor, 2))
            {
                graphy.DrawLine(pen, FirstPoint, SecondPoint);
            }
        }

        public bool Contains(Point point)
        {
            /* double a = Math.Round((double)(point.X - this.FirstPoint.X) / (this.SecondPoint.X - this.FirstPoint.X), 2);
             double b = Math.Round((double)(point.Y - this.FirstPoint.Y) / (this.SecondPoint.Y - this.FirstPoint.Y), 2);

             if (a == b)
                 return true;
             return false;*/

            // dis = Math.sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            // dist(AC) + dist(CB) == dist(AB)

            var AB = Math.Sqrt((this.SecondPoint.X - this.FirstPoint.X) * (this.SecondPoint.X - this.FirstPoint.X) +
                (this.SecondPoint.Y - this.FirstPoint.Y) * (this.SecondPoint.Y - this.FirstPoint.Y));
            var AC = Math.Sqrt((point.X - this.FirstPoint.X) * (point.X - this.FirstPoint.X) +
                (point.Y - this.FirstPoint.Y) * (point.Y - this.FirstPoint.Y));
            var CB = Math.Sqrt((this.SecondPoint.X - point.X) * (this.SecondPoint.X - point.X) +
                (this.SecondPoint.Y - point.Y) * (this.SecondPoint.Y - point.Y));
            AB = Math.Round(AB, 2);
            AC = Math.Round(AC, 2);
            CB = Math.Round(CB, 2);
            if (AC + CB == AB)
                return true;
            return false;

        }
    }
}

