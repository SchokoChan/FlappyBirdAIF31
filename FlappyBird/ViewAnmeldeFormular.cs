namespace FlappyBird
{
    public partial class FormAnmeldeFormular : Form
    {
        public FormAnmeldeFormular()
        {
            InitializeComponent();
        }

        private void buttonRegistrieren_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int abschlussCode = ControllerAnmeldeFormular.userRegistrierung(textBoxBenutzername.Text,
                textBoxPasswort.Text);


            switch (abschlussCode)
            {
                case 0:
                    //Einfügen von Bestätigung der Registrierung 
                    break;
                case 1:
                    errorProvider.SetError(buttonRegistrieren, "Datenbank verbindung konnte nicht Aufgebaut werden!");
                    break;
                case 2:
                    errorProvider.SetError(textBoxBenutzername, "Der Benutzername ist Bereits vergeben!");
                    break;
                case 3:
                    errorProvider.SetError(textBoxPasswort, "Passwort konnte nicht gehasht werden! Error Code:3");
                    break;
                case 4:
                    errorProvider.SetError(buttonRegistrieren, "Datenbank eintrag wurde nicht erstellt! Error Code:4");
                    break;
                case 50:
                    errorProvider.SetError(buttonRegistrieren, "Fehler Code: 50");
                    break;
                case 100:
                    errorProvider.SetError(textBoxPasswort, "Das Passwort muss mindestents 8 zeichen lang sein!");
                    break;
            }

        }

        private void buttonAnmelden_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int abschlussCode = ControllerAnmeldeFormular.userAnmeldung(textBoxBenutzername.Text,
                textBoxPasswort.Text);
            switch (abschlussCode)
            {
                case 0:
                    Form gameOverview = new ViewGame();
                    gameOverview.Show();
                    break;
                case 1:
                    errorProvider.SetError(buttonAnmelden, "Datenbank verbindung konnte nicht Aufgebaut werden!");
                    break;
                case 5:
                    errorProvider.SetError(buttonAnmelden, "Benutzername und Passwort stimmen nicht überein!");
                    break;
                case 6:
                    errorProvider.SetError(buttonAnmelden, "Error Code: 6");
                    break;
                case 50:
                    errorProvider.SetError(buttonAnmelden, "Error Code: 50");
                    break;
                case 200:
                    errorProvider.SetError(buttonAnmelden, "Error Code: 200");
                    break;

            }

        }
    }
}