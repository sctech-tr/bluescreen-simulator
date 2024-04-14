using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BluescreenSimulator
{
    public partial class windowsNTTimer : Form
    {
        public windowsNTTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor.Hide();
            timer1.Enabled = false;
            windowsNTBSOD w = new windowsNTBSOD();
            w.Show();
            this.Hide();
        }

        private void windowsNTTimer_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
