using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dxballOOP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            

            int mousePositionX = Cursor.Position.X;
            playerStick.Location = new Point(mousePositionX-190, 510);
           
        }
        
        Random randomNum = new Random();

        private void left_down_Tick(object sender, EventArgs e)
        {
            int num = randomNum.Next(10, 15);
            int x = num;
            int y = num;
            ball.Top = ball.Top + y;
            ball.Left = ball.Left - x;


            if (playerStick.Top <= ball.Bottom && playerStick.Bottom >= ball.Top && playerStick.Left <= ball.Left && playerStick.Right >= ball.Right)
            {
                left_down.Enabled = false;
                left_up.Enabled = true;
            }
            else if (leftWall.Right >= ball.Left)
            {
                left_down.Enabled = false;
                right_down.Enabled = true;

            }
            else if (ball.Top >= 600)
            {
                ball.Top = 300;
                ball.Left = 400;
            }
        }

        private void left_up_Tick(object sender, EventArgs e)
        {
            int num = randomNum.Next(10, 15);
            int x = num;
            int y = num;
            ball.Top = ball.Top - y;
            ball.Left = ball.Left - x;


            if (leftWall.Right >= ball.Left)
            {
                left_up.Enabled = false;
                right_up.Enabled = true;

            }
            else if (topWall.Bottom >= ball.Top)
            {
                left_up.Enabled = false;
                left_down.Enabled = true;
            }
        }

        private void right_up_Tick(object sender, EventArgs e)
        {
            int num = randomNum.Next(10, 15);
            int x = num;
            int y = num;
            ball.Top = ball.Top - y;
            ball.Left = ball.Left + x;


            if (topWall.Bottom >= ball.Top)
            {
                right_up.Enabled = false;
                right_down.Enabled = true;
            }
            else if (rightWall.Left <= ball.Right)
            {
                right_up.Enabled = false;
                left_up.Enabled = true;
            }
        }

        private void right_down_Tick(object sender, EventArgs e)
        {
            int num = randomNum.Next(10, 15);
            int x = num;
            int y = num;
            ball.Top = ball.Top + y;
            ball.Left = ball.Left + x;


            if (playerStick.Top <= ball.Bottom && playerStick.Bottom >= ball.Top && playerStick.Left <= ball.Left && playerStick.Right >= ball.Right)
            {
                right_down.Enabled = false;
                right_up.Enabled = true;
            }
            else if (rightWall.Left <= ball.Right)
            {
                right_down.Enabled = false;
                left_down.Enabled = true;
            }
            else if (ball.Top >= 600)
            {
                ball.Top = 300;
                ball.Left = 400;
            }
        }
    }
}
