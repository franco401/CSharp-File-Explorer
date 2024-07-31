namespace MyFileExplorer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            CurrentDir = new Label();
            PreviousDirBtn = new Button();
            FilesTable = new DataGridView();
            DirName = new DataGridViewTextBoxColumn();
            DirType = new DataGridViewTextBoxColumn();
            FileSize = new DataGridViewTextBoxColumn();
            DateCreated = new DataGridViewTextBoxColumn();
            NextDirBtn = new Button();
            CreateDirBtn = new Button();
            NewDirBox = new TextBox();
            label3 = new Label();
            SelectedFile = new Label();
            RenameDirBox = new TextBox();
            RenameDirBtn = new Button();
            OpenFileBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)FilesTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 35);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 3;
            label1.Text = "Current Directory:";
            // 
            // CurrentDir
            // 
            CurrentDir.AutoSize = true;
            CurrentDir.Location = new Point(171, 35);
            CurrentDir.Name = "CurrentDir";
            CurrentDir.Size = new Size(122, 20);
            CurrentDir.TabIndex = 4;
            CurrentDir.Text = "Current Directory";
            // 
            // PreviousDirBtn
            // 
            PreviousDirBtn.Location = new Point(13, 63);
            PreviousDirBtn.Name = "PreviousDirBtn";
            PreviousDirBtn.Size = new Size(123, 29);
            PreviousDirBtn.TabIndex = 7;
            PreviousDirBtn.Text = "Back";
            PreviousDirBtn.UseVisualStyleBackColor = true;
            PreviousDirBtn.Click += PreviousDirBtn_Click;
            // 
            // FilesTable
            // 
            FilesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FilesTable.BackgroundColor = SystemColors.Control;
            FilesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilesTable.Columns.AddRange(new DataGridViewColumn[] { DirName, DirType, FileSize, DateCreated });
            FilesTable.GridColor = SystemColors.ButtonFace;
            FilesTable.Location = new Point(11, 98);
            FilesTable.Name = "FilesTable";
            FilesTable.RowHeadersWidth = 51;
            FilesTable.RowTemplate.Height = 29;
            FilesTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            FilesTable.Size = new Size(1142, 363);
            FilesTable.TabIndex = 2;
            FilesTable.CellMouseClick += FilesTable_CellMouseClick;
            FilesTable.CellMouseDoubleClick += FilesTable_CellMouseDoubleClick;
            // 
            // DirName
            // 
            DirName.HeaderText = "Name";
            DirName.MinimumWidth = 6;
            DirName.Name = "DirName";
            DirName.ReadOnly = true;
            DirName.Width = 512;
            // 
            // DirType
            // 
            DirType.HeaderText = "Type";
            DirType.MinimumWidth = 6;
            DirType.Name = "DirType";
            DirType.ReadOnly = true;
            DirType.Width = 125;
            // 
            // FileSize
            // 
            FileSize.HeaderText = "Size";
            FileSize.MinimumWidth = 6;
            FileSize.Name = "FileSize";
            FileSize.ReadOnly = true;
            FileSize.Width = 125;
            // 
            // DateCreated
            // 
            DateCreated.HeaderText = "Date Created";
            DateCreated.MinimumWidth = 6;
            DateCreated.Name = "DateCreated";
            DateCreated.ReadOnly = true;
            DateCreated.Width = 256;
            // 
            // NextDirBtn
            // 
            NextDirBtn.Location = new Point(142, 63);
            NextDirBtn.Name = "NextDirBtn";
            NextDirBtn.Size = new Size(94, 29);
            NextDirBtn.TabIndex = 8;
            NextDirBtn.Text = "Forward";
            NextDirBtn.UseVisualStyleBackColor = true;
            NextDirBtn.Click += NextDirBtn_Click;
            // 
            // CreateDirBtn
            // 
            CreateDirBtn.Location = new Point(654, 513);
            CreateDirBtn.Name = "CreateDirBtn";
            CreateDirBtn.Size = new Size(214, 29);
            CreateDirBtn.TabIndex = 9;
            CreateDirBtn.Text = "Create New Folder";
            CreateDirBtn.UseVisualStyleBackColor = true;
            CreateDirBtn.Click += CreateDirBtn_Click;
            // 
            // NewDirBox
            // 
            NewDirBox.Location = new Point(340, 514);
            NewDirBox.Name = "NewDirBox";
            NewDirBox.Size = new Size(309, 27);
            NewDirBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 9);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 13;
            label3.Text = "Selected File/Folder:";
            // 
            // SelectedFile
            // 
            SelectedFile.AutoSize = true;
            SelectedFile.Location = new Point(171, 9);
            SelectedFile.Name = "SelectedFile";
            SelectedFile.Size = new Size(93, 20);
            SelectedFile.TabIndex = 14;
            SelectedFile.Text = "Selected File";
            // 
            // RenameDirBox
            // 
            RenameDirBox.Location = new Point(340, 548);
            RenameDirBox.Name = "RenameDirBox";
            RenameDirBox.Size = new Size(309, 27);
            RenameDirBox.TabIndex = 17;
            // 
            // RenameDirBtn
            // 
            RenameDirBtn.Location = new Point(655, 546);
            RenameDirBtn.Name = "RenameDirBtn";
            RenameDirBtn.Size = new Size(213, 29);
            RenameDirBtn.TabIndex = 16;
            RenameDirBtn.Text = "Rename Selected File/Folder";
            RenameDirBtn.UseVisualStyleBackColor = true;
            RenameDirBtn.Click += RenameDirBtn_Click;
            // 
            // OpenFileBtn
            // 
            OpenFileBtn.Location = new Point(484, 479);
            OpenFileBtn.Name = "OpenFileBtn";
            OpenFileBtn.Size = new Size(165, 29);
            OpenFileBtn.TabIndex = 18;
            OpenFileBtn.Text = "Open Selected File";
            OpenFileBtn.UseVisualStyleBackColor = true;
            OpenFileBtn.Click += OpenFileBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1165, 586);
            Controls.Add(OpenFileBtn);
            Controls.Add(RenameDirBox);
            Controls.Add(RenameDirBtn);
            Controls.Add(SelectedFile);
            Controls.Add(label3);
            Controls.Add(NewDirBox);
            Controls.Add(CreateDirBtn);
            Controls.Add(NextDirBtn);
            Controls.Add(PreviousDirBtn);
            Controls.Add(CurrentDir);
            Controls.Add(label1);
            Controls.Add(FilesTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "My File Explorer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)FilesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label CurrentDir;
        private Button PreviousDirBtn;
        private DataGridView FilesTable;
        private Button NextDirBtn;
        private Button CreateDirBtn;
        private TextBox NewDirBox;
        private DataGridViewTextBoxColumn DirName;
        private DataGridViewTextBoxColumn DirType;
        private DataGridViewTextBoxColumn FileSize;
        private DataGridViewTextBoxColumn DateCreated;
        private Label label3;
        private Label SelectedFile;
        private TextBox RenameDirBox;
        private Button RenameDirBtn;
        private Button OpenFileBtn;
    }
}