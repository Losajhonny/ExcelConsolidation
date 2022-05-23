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

namespace ExcelConsolidation
{
    public partial class Form1 : Form
    {
        private FolderWatcher watcher;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrower.ShowDialog();

            if (result == DialogResult.OK)
            {
                watcher = new FolderWatcher(folderBrower.SelectedPath);
                txtCurrentPath.Text = watcher.CurrentFolder;
                fileSystemWatcher.Path = watcher.CurrentFolder;
                generateTreeView();
            }
            else
            {
                MessageBox.Show("Error, failed to load folder");
            }
        }

        private void folderSystemWatcher(string fileFullName, string name)
        {
            if (watcher == null)
                return;
            watcher.monitorFile(fileFullName, name);
        }

        private void generateTreeView()
        {
            if (watcher == null)
                return;
            treeDir.Nodes.Clear();
            var directory = watcher.getDirectoryInfo();
            treeDir.Nodes.Add(generateTreeDirectory(directory));
            treeDir.ExpandAll();
        }

        private TreeNode generateTreeDirectory(DirectoryInfo dirInfo)
        {
            TreeNode node = new TreeNode(dirInfo.Name);
            foreach (var dir in dirInfo.GetDirectories())
            {
                node.Nodes.Add(generateTreeDirectory(dir));
            }
            foreach (var file in dirInfo.GetFiles())
            {
                if (!file.Attributes.ToString().Contains("Hidden"))
                {
                    node.Nodes.Add(new TreeNode(file.Name));
                }
            }
            return node;
        }

        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            FileInfo file = new FileInfo(e.FullPath);
            if (!file.Attributes.ToString().Contains("Hidden"))
            {
                generateTreeView();
                folderSystemWatcher(e.FullPath, e.Name);
            }
        }

        private void fileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            generateTreeView();
        }

        private void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            generateTreeView();
        }
    }
}
