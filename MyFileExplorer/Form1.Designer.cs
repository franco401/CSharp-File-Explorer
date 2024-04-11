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
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentDir = new System.Windows.Forms.Label();
            this.PreviousDirBtn = new System.Windows.Forms.Button();
            this.FilesTable = new System.Windows.Forms.DataGridView();
            this.DirName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextDirBtn = new System.Windows.Forms.Button();
            this.CreateDirBtn = new System.Windows.Forms.Button();
            this.NewDirBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectedFile = new System.Windows.Forms.Label();
            this.DeleteDirBtn = new System.Windows.Forms.Button();
            this.RenameDirBox = new System.Windows.Forms.TextBox();
            this.RenameDirBtn = new System.Windows.Forms.Button();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FilesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Directory:";
            // 
            // CurrentDir
            // 
            this.CurrentDir.AutoSize = true;
            this.CurrentDir.Location = new System.Drawing.Point(171, 35);
            this.CurrentDir.Name = "CurrentDir";
            this.CurrentDir.Size = new System.Drawing.Size(122, 20);
            this.CurrentDir.TabIndex = 4;
            this.CurrentDir.Text = "Current Directory";
            // 
            // PreviousDirBtn
            // 
            this.PreviousDirBtn.Location = new System.Drawing.Point(13, 63);
            this.PreviousDirBtn.Name = "PreviousDirBtn";
            this.PreviousDirBtn.Size = new System.Drawing.Size(123, 29);
            this.PreviousDirBtn.TabIndex = 7;
            this.PreviousDirBtn.Text = "Back";
            this.PreviousDirBtn.UseVisualStyleBackColor = true;
            this.PreviousDirBtn.Click += new System.EventHandler(this.PreviousDirBtn_Click);
            // 
            // FilesTable
            // 
            this.FilesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.FilesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirName,
            this.DirType,
            this.FileSize,
            this.DateCreated});
            this.FilesTable.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.FilesTable.Location = new System.Drawing.Point(11, 98);
            this.FilesTable.Name = "FilesTable";
            this.FilesTable.RowHeadersWidth = 51;
            this.FilesTable.RowTemplate.Height = 29;
            this.FilesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.FilesTable.Size = new System.Drawing.Size(1142, 363);
            this.FilesTable.TabIndex = 2;
            this.FilesTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FilesTable_CellMouseClick);
            this.FilesTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FilesTable_CellMouseDoubleClick);
            // 
            // DirName
            // 
            this.DirName.HeaderText = "Name";
            this.DirName.MinimumWidth = 6;
            this.DirName.Name = "DirName";
            this.DirName.ReadOnly = true;
            this.DirName.Width = 512;
            // 
            // DirType
            // 
            this.DirType.HeaderText = "Type";
            this.DirType.MinimumWidth = 6;
            this.DirType.Name = "DirType";
            this.DirType.ReadOnly = true;
            this.DirType.Width = 125;
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "Size";
            this.FileSize.MinimumWidth = 6;
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.Width = 125;
            // 
            // DateCreated
            // 
            this.DateCreated.HeaderText = "Date Created";
            this.DateCreated.MinimumWidth = 6;
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.ReadOnly = true;
            this.DateCreated.Width = 256;
            // 
            // NextDirBtn
            // 
            this.NextDirBtn.Location = new System.Drawing.Point(142, 63);
            this.NextDirBtn.Name = "NextDirBtn";
            this.NextDirBtn.Size = new System.Drawing.Size(94, 29);
            this.NextDirBtn.TabIndex = 8;
            this.NextDirBtn.Text = "Forward";
            this.NextDirBtn.UseVisualStyleBackColor = true;
            this.NextDirBtn.Click += new System.EventHandler(this.NextDirBtn_Click);
            // 
            // CreateDirBtn
            // 
            this.CreateDirBtn.Location = new System.Drawing.Point(941, 514);
            this.CreateDirBtn.Name = "CreateDirBtn";
            this.CreateDirBtn.Size = new System.Drawing.Size(214, 29);
            this.CreateDirBtn.TabIndex = 9;
            this.CreateDirBtn.Text = "Create New Folder";
            this.CreateDirBtn.UseVisualStyleBackColor = true;
            this.CreateDirBtn.Click += new System.EventHandler(this.CreateDirBtn_Click);
            // 
            // NewDirBox
            // 
            this.NewDirBox.Location = new System.Drawing.Point(626, 515);
            this.NewDirBox.Name = "NewDirBox";
            this.NewDirBox.Size = new System.Drawing.Size(309, 27);
            this.NewDirBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Selected File/Folder:";
            // 
            // SelectedFile
            // 
            this.SelectedFile.AutoSize = true;
            this.SelectedFile.Location = new System.Drawing.Point(171, 9);
            this.SelectedFile.Name = "SelectedFile";
            this.SelectedFile.Size = new System.Drawing.Size(93, 20);
            this.SelectedFile.TabIndex = 14;
            this.SelectedFile.Text = "Selected File";
            // 
            // DeleteDirBtn
            // 
            this.DeleteDirBtn.Location = new System.Drawing.Point(11, 479);
            this.DeleteDirBtn.Name = "DeleteDirBtn";
            this.DeleteDirBtn.Size = new System.Drawing.Size(170, 29);
            this.DeleteDirBtn.TabIndex = 15;
            this.DeleteDirBtn.Text = "Delete Selected Folder";
            this.DeleteDirBtn.UseVisualStyleBackColor = true;
            this.DeleteDirBtn.Click += new System.EventHandler(this.DeleteDirBtn_Click);
            // 
            // RenameDirBox
            // 
            this.RenameDirBox.Location = new System.Drawing.Point(626, 549);
            this.RenameDirBox.Name = "RenameDirBox";
            this.RenameDirBox.Size = new System.Drawing.Size(309, 27);
            this.RenameDirBox.TabIndex = 17;
            // 
            // RenameDirBtn
            // 
            this.RenameDirBtn.Location = new System.Drawing.Point(942, 547);
            this.RenameDirBtn.Name = "RenameDirBtn";
            this.RenameDirBtn.Size = new System.Drawing.Size(213, 29);
            this.RenameDirBtn.TabIndex = 16;
            this.RenameDirBtn.Text = "Rename Selected File/Folder";
            this.RenameDirBtn.UseVisualStyleBackColor = true;
            this.RenameDirBtn.Click += new System.EventHandler(this.RenameDirBtn_Click);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(13, 513);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(165, 29);
            this.OpenFileBtn.TabIndex = 18;
            this.OpenFileBtn.Text = "Open Selected File";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1165, 586);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.RenameDirBox);
            this.Controls.Add(this.RenameDirBtn);
            this.Controls.Add(this.DeleteDirBtn);
            this.Controls.Add(this.SelectedFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewDirBox);
            this.Controls.Add(this.CreateDirBtn);
            this.Controls.Add(this.NextDirBtn);
            this.Controls.Add(this.PreviousDirBtn);
            this.Controls.Add(this.CurrentDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilesTable);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "My File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button DeleteDirBtn;
        private TextBox RenameDirBox;
        private Button RenameDirBtn;
        private Button OpenFileBtn;
    }
}