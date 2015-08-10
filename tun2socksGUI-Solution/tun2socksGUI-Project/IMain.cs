using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.IO;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Net;
using System.Timers;
using System.Diagnostics;
using System.Collections;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace tun2socksGUI_Project
{
    public partial class IMain : Form
    {
        char coma = '"';
        private string tap_loc32 = Application.StartupPath + "\\tap-driver\\x86\\tapinstall.exe";
        private string tap_loc64 = Application.StartupPath + "\\tap-driver\\x64\\tapinstall.exe";
        private string tun_loc = Application.StartupPath + "\\tun2sock\\badvpn-tun2socks.exe";
        private string dns2socks_loc = Application.StartupPath + "\\tun2sock\\dns2socks.exe";

        public IMain()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.intel;
        }

        private void InitializeNetworkInterface()
        {
            tunTapAdapter.Text = ""; 
            netInterface.Text = "";
            tunTapAdapter.Items.Clear();
            netInterface.Items.Clear();

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                    netInterface.Items.Add(nic.Name);

                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    tunTapAdapter.Items.Add(nic.Name);
            }
        }

        private void netInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            textLocalIP.Clear();
            textDNS.Clear();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                {
                    if (nic.OperationalStatus == OperationalStatus.Up)
                        if (nic.Description == netInterface.Text)
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                textLocalIP.Text = ip.Address.ToString();
                                foreach (IPAddress dnsAdress in nic.GetIPProperties().DnsAddresses)
                                {
                                    if (!textDNS.Text.Contains(dnsAdress.ToString()))
                                        textDNS.AppendText(dnsAdress.ToString() + Environment.NewLine);
                                }
                            }
                }
            } 
        }

        private void IMain_Load(object sender, EventArgs e)
        {
            InitializeNetworkInterface();
        }

        string badvpn_param = string.Empty;
        private void startStopButton_Click(object sender, EventArgs e)
        {
            string tunparam = string.Empty;

            if (startStopButton.Text == "Start")
            {
                _log(new string[] { "Setting IP Adapter", "-" });
                tunparam = "netsh interface ip set address name=" + coma + tunTapAdapter.Text + coma + " static 10.0.0.3 255.255.255.0";
                _executeWithOutput(new string[] { "cmd", "/c " + tunparam });

                Thread.Sleep(1000);
                _log(new string[]{ "Setting Adapter", "Success"});

                badvpn_param = "--tundev " + coma + "tap0901:" + tunTapAdapter.Text + ":10.0.0.3:10.0.0.0:255.255.255.0" + coma +
                    " --netif-ipaddr 10.0.0.1 --netif-netmask 255.255.255.0 --socks-server-addr " + socksProxy.Text;
                
                _executeWithOutput(new string[] { tun_loc, badvpn_param });
                Thread.Sleep(1000);
                _log(new string[] { "Lauch badvpn-tun2socks", "Success" });

                _executeWithOutput(new string[] { tun_loc, badvpn_param });

                Thread.Sleep(3000);
                _routeLine();
                Thread.Sleep(1000);
                _log(new string[] { "Routing", "Success" });

                Thread.Sleep(1000);
                startStopButton.Text = "Stop";
            }
            else
            {
                _rollingBack();
                Thread.Sleep(1000);
                startStopButton.Text = "Start";
            }
        }

        private void _log(string[] value)
        {
            textBox1.AppendText(value[0] +" : "+ value[1] + Environment.NewLine);
        }

        private void _rollingBack()
        {
            string arg1 = "";
            string[] lst = textDNS.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lst)
            {

                arg1 = "route delete " + line;
                _executeWithOutput(new string[] { "cmd.exe", "/c " + arg1 });
            }
            Thread.Sleep(1000);
            _log(new string[] { "Rolling Back Configuration", "Success" });
        }

        private void _routeLine()
        {
            string arg1 = "";

            arg1 = "route delete 0.0.0.0 & ";
            arg1 = arg1 + "route add 0.0.0.0 mask 0.0.0.0 10.0.0.1 metric 30 & ";
            arg1 = arg1 + "route add 0.0.0.0 mask 128.0.0.0 10.0.0.1 metric 30 & ";
            arg1 = arg1 + "route add 128.0.0.0 mask 128.0.0.0 10.0.0.1 metric 30 & ";

            string[] lst = textDNS.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lst)
            {
                arg1 = arg1 + "route add " + line + " mask 255.255.255.255 " + textLocalIP.Text + " metric 2 & ";
                _executeWithOutput(new string[] { "cmd.exe", "/c " + arg1 });
            }

            if (addRoute.Checked)
                _executeWithOutput(new string[] { "cmd.exe", "/c " + "route add " + routeProxy.Text + " mask 255.255.255.255 " + textLocalIP.Text });

        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            string Oem_loc = Application.StartupPath + "\\tap-driver\\OemWin2k.inf";
            string arguments = "install " + '"' + Oem_loc + '"' + " " + " TAP0901";

            if (File.Exists(tap_loc32))
            {
                _executeWithOutput(new string[] { tap_loc32, arguments });

                Thread.Sleep(4000);
                InitializeNetworkInterface();
            }
        }

        private void remTapButton_Click(object sender, EventArgs e)
        {
            string Tap_loc = Application.StartupPath + "\\tap-driver\\tapinstall.exe";
            _executeWithOutput(new string[] { Tap_loc, "remove TAP0901" });
        }
        
        private void refreshButton_Click(object sender, EventArgs e)
        {
            InitializeNetworkInterface();
        }

        private void routeButton_Click(object sender, EventArgs e){
            _executeWithOutput(new string[] { "cmd.exe", "/c " + "route.exe print" });
        }

        private void _executeWithOutput(string[] str)
        {
            Process process = new Process();

            ProcessStartInfo procStartInfo = new ProcessStartInfo(str[0], str[1]);
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.RedirectStandardInput  = true;
            procStartInfo.Verb = "runas";

            process.StartInfo = procStartInfo;
            process.Start();

            string result;
            while ((result = process.StandardOutput.ReadLine()) != null)
            {
                textBox1.AppendText(str[0] + " : " + result + Environment.NewLine);
            }
        }
    }
}
