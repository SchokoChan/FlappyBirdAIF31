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
            Thread vogelThread = new Thread(vogelMethode) ;
            Thread hindernissThread = new Thread(hindernissMethode);
            vogelThread.Start();
            hindernissThread.Start();

        }

        private void ViewGame_Load(object sender, EventArgs e)
        {
            

        }

        private void ViewGame_Click(object sender, EventArgs e)
        {
            pannelBoxVogel.Location = new Point(pannelBoxVogel.Location.X, pannelBoxVogel.Location.Y-50);
        }

        private void ViewGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == ' ')
            {

                pannelBoxVogel.Location = new Point(pannelBoxVogel.Location.X, pannelBoxVogel.Location.Y - 50);
            }
        }

        private void vogelMethode()
        {
            while (true)
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
                     
                Thread.Sleep(10);
                
            }

        }


        private int vogelFallen()
        {
            PictureBox vogel = pannelBoxVogel;
            
            if(ControllerGame.spielerLebt == true) 
            {
                if (vogel.InvokeRequired)
                {
                    vogel.Invoke(new Action(() => {
                        vogel.Location = new Point(vogel.Location.X, vogel.Location.Y + 5);
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
            while (true)

            {
                switch (hindernissBewegen(panelRoehre1, pannelBoxRoehre2, pannelBoxRoehre4))

                {
                    
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Fehlercode 1: Falscher Thread beim invoken!");
                        break;
                }
                switch (hindernissBewegen(panelRoehre2, pannelBoxRoehre1, pannelBoxRoehre3))
                {

                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Fehlercode 1: Falscher Thread beim invoken!");
                        break;
                }
                Thread.Sleep(10);
            }
        }
        private int hindernissBewegen(Panel p,PictureBox roehre1, PictureBox roehre2)
        {

            if (ControllerGame.spielerLebt == true)
            {
                if (p.InvokeRequired)
                {
                    p.Invoke(new Action(() => {
                        p.Location = new Point(p.Location.X -5 , p.Location.Y );
                    }));
                    roehre1.Invoke(new Action(() => {
                        roehre1.Location = new Point(roehre1.Location.X -5 , roehre1.Location.Y );
                    }));
                    roehre2.Invoke(new Action(() => {
                        roehre2.Location = new Point(roehre2.Location.X -5 , roehre2.Location.Y );
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
