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
    public partial class Form_Main : Form
    {
        private ArrayList points = new ArrayList();
        private ArrayList shapes = new ArrayList();
        Pen pen = new Pen(Color.Aqua);
        SolidBrush brush = new SolidBrush(Color.Red);
        private static ColorDialog myColorChooser = new ColorDialog();
        public Graphics graphicsObject;
        Point[] pointArray;
        Color customColor = Color.ForestGreen;
        bool fill;
        int height;
        int width;
        int previousXpos;
        int previousYposition;
        int currentXposition;
        int currentYposition;


        public Form_Main()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //exitToolStripMenuItem_Click
        private void clearPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            panel_DrawPad.Invalidate();
        }//clearPadToolStripMenuItem_Click
        private void Form_Main_Load(object sender, EventArgs e)
        {
            pen.Width = 2.0F;
            comboBox_Shape.SelectedIndex = 0;
            pen.Color = Color.Black;
            brush.Color = Color.Black;
        }//Form_Main_Load
        private void panel_DrawPad_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //get mouse position and store it in the ArrayList
            points.Add(new Point(e.X, e.Y));
            //refresh pad
            panel_DrawPad.Invalidate();
        }//panel_DrawPad_MouseDown


        private void button_SaveShape_Click(object sender, EventArgs e)
        {
            //the last line of a polygon is drawn automatically by the computer
            //that means it would not be in our points list so we need to add it manually
            if (comboBox_Shape.SelectedIndex == 3)
                shapes.Add(new Polygon(pen, points, fill));
            else
                shapes.Add(new Lines(pen, points, fill));
            points.Clear();
            Array.Clear(pointArray, 0, pointArray.Length);
        }


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

        private void groupBox_PenSize_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton_smallPen.Checked)
            {
                pen.Width = 2.0F;
            }
            else if (radioButton_mediumPen.Checked)
            {
                pen.Width = 5.0F;
            }
            else if (radioButton_LargePen.Checked)
            {
                pen.Width = 10.0F;
            }
        }//groupBox_PenSize_CheckedChanged



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

        private void button_customColor_Click(object sender, EventArgs e)
        {
            DialogResult result = myColorChooser.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                customColor = myColorChooser.Color;
                pictureBox_customColor.BackColor = customColor;
            }//if

            //if the custom radio button was already checked
            //set the pen color within this method
            if (radioButton_Custom.Checked)
            {
                pen.Color = customColor;
                brush.Color = customColor;

            }//if
        }//button_customColor_Click

        private void comboBox_Shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            //draw line
            if (comboBox_Shape.SelectedIndex == 0)
            {
                button_SaveShape.Visible = true;
            }
            //draw Ellipse
            else if (comboBox_Shape.SelectedIndex == 1)
            {
                button_SaveShape.Visible = false;
            }
            //draw Rectangle
            else if (comboBox_Shape.SelectedIndex == 2)
            {
                button_SaveShape.Visible = false;
            }
            //draw polygon
            else if (comboBox_Shape.SelectedIndex == 3)
            {
                button_SaveShape.Visible = true;
            }
            //fill shape
            else if (comboBox_Shape.SelectedIndex == 4)
            {
                button_SaveShape.Visible = true;
            }
        }//comboBox_Shape_SelectedIndexChanged

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
        }
    }//FormMain
}
