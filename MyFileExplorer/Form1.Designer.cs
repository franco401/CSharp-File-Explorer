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
            this.FilesTable = new System.Windows.Forms.DataGridView();
            this.DirName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentDir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FilesTable)).BeginInit();
            this.SuspendLayout();
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
            this.FileType,
            this.DirSize});
            this.FilesTable.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.FilesTable.Location = new System.Drawing.Point(3, 40);
            this.FilesTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilesTable.Name = "FilesTable";
            this.FilesTable.RowHeadersWidth = 51;
            this.FilesTable.RowTemplate.Height = 29;
            this.FilesTable.Size = new System.Drawing.Size(797, 316);
            this.FilesTable.TabIndex = 2;
            // 
            // DirName
            // 
            this.DirName.HeaderText = "Name";
            this.DirName.MinimumWidth = 300;
            this.DirName.Name = "DirName";
            this.DirName.Width = 300;
            // 
            // FileType
            // 
            this.FileType.HeaderText = "Type";
            this.FileType.MinimumWidth = 200;
            this.FileType.Name = "FileType";
            this.FileType.Width = 200;
            // 
            // DirSize
            // 
            this.DirSize.HeaderText = "Size";
            this.DirSize.MinimumWidth = 200;
            this.DirSize.Name = "DirSize";
            this.DirSize.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Directory:";
            // 
            // CurrentDir
            // 
            this.CurrentDir.AutoSize = true;
            this.CurrentDir.Location = new System.Drawing.Point(125, 7);
            this.CurrentDir.Name = "CurrentDir";
            this.CurrentDir.Size = new System.Drawing.Size(98, 15);
            this.CurrentDir.TabIndex = 4;
            this.CurrentDir.Text = "Current Directory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilesTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView FilesTable;
        private Label label1;
        private Label CurrentDir;
        private DataGridViewTextBoxColumn DirName;
        private DataGridViewTextBoxColumn FileType;
        private DataGridViewTextBoxColumn DirSize;
    }
}