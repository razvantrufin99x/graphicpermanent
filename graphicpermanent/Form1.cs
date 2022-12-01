using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace graphicpermanent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //persistent permanant
        private System.Drawing.Bitmap myBitmap;
        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics graphicsObj;
            myBitmap = new Bitmap(this.ClientRectangle.Width,
               this.ClientRectangle.Height,
               System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            graphicsObj = Graphics.FromImage(myBitmap);
            Pen myPen = new Pen(System.Drawing.Color.Plum, 3);
            Rectangle rectangleObj = new Rectangle(10, 10, 200, 200);
            graphicsObj.DrawEllipse(myPen, rectangleObj);
            graphicsObj.Dispose();
        }

        public void doit() {

            Graphics graphicsObj;
            myBitmap = new Bitmap(this.ClientRectangle.Width,
            this.ClientRectangle.Height,
            System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            graphicsObj = Graphics.FromImage(myBitmap);

            graphicsObj.Clear(Color.White); // Set Bitmap background to white

            Pen myPen = new Pen(System.Drawing.Color.Plum, 3);
            Rectangle rectangleObj = new Rectangle(10, 10, 200, 200);
            graphicsObj.DrawEllipse(myPen, rectangleObj);

            graphicsObj.Dispose();

        
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = e.Graphics;

            graphicsObj.DrawImage(myBitmap, 0, 0, myBitmap.Width, myBitmap.Height);

            graphicsObj.Dispose();
        }
    }
}
