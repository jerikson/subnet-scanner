using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace subnet_scanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        Thread _newThread = null;

        
        public void Scan(string subnet)
        {
            Ping ping;
            PingReply reply;
            IPAddress address;
            IPHostEntry host;
            txtBox_Hosts.Clear();

            for(int i = 1; i < 255; i ++ )
            {
                string subnetName = "." + i.ToString();
                ping = new Ping();
                reply = ping.Send(subnet + subnetName);

                if(reply.Status == IPStatus.Success)
                {
                    try
                    {
                        address = IPAddress.Parse(subnet + subnetName);
                        host = Dns.GetHostEntry(address);
                        txtBox_Hosts.AppendText(subnet + "" + subnetName + " " + host.HostName.ToString() + " [UP]\n");
                    }
                    catch (Exception ex) { }
                }
            }

        }

        private void btn_Scan_Click(object sender, EventArgs e)
        {
            _newThread = new Thread(() => Scan(txtBox_Ip.Text));
            _newThread.Start();
            if (_newThread.IsAlive)
            {
                btn_Scan.Text = "Scanning";
                btn_Stop.Enabled = true;
                btn_Scan.Enabled = false;
                txtBox_Ip.Enabled = false;

            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            _newThread.Suspend();
            btn_Scan.Text = "Scan";
            btn_Scan.Enabled = true;
            btn_Stop.Enabled = false;
            txtBox_Ip.Enabled = true;
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _newThread.Suspend();
        }

    }
}
