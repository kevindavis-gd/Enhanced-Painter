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
