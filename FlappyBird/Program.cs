using System.Windows.Forms.VisualStyles;

namespace FlappyBird
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool unitTest = true;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (unitTest)
            {
                unitTests();
            }
            else
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new ViewAnmeldeFormular());
            }
        }

        static void unitTests()
        {
            ViewGameTests.TestPlayerDeath();
            ControllerGameTests.TestChangeScore();
            ControllerAnmeldeFormularTests.TestUserRegistrierung();
            ControllerAnmeldeFormularTests.TestUserAnmeldung();
            ModelAnmeldeFormularTests.TestUserAusDatenbankLesen();
            ModelAnmeldeFormularTests.TestBenutzerExistiert();
            ModelAnmeldeFormularTests.TestGeneriereSalt();
            ModelAnmeldeFormularTests.TestUserInDatenbankEinfuegen();
        }
    }
}