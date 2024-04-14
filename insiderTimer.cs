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
    public partial class insiderTimer : Form
    {
        public insiderTimer()
        {
            InitializeComponent();
        }

        private void insiderTimer_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor.Hide();
            timer1.Enabled = false;
            insiderBSOD view = new insiderBSOD();
            view.Show();
            this.Hide();
        }
    }
}
