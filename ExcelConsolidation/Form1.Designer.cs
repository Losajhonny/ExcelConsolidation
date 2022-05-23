namespace ExcelConsolidation
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
            this.btnBuscarFolder = new System.Windows.Forms.Button();
            this.lblElegirFolder = new System.Windows.Forms.Label();
            this.folderBrower = new System.Windows.Forms.FolderBrowserDialog();
            this.treeDir = new System.Windows.Forms.TreeView();
            this.lblRutaActual = new System.Windows.Forms.Label();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.txtCurrentPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarFolder
            // 
            this.btnBuscarFolder.Location = new System.Drawing.Point(137, 13);
            this.btnBuscarFolder.Name = "btnBuscarFolder";
            this.btnBuscarFolder.Size = new System.Drawing.Size(131, 25);
            this.btnBuscarFolder.TabIndex = 0;
            this.btnBuscarFolder.Text = "Search Folder";
            this.btnBuscarFolder.UseVisualStyleBackColor = true;
            this.btnBuscarFolder.Click += new System.EventHandler(this.btnBuscarFolder_Click);
            // 
            // lblElegirFolder
            // 
            this.lblElegirFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirFolder.Location = new System.Drawing.Point(15, 16);
            this.lblElegirFolder.Name = "lblElegirFolder";
            this.lblElegirFolder.Size = new System.Drawing.Size(116, 22);
            this.lblElegirFolder.TabIndex = 1;
            this.lblElegirFolder.Text = "Choose folder";
            // 
            // treeDir
            // 
            this.treeDir.Location = new System.Drawing.Point(12, 44);
            this.treeDir.Name = "treeDir";
            this.treeDir.Size = new System.Drawing.Size(776, 385);
            this.treeDir.TabIndex = 2;
            // 
            // lblRutaActual
            // 
            this.lblRutaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaActual.Location = new System.Drawing.Point(295, 17);
            this.lblRutaActual.Name = "lblRutaActual";
            this.lblRutaActual.Size = new System.Drawing.Size(103, 21);
            this.lblRutaActual.TabIndex = 3;
            this.lblRutaActual.Text = "Current Path";
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // txtCurrentPath
            // 
            this.txtCurrentPath.Location = new System.Drawing.Point(404, 16);
            this.txtCurrentPath.Name = "txtCurrentPath";
            this.txtCurrentPath.ReadOnly = true;
            this.txtCurrentPath.Size = new System.Drawing.Size(384, 22);
            this.txtCurrentPath.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.txtCurrentPath);
            this.Controls.Add(this.lblRutaActual);
            this.Controls.Add(this.treeDir);
            this.Controls.Add(this.lblElegirFolder);
            this.Controls.Add(this.btnBuscarFolder);
            this.Name = "Form1";
            this.Text = "Excel Consolidation Tool";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarFolder;
        private System.Windows.Forms.Label lblElegirFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrower;
        private System.Windows.Forms.Label lblRutaActual;
        private System.Windows.Forms.TreeView treeDir;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.TextBox txtCurrentPath;
    }
}

