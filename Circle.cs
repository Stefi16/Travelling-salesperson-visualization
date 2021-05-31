using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace courseProjectTSP
{
    class Circle
    {
        private int height = 50;
        private int width = 50;
        private Color myColor = Color.Blue;
        public Point Center { get; private set; }
        public Point Location { get; private set; }
        public int nodeNum { get; private set; }

        public Circle(Point pointy, int num)
        {
            this.nodeNum = num;
            this.Location = new Point(pointy.X, pointy.Y);
            FindCenter();


        }
        public void Paint(Graphics graphy)
        {
            using (Pen pen = new Pen(myColor, 2))
            {
                graphy.DrawEllipse(pen, this.Location.X, this.Location.Y, this.height, this.width);
            }

            DrawNumber(graphy);
        }

        private void DrawNumber(Graphics graphy)
        {
            Font drawFont = new Font("Arial", 20);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            var t = new Point(this.Center.X - 2, this.Center.Y -55);
            graphy.DrawString($"{this.nodeNum}", drawFont, drawBrush, t, drawFormat);
        }
        public void FindCenter()
        {

            this.Center = new Point(
                this.Location.X + this.width / 2,
                this.Location.Y + this.height / 2);

        }
    }
}

