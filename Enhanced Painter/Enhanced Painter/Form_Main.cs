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


using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace Enhanced_Painter
{
    public partial class Form_Main : Form
    {
        private ArrayList points = new ArrayList();
        private ArrayList shapes = new ArrayList();
        Point[] pointArray;

        Pen pen = new Pen(Color.Aqua);
        SolidBrush brush = new SolidBrush(Color.Red);
        Color customColor = Color.ForestGreen;
        private static ColorDialog myColorChooser = new ColorDialog();

        public Graphics graphicsObject;
        
        bool fill;
        int height;
        int width;
        int previousXpos;
        int previousYposition;
        int currentXposition;
        int currentYposition;

        ////////////////////////////////////////////////////////////////////////////////////////// Form Main
        // Name: Form_Main
        // Arguments : None
        //
        // Description :
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public Form_Main()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////// Exit Click
        // Name: exitToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // Exits the program
        //////////////////////////////////////////////////////////////////////////////////////////
        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit program via menu strip
            Application.Exit();
        } //exitToolStripMenuItem_Click


        ////////////////////////////////////////////////////////////////////////////////////////// Clear Pad Click
        // Name: clearPadToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // It clears the shapes array and the points array and then refreshes the pannel to clear
        // the drawing surface
        //////////////////////////////////////////////////////////////////////////////////////////
        private void clearPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clear pad via menu strip
            shapes.Clear();
            points.Clear();

            panel_DrawPad.Invalidate();
        }//clearPadToolStripMenuItem_Click

        ////////////////////////////////////////////////////////////////////////////////////////// Form Load
        // Name: Form_Main_Load
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // as soon as the form loads set the default values
        //////////////////////////////////////////////////////////////////////////////////////////
        private void Form_Main_Load(object sender, EventArgs e)
        {   //set default values
            pen.Width = 2.0F;
            comboBox_Shape.SelectedIndex = 0;
            pen.Color = Color.Black;
            brush.Color = Color.Black;
        }//Form_Main_Load

        
        ////////////////////////////////////////////////////////////////////////////////////////// Draw Pad Mouse Down
        // Name: panel_DrawPad_MouseDown
        // Arguments : object sender, System.Windows.Forms.MouseEventArgs e
        //
        // Description :
        // when the mouse button is pressed down this method adds a point to the point array then 
        // it incalidates the panel
        //////////////////////////////////////////////////////////////////////////////////////////
        private void panel_DrawPad_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //get mouse position and store it in the ArrayList
            points.Add(new Point(e.X, e.Y));
            //refresh pad
            panel_DrawPad.Invalidate();
        }//panel_DrawPad_MouseDown


        ////////////////////////////////////////////////////////////////////////////////////////// Save Shape Click
        // Name: button_SaveShape_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // this method checks to see if there is more than 1 point within the
        // point array. if there is more than one point it checks whether its 
        // a polygon or a line and saves it appropriately.
        //////////////////////////////////////////////////////////////////////////////////////////
        private void button_SaveShape_Click(object sender, EventArgs e)
        {   
            //if nothing has been drawn and buttion has been clicked
            //nothing will happen
            if (points.Count > 1)
            {
                if (comboBox_Shape.SelectedIndex == 3)
                    shapes.Add(new Polygon(pen, points, fill));
                else if (comboBox_Shape.SelectedIndex == 0)
                    shapes.Add(new Lines(pen, points, fill));
                points.Clear();
                Array.Clear(pointArray, 0, pointArray.Length);
            }
            
        }//button_SaveShape_Click


        ////////////////////////////////////////////////////////////////////////////////////////// Fill Checked Changed
        // Name: checkBox_Fill_CheckedChanged
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // this method  changes the bool to true 
        // if its checked ,or false if its not checked.
        //////////////////////////////////////////////////////////////////////////////////////////
        private void checkBox_Fill_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Fill.Checked)
            {
                fill = true;
            }
            else
            {
                fill = false;
            }
        }//checkBox_Fill_CheckedChanged


        ////////////////////////////////////////////////////////////////////////////////////////// Pen Size Checked Changed
        // Name: groupBox_PenSize_CheckedChanged
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // this method waits for the radiobutton selection within the pensize groupbox to be
        // changed, then sets the size of the pen appropriately.
        //////////////////////////////////////////////////////////////////////////////////////////
        private void groupBox_PenSize_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            //variable for pen width not necessary
            if (radioButton_smallPen.Checked)
            {
                pen.Width = 2;
            }
            else if (radioButton_mediumPen.Checked)
            {
                pen.Width = 5;
            }
            else if (radioButton_LargePen.Checked)
            {
                pen.Width = 10;
            }
        }//groupBox_PenSize_CheckedChanged


        ////////////////////////////////////////////////////////////////////////////////////////// Color Checked Changed 
        // Name: groupBox_Color_CheckedChanged
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // this method waits for the radiobutton selection within the color groupbox to be
        // changed, then sets the color of the brushe and pen accordingly, it also changes 
        // the color of the picture box, which lets the user know the current color of the pen/brush
        //////////////////////////////////////////////////////////////////////////////////////////
        private void groupBox_Color_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton_Black.Checked)
            {
                pen.Color = Color.Black;
                brush.Color = Color.Black;
                pictureBox_customColor.BackColor = Color.Black;
            }
            else if (radioButton_Red.Checked)
            {
                pen.Color = Color.Red;
                brush.Color = Color.Red;
                pictureBox_customColor.BackColor = Color.Red;
            }
            else if (radioButton_Custom.Checked)
            {
                pen.Color = customColor;
                brush.Color = customColor;
                pictureBox_customColor.BackColor = customColor;
            }
        }//groupBox_PenSize_CheckedChanged

        
        ////////////////////////////////////////////////////////////////////////////////////////// Custom Color Button Click
        // Name: button_customColor_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // In this method, it uses an event handler to listen for a button click
        // if the button is clicked it shows a color dialog then saves the selected
        // color into a variable. it also checks to see if the custom color radio button
        // was already selected, if it was selected change the color of the brush and pen
        //////////////////////////////////////////////////////////////////////////////////////////
        private void button_customColor_Click(object sender, EventArgs e)
        {
            DialogResult result = myColorChooser.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                customColor = myColorChooser.Color;
            }//if

            //if the custom radio button was already checked
            //set the pen color within this method
            if (radioButton_Custom.Checked)
            {
                pen.Color = customColor;
                brush.Color = customColor;
                pictureBox_customColor.BackColor = customColor;
            }//if
        }//button_customColor_Click


        ////////////////////////////////////////////////////////////////////////////////////////// ComboBox Index Changed
        // Name: comboBox_Shape_SelectedIndexChanged
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // In this method, certain buttons are hidden or made visible based on which combobox
        // item is selected.
        //////////////////////////////////////////////////////////////////////////////////////////
        private void comboBox_Shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            //line
            if (comboBox_Shape.SelectedIndex == 0)
            {
                button_SaveShape.Visible = true;
                checkBox_Fill.Visible = false;
            }
            //Ellipse
            else if (comboBox_Shape.SelectedIndex == 1)
            {
                button_SaveShape.Visible = false;
                checkBox_Fill.Visible = true;
            }
            //Rectangle
            else if (comboBox_Shape.SelectedIndex == 2)
            {
                button_SaveShape.Visible = false;
                checkBox_Fill.Visible = true;
            }
            //polygon
            else if (comboBox_Shape.SelectedIndex == 3)
            {
                button_SaveShape.Visible = true;
                checkBox_Fill.Visible = true;
            }
        }//comboBox_Shape_SelectedIndexChanged


        ////////////////////////////////////////////////////////////////////////////////////////// DrawPad Paint
        // Name: panel_DrawPad_Paint
        // Arguments : object sender, PaintEventArgs e
        //
        // Description :
        // This method allows for the drawing of different shapes based on what selection is made
        // in the combobox. It stores the mouse coordinates into the array whenever the panel is
        // painted / clicked. When the point array has more than 2 points stored, the method then 
        // checks to see which item is selected in the combobox. Depending on the selection, it
        // will either draw the shape object onto the screen then wait for the user to save it into the 
        // shape array, or it will save the shape object automatically after the screen is clicked twice.
        // if the item is a polygon, it will check if fill it true, so that it can fill the shape
        //////////////////////////////////////////////////////////////////////////////////////////
        private void panel_DrawPad_Paint(object sender, PaintEventArgs e)
        {
            graphicsObject = e.Graphics;
            this.DoubleBuffered = true;
            //draw shapes on screen to prevent screen being blank while drawing new shape
            RefreshShapes();

            //if arraylist has more than 1 point
            if (points.Count > 1)
            {
                pointArray = (Point[])points.ToArray(points[0].GetType());

                //draw line
                if (comboBox_Shape.SelectedIndex == 0)
                {
                    graphicsObject.DrawLines(pen, pointArray);
                }
                //draw Ellipse
                else if (comboBox_Shape.SelectedIndex == 1)
                {
                    setPositions(pointArray);
                    //since this shape only requires 2 points, clear the point array
                    points.Clear();
                    Array.Clear(pointArray, 0, pointArray.Length);
                    shapes.Add(new Ellipse(pen, previousXpos, previousYposition, height, width, fill));
                }
                //draw Rectangle
                else if (comboBox_Shape.SelectedIndex == 2)
                {
                    setPositions(pointArray);
                    //since this shape only requires 2 points, clear the point array
                    points.Clear();
                    Array.Clear(pointArray, 0, pointArray.Length);
                    shapes.Add(new Rectangle(pen, previousXpos, previousYposition, height, width, fill));
                }
                //draw polygon
                else if (comboBox_Shape.SelectedIndex == 3)
                {
                    if (fill)
                        graphicsObject.FillPolygon(brush, pointArray);

                    else
                        graphicsObject.DrawPolygon(pen, pointArray);
                }
                RefreshShapes();
            }//if
        } //panel_DrawPad_Paint


        ////////////////////////////////////////////////////////////////////////////////////////// Set Positions
        // Name: Set Positions
        // Arguments : Point[] pointArray
        //
        // Description :
        // This method takes the last 2 points in the point array and stores them into variables
        // it then calculates the difference between the X and Y positions and stores thenm in 
        // height and width. It ensures that the hight and width is never negative and never 0
        //////////////////////////////////////////////////////////////////////////////////////////
        void setPositions(Point[] pointArray)
        {
            previousXpos = pointArray[pointArray.Length - 2].X;
            previousYposition = pointArray[pointArray.Length - 2].Y;
            currentXposition = pointArray[pointArray.Length - 1].X;
            currentYposition = pointArray[pointArray.Length - 1].Y;
            width = currentYposition - previousYposition;
            height = currentXposition - previousXpos;

            if (width == 0)
            {
                //dont let it be zero otherwise it will not draw
                width = 1;
            }
            if (height == 0)
            {
                height = 1;
            }

            //rectangles can not process negative height / width
            if (height < 0)
            {
                height = -height;
                previousXpos -= height;
            }
            if (width < 0)
            {
                width = -width;
                previousYposition -= width;
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////// Refresh Shapes
        // Name: Refresh Shapes
        // Arguments : None
        //
        // Description :
        // This method loops through the shape array list and redraws every shape in the array.
        //It only happens if the size of the array list is more than 0
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void RefreshShapes()
        {
            if (shapes.Count > 0)
            {
                foreach (Shape S in shapes)
                {
                    //graphics object changes every time the panel is clicked/painted
                    //the new object needs th be passed every time
                    S.Draw(graphicsObject);
                }
            }
        }// RefreshShapes
    }//FormMain
}
