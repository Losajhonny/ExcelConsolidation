using IronXL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelConsolidation
{
    internal class FolderWatcher
    {
        const string processedFolder = "Processed";
        const string notApplicableFolder = "NotApplicable";
        const string masterFileName = "Master.xlsx";
        public string CurrentFolder { set; get; }

        public FolderWatcher(string currenteFolder)
        {
            CurrentFolder = currenteFolder;
            createDirectory(getPathFolderProcessed());
            createDirectory(getPathFolderNotApplicable());
            createMasterFile();
        }

        public DirectoryInfo getDirectoryInfo()
        {
            return new DirectoryInfo(CurrentFolder);
        }

        private void createDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private string getPathMasterFile()
        {
            return CurrentFolder + "\\" + masterFileName;
        }

        private string getPathFolderProcessed()
        {
            return CurrentFolder + "\\" + processedFolder;
        }

        private string getPathFolderNotApplicable()
        {
            return CurrentFolder + "\\" + notApplicableFolder;
        }

        public void monitorFile(string fileFullName, string filename)
        {
            if (filename.Contains(masterFileName))
                return;

            string source = CurrentFolder + "\\" + filename;
            string target = getPathFolderNotApplicable() + "\\" + filename;
            FileInfo file = new FileInfo(source);

            if (file.Extension == ".xls" || file.Extension == ".xlsx")
            {
                toConsolidate(fileFullName, filename);
                target = getPathFolderProcessed() + "\\" + filename;
            }
            
            if (File.Exists(target))
                File.Delete(target);

            File.Move(source, target);
        }

        private void createMasterFile()
        {
            string masterFile = getPathMasterFile();
            if (File.Exists(masterFile))
                return;
            WorkBook masterbook = new WorkBook(ExcelFileFormat.XLSX);
            masterbook.Metadata.Author = "Jhonatan";
            WorkSheet booksheet = masterbook.CreateWorkSheet("Default");
            booksheet["A1"].Value = "Main Sheet";
            masterbook.SaveAs(masterFile);
            masterbook.Close();
        }

        public void toConsolidate(string fileFullName, string filename)
        {
            WorkBook target = WorkBook.Load(getPathMasterFile());
            WorkBook source = WorkBook.Load(fileFullName);

            foreach(var sheet in source.WorkSheets)
            {
                sheet.CopyTo(target, (target.WorkSheets.Count + 1) + " " + sheet.Name + " " + filename.Replace(".xlsx", "").Replace(".xls", ""));
            }

            target.Save();
            source.Close();
            target.Close();
        }
    }
}
