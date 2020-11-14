////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Name: Kevin Davis 
// Class : CMPS4143
// Assignment: Program 6
// Date: 11/16/2020
//
// Description :
// This program displays lines, rectangles and ovals using 
// methods from Graphics. The shape draw is selected from a combo box with check boxes. 
// Graphics methods  will be used to draw or fill. 
// Variables will be used to keep track of the currently selected size (int) of the “lines” of the 
// drawn shapes and color (Color object). 
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Drawing;
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
        ////////////////////////////////////////////////////////////////////////////////////////// Draw
        // Name: Draw
        // Arguments : Graphics g
        //
        // Description :
        // This method takes in a graphics object and uses it  draw multiple lines using the 
        // point array
        //////////////////////////////////////////////////////////////////////////////////////////
        public override void Draw(Graphics g)
        {
            g.DrawLines(pen, pointArray);
        }
    }
}

