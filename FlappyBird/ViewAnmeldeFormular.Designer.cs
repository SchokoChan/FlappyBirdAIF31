namespace FlappyBird
{
    partial class ViewAnmeldeFormular
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxPasswort = new TextBox();
            textBoxBenutzername = new TextBox();
            labelBenutzername = new Label();
            labelPasswort = new Label();
            buttonAnmelden = new Button();
            buttonRegistrieren = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(35, 140);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.PasswordChar = '*';
            textBoxPasswort.Size = new Size(376, 23);
            textBoxPasswort.TabIndex = 1;
            // 
            // textBoxBenutzername
            // 
            textBoxBenutzername.Location = new Point(35, 41);
            textBoxBenutzername.Name = "textBoxBenutzername";
            textBoxBenutzername.Size = new Size(376, 23);
            textBoxBenutzername.TabIndex = 0;
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelBenutzername.Location = new Point(35, 16);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(132, 22);
            labelBenutzername.TabIndex = 2;
            labelBenutzername.Text = "Benutzername";
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPasswort.Location = new Point(35, 115);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(88, 22);
            labelPasswort.TabIndex = 3;
            labelPasswort.Text = "Passwort";
            // 
            // buttonAnmelden
            // 
            buttonAnmelden.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAnmelden.Location = new Point(35, 203);
            buttonAnmelden.Name = "buttonAnmelden";
            buttonAnmelden.Size = new Size(133, 44);
            buttonAnmelden.TabIndex = 2;
            buttonAnmelden.Text = "Anmelden";
            buttonAnmelden.UseVisualStyleBackColor = true;
            buttonAnmelden.Click += buttonAnmelden_Click;
            // 
            // buttonRegistrieren
            // 
            buttonRegistrieren.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrieren.Location = new Point(278, 203);
            buttonRegistrieren.Name = "buttonRegistrieren";
            buttonRegistrieren.Size = new Size(133, 44);
            buttonRegistrieren.TabIndex = 3;
            buttonRegistrieren.Text = "Registrieren";
            buttonRegistrieren.UseVisualStyleBackColor = true;
            buttonRegistrieren.Click += buttonRegistrieren_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ViewAnmeldeFormular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 271);
            Controls.Add(buttonRegistrieren);
            Controls.Add(buttonAnmelden);
            Controls.Add(labelPasswort);
            Controls.Add(labelBenutzername);
            Controls.Add(textBoxBenutzername);
            Controls.Add(textBoxPasswort);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ViewAnmeldeFormular";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPasswort;
        private TextBox textBoxBenutzername;
        private Label labelBenutzername;
        private Label labelPasswort;
        private Button buttonAnmelden;
        private Button buttonRegistrieren;
        private ErrorProvider errorProvider;
    }
}