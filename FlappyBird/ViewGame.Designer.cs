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
            pannelBoxRoehre1 = new PictureBox();
            pannelBoxRoehre2 = new PictureBox();
            pannelBoxRoehre3 = new PictureBox();
            pannelBoxRoehre4 = new PictureBox();
            pannelBoxVogel = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxVogel).BeginInit();
            SuspendLayout();
            // 
            // pannelBoxRoehre1
            // 
            pannelBoxRoehre1.BackColor = Color.Transparent;
            pannelBoxRoehre1.Image = Properties.Resources.Roehre1;
            pannelBoxRoehre1.Location = new Point(708, 506);
            pannelBoxRoehre1.Name = "pannelBoxRoehre1";
            pannelBoxRoehre1.Size = new Size(119, 600);
            pannelBoxRoehre1.TabIndex = 0;
            pannelBoxRoehre1.TabStop = false;
            // 
            // pannelBoxRoehre2
            // 
            pannelBoxRoehre2.BackColor = Color.Transparent;
            pannelBoxRoehre2.BackgroundImageLayout = ImageLayout.None;
            pannelBoxRoehre2.Image = Properties.Resources.Roehre1;
            pannelBoxRoehre2.Location = new Point(299, 625);
            pannelBoxRoehre2.Name = "pannelBoxRoehre2";
            pannelBoxRoehre2.Size = new Size(120, 600);
            pannelBoxRoehre2.TabIndex = 1;
            pannelBoxRoehre2.TabStop = false;
            // 
            // pannelBoxRoehre3
            // 
            pannelBoxRoehre3.BackColor = Color.Transparent;
            pannelBoxRoehre3.Image = Properties.Resources.RoehreGedreht;
            pannelBoxRoehre3.Location = new Point(708, -319);
            pannelBoxRoehre3.Name = "pannelBoxRoehre3";
            pannelBoxRoehre3.Size = new Size(120, 600);
            pannelBoxRoehre3.TabIndex = 3;
            pannelBoxRoehre3.TabStop = false;
            // 
            // pannelBoxRoehre4
            // 
            pannelBoxRoehre4.BackColor = Color.Transparent;
            pannelBoxRoehre4.BackgroundImageLayout = ImageLayout.None;
            pannelBoxRoehre4.Image = Properties.Resources.RoehreGedreht;
            pannelBoxRoehre4.Location = new Point(299, -200);
            pannelBoxRoehre4.Name = "pannelBoxRoehre4";
            pannelBoxRoehre4.Size = new Size(120, 600);
            pannelBoxRoehre4.TabIndex = 4;
            pannelBoxRoehre4.TabStop = false;
            // 
            // pannelBoxVogel
            // 
            pannelBoxVogel.BackColor = Color.Transparent;
            pannelBoxVogel.Image = Properties.Resources.vogel_icon;
            pannelBoxVogel.Location = new Point(100, 400);
            pannelBoxVogel.Name = "pannelBoxVogel";
            pannelBoxVogel.Size = new Size(100, 75);
            pannelBoxVogel.TabIndex = 5;
            pannelBoxVogel.TabStop = false;
            // 
            // ViewGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund;
            ClientSize = new Size(850, 1024);
            Controls.Add(pannelBoxRoehre1);
            Controls.Add(pannelBoxRoehre3);
            Controls.Add(pannelBoxRoehre2);
            Controls.Add(pannelBoxRoehre4);
            Controls.Add(pannelBoxVogel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewGame";
            Text = "ViewGame";
            Load += ViewGame_Load_1;
            Click += ViewGame_Click;
            KeyDown += ViewGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxVogel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pannelBoxRoehre1;
        public PictureBox pannelBoxRoehre2;
        public PictureBox pannelBoxRoehre3;
        public PictureBox pannelBoxRoehre4;
        public PictureBox pannelBoxVogel;
    }
}