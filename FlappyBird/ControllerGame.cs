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




        public static int ueberpruefenVonRoehren(PictureBox roehre1, PictureBox roehre2)
        {
            if(roehre1.Location.X <= -120)
            {

                Random random = new Random();
                positionRoehren = random.Next(300, 901);
                return 5;
            }
            if(roehre2.Location.X <= -120)
            {

                Random random = new Random();
                positionRoehren = random.Next(300, 901);
                return 6;
            }
            return 0;
            
        }
    }
}
