using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;

namespace MyFileExplorer
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String GetFileSize(Double fileSize)
        {
            String[] fileSizes = { "B", "KB", "MB", "GB, TB" };
            int fileSizeIndex = 0;

            /*
             * while the memory size is greater than
             * 1024, divide by 1024 and increment
             * the fileSizeIndex by 1 for each division
             */
            while (fileSize >= 1024.0)
            {
                fileSize /= 1024.0;
                fileSizeIndex++;
            }

            fileSize = Math.Round(fileSize, 2);
            return fileSize + " " + fileSizes[fileSizeIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dynamically set the current directory to the user's desktop
            string username = Environment.UserName;
            string currentDir = @"C:\Users\" + username + "\\Desktop";
            CurrentDir.Text = currentDir;

            //files and folders in directory
            string[] folders = Directory.GetDirectories(currentDir);
            string[] files = Directory.GetFiles(currentDir);

            double fileSize;

            //read all folders from given directory
            for (int i = 0; i < folders.Length; i++)
            {
                FileInfo folder = new FileInfo(folders[i]);
                FilesTable.Rows.Add(folder.Name, "Folder");
            }
            //read all files from given directory
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                fileSize = file.Length;
                FilesTable.Rows.Add(file.Name, "File", GetFileSize(fileSize));
            }
        }

        //variables to be used below
        DataGridViewRow? row;
        String? data;

        //called every time the user double clicks on a row in the tables
        private void FilesTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
             * checks if the index of the selected row
             * is within the range of 0 to the amount of processes
             * because the user may click something in the table
             * out of range such as when they want to order the table by
             * process name
             */
            if (e.RowIndex > -1)
            {
                //get the currently selected row
                row = FilesTable.Rows[e.RowIndex];
                /*
                 * check if the currently selected row's values aren't null
                 * so then the program can read the contents of that row
                 */

                if (row.Cells[0].Value != null)
                {
                    data = row.Cells[0].Value.ToString();
                    CurrentDir.Text += data + "\\";
                }
            }
        }
    }
}