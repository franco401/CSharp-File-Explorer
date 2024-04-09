using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace MyFileExplorer
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string GetFileSize(double fileSize)
        {
            string[] fileSizes = { "B", "KB", "MB", "GB, TB" };
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


        /*
         * initial directory to load
         * it's placed here so it's accessible across all functions
         * and it's loaded once so the it's value can be changed later
         */
        string currentDir = "C:\\";

        //used for loading the previous directory
        string? directory = "";


        //directory stack to keep track of visted directories
        string[] dirStack = new string[65536];
        int top = 0;

        //loads the files and folders in a given directory into the files table
        private void LoadDirectory(string path)
        {
            FilesTable.Rows.Clear();

            currentDir += path;
            CurrentDir.Text = currentDir;

            if (top < dirStack.Length)
            {
                top++;
                dirStack[top] = currentDir;
            }

            try
            {
                //get files and folders in the current directory
                string[] folders = Directory.GetDirectories(currentDir);
                string[] files = Directory.GetFiles(currentDir);

                double fileSize;

                //read all folders from given directory
                for (int i = 0; i < folders.Length; i++)
                {
                    FileInfo folder = new FileInfo(folders[i]);
                    FilesTable.Rows.Add(folder.Name, "Folder", "", folder.CreationTime);
                }
                //read all files from given directory
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo file = new FileInfo(files[i]);
                    fileSize = file.Length;
                    FilesTable.Rows.Add(file.Name, "File", GetFileSize(fileSize), file.CreationTime);
                }
            }
            catch
            {
                string message = "Couldn't load this folder: " + currentDir;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dirStack[top] = currentDir;
            NextDirBtn.Enabled = false;
            LoadDirectory("");
        }

        //called every time the user double clicks on a row (file/folder) in the table
        private void FilesTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //variables to be used below
            DataGridViewRow? row;

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

                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    /*
                     * checks if the currently selected row is a folder and
                     * if the column is the first one (when user clicks folder name)
                     */
                    if (row.Cells[1].Value.ToString() == "Folder" && e.ColumnIndex == 0)
                    {
                        //read next directory's name
                        directory = "\\"  + row.Cells[0].Value.ToString();
                        CurrentDir.Text += directory;

                        //load the next directory
                        LoadDirectory(directory);
                    }
                }
            }
        }

        //loads the files and folders in a given directory into the files table
        private void LoadPreviousDirectory(string? path, string direction)
        {
            FilesTable.Rows.Clear();

            if (direction == "Up")
            {
                if (top < dirStack.Length)
                {
                    top++;

                    //disable the forward button
                    if (String.IsNullOrEmpty(dirStack[top]))
                    {
                        NextDirBtn.Enabled = false;
                        top--;
                    } else
                    {
                        // set the current directory to the top of the dirStack if it's NOT empty
                        currentDir = dirStack[top];
                        NextDirBtn.Enabled = true;
                    }
                }
            } else 
            {
                //go back to previously visited directory
                if (top > 0) {
                    top--;
                    currentDir = dirStack[top];
                    NextDirBtn.Enabled = true;
                }
            }

            try
            {
                //get the previous directory to load
                //currentDir = currentDir.Remove(stringToRemoveIndex);
                
                CurrentDir.Text = currentDir;

                //get files and folders in the current directory
                string[] folders = Directory.GetDirectories(currentDir);
                string[] files = Directory.GetFiles(currentDir);

                double fileSize;

                //read all folders from given directory
                for (int i = 0; i < folders.Length; i++)
                {
                    FileInfo folder = new FileInfo(folders[i]);
                    FilesTable.Rows.Add(folder.Name, "Folder", "", folder.CreationTime);
                }
                //read all files from given directory
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo file = new FileInfo(files[i]);
                    fileSize = file.Length;
                    FilesTable.Rows.Add(file.Name, "File", GetFileSize(fileSize), file.CreationTime);
                }
            }
            catch
            {
                /*
                 * when removing the \\ character makes the currentDir C:
                 * set currentDir to C:\\ and load that directory instead
                 */
                if (currentDir == "C:")
                {
                    currentDir = "C:\\";
                    CurrentDir.Text = currentDir;
                    LoadDirectory("");
                } else
                {
                    string message = "Couldn't load this folder: " + currentDir;
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void PreviousDirBtn_Click(object sender, EventArgs e)
        {
            LoadPreviousDirectory(directory, "Down");
        }

        private void NextDirBtn_Click(object sender, EventArgs e)
        {
            LoadPreviousDirectory(directory, "Up");
        }

        private void CreateDirBtn_Click(object sender, EventArgs e)
        {
            //read user input directory
            string directory = newDirBox.Text;

            //escape backslash
            string quote = "\"";

            if (directory != "")
            {
                //create process object
                Process process = new Process();

                
                //use cmd to create a new directory without display it
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/K " + "mkdir " + quote + currentDir + "\\" + directory + quote;
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();

                //let user know the new directory was made
                MessageBox.Show("Directory successfully made. Reopen this directory to see changes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Directory can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilesTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //variables to be used below
            DataGridViewRow? row;

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
                 * check if the currently selected row's folder/file name isn't null
                 * so then the program can read the contents of that row
                 */

                if (row.Cells[0].Value != null)
                {
                    /*
                     * checks if the currently selected row is a folder and
                     * if the column is the first one (when user clicks folder name)
                     */
                    SelectedFile.Text = row.Cells[0].Value.ToString();
                }
                
                //if the currently selected row is not a folder, disable delete directory button
                if (row.Cells[1].Value.ToString() == "File")
                {
                    DeleteDirBtn.Enabled = false;
                } else
                {
                    DeleteDirBtn.Enabled = true;
                }
            }
        }

        private void DeleteDirBtn_Click(object sender, EventArgs e)
        {
            //read seleted directory
            string selectedDirectory = SelectedFile.Text;

            //escape backslash
            string quote = "\"";

            if (selectedDirectory != "C:\\" || directory != "C:\\Windows\\System32")
            {
                //create process object
                Process process = new Process();


                //use cmd to create a new directory without display it
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/K " + "rmdir " + quote + currentDir + "\\" + selectedDirectory + quote;
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                
                //let user know the directory was deleted
                MessageBox.Show("Successfully deleted directory. Reopen this directory to see changes", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This directory can't be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}