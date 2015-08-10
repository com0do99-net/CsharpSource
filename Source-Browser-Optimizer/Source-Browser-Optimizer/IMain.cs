using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Source_Browser_Optimizer
{
    public partial class IMain : Form
    {
        private bool fStartStop;
        public IMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.fStartStop)
            {
                this.fStartStop = false;
                this.button1.Text = "Start";
                timer1.Stop();
            }
            else
            {
                this.fStartStop = true;
                this.button1.Text = "Stop";
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBoxProcess.Text != string.Empty)
            {
                timer1.Interval = Convert.ToInt32(numericUpDown1.Value) * 1000;
                WorkingSet.setMaximizeProcess(textBoxProcess.Text, 568000, 568000);
            }
        }
    }
}
