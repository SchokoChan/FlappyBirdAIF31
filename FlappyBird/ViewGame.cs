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
            vogelThread.Start();
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
                if(fallenAbschlussCode == 0)
                {
                    //gut
                }
                else
                {
                    //nicht gut
                }
                Thread.Sleep(10);
                
            }

        }


        private int vogelFallen()
        {
            PictureBox vogel = pannelBoxVogel;
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

    }
}
