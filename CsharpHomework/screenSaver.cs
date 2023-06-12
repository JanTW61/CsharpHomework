using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpHomework
{
    public partial class screenSaver : Form
    {
        public screenSaver()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 10;
            
        }
        private int pictureBoxSpeed = 5; 
        private int pictureBoxDirectiony = 1;
        private int pictureBoxDirectionx = 1;
        private int previousX = Cursor.Position.X;
        private int previousY = Cursor.Position.Y;

        
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += pictureBoxSpeed * pictureBoxDirectionx;
            pictureBox1.Top += pictureBoxSpeed * pictureBoxDirectiony;

            // 检查是否到达Form的边界，如果是，则改变移动方向
            if (pictureBox1.Left + pictureBox1.Width >= this.ClientSize.Width)
            {
                pictureBoxDirectionx = -1;
            }
            else if (pictureBox1.Left <= 0)
            {
                pictureBoxDirectionx = 1;
            }
            if (pictureBox1.Top + pictureBox1.Height >= this.ClientSize.Height)
            {
                pictureBoxDirectiony = -1;
            }
            else if (pictureBox1.Top <= 0)
            {
                pictureBoxDirectiony = 1;
            }


        }

        private void screenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            int currentX = Cursor.Position.X;
            int currentY = Cursor.Position.Y;
            if (currentX != previousX && currentY != previousY)
            {
                this.Close(); // 關閉 Form
            }

        }

        private void screenSaver_Load(object sender, EventArgs e)
        {
            BringToFront();

        }

    }
} 
    

