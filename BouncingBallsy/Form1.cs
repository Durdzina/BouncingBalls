using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBallsy
{
    public partial class Form1 : Form
    {
        private int ballWidth = 100;
        private int ballHeight = 100;
        private int ballPosX = 0;
        private int ballPosY = 0;
        private int moveStepX = 10;
        private int moveStepY = 10;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PaintCircle(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(Brushes.Blue, ballPosX, ballPosY, ballWidth, ballHeight);
            e.Graphics.DrawEllipse(Pens.Black, ballPosX, ballPosY, ballWidth, ballHeight);

        }

        private void MoveBall(object sender, EventArgs e)
        {
            ballPosX += moveStepX;
            if(ballPosX <0 || ballPosX + ballWidth > this.ClientSize.Width)
            {
                moveStepX = -moveStepX;
            }
            ballPosY += moveStepY;
            if(ballPosY <0 || ballPosY + ballHeight > this.ClientSize.Height)
            {
                moveStepY = -moveStepY;
            }

            this.Refresh();
        }
    }
}
