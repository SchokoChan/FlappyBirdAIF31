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
            components = new System.ComponentModel.Container();
            pannelBoxRoehre1 = new PictureBox();
            pannelBoxRoehre2 = new PictureBox();
            pannelBoxRoehre3 = new PictureBox();
            pannelBoxRoehre4 = new PictureBox();
            pannelBoxVogel = new PictureBox();
            timerRoehrenBewegen = new System.Windows.Forms.Timer(components);
            timerRoehrenNeuGenerieren = new System.Windows.Forms.Timer(components);
            labelScore = new Label();
            labelGestorben = new Label();
            buttonNeustart = new Button();
            timerKeyboardInput = new System.Windows.Forms.Timer(components);
            buttonSchliessen = new Button();
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
            pannelBoxRoehre1.Location = new Point(700, 506);
            pannelBoxRoehre1.Name = "pannelBoxRoehre1";
            pannelBoxRoehre1.Size = new Size(119, 600);
            pannelBoxRoehre1.TabIndex = 0;
            pannelBoxRoehre1.TabStop = false;
            pannelBoxRoehre1.Click += ViewGame_Click;
            // 
            // pannelBoxRoehre2
            // 
            pannelBoxRoehre2.BackColor = Color.Transparent;
            pannelBoxRoehre2.BackgroundImageLayout = ImageLayout.None;
            pannelBoxRoehre2.Image = Properties.Resources.Roehre1;
            pannelBoxRoehre2.Location = new Point(300, 625);
            pannelBoxRoehre2.Name = "pannelBoxRoehre2";
            pannelBoxRoehre2.Size = new Size(120, 600);
            pannelBoxRoehre2.TabIndex = 1;
            pannelBoxRoehre2.TabStop = false;
            pannelBoxRoehre2.Click += ViewGame_Click;
            // 
            // pannelBoxRoehre3
            // 
            pannelBoxRoehre3.BackColor = Color.Transparent;
            pannelBoxRoehre3.Image = Properties.Resources.RoehreGedreht;
            pannelBoxRoehre3.Location = new Point(700, -319);
            pannelBoxRoehre3.Name = "pannelBoxRoehre3";
            pannelBoxRoehre3.Size = new Size(120, 600);
            pannelBoxRoehre3.TabIndex = 3;
            pannelBoxRoehre3.TabStop = false;
            pannelBoxRoehre3.Click += ViewGame_Click;
            // 
            // pannelBoxRoehre4
            // 
            pannelBoxRoehre4.BackColor = Color.Transparent;
            pannelBoxRoehre4.BackgroundImageLayout = ImageLayout.None;
            pannelBoxRoehre4.Image = Properties.Resources.RoehreGedreht;
            pannelBoxRoehre4.Location = new Point(300, -200);
            pannelBoxRoehre4.Name = "pannelBoxRoehre4";
            pannelBoxRoehre4.Size = new Size(120, 600);
            pannelBoxRoehre4.TabIndex = 4;
            pannelBoxRoehre4.TabStop = false;
            pannelBoxRoehre4.Click += ViewGame_Click;
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
            pannelBoxVogel.Click += ViewGame_Click;
            // 
            // timerRoehrenBewegen
            // 
            timerRoehrenBewegen.Enabled = true;
            timerRoehrenBewegen.Interval = 10;
            timerRoehrenBewegen.Tick += timerRoehrenBewegen_Tick;
            // 
            // timerRoehrenNeuGenerieren
            // 
            timerRoehrenNeuGenerieren.Enabled = true;
            timerRoehrenNeuGenerieren.Interval = 1;
            timerRoehrenNeuGenerieren.Tick += timerRoehrenNeuGenerieren_Tick;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Transparent;
            labelScore.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.Location = new Point(331, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(131, 31);
            labelScore.TabIndex = 6;
            labelScore.Text = "Score : 0";
            // 
            // labelGestorben
            // 
            labelGestorben.AutoSize = true;
            labelGestorben.BackColor = Color.Transparent;
            labelGestorben.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelGestorben.ImageAlign = ContentAlignment.MiddleLeft;
            labelGestorben.Location = new Point(237, 332);
            labelGestorben.Name = "labelGestorben";
            labelGestorben.Size = new Size(507, 68);
            labelGestorben.TabIndex = 12;
            labelGestorben.Text = "Du bist gestorben!";
            // 
            // buttonNeustart
            // 
            buttonNeustart.BackColor = SystemColors.ButtonFace;
            buttonNeustart.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNeustart.ForeColor = SystemColors.ActiveCaptionText;
            buttonNeustart.Location = new Point(288, 447);
            buttonNeustart.Name = "buttonNeustart";
            buttonNeustart.Size = new Size(204, 73);
            buttonNeustart.TabIndex = 11;
            buttonNeustart.Text = "Neustart";
            buttonNeustart.UseVisualStyleBackColor = false;
            buttonNeustart.Click += buttonNeustart_Click;
            // 
            // timerKeyboardInput
            // 
            timerKeyboardInput.Enabled = true;
            timerKeyboardInput.Interval = 1;
            timerKeyboardInput.Tick += timerKeyboardInput_Tick;
            // 
            // buttonSchliessen
            // 
            buttonSchliessen.BackColor = SystemColors.ButtonFace;
            buttonSchliessen.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSchliessen.ForeColor = SystemColors.ActiveCaptionText;
            buttonSchliessen.Location = new Point(513, 447);
            buttonSchliessen.Name = "buttonSchliessen";
            buttonSchliessen.Size = new Size(204, 73); 
            buttonSchliessen.Text = "Schließen";
            buttonSchliessen.UseVisualStyleBackColor = false;
            buttonSchliessen.Click += buttonSchliessen_Click;
            // 
            // ViewGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund;
            ClientSize = new Size(850, 1024);
            Controls.Add(buttonSchliessen);
            Controls.Add(buttonNeustart);
            Controls.Add(labelGestorben);
            Controls.Add(labelScore);
            Controls.Add(pannelBoxVogel);
            Controls.Add(pannelBoxRoehre1);
            Controls.Add(pannelBoxRoehre3);
            Controls.Add(pannelBoxRoehre2);
            Controls.Add(pannelBoxRoehre4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewGame";
            Text = "ViewGame";
            Click += ViewGame_Click;
            KeyDown += ViewGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxRoehre4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pannelBoxVogel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pannelBoxRoehre1;
        public PictureBox pannelBoxRoehre2;
        public PictureBox pannelBoxRoehre3;
        public PictureBox pannelBoxRoehre4;
        public PictureBox pannelBoxVogel;
        private System.Windows.Forms.Timer timerRoehrenBewegen;
        private System.Windows.Forms.Timer timerRoehrenNeuGenerieren;
        private Label labelScore;
        private Label labelGestorben;
        private Button buttonNeustart;
        private System.Windows.Forms.Timer timerKeyboardInput;
        private Button buttonSchliessen;
    }
}