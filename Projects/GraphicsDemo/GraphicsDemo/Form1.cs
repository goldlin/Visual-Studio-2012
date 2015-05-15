using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var graphics = CreateGraphics();
            var myPen = new Pen(Color.Red, 5);
            graphics.DrawLine(myPen, 20, 20, 200, 20);
            var myPen1 = new Pen(Color.Blue, 5);
            var myRectangle = new Rectangle(0, 0, 100, 50);
            graphics.DrawRectangle(myPen1, myRectangle);
            var myPen2 = new Pen(Color.Green, 2) { DashPattern = new float[] { 2, 2, 2, 2 } };
            var myRectangle1 = new Rectangle(10, 10, 100, 50);
            graphics.DrawRectangle(myPen2, myRectangle1);
        }
    }
}
