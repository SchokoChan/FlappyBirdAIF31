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
    }
}
