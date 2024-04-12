namespace BluescreenSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRASH CRASH = new CRASH();
            CRASH.ShowDialog();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            win10hbsod_t win10Hbsod_T = new win10hbsod_t();
            win10Hbsod_T.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            winxpt winxpt = new winxpt();
            winxpt.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            w9xt w9xt = new w9xt();
            w9xt.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sbt sbt = new sbt();
            sbt.ShowDialog();
            this.Hide();
        }
    }
}
