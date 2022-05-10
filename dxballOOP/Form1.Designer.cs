namespace dxballOOP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerStick = new System.Windows.Forms.Button();
            this.rightWall = new System.Windows.Forms.Label();
            this.leftWall = new System.Windows.Forms.Label();
            this.topWall = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.left_down = new System.Windows.Forms.Timer(this.components);
            this.left_up = new System.Windows.Forms.Timer(this.components);
            this.right_up = new System.Windows.Forms.Timer(this.components);
            this.right_down = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playerStick
            // 
            this.playerStick.Location = new System.Drawing.Point(597, 746);
            this.playerStick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerStick.Name = "playerStick";
            this.playerStick.Size = new System.Drawing.Size(255, 46);
            this.playerStick.TabIndex = 0;
            this.playerStick.UseVisualStyleBackColor = true;
            this.playerStick.Click += new System.EventHandler(this.button1_Click);
            // 
            // rightWall
            // 
            this.rightWall.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rightWall.Location = new System.Drawing.Point(1460, 0);
            this.rightWall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightWall.Name = "rightWall";
            this.rightWall.Size = new System.Drawing.Size(15, 868);
            this.rightWall.TabIndex = 2;
            // 
            // leftWall
            // 
            this.leftWall.BackColor = System.Drawing.SystemColors.HighlightText;
            this.leftWall.Location = new System.Drawing.Point(-8, -18);
            this.leftWall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftWall.Name = "leftWall";
            this.leftWall.Size = new System.Drawing.Size(22, 886);
            this.leftWall.TabIndex = 3;
            // 
            // topWall
            // 
            this.topWall.BackColor = System.Drawing.SystemColors.HighlightText;
            this.topWall.Location = new System.Drawing.Point(-8, 0);
            this.topWall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topWall.Name = "topWall";
            this.topWall.Size = new System.Drawing.Size(1480, 15);
            this.topWall.TabIndex = 4;
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(692, 591);
            this.ball.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(54, 57);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 5;
            this.ball.TabStop = false;
            // 
            // left_down
            // 
            this.left_down.Enabled = true;
            this.left_down.Tick += new System.EventHandler(this.left_down_Tick);
            // 
            // left_up
            // 
            this.left_up.Tick += new System.EventHandler(this.left_up_Tick);
            // 
            // right_up
            // 
            this.right_up.Tick += new System.EventHandler(this.right_up_Tick);
            // 
            // right_down
            // 
            this.right_down.Tick += new System.EventHandler(this.right_down_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1476, 863);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.topWall);
            this.Controls.Add(this.leftWall);
            this.Controls.Add(this.rightWall);
            this.Controls.Add(this.playerStick);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playerStick;
        private System.Windows.Forms.Label rightWall;
        private System.Windows.Forms.Label leftWall;
        private System.Windows.Forms.Label topWall;
        public System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer left_down;
        private System.Windows.Forms.Timer left_up;
        private System.Windows.Forms.Timer right_up;
        private System.Windows.Forms.Timer right_down;
    }
}

