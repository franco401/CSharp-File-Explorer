using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MyFileExplorer
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        * initial directory to load
        * it's placed here so it's accessible across all functions
        * and it's loaded once so the it's value can be changed later
        */
        string currentDir = "C:\\Users\\";

        //used for loading the previous directory
        string? directory = "";


        //directory stack to keep track of visted directories
        string[] dirStack = new string[1024];
        int top = 0;


        //displays file size (such as KB, MB, GB, etc.)
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

        //load the Users directory when loading this program (first time)
        private void Form1_Load(object sender, EventArgs e)
        {
            dirStack[top] = currentDir;
            NextDirBtn.Enabled = false;

            //empty string is used to stay on Users directory first time
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

        /*
         * button click to go back to previously viewed directory
         * goes down the dirStack
         */
        private void PreviousDirBtn_Click(object sender, EventArgs e)
        {
            LoadPreviousDirectory(directory, "Down");
        }

        /*
         * button click to go back to previously viewed directory
         * goes up the dirStack
         */
        private void NextDirBtn_Click(object sender, EventArgs e)
        {
            LoadPreviousDirectory(directory, "Up");
        }

        /*
         * runs a command with cmd
         * this is used for creating and deleting a file/folder,
         * renaming a file/folder and to open a file (if possible) as a process
         */
        private void RunCommand(string command)
        {
            //create process object
            Process process = new Process();

            //use cmd commands without display it
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/K " + command;
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            
            //set Process object to null so GC can collect it sooner to save heap memory (hopefully)
            process = null!;
        }

        /*
         * button click to create a new folder (in currently viewing directory)
         * based on name entered in textbox
         */
        private void CreateDirBtn_Click(object sender, EventArgs e)
        {
            //read user input directory
            string newDirectory = NewDirBox.Text;

            if (newDirectory != "")
            {
                try
                {
                    //command to run
                    string command = "mkdir " + "\"" + currentDir + "\\" + newDirectory + "\"";

                    //create directory with cmd
                    RunCommand(command);

                    //let user know the new directory was made
                    MessageBox.Show("Directory successfully made. Reopen this directory to see changes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch
                {
                    MessageBox.Show("Directory can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                
                /*
                 * if the currently selected row is a file, 
                 * disable delete directory button and enable open file button
                 * otherwise, enable delete directory button and disable open file button
                 */
                if (row.Cells[1].Value.ToString() == "File")
                {
                    //DeleteDirBtn.Enabled = false;
                    OpenFileBtn.Enabled = true;
                } else
                {
                    //DeleteDirBtn.Enabled = true;
                    OpenFileBtn.Enabled = false;
                }
            }
        }

        private void RenameDirBtn_Click(object sender, EventArgs e)
        {
            //read seleted directory
            string selectedDirectory = SelectedFile.Text;

            //read what the renamed file/directory name will be
            string newFileName = RenameDirBox.Text;

            if (selectedDirectory != "C:\\" || directory != "C:\\Windows\\System32")
            {
                try
                {
                    //command to run
                    string command = "ren " + "\"" + currentDir + "\\" + selectedDirectory + "\"" + " " + newFileName;

                    MessageBox.Show(command);

                    //rename selected directory with cmd
                    RunCommand(command);

                    //let user know the file/directory was renamed
                    MessageBox.Show("Successfully renamed file/directory. Reopen this directory to see changes", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SelectedFile.Text = newFileName;
                } catch
                {
                    MessageBox.Show("This directory can't be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            //read seleted file
            string selectedFile = SelectedFile.Text;
            try
            {
                //command to run
                string command = "start " + "\"" + "\"" + " " + "\"" + currentDir + "\\" + selectedFile + "\"" + "\"";

                //open selected file with cmd
                RunCommand(command);
            }
            catch
            {
                MessageBox.Show("This file couldn't be opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}