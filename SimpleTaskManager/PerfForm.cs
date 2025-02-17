﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net.NetworkInformation;

namespace SimpleTaskManager
{
    public partial class PerfForm : Form
    {
        public PerfForm()
        {
            InitializeComponent();
        }

        private int count = 0;
        private PerformanceCounter pNetS = new PerformanceCounter();
        private PerformanceCounter pNetR = new PerformanceCounter();

        private void CPU_count(int count)
        {
            float fcpu = pCPU.NextValue();
            float fhandle = pHandle.NextValue();
            float fprocess = pProcess.NextValue();

            labelCPU.Text = string.Format("{0:0.00}%", fcpu);
            labelHandle.Text = string.Format("{0:0}", fhandle);
            labelProcess.Text = string.Format("{0:0}", fprocess);

            if (count >= 60)
                chartCPU.Series["CPU"].Points.RemoveAt(0);
            chartCPU.Series["CPU"].Points.AddY(fcpu);
        }

        private void RAM_count(int count) 
        {
            ComputerInfo cpI = new ComputerInfo();
            float avaiRAM = cpI.TotalPhysicalMemory / (1024 * 1024 * 1024); //GB
            float fram = pRAM.NextValue();
            float framCmt = pRAMcmt.NextValue();
            float framAvai = pRAMavai.NextValue();
            float fCached = pCached.NextValue();
            float fPaged = pPaged.NextValue();
            float fNPaged = pNPaged.NextValue();
            labelRAM.Text = string.Format("{0:0.0} GB", (fram/100) * avaiRAM);
            labelCmt.Text = string.Format("{0:0.0} GB", framCmt / (1024 * 1024 * 1024));
            labelRamAvai.Text = string.Format("{0:0.0} GB", framAvai / 1024);
            labelCached.Text = string.Format("{0:0.0} GB", fCached / (1024 * 1024 * 1024));
            labelPaged.Text = string.Format("{0:0} MB", fPaged / (1024 * 1024));
            labelNPaged.Text = string.Format("{0:0} MB", fNPaged / (1024 * 1024));

            if (count >= 60)
                chartRAM.Series["RAM"].Points.RemoveAt(0);
            chartRAM.Series["RAM"].Points.AddY(fram);
        }

        private void DISK_count(int count) 
        {
            float fdisk = pDISK.NextValue();
            float fdRead = pReadSpd.NextValue();
            float fdWrite = pWriteSpd.NextValue();
            labelDiskUse.Text = string.Format("{0:0}%", fdisk);
            labelReadSpd.Text = string.Format("{0:0.0} KB/s", fdRead / 1024);
            labelWriteSpd.Text = string.Format("{0:0.0} KB/s", fdWrite / 1024);

            if (count >= 60)
            {
                chartDiskUse.Series["DiskUse"].Points.RemoveAt(0);
                chartDiskRate.Series["DiskRead"].Points.RemoveAt(0);
                chartDiskRate.Series["DiskWrite"].Points.RemoveAt(0);
            }
            chartDiskUse.Series["DiskUse"].Points.AddY(fdisk);
            chartDiskRate.Series["DiskRead"].Points.AddY(fdRead / 1024);
            chartDiskRate.Series["DiskWrite"].Points.AddY(fdWrite / 1024);
        }

        private void INTERNET_count(int count) 
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            CPU_count(count);
            RAM_count(count);
            DISK_count(count);
            count++;
        }

        private void perfForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void labelProcess_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
