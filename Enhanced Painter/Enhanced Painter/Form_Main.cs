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
        Pen pen = new Pen(Color.Aqua);
        SolidBrush brush = new SolidBrush(Color.Red);
        private static ColorDialog myColorChooser = new ColorDialog();
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
        }

        private void panel_DrawPad_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //get mouse position and store it in the ArrayList
            points.Add(new Point(e.X, e.Y));
            //refresh pad
            panel_DrawPad.Invalidate();
        }//panel_DrawPad_MouseDown

        //clear pad from menu strip
        private void clearPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            points.Clear();
            panel_DrawPad.Invalidate();
        }//clearPadToolStripMenuItem_Click


        private void panel_DrawPad_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObject = e.Graphics;
            this.DoubleBuffered = true;
            //if arraylist has more than 1 point
            if (points.Count > 1)
            {
                Point[] pointArray = (Point[])points.ToArray(points[0].GetType());

                //draw line
                if (comboBox_Shape.SelectedIndex == 0)
                {
                    graphicsObject.DrawLines(pen, pointArray);
                }
                //draw Ellipse
                else if (comboBox_Shape.SelectedIndex == 1)
                {
                   
                    previousXpos = pointArray[pointArray.Length - 2].X;
                    previousYposition = pointArray[pointArray.Length - 2].Y;
                    currentXposition = pointArray[pointArray.Length - 1].X;
                    currentYposition = pointArray[pointArray.Length - 1].Y;

                    graphicsObject.DrawEllipse(pen, previousXpos, previousYposition, currentXposition - previousXpos, currentYposition - previousYposition);

                    points.Clear();
                }
                //draw Rectangle
                else if (comboBox_Shape.SelectedIndex == 2)
                {
                    previousXpos = pointArray[pointArray.Length - 2].X;
                    previousYposition = pointArray[pointArray.Length - 2].Y;
                    currentXposition = pointArray[pointArray.Length - 1].X;
                    currentYposition = pointArray[pointArray.Length - 1].Y;

                    graphicsObject.DrawRectangle(pen, previousXpos, previousYposition, currentXposition - previousXpos, currentYposition - previousYposition);

                    points.Clear();
                }
                //draw polygon
                else if (comboBox_Shape.SelectedIndex == 3)
                {
                    graphicsObject.DrawPolygon(pen, pointArray);
                }
                //fill shape
                else if (comboBox_Shape.SelectedIndex == 4)
                {
                    graphicsObject.FillPolygon(brush, pointArray);
                }

            }//if

        } //panel_DrawPad_Paint

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

        private void Form_Main_Load(object sender, EventArgs e)
        {
            pen.Width = 2.0F;
            comboBox_Shape.SelectedIndex = 0;
            pen.Color = Color.Black;
        }//Form_Main_Load


        private void groupBox_Color_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton_Black.Checked)
            {
                pen.Color = Color.Black;
                brush.Color = Color.Black;
            }
            else if (radioButton_Red.Checked)
            {
                pen.Color = Color.Red;
                brush.Color = Color.Red;
            }
            else if (radioButton_Custom.Checked)
            {
                DialogResult result = myColorChooser.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    pen.Color = myColorChooser.Color;
                    brush.Color = myColorChooser.Color;
                }
            }
        }//groupBox_PenSize_CheckedChanged
    }
}
