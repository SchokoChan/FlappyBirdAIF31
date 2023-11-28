using System;
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
            Thread externalThread = new Thread(externalMethode);
            externalThread.Start();

        }

        private void ViewGame_Load(object sender, EventArgs e)
        {


        }

        private void ViewGame_Click(object sender, EventArgs e)
        {
            pannelBoxVogel.Location = new Point(pannelBoxVogel.Location.X, pannelBoxVogel.Location.Y - 75);
        }

        private void ViewGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == ' ')
            {

                pannelBoxVogel.Location = new Point(pannelBoxVogel.Location.X, pannelBoxVogel.Location.Y - 75);
            }
        }
        private void externalMethode()
        {
            try
            {
                while (true)
                {
                    switch(ControllerGame.ueberpruefenVonRoehren(pannelBoxRoehre1, pannelBoxRoehre2))
                    {
                        case 5:
                            pannelBoxRoehre1.Invoke(new Action(() =>
                            {
                                pannelBoxRoehre1.Location = new Point(730, ControllerGame.positionRoehren);
                                pannelBoxRoehre3.Location = new Point(730, 1024 - ControllerGame.positionRoehren - 160);
                            }));
                            break;
                        case 6:
                            pannelBoxRoehre1.Invoke(new Action(() =>
                            {
                                pannelBoxRoehre2.Location = new Point(730, ControllerGame.positionRoehren);
                                pannelBoxRoehre4.Location = new Point(730, 1024 - ControllerGame.positionRoehren - 160);
                            }));
                            break;
                        case 0:
                            break;
                    }
                    vogelMethode();
                    hindernissMethode();
                    Thread.Sleep(65);
                }
            }
            catch
            {
                Environment.Exit(0);
            }
        }
        private void vogelMethode()
        {
            
            int fallenAbschlussCode = vogelFallen();
            switch (fallenAbschlussCode)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Fehlercode 1: Falscher Thread beim invoken!");
                    break;
            }


            

        }


        private int vogelFallen()
        {
            PictureBox vogel = pannelBoxVogel;
            if (ControllerGame.spielerLebt == true)
            {
                if (vogel.InvokeRequired)
                {
                    vogel.Invoke(new Action(() =>
                    {
                        if (vogel.Location.Y >= 862)
                        {
                            ControllerGame.spielerLebt = false;
                        }
                        if (vogel.Location.Y <= 0)
                        {
                            ControllerGame.spielerLebt = false;
                        }
                        vogel.Location = new Point(vogel.Location.X, vogel.Location.Y + 10);
                    }));
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            return 0;

        }
        private void hindernissMethode()
        {
            
            switch (hindernissBewegen(pannelBoxRoehre2, pannelBoxRoehre4))

            {

                case 0:
                    break;
                case 1:
                    Console.WriteLine("Fehlercode 1: Falscher Thread beim invoken!");
                    break;
            }
            switch (hindernissBewegen(pannelBoxRoehre1, pannelBoxRoehre3))
            {

                case 0:
                    break;
                case 1:
                    Console.WriteLine("Fehlercode 1: Falscher Thread beim invoken!");
                    break;
            }
            
        }
        private int hindernissBewegen(PictureBox roehre1, PictureBox roehre2)
        {

            if (ControllerGame.spielerLebt == true)
            {
                if (roehre1.InvokeRequired)
                {

                    roehre1.Invoke(new Action(() =>
                    {
                        roehre1.Location = new Point(roehre1.Location.X - 10, roehre1.Location.Y);
                    }));
                    roehre2.Invoke(new Action(() =>
                    {
                        roehre2.Location = new Point(roehre2.Location.X - 10, roehre2.Location.Y);
                    }));
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            return 0;
        }



    }
}
