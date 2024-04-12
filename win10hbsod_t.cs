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
    public partial class win10hbsod_t : Form
    {
        public win10hbsod_t()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor.Hide();
            timer1.Enabled = false;
            winhbsod whbsod = new winhbsod();
            whbsod.Show();
            this.Hide();
        }

        private void win10hbsod_t_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
