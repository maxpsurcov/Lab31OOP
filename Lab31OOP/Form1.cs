using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab31OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshProcessList();
        }
        private void RefreshProcessList()
        {
            processList.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                processList.Items.Add(process.ProcessName);
            }
        }
        private void exportProcessListButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Text files (*.txt)|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(dialog.FileName))
                    {
                        foreach (string processName in processList.Items)
                        {
                            writer.WriteLine(processName);
                        }
                    }
                }
            }
        }

        private void processList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (processList.SelectedIndex >= 0)
            {
                Process selectedProcess = Process.GetProcessesByName(processList.SelectedItem.ToString())[0];
                processContextMenuStrip.Tag = selectedProcess;
                modulesToolStripMenuItem.Enabled = true;
                threadsToolStripMenuItem.Enabled = true;
            }
            else
            {
                modulesToolStripMenuItem.Enabled = false;
                threadsToolStripMenuItem.Enabled = false;
            }
        }

        private void refreshProcessListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void stopProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Process selectedProcess = (Process)processContextMenuStrip.Tag;
                selectedProcess.Kill();
                selectedProcess.WaitForExit();
                RefreshProcessList();
        }

        private void threadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Process selectedProcess = (Process)processContextMenuStrip.Tag;
                string threads = "";
                foreach (ProcessThread thread in selectedProcess.Threads)
                {
                    threads += "Thread ID: " + thread.Id + Environment.NewLine;
                }
                MessageBox.Show(threads, "Threads for " + selectedProcess.ProcessName);
        }

        private void modulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Process selectedProcess = (Process)processContextMenuStrip.Tag;
                string modules = "";
                foreach (ProcessModule module in selectedProcess.Modules)
                {
                    modules += module.FileName + Environment.NewLine;
                }
                MessageBox.Show(modules, "Modules for " + selectedProcess.ProcessName);
        }
    }
}
