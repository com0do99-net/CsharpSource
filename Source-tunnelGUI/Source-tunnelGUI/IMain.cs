using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Source_tunnelGUI
{
    public partial class IMain : Form
    {
        private bool fStartStop;
        private string command;
        private string location = Application.StartupPath + "\\App\\BvSsh.exe";

        public IMain()
        {
            InitializeComponent();
        }

        /*
         * Read more command
         * https://www.bitvise.com/files/tunnelier-params.txt
         */

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.fStartStop)
            {
                this.fStartStop = false;
                this.btnStart.Text = "Start";

                command = " -host=" + txtHost.Text + " -port=" + txtPortHost.Text + " -username=" + txtusername.Text
                        + " -password=" + txtPassword.Text + " -loginOnStartup -title=[com0do99.net]SshTunnel" + " -proxy=n"
                        + " -proxyUsername=" + txtusername.Text + " -proxyPassword=" + txtPassword.Text;
                Process.Start(location, command);
            }
            else
            {
                this.fStartStop = true;
                this.btnStart.Text = "Stop";
                Stop("BvSsh.exe");
            }
        }

        void Stop(string name)
        {
            Process[] pcs;
            pcs = Process.GetProcessesByName(name);
            if (pcs.Length > 0)
                foreach (Process tn in pcs)
                    tn.Kill();
        }
    }
}
