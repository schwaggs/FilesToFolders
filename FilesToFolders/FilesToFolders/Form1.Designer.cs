namespace FilesToFolders
{
    partial class Form1
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
            this.BrowseBT = new System.Windows.Forms.Button();
            this.CreationPB = new System.Windows.Forms.ProgressBar();
            this.DirPathTB = new System.Windows.Forms.TextBox();
            this.ConversionBW = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BrowseBT
            // 
            this.BrowseBT.Location = new System.Drawing.Point(452, 12);
            this.BrowseBT.Name = "BrowseBT";
            this.BrowseBT.Size = new System.Drawing.Size(130, 32);
            this.BrowseBT.TabIndex = 0;
            this.BrowseBT.Text = "Browse";
            this.BrowseBT.UseVisualStyleBackColor = true;
            this.BrowseBT.Click += new System.EventHandler(this.BrowseBT_Click);
            // 
            // CreationPB
            // 
            this.CreationPB.Location = new System.Drawing.Point(12, 66);
            this.CreationPB.Name = "CreationPB";
            this.CreationPB.Size = new System.Drawing.Size(425, 23);
            this.CreationPB.TabIndex = 1;
            // 
            // DirPathTB
            // 
            this.DirPathTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirPathTB.Location = new System.Drawing.Point(13, 14);
            this.DirPathTB.Name = "DirPathTB";
            this.DirPathTB.Size = new System.Drawing.Size(424, 31);
            this.DirPathTB.TabIndex = 2;
            // 
            // ConversionBW
            // 
            this.ConversionBW.WorkerReportsProgress = true;
            this.ConversionBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ConversionBW_DoWork);
            this.ConversionBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ConversionBW_ProgressChanged);
            this.ConversionBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ConversionBW_RunWorkerCompleted);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "pdf",
            "zip",
            "txt"});
            this.listBox1.Location = new System.Drawing.Point(452, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(130, 30);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 102);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DirPathTB);
            this.Controls.Add(this.CreationPB);
            this.Controls.Add(this.BrowseBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseBT;
        private System.Windows.Forms.ProgressBar CreationPB;
        private System.Windows.Forms.TextBox DirPathTB;
        private System.ComponentModel.BackgroundWorker ConversionBW;
        private System.Windows.Forms.ListBox listBox1;
    }
}

