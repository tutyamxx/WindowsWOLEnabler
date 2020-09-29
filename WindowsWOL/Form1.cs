﻿using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Management.Automation;

namespace WindowsWOL
{
    public partial class FormUI : Form
    {
        public FormUI()
        {
            InitializeComponent();
        }

        string NetWorkAdapterName = "";

        private string GetInternalIP()
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = hostEntry.AddressList;

            var ip = addr.Where(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).FirstOrDefault();

            return ip.ToString() ?? "";
        }

        private void RunSilentProcess(string Argument)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                Arguments = Argument.Trim(),
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "powercfg.exe",
                UseShellExecute = false
            };

            Process.Start(psi);
        }

        private void RunSilentPowerShell(string Argument)
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                PowerShellInstance.AddScript(Argument.Trim());
                IAsyncResult result = PowerShellInstance.BeginInvoke();

                while (result.IsCompleted == false)
                {
                    Button_EnableWOL.Text = "Enabling Wake-on-LAN...";
                    Button_EnableWOL.Enabled = false;
                }

                Button_EnableWOL.Enabled = true;
                Button_EnableWOL.Text = "Enable Wake-on-LAN";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button_EnableWOL.Text = "Enable Wake-on-LAN";
            NetworkInterface[] networks = NetworkInterface.GetAllNetworkInterfaces();

            var GetActiveNetworkAdapter = networks.First(x => x.NetworkInterfaceType != NetworkInterfaceType.Loopback && x.NetworkInterfaceType != NetworkInterfaceType.Tunnel && x.OperationalStatus == OperationalStatus.Up && x.Name.StartsWith("vEthernet") == false);

            if(GetActiveNetworkAdapter.NetworkInterfaceType.ToString() != "Ethernet")
            {
                MessageBox.Show("You need a wired Ethernet connection in order to use/enable Wake-on-LAN on this machine!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            NetWorkAdapterName = GetActiveNetworkAdapter.Description.ToString();
            label_NetworkAdapterName.Text = "Adapter: " + GetActiveNetworkAdapter.Description;

            textBox_IPv4_Address.Text = GetInternalIP();

            // --| I used this random IP for screenshot
            // textBox_IPv4_Address.Text = "192.168.1.19";

            String GetMachineMacAddress = NetworkInterface.GetAllNetworkInterfaces().Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback).Select(nic => nic.GetPhysicalAddress().ToString()).FirstOrDefault();
            var FormatValidateMacAddress = string.Join("-", Enumerable.Range(0, 6).Select(i => GetMachineMacAddress.Substring(i * 2, 2)));

            textBox_MacAddress.Text = FormatValidateMacAddress;

            // --| I used this randomly generated mac address for screenshot
            //textBox_MacAddress.Text = "BE-43-A2-67-6A-97";
        }

        private void Button_EnableWOL_Click(object sender, EventArgs e)
        {
            // --| Using windows powercfg.exe
            // --| Enable the option "Allow this device to wake the computer" for the user's currently used network adapter.
            RunSilentProcess("-deviceenablewake \"" + NetWorkAdapterName.Trim() + "\"");

            // --| Enable Wake on magic packet, Shutdown Wake Up and disable Energy Efficient Ethernet properties
            // --| https://docs.microsoft.com/en-us/powershell/module/netadapter/set-netadapteradvancedproperty?view=win10-ps
            RunSilentPowerShell("Set-NetAdapterAdvancedProperty -Name \"Ethernet\" -DisplayName \"Wake on magic packet\" -DisplayValue \"Enabled\"");
            RunSilentPowerShell("Set-NetAdapterAdvancedProperty -Name \"Ethernet\" -DisplayName \"Shutdown Wake Up\" -DisplayValue \"Enabled\"");
            RunSilentPowerShell("Set-NetAdapterAdvancedProperty -Name \"Ethernet\" -DisplayName \"Energy Efficient Ethernet\" -DisplayValue \"Disabled\"");


            // --| Done :3
            MessageBox.Show("Successfully enabled Wake-on-LAN operating system settings for this computer!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}