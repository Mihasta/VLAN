using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace BugTracking
{
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();
        }

        private void information_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher11 =
            new ManagementObjectSearcher("root\\CIMV2",
            "SELECT * FROM Win32_VideoController");

            foreach (ManagementObject queryObj in searcher11.Get())
            {
                label1.Text = "----------- Win32_VideoController instance -----------";
                label2.Text = string.Format("AdapterRAM: {0}", queryObj["AdapterRAM"]);
                label3.Text = string.Format("Caption: {0}", queryObj["Caption"]);
                label4.Text = string.Format("Description: {0}", queryObj["Description"]);
                label5.Text = string.Format("VideoProcessor: {0}", queryObj["VideoProcessor"]);
            }

            ManagementObjectSearcher searcher8 =
            new ManagementObjectSearcher("root\\CIMV2",
            "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj in searcher8.Get())
            {
                label6.Text = string.Format("------------- Win32_Processor instance ---------------");
                label7.Text = string.Format("Name: {0}", queryObj["Name"]);
                label8.Text = string.Format("NumberOfCores: {0}", queryObj["NumberOfCores"]);
                label9.Text = string.Format("ProcessorId: {0}", queryObj["ProcessorId"]);
            }

            ManagementObjectSearcher searcher12 =
            new ManagementObjectSearcher("root\\CIMV2",
            "SELECT * FROM Win32_PhysicalMemory");

            label10.Text = ("------------- Win32_PhysicalMemory instance --------");
            foreach (ManagementObject queryObj in searcher12.Get())
            {
                listBox1.Items.Add(String.Format("BankLabel: {0} ; Capacity: {1} Gb; Speed: {2} ", queryObj["BankLabel"],
                                       Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024, 2),
                                        queryObj["Speed"]));
            }
        }
    }
}
