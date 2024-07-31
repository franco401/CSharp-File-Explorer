# CSharp-File-Explorer

This is a desktop application written in C# that can let users browser the files and folders of their pc.

# Features
* Displays the name of the file or folder in the current directory
* Displays the size of files (in bytes, kilobytes, megabytes, etc.)
* Displays the date and time of when the file or folder was created
* Users can traverse back and forth between their folders
* Users can create new directories by typing it in a textbox and clicking a button
* Users can delete a currently selected folder with a button

## Installation Guide for Windows

1. Install .NET if you don't already have it: https://learn.microsoft.com/en-us/dotnet/core/install/windows
2. Download the source code
3. Open the command prompt in the same folder where you extracted the source code and enter the following command:
```
dotnet build MyFileExplorer.sln
```
4. Go through the folders MyFileExplorer -> bin -> Debug -> net6.0-windows and click on MyFileExplorer.exe to run the program
