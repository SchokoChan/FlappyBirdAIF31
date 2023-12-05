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
    public partial class ViewDeathScreen : Form
    {
        public ViewDeathScreen()
        {
            InitializeComponent();
        }

        private void Neustart_Click(object sender, EventArgs e)
        {

        }

        private void Beenden_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }

}


