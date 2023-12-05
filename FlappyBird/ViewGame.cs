﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class ViewGame : Form
    {

        public ViewGame()
        {
            InitializeComponent();
            Thread roeher = new Thread(ueberpruefungObFlappyBirdAnRoeherIst);
            roeher.Start();


        }

        private void ViewGame_Click(object sender, EventArgs e)
        {
            pannelBoxVogel.Location = new Point(pannelBoxVogel.Location.X, pannelBoxVogel.Location.Y - 75);
        }

        private void ViewGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == ' ')
            {

                if (ControllerGame.leertasteDruecken && ControllerGame.spielerLebt)
                {
                    pannelBoxVogel.Location = new Point(pannelBoxVogel.Location.X, pannelBoxVogel.Location.Y - 75);

                }
                if (!ControllerGame.spielerLebt)
                {

                    pannelBoxRoehre1.Location = new Point(700, 506);
                    pannelBoxRoehre2.Location = new Point(300, 625);
                    pannelBoxRoehre3.Location = new Point(700, -319);
                    pannelBoxRoehre4.Location = new Point(300, -200);
                    pannelBoxVogel.Location = new Point(100, 400);
                    ControllerGame.score = 0;
                    ControllerGame.spielerLebt = true;
                }
            }
        }



        private void ueberpruefungObFlappyBirdAnRoeherIst()
        {
            while (true)
            {
                if (ControllerGame.spielerLebt == true)
                {
                    if (pannelBoxRoehre3.Location.X <= 100 + 70 && pannelBoxRoehre3.Location.X >= 30)
                    {
                        if (pannelBoxVogel.Location.Y <= pannelBoxRoehre3.Location.Y + 600)
                        {
                            playerDeath();
                        }

                    }
                    if (pannelBoxRoehre1.Location.X <= 100 + 70 && pannelBoxRoehre1.Location.X >= 30)
                    {
                        if (pannelBoxVogel.Location.Y + 75 >= pannelBoxRoehre1.Location.Y)
                        {
                            playerDeath();
                        }
                    }
                    if (pannelBoxRoehre4.Location.X <= 100 + 70 && pannelBoxRoehre4.Location.X >= 30)
                    {
                        if (pannelBoxVogel.Location.Y <= pannelBoxRoehre4.Location.Y + 600)
                        {
                            playerDeath();
                        }
                    }
                    if (pannelBoxRoehre2.Location.X <= 100 + 70 && pannelBoxRoehre2.Location.X >= 30)
                    {
                        if (pannelBoxVogel.Location.Y + 75 >= pannelBoxRoehre2.Location.Y)
                        {
                            playerDeath();
                        }
                    }

                }

                {

                }
            }


        }

        private void timerRoehrenBewegen_Tick(object sender, EventArgs e)
        {
            if (ControllerGame.spielerLebt)
            {
                pannelBoxRoehre1.Location = new Point(pannelBoxRoehre1.Location.X - 10, pannelBoxRoehre1.Location.Y);
                pannelBoxRoehre2.Location = new Point(pannelBoxRoehre2.Location.X - 10, pannelBoxRoehre2.Location.Y);
                pannelBoxRoehre3.Location = new Point(pannelBoxRoehre3.Location.X - 10, pannelBoxRoehre3.Location.Y);
                pannelBoxRoehre4.Location = new Point(pannelBoxRoehre4.Location.X - 10, pannelBoxRoehre4.Location.Y);
                ControllerGame.vogelFallen(pannelBoxVogel);
                if (pannelBoxRoehre1.Location.X == 100 || pannelBoxRoehre2.Location.X == 100)
                {
                    ControllerGame.score += 1;
                    labelScore.Text = "Score : " + ControllerGame.score;
                }

            }

        }

        private void timerRoehrenNeuGenerieren_Tick(object sender, EventArgs e)
        {
            switch (ControllerGame.ueberpruefenVonRoehren(pannelBoxRoehre1, pannelBoxRoehre2))
            {
                case 5:


                    pannelBoxRoehre3.Location = new Point(730, ControllerGame.positionRoehren - 600);
                    pannelBoxRoehre1.Location = new Point(730, pannelBoxRoehre3.Location.Y + 600 + 225);
                    pannelBoxRoehre1.Refresh();
                    pannelBoxRoehre3.Refresh();

                    break;
                case 6:

                    pannelBoxRoehre4.Location = new Point(730, -600 + ControllerGame.positionRoehren);
                    pannelBoxRoehre2.Location = new Point(730, pannelBoxRoehre4.Location.Y + 600 + 225);
                    pannelBoxRoehre2.Refresh();
                    pannelBoxRoehre4.Refresh();

                    break;
                case 0:
                    break;
            }
        }

        private void timerKeyboardInput_Tick(object sender, EventArgs e)
        {

            if (ControllerGame.leertasteDruecken == false)
            {
                if (ControllerGame.leertasteIterationen == 50)
                {
                    ControllerGame.leertasteDruecken = true;
                    ControllerGame.leertasteIterationen = 0;
                }
                else
                {
                    ControllerGame.leertasteIterationen += 1;
                }




            }
        }

        internal static void playerDeath()
        {
            ControllerGame.spielerLebt = false;
            if (ControllerGame.score > ControllerGame.userData.Highscore)
            {
                //APPLAUS NEUER HIGHSCORE (Einfügen, Danke<3)
                ControllerGame.changeScore();
            }
            ViewDeathScreen deathScreen = new ViewDeathScreen();
            deathScreen.ShowDialog();
        }


        
    }
}
