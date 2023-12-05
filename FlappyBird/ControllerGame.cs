using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    public class ControllerGame
    {
        internal static User userData;
        internal static bool spielerLebt = true;
        internal static int positionRoehren = -1;
        internal static bool leertasteDruecken = true;
        internal static int leertasteIterationen = 0;
        internal static int score;
        private static string connectionString = "Server=localhost;Port=3306;Database=FlappyBird;Uid=root;Pwd=;";      


        public static int ueberpruefenVonRoehren(PictureBox roehre1, PictureBox roehre2)
        {
            if(roehre1.Location.X <= -120)
            {

                Random random = new Random();
                positionRoehren = random.Next(300, 601);
                
                return 5;
            }
            if(roehre2.Location.X <= -120)
            {

                Random random = new Random();
                positionRoehren = random.Next(300, 601);
                return 6;
            }
            return 0;
            
        }

        public static void vogelFallen(PictureBox vogel)
        {
            if (ControllerGame.spielerLebt == true)
            {


                if (vogel.Location.Y >= 862)
                {
                    ViewGame.playerDeath();
                }
                if (vogel.Location.Y <= 0)
                {
                    ViewGame.playerDeath();
                }
                if (ControllerGame.spielerLebt == true)
                {
                    vogel.Location = new Point(vogel.Location.X, vogel.Location.Y + 10);
                }
            }
        }

        internal static void changeScore()
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE User SET Highscore = " + score + " WHERE Username = '"+ userData.Benutzername+ "';");
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }catch (Exception e)
                {
                }
            }
        }
    }
}
