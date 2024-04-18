using System.Diagnostics;

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



        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Windows 10")
            {
                CRASH CRASH = new CRASH();
                CRASH.ShowDialog();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Windows 10 (happy)")
            {
                win10hbsod_t win10Hbsod_T = new win10hbsod_t();
                win10Hbsod_T.ShowDialog();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Windows XP to 7")
            {
                winxpt winxpt = new winxpt();
                winxpt.ShowDialog();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Windows 9x")
            {
                w9xt win9xt = new w9xt();
                win9xt.ShowDialog();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Windows 9x (system is busy)")
            {
                sbt sbt = new sbt();
                sbt.ShowDialog();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Windows 9x (warning)")
            {
                warningTimer warningTimer = new warningTimer();
                warningTimer.ShowDialog();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Windows NT")
            {
                windowsNTTimer windowsNTTimer = new windowsNTTimer();
                windowsNTTimer.ShowDialog();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Windows 1.0")
            {
                windows1Timer windows1Timer = new windows1Timer();
                windows1Timer.ShowDialog();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Windows Insider Build")
            {
                insiderTimer insiderTimer = new insiderTimer();
                insiderTimer.ShowDialog();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Windows Longhorn")
            {
                longhornTimer longhornTimer = new longhornTimer();
                longhornTimer.ShowDialog();
                this.Hide();
            }
            else
            {
                string m = "Please enter a valid entry.";
                string t = "BluescreenSimulator";
                MessageBox.Show(m, t);
            }
        }
    }
}
