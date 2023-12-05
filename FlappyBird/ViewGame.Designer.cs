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
            this.components = new System.ComponentModel.Container();
            this.pannelBoxRoehre1 = new System.Windows.Forms.PictureBox();
            this.pannelBoxRoehre2 = new System.Windows.Forms.PictureBox();
            this.pannelBoxRoehre3 = new System.Windows.Forms.PictureBox();
            this.pannelBoxRoehre4 = new System.Windows.Forms.PictureBox();
            this.pannelBoxVogel = new System.Windows.Forms.PictureBox();
            this.timerRoehrenBewegen = new System.Windows.Forms.Timer(this.components);
            this.timerRoehrenNeuGenerieren = new System.Windows.Forms.Timer(this.components);
            this.timerKeyboardInput = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.labelGestorben = new System.Windows.Forms.Label();
            this.buttonNeustart = new System.Windows.Forms.Button();
            this.buttonSchliessen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxVogel)).BeginInit();
            this.SuspendLayout();
            // 
            // pannelBoxRoehre1
            // 
            this.pannelBoxRoehre1.BackColor = System.Drawing.Color.Transparent;
            this.pannelBoxRoehre1.Image = global::FlappyBird.Properties.Resources.Roehre1;
            this.pannelBoxRoehre1.Location = new System.Drawing.Point(700, 506);
            this.pannelBoxRoehre1.Name = "pannelBoxRoehre1";
            this.pannelBoxRoehre1.Size = new System.Drawing.Size(119, 600);
            this.pannelBoxRoehre1.TabIndex = 0;
            this.pannelBoxRoehre1.TabStop = false;
            // 
            // pannelBoxRoehre2
            // 
            this.pannelBoxRoehre2.BackColor = System.Drawing.Color.Transparent;
            this.pannelBoxRoehre2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pannelBoxRoehre2.Image = global::FlappyBird.Properties.Resources.Roehre1;
            this.pannelBoxRoehre2.Location = new System.Drawing.Point(300, 625);
            this.pannelBoxRoehre2.Name = "pannelBoxRoehre2";
            this.pannelBoxRoehre2.Size = new System.Drawing.Size(120, 600);
            this.pannelBoxRoehre2.TabIndex = 1;
            this.pannelBoxRoehre2.TabStop = false;
            // 
            // pannelBoxRoehre3
            // 
            this.pannelBoxRoehre3.BackColor = System.Drawing.Color.Transparent;
            this.pannelBoxRoehre3.Image = global::FlappyBird.Properties.Resources.RoehreGedreht;
            this.pannelBoxRoehre3.Location = new System.Drawing.Point(700, -319);
            this.pannelBoxRoehre3.Name = "pannelBoxRoehre3";
            this.pannelBoxRoehre3.Size = new System.Drawing.Size(120, 600);
            this.pannelBoxRoehre3.TabIndex = 3;
            this.pannelBoxRoehre3.TabStop = false;
            // 
            // pannelBoxRoehre4
            // 
            this.pannelBoxRoehre4.BackColor = System.Drawing.Color.Transparent;
            this.pannelBoxRoehre4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pannelBoxRoehre4.Image = global::FlappyBird.Properties.Resources.RoehreGedreht;
            this.pannelBoxRoehre4.Location = new System.Drawing.Point(300, -200);
            this.pannelBoxRoehre4.Name = "pannelBoxRoehre4";
            this.pannelBoxRoehre4.Size = new System.Drawing.Size(120, 600);
            this.pannelBoxRoehre4.TabIndex = 4;
            this.pannelBoxRoehre4.TabStop = false;
            // 
            // pannelBoxVogel
            // 
            this.pannelBoxVogel.BackColor = System.Drawing.Color.Transparent;
            this.pannelBoxVogel.Image = global::FlappyBird.Properties.Resources.vogel_icon;
            this.pannelBoxVogel.Location = new System.Drawing.Point(100, 400);
            this.pannelBoxVogel.Name = "pannelBoxVogel";
            this.pannelBoxVogel.Size = new System.Drawing.Size(100, 75);
            this.pannelBoxVogel.TabIndex = 5;
            this.pannelBoxVogel.TabStop = false;
            // 
            // timerRoehrenBewegen
            // 
            this.timerRoehrenBewegen.Enabled = true;
            this.timerRoehrenBewegen.Interval = 10;
            // 
            // timerRoehrenNeuGenerieren
            // 
            this.timerRoehrenNeuGenerieren.Enabled = true;
            this.timerRoehrenNeuGenerieren.Interval = 1;
            // 
            // timerKeyboardInput
            // 
            this.timerKeyboardInput.Interval = 1;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScore.Location = new System.Drawing.Point(331, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(131, 31);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "Score : 0";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1024);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // labelGestorben
            // 
            this.labelGestorben.AutoSize = true;
            this.labelGestorben.BackColor = System.Drawing.Color.Transparent;
            this.labelGestorben.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGestorben.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelGestorben.Location = new System.Drawing.Point(237, 332);
            this.labelGestorben.Name = "labelGestorben";
            this.labelGestorben.Size = new System.Drawing.Size(507, 68);
            this.labelGestorben.Text = "Du bist gestorben!";
            // 
            // buttonNeustart
            // 
            this.buttonNeustart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNeustart.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNeustart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNeustart.Location = new System.Drawing.Point(288, 447);
            this.buttonNeustart.Name = "buttonNeustart";
            this.buttonNeustart.Size = new System.Drawing.Size(204, 73);           
            this.buttonNeustart.Text = "Neustart";
            this.buttonNeustart.UseVisualStyleBackColor = false;
            this.buttonNeustart.Click += new System.EventHandler(this.buttonNeustart_Click);
            // 
            // buttonSchliessen
            // 
            this.buttonSchliessen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSchliessen.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSchliessen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSchliessen.Location = new System.Drawing.Point(513, 447);
            this.buttonSchliessen.Name = "buttonSchliessen";
            this.buttonSchliessen.Size = new System.Drawing.Size(204, 73);
            this.buttonSchliessen.TabIndex = 10;
            this.buttonSchliessen.Text = "Schließen";
            this.buttonSchliessen.UseVisualStyleBackColor = false;
            this.buttonSchliessen.Click += new System.EventHandler(this.buttonSchliessen_Click);
            // 
            // ViewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.Hintergrund;
            this.ClientSize = new System.Drawing.Size(850, 1024);
            this.Controls.Add(this.buttonSchliessen);
            this.Controls.Add(this.buttonNeustart);
            this.Controls.Add(this.labelGestorben);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pannelBoxVogel);
            this.Controls.Add(this.pannelBoxRoehre1);
            this.Controls.Add(this.pannelBoxRoehre3);
            this.Controls.Add(this.pannelBoxRoehre2);
            this.Controls.Add(this.pannelBoxRoehre4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewGame";
            this.Text = "ViewGame";
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxRoehre4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelBoxVogel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PictureBox pannelBoxRoehre1;
        public PictureBox pannelBoxRoehre2;
        public PictureBox pannelBoxRoehre3;
        public PictureBox pannelBoxRoehre4;
        public PictureBox pannelBoxVogel;
        private System.Windows.Forms.Timer timerRoehrenBewegen;
        private System.Windows.Forms.Timer timerRoehrenNeuGenerieren;
        private System.Windows.Forms.Timer timerKeyboardInput;
        private Label labelScore;
        private Splitter splitter1;
        private Label labelGestorben;
        private Button buttonNeustart;
        private Button buttonSchliessen;
    }
}