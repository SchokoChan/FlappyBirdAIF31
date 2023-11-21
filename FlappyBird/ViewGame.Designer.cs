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
            this.pannelBoxRoehre1 = new System.Windows.Forms.PictureBox();
            this.pannelBoxRoehre2 = new System.Windows.Forms.PictureBox();
            this.pannelBoxRoehre3 = new System.Windows.Forms.PictureBox();
            this.pannelBoxRoehre4 = new System.Windows.Forms.PictureBox();
            this.pannelBoxVogel = new System.Windows.Forms.PictureBox();
            this.panelRoehre1 = new System.Windows.Forms.Panel();
            this.panelRoehre2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxVogel)).BeginInit();
            this.panelRoehre1.SuspendLayout();
            this.panelRoehre2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelBoxRoehre1
            // 
            this.pannelBoxRoehre1.BackColor = System.Drawing.Color.Transparent;
            this.pannelBoxRoehre1.Image = global::FlappyBird.Properties.Resources.Roehre1;
            this.pannelBoxRoehre1.Location = new System.Drawing.Point(-3, 609);
            this.pannelBoxRoehre1.Name = "pannelBoxRoehre1";
            this.pannelBoxRoehre1.Size = new System.Drawing.Size(119, 353);
            this.pannelBoxRoehre1.TabIndex = 0;
            this.pannelBoxRoehre1.TabStop = false;
            // 
            // pannelBoxRoehre2
            // 
            this.pannelBoxRoehre2.BackColor = System.Drawing.Color.Transparent;
            this.pannelBoxRoehre2.Image = global::FlappyBird.Properties.Resources.Roehre1;
            this.pannelBoxRoehre2.Location = new System.Drawing.Point(-3, 609);
            this.pannelBoxRoehre2.Name = "pannelBoxRoehre2";
            this.pannelBoxRoehre2.Size = new System.Drawing.Size(120, 353);
            this.pannelBoxRoehre2.TabIndex = 1;
            this.pannelBoxRoehre2.TabStop = false;
            // 
            // pannelBoxRoehre3
            // 
            this.pannelBoxRoehre3.BackColor = System.Drawing.Color.Transparent;
            this.pannelBoxRoehre3.Image = global::FlappyBird.Properties.Resources.RoehreGedreht;
            this.pannelBoxRoehre3.Location = new System.Drawing.Point(-3, -221);
            this.pannelBoxRoehre3.Name = "pannelBoxRoehre3";
            this.pannelBoxRoehre3.Size = new System.Drawing.Size(120, 598);
            this.pannelBoxRoehre3.TabIndex = 3;
            this.pannelBoxRoehre3.TabStop = false;
            // 
            // pannelBoxRoehre4
            // 
            this.pannelBoxRoehre4.BackColor = System.Drawing.Color.Transparent;
            this.pannelBoxRoehre4.Image = global::FlappyBird.Properties.Resources.RoehreGedreht;
            this.pannelBoxRoehre4.Location = new System.Drawing.Point(-3, -221);
            this.pannelBoxRoehre4.Name = "pannelBoxRoehre4";
            this.pannelBoxRoehre4.Size = new System.Drawing.Size(120, 598);
            this.pannelBoxRoehre4.TabIndex = 4;
            this.pannelBoxRoehre4.TabStop = false;
            // 
            // pannelBoxVogel
            // 
            this.pannelBoxVogel.BackColor = System.Drawing.Color.Transparent;
            this.pannelBoxVogel.Image = global::FlappyBird.Properties.Resources.vogel_icon;
            this.pannelBoxVogel.Location = new System.Drawing.Point(144, 454);
            this.pannelBoxVogel.Name = "pannelBoxVogel";
            this.pannelBoxVogel.Size = new System.Drawing.Size(100, 75);
            this.pannelBoxVogel.TabIndex = 5;
            this.pannelBoxVogel.TabStop = false;
            this.pannelBoxVogel.Click += new System.EventHandler(this.pannelBoxVogel_Click);
            // 
            // panelRoehre1
            // 
            this.panelRoehre1.BackColor = System.Drawing.Color.Transparent;
            this.panelRoehre1.Controls.Add(this.pannelBoxRoehre4);
            this.panelRoehre1.Controls.Add(this.pannelBoxRoehre2);
            this.panelRoehre1.Location = new System.Drawing.Point(453, 0);
            this.panelRoehre1.Name = "panelRoehre1";
            this.panelRoehre1.Size = new System.Drawing.Size(120, 934);
            this.panelRoehre1.TabIndex = 6;
            // 
            // panelRoehre2
            // 
            this.panelRoehre2.BackColor = System.Drawing.Color.Transparent;
            this.panelRoehre2.Controls.Add(this.pannelBoxRoehre3);
            this.panelRoehre2.Controls.Add(this.pannelBoxRoehre1);
            this.panelRoehre2.Location = new System.Drawing.Point(718, 0);
            this.panelRoehre2.Name = "panelRoehre2";
            this.panelRoehre2.Size = new System.Drawing.Size(120, 934);
            this.panelRoehre2.TabIndex = 7;
            // 
            // ViewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.Hintergrund;
            this.ClientSize = new System.Drawing.Size(850, 1024);
            this.Controls.Add(this.panelRoehre2);
            this.Controls.Add(this.pannelBoxVogel);
            this.Controls.Add(this.panelRoehre1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewGame";
            this.Text = "ViewGame";
            this.Load += new System.EventHandler(this.ViewGame_Load);
            this.Click += new System.EventHandler(this.ViewGame_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxVogel)).EndInit();
            this.panelRoehre1.ResumeLayout(false);
            this.panelRoehre2.ResumeLayout(false);
            this.ResumeLayout(false);

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