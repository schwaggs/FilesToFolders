using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FilesToFolders
{
    public partial class Form1 : Form
    {
        private DirectoryInfo directory { get; set; }
        private List<string> Extensions { get; set; }

        public Form1()
        {
            InitializeComponent();
            Extensions = new List<string>();
        }

        private void BrowseBT_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                IsFolderPicker = true,
            };

            if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                directory = new DirectoryInfo(dialog.FileName);
                DirPathTB.Text = directory.FullName;

                for(int i = 0; i < Extensions.Count; i ++)
                {
                    Extensions[i] = "." + Extensions[i].ToLower();
                }

                ConversionBW.RunWorkerAsync();
            }


        }

        private void ConversionBW_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CreationPB.InvokeRequired)
            {
                CreationPB.Invoke(new MethodInvoker(delegate
                {
                    CreationPB.Maximum = directory.GetFiles().Count();
                    CreationPB.Value = 0;
                }));
            }

            foreach(FileInfo file in directory.GetFiles())
            {
                if (Extensions.Contains(file.Extension.ToLower()))
                {
                    string dir = file.Name.Substring(0, file.Name.Length - 4);

                    if(directory.GetDirectories().Contains(new DirectoryInfo(dir)))
                    {
                        Directory.Delete(dir);
                    }
                    
                    directory.CreateSubdirectory(dir);
                }

                if (CreationPB.InvokeRequired)
                {
                    CreationPB.Invoke(new MethodInvoker(delegate
                    {
                        CreationPB.Value += 1;
                    }));
                }

                ConversionBW.ReportProgress(CreationPB.Value);
            }
        }

        private void ConversionBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (CreationPB.InvokeRequired)
            {
                CreationPB.Invoke(new MethodInvoker(delegate
                {
                    CreationPB.Value = e.ProgressPercentage;
                }));
            }
        }

        private void ConversionBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("All folders created successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
