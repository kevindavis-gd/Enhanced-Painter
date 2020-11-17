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
        ////////////////////////////////////////////////////////////////////////////////////////// Draw
        // Name: Draw
        // Arguments : Graphics g
        //
        // Description :
        // This method takes in a graphics object and uses it to either draw a rectangle or fill a
        // rectangle based on the bool named fill.
        //////////////////////////////////////////////////////////////////////////////////////////
        public override void Draw(Graphics g)
        {
            if (Fill == true)
                g.FillRectangle(brush, xPos, yPos, width, height);
            else
                g.DrawRectangle(pen, xPos, yPos, width, height);
        }
    }
}
