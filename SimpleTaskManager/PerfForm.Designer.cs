namespace SimpleTaskManager
{
    partial class PerfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pDISK = new System.Diagnostics.PerformanceCounter();
            this.pReadSpd = new System.Diagnostics.PerformanceCounter();
            this.pWriteSpd = new System.Diagnostics.PerformanceCounter();
            this.pRAMcmt = new System.Diagnostics.PerformanceCounter();
            this.pRAMavai = new System.Diagnostics.PerformanceCounter();
            this.pCached = new System.Diagnostics.PerformanceCounter();
            this.pPaged = new System.Diagnostics.PerformanceCounter();
            this.pNPaged = new System.Diagnostics.PerformanceCounter();
            this.pHandle = new System.Diagnostics.PerformanceCounter();
            this.pProcess = new System.Diagnostics.PerformanceCounter();
            this.tabDisk = new System.Windows.Forms.TabPage();
            this.labelWriteSpd = new System.Windows.Forms.Label();
            this.labelReadSpd = new System.Windows.Forms.Label();
            this.labelDiskUse = new System.Windows.Forms.Label();
            this.chartDiskRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartDiskUse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.tabRAM = new System.Windows.Forms.TabPage();
            this.labelCmt = new System.Windows.Forms.Label();
            this.labelNPaged = new System.Windows.Forms.Label();
            this.labelPaged = new System.Windows.Forms.Label();
            this.labelCached = new System.Windows.Forms.Label();
            this.labelRamAvai = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartRAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabCPU = new System.Windows.Forms.TabPage();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProcess = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelHandle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPerformance = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDISK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReadSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWriteSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMcmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMavai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCached)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPaged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNPaged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHandle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pProcess)).BeginInit();
            this.tabDisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskUse)).BeginInit();
            this.tabRAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).BeginInit();
            this.tabCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.tabPerformance.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pDISK
            // 
            this.pDISK.CategoryName = "PhysicalDisk";
            this.pDISK.CounterName = "% Disk Time";
            this.pDISK.InstanceName = "_Total";
            // 
            // pReadSpd
            // 
            this.pReadSpd.CategoryName = "PhysicalDisk";
            this.pReadSpd.CounterName = "Disk Read Bytes/sec";
            this.pReadSpd.InstanceName = "_Total";
            // 
            // pWriteSpd
            // 
            this.pWriteSpd.CategoryName = "PhysicalDisk";
            this.pWriteSpd.CounterName = "Disk Write Bytes/sec";
            this.pWriteSpd.InstanceName = "_Total";
            // 
            // pRAMcmt
            // 
            this.pRAMcmt.CategoryName = "Memory";
            this.pRAMcmt.CounterName = "Committed Bytes";
            // 
            // pRAMavai
            // 
            this.pRAMavai.CategoryName = "Memory";
            this.pRAMavai.CounterName = "Available MBytes";
            // 
            // pCached
            // 
            this.pCached.CategoryName = "Memory";
            this.pCached.CounterName = "Cache Bytes";
            // 
            // pPaged
            // 
            this.pPaged.CategoryName = "Memory";
            this.pPaged.CounterName = "Pool Paged Bytes";
            // 
            // pNPaged
            // 
            this.pNPaged.CategoryName = "Memory";
            this.pNPaged.CounterName = "Pool Nonpaged Bytes";
            // 
            // pHandle
            // 
            this.pHandle.CategoryName = "Process";
            this.pHandle.CounterName = "Handle Count";
            this.pHandle.InstanceName = "_Total";
            // 
            // pProcess
            // 
            this.pProcess.CategoryName = "Process";
            this.pProcess.CounterName = "Thread Count";
            this.pProcess.InstanceName = "_Total";
            // 
            // tabDisk
            // 
            this.tabDisk.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabDisk.Controls.Add(this.labelWriteSpd);
            this.tabDisk.Controls.Add(this.labelReadSpd);
            this.tabDisk.Controls.Add(this.labelDiskUse);
            this.tabDisk.Controls.Add(this.chartDiskRate);
            this.tabDisk.Controls.Add(this.label9);
            this.tabDisk.Controls.Add(this.label8);
            this.tabDisk.Controls.Add(this.label6);
            this.tabDisk.Controls.Add(this.chartDiskUse);
            this.tabDisk.Controls.Add(this.label5);
            this.tabDisk.Location = new System.Drawing.Point(4, 38);
            this.tabDisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDisk.Name = "tabDisk";
            this.tabDisk.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDisk.Size = new System.Drawing.Size(907, 665);
            this.tabDisk.TabIndex = 2;
            this.tabDisk.Text = "Disk";
            // 
            // labelWriteSpd
            // 
            this.labelWriteSpd.AutoSize = true;
            this.labelWriteSpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelWriteSpd.Location = new System.Drawing.Point(680, 567);
            this.labelWriteSpd.Name = "labelWriteSpd";
            this.labelWriteSpd.Size = new System.Drawing.Size(77, 26);
            this.labelWriteSpd.TabIndex = 4;
            this.labelWriteSpd.Text = "0 KB/s";
            // 
            // labelReadSpd
            // 
            this.labelReadSpd.AutoSize = true;
            this.labelReadSpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelReadSpd.Location = new System.Drawing.Point(300, 567);
            this.labelReadSpd.Name = "labelReadSpd";
            this.labelReadSpd.Size = new System.Drawing.Size(77, 26);
            this.labelReadSpd.TabIndex = 4;
            this.labelReadSpd.Text = "0 KB/s";
            // 
            // labelDiskUse
            // 
            this.labelDiskUse.AutoSize = true;
            this.labelDiskUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelDiskUse.Location = new System.Drawing.Point(46, 567);
            this.labelDiskUse.Name = "labelDiskUse";
            this.labelDiskUse.Size = new System.Drawing.Size(44, 26);
            this.labelDiskUse.TabIndex = 4;
            this.labelDiskUse.Text = "0%";
            // 
            // chartDiskRate
            // 
            this.chartDiskRate.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            this.chartDiskRate.BackColor = System.Drawing.Color.DarkGray;
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea5.Name = "ChartArea1";
            this.chartDiskRate.ChartAreas.Add(chartArea5);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartDiskRate.Legends.Add(legend4);
            this.chartDiskRate.Location = new System.Drawing.Point(15, 373);
            this.chartDiskRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDiskRate.Name = "chartDiskRate";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "DiskRead";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "DiskWrite";
            this.chartDiskRate.Series.Add(series6);
            this.chartDiskRate.Series.Add(series7);
            this.chartDiskRate.Size = new System.Drawing.Size(700, 117);
            this.chartDiskRate.TabIndex = 3;
            this.chartDiskRate.Text = "chart2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.Location = new System.Drawing.Point(606, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "Velocidad de Escritura";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(268, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "Velocidad de Lectura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(9, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tiempo Activo";
            // 
            // chartDiskUse
            // 
            this.chartDiskUse.BackColor = System.Drawing.Color.DarkGray;
            chartArea6.Name = "ChartArea1";
            this.chartDiskUse.ChartAreas.Add(chartArea6);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chartDiskUse.Legends.Add(legend5);
            this.chartDiskUse.Location = new System.Drawing.Point(15, 67);
            this.chartDiskUse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDiskUse.Name = "chartDiskUse";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "DiskUse";
            this.chartDiskUse.Series.Add(series8);
            this.chartDiskUse.Size = new System.Drawing.Size(700, 300);
            this.chartDiskUse.TabIndex = 1;
            this.chartDiskUse.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(26, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "USO DE DISCO";
            // 
            // tabRAM
            // 
            this.tabRAM.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabRAM.Controls.Add(this.labelCmt);
            this.tabRAM.Controls.Add(this.labelNPaged);
            this.tabRAM.Controls.Add(this.labelPaged);
            this.tabRAM.Controls.Add(this.labelCached);
            this.tabRAM.Controls.Add(this.labelRamAvai);
            this.tabRAM.Controls.Add(this.labelRAM);
            this.tabRAM.Controls.Add(this.label7);
            this.tabRAM.Controls.Add(this.label14);
            this.tabRAM.Controls.Add(this.label13);
            this.tabRAM.Controls.Add(this.label12);
            this.tabRAM.Controls.Add(this.label11);
            this.tabRAM.Controls.Add(this.label4);
            this.tabRAM.Controls.Add(this.label3);
            this.tabRAM.Controls.Add(this.chartRAM);
            this.tabRAM.Location = new System.Drawing.Point(4, 38);
            this.tabRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRAM.Name = "tabRAM";
            this.tabRAM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRAM.Size = new System.Drawing.Size(907, 665);
            this.tabRAM.TabIndex = 1;
            this.tabRAM.Text = "RAM";
            // 
            // labelCmt
            // 
            this.labelCmt.AutoSize = true;
            this.labelCmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelCmt.Location = new System.Drawing.Point(50, 529);
            this.labelCmt.Name = "labelCmt";
            this.labelCmt.Size = new System.Drawing.Size(62, 26);
            this.labelCmt.TabIndex = 1;
            this.labelCmt.Text = "0 GB";
            // 
            // labelNPaged
            // 
            this.labelNPaged.AutoSize = true;
            this.labelNPaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelNPaged.Location = new System.Drawing.Point(641, 529);
            this.labelNPaged.Name = "labelNPaged";
            this.labelNPaged.Size = new System.Drawing.Size(63, 26);
            this.labelNPaged.TabIndex = 1;
            this.labelNPaged.Text = "0 MB";
            // 
            // labelPaged
            // 
            this.labelPaged.AutoSize = true;
            this.labelPaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelPaged.Location = new System.Drawing.Point(366, 529);
            this.labelPaged.Name = "labelPaged";
            this.labelPaged.Size = new System.Drawing.Size(63, 26);
            this.labelPaged.TabIndex = 1;
            this.labelPaged.Text = "0 MB";
            // 
            // labelCached
            // 
            this.labelCached.AutoSize = true;
            this.labelCached.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelCached.Location = new System.Drawing.Point(641, 452);
            this.labelCached.Name = "labelCached";
            this.labelCached.Size = new System.Drawing.Size(62, 26);
            this.labelCached.TabIndex = 1;
            this.labelCached.Text = "0 GB";
            // 
            // labelRamAvai
            // 
            this.labelRamAvai.AutoSize = true;
            this.labelRamAvai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelRamAvai.Location = new System.Drawing.Point(366, 452);
            this.labelRamAvai.Name = "labelRamAvai";
            this.labelRamAvai.Size = new System.Drawing.Size(62, 26);
            this.labelRamAvai.TabIndex = 1;
            this.labelRamAvai.Text = "0 GB";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelRAM.Location = new System.Drawing.Point(50, 452);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(62, 26);
            this.labelRAM.TabIndex = 1;
            this.labelRAM.Text = "0 GB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(50, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Comprometida";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label14.Location = new System.Drawing.Point(640, 493);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 31);
            this.label14.TabIndex = 1;
            this.label14.Text = "Non-paged pool";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label13.Location = new System.Drawing.Point(640, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 31);
            this.label13.TabIndex = 1;
            this.label13.Text = "En Cache";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label12.Location = new System.Drawing.Point(366, 493);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 31);
            this.label12.TabIndex = 1;
            this.label12.Text = "Paged pool";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label11.Location = new System.Drawing.Point(366, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 31);
            this.label11.TabIndex = 1;
            this.label11.Text = "Disponible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(50, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "En Uso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "USO DE MEMORIA";
            // 
            // chartRAM
            // 
            this.chartRAM.BackColor = System.Drawing.Color.DarkGray;
            chartArea7.AxisY.Maximum = 100D;
            chartArea7.Name = "ChartArea1";
            this.chartRAM.ChartAreas.Add(chartArea7);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chartRAM.Legends.Add(legend6);
            this.chartRAM.Location = new System.Drawing.Point(18, 63);
            this.chartRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartRAM.Name = "chartRAM";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "RAM";
            this.chartRAM.Series.Add(series9);
            this.chartRAM.Size = new System.Drawing.Size(700, 300);
            this.chartRAM.TabIndex = 0;
            this.chartRAM.Text = "chartRAM";
            // 
            // tabCPU
            // 
            this.tabCPU.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabCPU.Controls.Add(this.chartCPU);
            this.tabCPU.Controls.Add(this.label2);
            this.tabCPU.Controls.Add(this.labelProcess);
            this.tabCPU.Controls.Add(this.label16);
            this.tabCPU.Controls.Add(this.labelHandle);
            this.tabCPU.Controls.Add(this.label10);
            this.tabCPU.Controls.Add(this.labelCPU);
            this.tabCPU.Controls.Add(this.label1);
            this.tabCPU.Location = new System.Drawing.Point(4, 38);
            this.tabCPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCPU.Name = "tabCPU";
            this.tabCPU.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCPU.Size = new System.Drawing.Size(907, 665);
            this.tabCPU.TabIndex = 0;
            this.tabCPU.Text = "  CPU";
            // 
            // chartCPU
            // 
            this.chartCPU.BackColor = System.Drawing.Color.DarkGray;
            chartArea8.AxisY.Maximum = 100D;
            chartArea8.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea8.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea8);
            this.chartCPU.Location = new System.Drawing.Point(31, 71);
            this.chartCPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartCPU.Name = "chartCPU";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Name = "CPU";
            this.chartCPU.Series.Add(series10);
            this.chartCPU.Size = new System.Drawing.Size(700, 300);
            this.chartCPU.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(37, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "USO DE CPU";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelProcess.Location = new System.Drawing.Point(644, 479);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(24, 26);
            this.labelProcess.TabIndex = 0;
            this.labelProcess.Text = "0";
            this.labelProcess.Click += new System.EventHandler(this.labelProcess_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label16.Location = new System.Drawing.Point(642, 436);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 31);
            this.label16.TabIndex = 0;
            this.label16.Text = "Hilos";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // labelHandle
            // 
            this.labelHandle.AutoSize = true;
            this.labelHandle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelHandle.Location = new System.Drawing.Point(392, 479);
            this.labelHandle.Name = "labelHandle";
            this.labelHandle.Size = new System.Drawing.Size(24, 26);
            this.labelHandle.TabIndex = 0;
            this.labelHandle.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label10.Location = new System.Drawing.Point(390, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Handle";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelCPU.Location = new System.Drawing.Point(38, 479);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(50, 26);
            this.labelCPU.TabIndex = 0;
            this.labelCPU.Text = "0 %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(38, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "%CPU Usado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPerformance
            // 
            this.tabPerformance.AccessibleDescription = "";
            this.tabPerformance.Controls.Add(this.tabCPU);
            this.tabPerformance.Controls.Add(this.tabRAM);
            this.tabPerformance.Controls.Add(this.tabDisk);
            this.tabPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tabPerformance.Location = new System.Drawing.Point(0, 3);
            this.tabPerformance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPerformance.Name = "tabPerformance";
            this.tabPerformance.RightToLeftLayout = true;
            this.tabPerformance.SelectedIndex = 0;
            this.tabPerformance.Size = new System.Drawing.Size(915, 707);
            this.tabPerformance.TabIndex = 0;
            // 
            // PerfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 700);
            this.Controls.Add(this.tabPerformance);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PerfForm";
            this.Text = "Performance";
            this.Load += new System.EventHandler(this.perfForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDISK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReadSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWriteSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMcmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMavai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCached)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPaged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNPaged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHandle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pProcess)).EndInit();
            this.tabDisk.ResumeLayout(false);
            this.tabDisk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskUse)).EndInit();
            this.tabRAM.ResumeLayout(false);
            this.tabRAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).EndInit();
            this.tabCPU.ResumeLayout(false);
            this.tabCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            this.tabPerformance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pDISK;
        private System.Diagnostics.PerformanceCounter pReadSpd;
        private System.Diagnostics.PerformanceCounter pWriteSpd;
        private System.Diagnostics.PerformanceCounter pRAMcmt;
        private System.Diagnostics.PerformanceCounter pRAMavai;
        private System.Diagnostics.PerformanceCounter pCached;
        private System.Diagnostics.PerformanceCounter pPaged;
        private System.Diagnostics.PerformanceCounter pNPaged;
        private System.Diagnostics.PerformanceCounter pHandle;
        private System.Diagnostics.PerformanceCounter pProcess;
        private System.Windows.Forms.TabPage tabDisk;
        private System.Windows.Forms.Label labelWriteSpd;
        private System.Windows.Forms.Label labelReadSpd;
        private System.Windows.Forms.Label labelDiskUse;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiskRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiskUse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabRAM;
        private System.Windows.Forms.Label labelCmt;
        private System.Windows.Forms.Label labelNPaged;
        private System.Windows.Forms.Label labelPaged;
        private System.Windows.Forms.Label labelCached;
        private System.Windows.Forms.Label labelRamAvai;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRAM;
        private System.Windows.Forms.TabPage tabCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelHandle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabPerformance;
    }
}