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
    abstract class Shape
    {
        bool fill;
        public bool Fill
        {
            get { return fill; }
            set { fill = value; }
        }
        public abstract void Draw(Graphics g);
    }
}
