using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;

namespace Enhanced_Painter
{
    class Lines : Shape
    {
        Pen pen;
        ArrayList points = new ArrayList();
        Point[] pointArray;
        SolidBrush brush;
        public Lines(Pen p, ArrayList pts, bool f)
        {
            Fill = f;
            //pen is passed by reference, so a new pen needs to be created
            pen = new Pen(p.Color, p.Width);
            brush = new SolidBrush(p.Color);
            //deep copy the points array for lines
            foreach (var point in pts)
            {
                points.Add(point);
            }
            pointArray = (Point[])points.ToArray(points[0].GetType());
        }
        public override void Draw(Graphics g)
        {
            g.DrawLines(pen, pointArray);
        }
    }
}

