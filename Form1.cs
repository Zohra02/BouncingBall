using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bouncingBall
{
    public partial class Form1 : Form
    {
        private int ballWidth = 100;
        private int ballHeigth = 100;
        private int ballPosX = 0;
        private int ballPosY = 0;
        private int moveStepX = 4;
        private int moveStepY = 4;


        public Form1()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true
                );
            this.UpdateStyles();
        }

        private void paintCircle(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);

            e.Graphics.FillEllipse(Brushes.Red,
            ballPosX, ballPosY, ballWidth, ballHeigth);

            e.Graphics.DrawEllipse(Pens.Black, ballPosX, ballPosY, ballWidth, ballHeigth);
        }

        private void moveBall(object sender, EventArgs e)
        {
            // update coordinates

            ballPosX += moveStepX;

            if(
            ballPosX < 0 ||
                ballPosX + ballWidth > this.ClientSize.Width)

            {
                moveStepX = -moveStepX;
            }

            ballPosY += moveStepY;

            if(
                ballPosY < 0 ||

                ballPosY + ballHeigth > this.ClientSize.Height)
            {
                moveStepY = -moveStepY;
            }

            //update painting
            this.Refresh();

        }
    }
}

