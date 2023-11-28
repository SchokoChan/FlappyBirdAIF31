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




        public static int ueberpruefenVonRoehren(PictureBox roehre1, PictureBox roehre2)
        {
            if(roehre1.Location.X <= -120)
            {
                return 5;
            }
            if(roehre2.Location.X <= -120)
            {
                return 6;
            }
            return 0;
            
        }
    }
}
