using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseProjectTSP
{

    public partial class Home : Form
    {
        public static bool home = false;
        public Home()
        {
            InitializeComponent();
        }

        private void visualization_Click(object sender, EventArgs e)
        {
            var t = new Initializer();
            t.ShowDialog();
        }

        private void information_Click(object sender, EventArgs e)
        {
            var t = new Information();
            t.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
