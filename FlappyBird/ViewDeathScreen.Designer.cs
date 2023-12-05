namespace FlappyBird
{
    partial class ViewDeathScreen
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
            this.textBoxGestorben = new System.Windows.Forms.TextBox();
            this.buttonNeustart = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGestorben
            // 
            this.textBoxGestorben.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxGestorben.Enabled = false;
            this.textBoxGestorben.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxGestorben.Location = new System.Drawing.Point(213, 59);
            this.textBoxGestorben.Name = "textBoxGestorben";
            this.textBoxGestorben.Size = new System.Drawing.Size(363, 63);
            this.textBoxGestorben.TabIndex = 0;
            this.textBoxGestorben.Text = "Du bist gestorben!";
            // 
            // buttonNeustart
            // 
            this.buttonNeustart.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNeustart.Location = new System.Drawing.Point(69, 244);
            this.buttonNeustart.Name = "buttonNeustart";
            this.buttonNeustart.Size = new System.Drawing.Size(222, 81);
            this.buttonNeustart.TabIndex = 1;
            this.buttonNeustart.Text = "Neustart";
            this.buttonNeustart.UseVisualStyleBackColor = true;
            this.buttonNeustart.Click += new System.EventHandler(this.Neustart_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBeenden.Location = new System.Drawing.Point(477, 244);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(222, 81);
            this.buttonBeenden.TabIndex = 2;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.Beenden_Click);
            // 
            // ViewDeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonNeustart);
            this.Controls.Add(this.textBoxGestorben);
            this.Name = "ViewDeathScreen";
            this.Text = "ViewDeathScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxGestorben;
        private Button buttonNeustart;
        private Button buttonBeenden;
    }
}