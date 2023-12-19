namespace FlappyBird
{
    public partial class ViewAnmeldeFormular : Form
    {

        ControllerAnmeldeFormular controller = new ControllerAnmeldeFormular();

        public static Form gameOverview = new ViewGame();
        public ViewAnmeldeFormular()
        {
            InitializeComponent();
            textBoxBenutzername.Text = "Admin";
            textBoxPasswort.Text = "Passwort";
        }

        private void buttonRegistrieren_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if(textBoxPasswort.Text.Length > 7)
            {
                if(controller.userRegistrierung(textBoxBenutzername.Text, textBoxPasswort.Text))
                {
                    Form registierBestaetigung = new ViewRegistrierBestaetigung();
                    registierBestaetigung.Show();
                }
                else
                {
                    errorProvider.SetError(buttonRegistrieren, "Fehler beim erstellen des Benutzers!");
                }
            }
            else
            {
                errorProvider.SetError(textBoxPasswort, "Das Passwort muss mindestents 8 zeichen lang sein!");
            }


            

        }

        private void buttonAnmelden_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (textBoxPasswort.Text.Length < 7)
            {
                errorProvider.SetError(textBoxPasswort, "Das Passwort muss mindestents 8 zeichen lang sein!");
            }
            else
            {
                if (controller.userAnmeldung(textBoxBenutzername.Text, textBoxPasswort.Text))
                {
                    gameOverview.Show();
                }
                else
                {
                    errorProvider.SetError(buttonAnmelden, "Anmeldung ist fehlgeschlagen!");
                }
            }

        }

        private void pressingEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                buttonAnmelden_Click(sender, null);
            }
        }
    }
}