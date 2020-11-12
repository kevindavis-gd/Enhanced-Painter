using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhanced_Painter
{
    class Rectangle : Shape
    {
        int xPos;
        int yPos;
        int width;
        int height;
        Pen pen;
        SolidBrush brush;

        public Rectangle(Pen p, int x, int y, int w, int h, bool f)
        {
            //pen is passed by reference, so a new pen needs to be created
            pen = new Pen(p.Color, p.Width);
            brush = new SolidBrush(p.Color);
            xPos = x;
            yPos = y;
            width = w;
            height = h;
            Fill = f;
        }
        public override void Draw(Graphics g)
        {
            if (Fill == true)
                g.FillRectangle(brush, xPos, yPos, width, height);
            else
                g.DrawRectangle(pen, xPos, yPos, width, height);
        }
    }
}
