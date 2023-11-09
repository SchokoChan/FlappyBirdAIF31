namespace FlappyBird
{
    partial class ViewGame
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
            pictureBoxFlappyBird = new PictureBox();
            pictureBoxRoehre1 = new PictureBox();
            pictureBoxRoehre3 = new PictureBox();
            pictureBoxRoehre2 = new PictureBox();
            pictureBoxRoehre4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoehre1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoehre3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoehre2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoehre4).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFlappyBird
            // 
            pictureBoxFlappyBird.BackColor = Color.Transparent;
            pictureBoxFlappyBird.BackgroundImage = Properties.Resources.flappybird;
            pictureBoxFlappyBird.Location = new Point(25, 400);
            pictureBoxFlappyBird.Name = "pictureBoxFlappyBird";
            pictureBoxFlappyBird.Size = new Size(98, 71);
            pictureBoxFlappyBird.TabIndex = 0;
            pictureBoxFlappyBird.TabStop = false;
            // 
            // pictureBoxRoehre1
            // 
            pictureBoxRoehre1.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxRoehre1.Location = new Point(218, 537);
            pictureBoxRoehre1.Name = "pictureBoxRoehre1";
            pictureBoxRoehre1.Size = new Size(100, 471);
            pictureBoxRoehre1.TabIndex = 1;
            pictureBoxRoehre1.TabStop = false;
            // 
            // pictureBoxRoehre3
            // 
            pictureBoxRoehre3.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxRoehre3.Location = new Point(514, 537);
            pictureBoxRoehre3.Name = "pictureBoxRoehre3";
            pictureBoxRoehre3.Size = new Size(100, 471);
            pictureBoxRoehre3.TabIndex = 1;
            pictureBoxRoehre3.TabStop = false;
            // 
            // pictureBoxRoehre2
            // 
            pictureBoxRoehre2.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxRoehre2.Location = new Point(218, -126);
            pictureBoxRoehre2.Name = "pictureBoxRoehre2";
            pictureBoxRoehre2.Size = new Size(100, 423);
            pictureBoxRoehre2.TabIndex = 1;
            pictureBoxRoehre2.TabStop = false;
            // 
            // pictureBoxRoehre4
            // 
            pictureBoxRoehre4.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxRoehre4.Location = new Point(514, -126);
            pictureBoxRoehre4.Name = "pictureBoxRoehre4";
            pictureBoxRoehre4.Size = new Size(100, 423);
            pictureBoxRoehre4.TabIndex = 1;
            pictureBoxRoehre4.TabStop = false;
            // 
            // ViewGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 1000);
            Controls.Add(pictureBoxRoehre4);
            Controls.Add(pictureBoxRoehre2);
            Controls.Add(pictureBoxRoehre3);
            Controls.Add(pictureBoxRoehre1);
            Controls.Add(pictureBoxFlappyBird);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewGame";
            Text = "ViewGame";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoehre1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoehre3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoehre2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoehre4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxFlappyBird;
        private PictureBox pictureBoxRoehre1;
        private PictureBox pictureBoxRoehre3;
        private PictureBox pictureBoxRoehre2;
        private PictureBox pictureBoxRoehre4;
    }
}