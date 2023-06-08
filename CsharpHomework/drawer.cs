using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpHomework
{
    public partial class drawer : Form
    {
        public bool isDrawing;
        public Point previouspoint;
        public Pen drawingPen;
        private Color selectedColor;
        public drawer()

        {
            InitializeComponent();
            drawingPen = new Pen(Color.Black, 3);
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
            }

            drawingPen.Color = selectedColor;
            btnChangeColor.BackColor = selectedColor;
        }
        private void TBChangeSize_Scroll(object sender, EventArgs e)
        {
            drawingPen.Width = TBChangeSize.Width;
        }

        private void drawer_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previouspoint = e.Location;
        }

        private void drawer_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = CreateGraphics())
                {
                    // 繪製線段
                    g.DrawLine(drawingPen, previouspoint, e.Location);
                    previouspoint = e.Location;
                }
            }

        }

        private void drawer_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            using (Graphics g = CreateGraphics())
            {
                g.Clear(BackColor);
            }
        }
    }
} 
