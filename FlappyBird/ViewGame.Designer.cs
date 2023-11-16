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
            panelRoehre1 = new Panel();
            panelRoehre2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxVogel).BeginInit();
            panelRoehre1.SuspendLayout();
            panelRoehre2.SuspendLayout();
            SuspendLayout();
            // 
            // pannelBoxRoehre1
            // 
            pannelBoxRoehre1.BackColor = Color.Transparent;
            pannelBoxRoehre1.Image = Properties.Resources.Roehre1;
            pannelBoxRoehre1.Location = new Point(1, 596);
            pannelBoxRoehre1.Name = "pannelBoxRoehre1";
            pannelBoxRoehre1.Size = new Size(119, 353);
            pannelBoxRoehre1.TabIndex = 0;
            pannelBoxRoehre1.TabStop = false;
            pannelBoxRoehre1.Click += pannelBoxRoehre1_Click;
            // 
            // pannelBoxRoehre2
            // 
            pannelBoxRoehre2.BackColor = Color.Transparent;
            pannelBoxRoehre2.Image = Properties.Resources.Roehre1;
            pannelBoxRoehre2.Location = new Point(-3, 585);
            pannelBoxRoehre2.Name = "pannelBoxRoehre2";
            pannelBoxRoehre2.Size = new Size(120, 353);
            pannelBoxRoehre2.TabIndex = 1;
            pannelBoxRoehre2.TabStop = false;
            pannelBoxRoehre2.Click += pannelBoxRoehre2_Click;
            // 
            // pannelBoxRoehre3
            // 
            pannelBoxRoehre3.BackColor = Color.Transparent;
            pannelBoxRoehre3.Image = Properties.Resources.RoehreGedreht;
            pannelBoxRoehre3.Location = new Point(0, -264);
            pannelBoxRoehre3.Name = "pannelBoxRoehre3";
            pannelBoxRoehre3.Size = new Size(120, 598);
            pannelBoxRoehre3.TabIndex = 3;
            pannelBoxRoehre3.TabStop = false;
            pannelBoxRoehre3.Click += pannelBoxRoehre3_Click;
            // 
            // pannelBoxRoehre4
            // 
            pannelBoxRoehre4.BackColor = Color.Transparent;
            pannelBoxRoehre4.Image = Properties.Resources.RoehreGedreht;
            pannelBoxRoehre4.Location = new Point(-3, -221);
            pannelBoxRoehre4.Name = "pannelBoxRoehre4";
            pannelBoxRoehre4.Size = new Size(120, 598);
            pannelBoxRoehre4.TabIndex = 4;
            pannelBoxRoehre4.TabStop = false;
            // 
            // pannelBoxVogel
            // 
            pannelBoxVogel.BackColor = Color.Transparent;
            pannelBoxVogel.Image = Properties.Resources.vogel_icon;
            pannelBoxVogel.Location = new Point(144, 454);
            pannelBoxVogel.Name = "pannelBoxVogel";
            pannelBoxVogel.Size = new Size(100, 75);
            pannelBoxVogel.TabIndex = 5;
            pannelBoxVogel.TabStop = false;
            // 
            // panelRoehre1
            // 
            panelRoehre1.BackColor = Color.Transparent;
            panelRoehre1.Controls.Add(pannelBoxRoehre4);
            panelRoehre1.Controls.Add(pannelBoxRoehre2);
            panelRoehre1.Location = new Point(423, 0);
            panelRoehre1.Name = "panelRoehre1";
            panelRoehre1.Size = new Size(120, 1024);
            panelRoehre1.TabIndex = 6;
            // 
            // panelRoehre2
            // 
            panelRoehre2.BackColor = Color.Transparent;
            panelRoehre2.Controls.Add(pannelBoxRoehre3);
            panelRoehre2.Controls.Add(pannelBoxRoehre1);
            panelRoehre2.Location = new Point(718, 0);
            panelRoehre2.Name = "panelRoehre2";
            panelRoehre2.Size = new Size(120, 1024);
            panelRoehre2.TabIndex = 7;
            // 
            // ViewGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund;
            ClientSize = new Size(850, 1024);
            Controls.Add(panelRoehre2);
            Controls.Add(pannelBoxVogel);
            Controls.Add(panelRoehre1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewGame";
            Text = "ViewGame";
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxVogel).EndInit();
            panelRoehre1.ResumeLayout(false);
            panelRoehre2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pannelBoxRoehre1;
        private PictureBox pannelBoxRoehre2;
        private PictureBox pannelBoxRoehre3;
        private PictureBox pannelBoxRoehre4;
        private PictureBox pannelBoxVogel;
        private Panel panelRoehre1;
        private Panel panelRoehre2;
    }
}