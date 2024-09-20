using System;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleTaskManager
{
    public partial class TaskManagerForm : Form
    {
        public TaskManagerForm()
        {
            InitializeComponent();
            GetProcess();
        }

        Process[] processes;
        PerformanceCounter cpuCounter;

        void GetProcess() 
        {
            processes = Process.GetProcesses();
            listView.Items.Clear();
            foreach (Process p in processes)
            {
                try
                {
                    cpuCounter = new PerformanceCounter("Process", "% Processor Time", p.ProcessName, true);
                    cpuCounter.NextValue();

                    float cpuUsage = cpuCounter.NextValue() / Environment.ProcessorCount;

                    float ramUsage = (float)p.PrivateMemorySize64 / (float)new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory * 100;

                    ListViewItem newItem = new ListViewItem(p.ProcessName);
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = p.Id.ToString() });
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = MemoryToString(p.PrivateMemorySize64) });
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ramUsage.ToString("F2") + "%" });
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (p.Responding == true ? "Responding" : "Not responding") });
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (p.MainWindowHandle == IntPtr.Zero) ? "Background Process" : (String.IsNullOrEmpty(p.MainWindowTitle) ? "Window Process" : "App") });
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = p.PrivateMemorySize64.ToString() });
                    listView.Items.Add(newItem);
                }
                catch
                {
                    Exception exception = new Exception();
                    Console.WriteLine("error en la lista" + exception.Message);
                }
            }
        }

        string MemoryToString(long memory) 
        {
            string[] suffixes = { " B", " KB", " MB", " GB", " TB", " PB" };
            for (int i = 0; i < suffixes.Length; i++)
            {
                long tmp = memory / (int)Math.Pow(1024, i + 1);
                if (tmp == 0)
                    return (memory / (int)Math.Pow(1024, i)) + suffixes[i];

            }
            return memory.ToString();
        }

        void changeColor()
        {
            try
            {
                foreach (Process p in processes)
                {
                    int i = 0;
                    if (i % 2 == 0) listView.Items[i].BackColor = Color.Moccasin;
                    else listView.Items[i].BackColor = Color.White;
                    i++;
                }
            }
            catch
            {

            }
        }

        private Process getSelectedProcess() 
        {
            int index = 0;
            foreach (Process p in processes)
            {
                if (p.Id == Int16.Parse(listView.SelectedItems[0].SubItems[1].Text))
                {
                    index = processes.ToList().IndexOf(p);
                    break;
                }
            }
            return processes[index];
        }

        private void endTaskToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().Kill();
            }
            GetProcess();
            changeColor();
        }

        private void idleToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().PriorityClass = ProcessPriorityClass.Idle;
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().PriorityClass = ProcessPriorityClass.Normal;
            }
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().PriorityClass = ProcessPriorityClass.High;
            }
        }

        private void realtimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().PriorityClass = ProcessPriorityClass.RealTime;
            }
        }

        private void endTaskButton_Click(object sender, EventArgs e) { 
            if (listView.SelectedItems.Count > 0)
            {
                getSelectedProcess().Kill();
            }
            GetProcess();
            changeColor();
        }

        private void reloadButton_Click(object sender, EventArgs e) 
        {
            GetProcess();
            changeColor();
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e) 
        {
            listView.ListViewItemSorter = new ListViewItemComparer(e.Column);
            listView.Sort();
            changeColor();
        }

        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            using (RunNewTaskForm runNewTaskForm = new RunNewTaskForm())
            {
                if (runNewTaskForm.ShowDialog() == DialogResult.OK)
                {
                    GetProcess();
                    changeColor();
                }
            }
        }

        private void performanceToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            PerfForm perfForm = new PerfForm();
            perfForm.ShowDialog();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TaskManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void toolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}