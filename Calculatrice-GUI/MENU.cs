using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice_GUI
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void caclutriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculatrice f = new frmCalculatrice();
            f.Show();
        }
    }
}
