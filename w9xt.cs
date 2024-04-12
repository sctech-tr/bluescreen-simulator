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
    public partial class w9xt : Form
    {
        public w9xt()
        {
            InitializeComponent();
        }

        private void w9xt_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor.Hide();
            timer1.Enabled = false;
            w9xcrash w9xc = new w9xcrash();
            w9xc.Show();
            this.Hide();
        }
    }
}
