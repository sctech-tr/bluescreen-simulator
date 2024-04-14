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
    public partial class windows1Timer : Form
    {
        public windows1Timer()
        {
            InitializeComponent();
        }

        private void windows1Timer_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor.Hide();
            timer1.Enabled = false;
            windows1BSOD w9xc = new windows1BSOD();
            w9xc.Show();
            this.Hide();
        }
    }
}
