namespace TcAiExamples
{
    partial class MainForm
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
            tabControl = new TabControl();
            WinFilesTabPage = new TabPage();
            DirLabelWinFiles = new Label();
            DirListBoxWinFiles = new ListBox();
            DelFileButtonWinFiles = new Button();
            OpenFileButtonWinFiles = new Button();
            CreateFileButtonWinFiles = new Button();
            FileNameTextBoxWinFiles = new TextBox();
            FileNameLabelWinFiles = new Label();
            DelDirButtonWinFiles = new Button();
            OpenDirButtonWinFiles = new Button();
            CreateDirButtonWinFiles = new Button();
            DirPathLabelWinFiles = new Label();
            DirPathTextBoxWinFiles = new TextBox();
            WinDirTabPage = new TabPage();
            CurFromDirLabel = new Label();
            MoveButton = new Button();
            CopyButton = new Button();
            ToDirTextBox = new TextBox();
            FromDirTextBox = new TextBox();
            ToLabel = new Label();
            FromLabel = new Label();
            DeleteSelectedButton = new Button();
            OpenSelectedButton = new Button();
            UpdateListBox = new Button();
            FileListBox = new ListBox();
            DelFileButton = new Button();
            OpenFileButton = new Button();
            CreateFileButton = new Button();
            FileNameTextBox = new TextBox();
            FileNameLabel = new Label();
            DelDirButton = new Button();
            OpenDirButton = new Button();
            CreateDirButton = new Button();
            DirPathLabel = new Label();
            DirPathTextBox = new TextBox();
            VisSudioTabPage = new TabPage();
            SlnTabPage = new TabPage();
            TcProjectTabPage = new TabPage();
            PlcProjTabPage = new TabPage();
            tabControl.SuspendLayout();
            WinFilesTabPage.SuspendLayout();
            WinDirTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(WinFilesTabPage);
            tabControl.Controls.Add(WinDirTabPage);
            tabControl.Controls.Add(VisSudioTabPage);
            tabControl.Controls.Add(SlnTabPage);
            tabControl.Controls.Add(TcProjectTabPage);
            tabControl.Controls.Add(PlcProjTabPage);
            tabControl.Location = new Point(12, 46);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1007, 563);
            tabControl.TabIndex = 0;
            tabControl.Selecting += tabControl_Selecting;
            // 
            // WinFilesTabPage
            // 
            WinFilesTabPage.Controls.Add(DirLabelWinFiles);
            WinFilesTabPage.Controls.Add(DirListBoxWinFiles);
            WinFilesTabPage.Controls.Add(DelFileButtonWinFiles);
            WinFilesTabPage.Controls.Add(OpenFileButtonWinFiles);
            WinFilesTabPage.Controls.Add(CreateFileButtonWinFiles);
            WinFilesTabPage.Controls.Add(FileNameTextBoxWinFiles);
            WinFilesTabPage.Controls.Add(FileNameLabelWinFiles);
            WinFilesTabPage.Controls.Add(DelDirButtonWinFiles);
            WinFilesTabPage.Controls.Add(OpenDirButtonWinFiles);
            WinFilesTabPage.Controls.Add(CreateDirButtonWinFiles);
            WinFilesTabPage.Controls.Add(DirPathLabelWinFiles);
            WinFilesTabPage.Controls.Add(DirPathTextBoxWinFiles);
            WinFilesTabPage.Location = new Point(4, 24);
            WinFilesTabPage.Name = "WinFilesTabPage";
            WinFilesTabPage.Padding = new Padding(3);
            WinFilesTabPage.Size = new Size(999, 535);
            WinFilesTabPage.TabIndex = 5;
            WinFilesTabPage.Text = "Windows Files";
            WinFilesTabPage.UseVisualStyleBackColor = true;
            // 
            // DirLabelWinFiles
            // 
            DirLabelWinFiles.AutoSize = true;
            DirLabelWinFiles.Location = new Point(429, 19);
            DirLabelWinFiles.Name = "DirLabelWinFiles";
            DirLabelWinFiles.Size = new Size(58, 15);
            DirLabelWinFiles.TabIndex = 23;
            DirLabelWinFiles.Text = "Directory:";
            // 
            // DirListBoxWinFiles
            // 
            DirListBoxWinFiles.FormattingEnabled = true;
            DirListBoxWinFiles.Location = new Point(429, 37);
            DirListBoxWinFiles.Name = "DirListBoxWinFiles";
            DirListBoxWinFiles.Size = new Size(372, 154);
            DirListBoxWinFiles.TabIndex = 22;
            // 
            // DelFileButtonWinFiles
            // 
            DelFileButtonWinFiles.Location = new Point(258, 168);
            DelFileButtonWinFiles.Name = "DelFileButtonWinFiles";
            DelFileButtonWinFiles.Size = new Size(120, 23);
            DelFileButtonWinFiles.TabIndex = 14;
            DelFileButtonWinFiles.Text = "Delete File";
            DelFileButtonWinFiles.UseVisualStyleBackColor = true;
            DelFileButtonWinFiles.Click += DelFileButtonWinFiles_Click;
            // 
            // OpenFileButtonWinFiles
            // 
            OpenFileButtonWinFiles.Location = new Point(132, 168);
            OpenFileButtonWinFiles.Name = "OpenFileButtonWinFiles";
            OpenFileButtonWinFiles.Size = new Size(120, 23);
            OpenFileButtonWinFiles.TabIndex = 13;
            OpenFileButtonWinFiles.Text = "Open File";
            OpenFileButtonWinFiles.UseVisualStyleBackColor = true;
            OpenFileButtonWinFiles.Click += OpenFileButtonWinFiles_Click;
            // 
            // CreateFileButtonWinFiles
            // 
            CreateFileButtonWinFiles.Location = new Point(6, 168);
            CreateFileButtonWinFiles.Name = "CreateFileButtonWinFiles";
            CreateFileButtonWinFiles.Size = new Size(120, 23);
            CreateFileButtonWinFiles.TabIndex = 12;
            CreateFileButtonWinFiles.Text = "Create File";
            CreateFileButtonWinFiles.UseVisualStyleBackColor = true;
            CreateFileButtonWinFiles.Click += CreateFileButtonWinFiles_Click;
            // 
            // FileNameTextBoxWinFiles
            // 
            FileNameTextBoxWinFiles.Location = new Point(6, 139);
            FileNameTextBoxWinFiles.Name = "FileNameTextBoxWinFiles";
            FileNameTextBoxWinFiles.Size = new Size(372, 23);
            FileNameTextBoxWinFiles.TabIndex = 11;
            FileNameTextBoxWinFiles.Text = "NewTextDoc.txt";
            // 
            // FileNameLabelWinFiles
            // 
            FileNameLabelWinFiles.AutoSize = true;
            FileNameLabelWinFiles.Location = new Point(6, 121);
            FileNameLabelWinFiles.Name = "FileNameLabelWinFiles";
            FileNameLabelWinFiles.Size = new Size(137, 15);
            FileNameLabelWinFiles.TabIndex = 10;
            FileNameLabelWinFiles.Text = "File Name and Extension";
            // 
            // DelDirButtonWinFiles
            // 
            DelDirButtonWinFiles.Location = new Point(258, 66);
            DelDirButtonWinFiles.Name = "DelDirButtonWinFiles";
            DelDirButtonWinFiles.Size = new Size(120, 23);
            DelDirButtonWinFiles.TabIndex = 9;
            DelDirButtonWinFiles.Text = "Delete Directory";
            DelDirButtonWinFiles.UseVisualStyleBackColor = true;
            DelDirButtonWinFiles.Click += DelDirButtonWinFiles_Click;
            // 
            // OpenDirButtonWinFiles
            // 
            OpenDirButtonWinFiles.Location = new Point(132, 66);
            OpenDirButtonWinFiles.Name = "OpenDirButtonWinFiles";
            OpenDirButtonWinFiles.Size = new Size(120, 23);
            OpenDirButtonWinFiles.TabIndex = 8;
            OpenDirButtonWinFiles.Text = "Open Directory";
            OpenDirButtonWinFiles.UseVisualStyleBackColor = true;
            OpenDirButtonWinFiles.Click += OpenDirButtonWinFiles_Click;
            // 
            // CreateDirButtonWinFiles
            // 
            CreateDirButtonWinFiles.Location = new Point(6, 66);
            CreateDirButtonWinFiles.Name = "CreateDirButtonWinFiles";
            CreateDirButtonWinFiles.Size = new Size(120, 23);
            CreateDirButtonWinFiles.TabIndex = 7;
            CreateDirButtonWinFiles.Text = "Create Directory";
            CreateDirButtonWinFiles.UseVisualStyleBackColor = true;
            CreateDirButtonWinFiles.Click += CreateDirButtonWinFiles_Click;
            // 
            // DirPathLabelWinFiles
            // 
            DirPathLabelWinFiles.AutoSize = true;
            DirPathLabelWinFiles.Location = new Point(6, 19);
            DirPathLabelWinFiles.Name = "DirPathLabelWinFiles";
            DirPathLabelWinFiles.Size = new Size(82, 15);
            DirPathLabelWinFiles.TabIndex = 6;
            DirPathLabelWinFiles.Text = "Directory Path";
            // 
            // DirPathTextBoxWinFiles
            // 
            DirPathTextBoxWinFiles.Location = new Point(6, 37);
            DirPathTextBoxWinFiles.Name = "DirPathTextBoxWinFiles";
            DirPathTextBoxWinFiles.Size = new Size(372, 23);
            DirPathTextBoxWinFiles.TabIndex = 5;
            DirPathTextBoxWinFiles.Text = "C:\\TcAiEx\\temp";
            // 
            // WinDirTabPage
            // 
            WinDirTabPage.Controls.Add(CurFromDirLabel);
            WinDirTabPage.Controls.Add(MoveButton);
            WinDirTabPage.Controls.Add(CopyButton);
            WinDirTabPage.Controls.Add(ToDirTextBox);
            WinDirTabPage.Controls.Add(FromDirTextBox);
            WinDirTabPage.Controls.Add(ToLabel);
            WinDirTabPage.Controls.Add(FromLabel);
            WinDirTabPage.Controls.Add(DeleteSelectedButton);
            WinDirTabPage.Controls.Add(OpenSelectedButton);
            WinDirTabPage.Controls.Add(UpdateListBox);
            WinDirTabPage.Controls.Add(FileListBox);
            WinDirTabPage.Controls.Add(DelFileButton);
            WinDirTabPage.Controls.Add(OpenFileButton);
            WinDirTabPage.Controls.Add(CreateFileButton);
            WinDirTabPage.Controls.Add(FileNameTextBox);
            WinDirTabPage.Controls.Add(FileNameLabel);
            WinDirTabPage.Controls.Add(DelDirButton);
            WinDirTabPage.Controls.Add(OpenDirButton);
            WinDirTabPage.Controls.Add(CreateDirButton);
            WinDirTabPage.Controls.Add(DirPathLabel);
            WinDirTabPage.Controls.Add(DirPathTextBox);
            WinDirTabPage.Location = new Point(4, 24);
            WinDirTabPage.Name = "WinDirTabPage";
            WinDirTabPage.Padding = new Padding(3);
            WinDirTabPage.Size = new Size(999, 535);
            WinDirTabPage.TabIndex = 2;
            WinDirTabPage.Text = "Windows Directory";
            WinDirTabPage.UseVisualStyleBackColor = true;
            // 
            // CurFromDirLabel
            // 
            CurFromDirLabel.AutoSize = true;
            CurFromDirLabel.Location = new Point(432, 24);
            CurFromDirLabel.Name = "CurFromDirLabel";
            CurFromDirLabel.Size = new Size(89, 15);
            CurFromDirLabel.TabIndex = 21;
            CurFromDirLabel.Text = "From Directory:";
            // 
            // MoveButton
            // 
            MoveButton.Location = new Point(132, 398);
            MoveButton.Name = "MoveButton";
            MoveButton.Size = new Size(75, 23);
            MoveButton.TabIndex = 20;
            MoveButton.Text = "Move File";
            MoveButton.UseVisualStyleBackColor = true;
            MoveButton.Click += MoveButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.Location = new Point(24, 398);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(75, 23);
            CopyButton.TabIndex = 19;
            CopyButton.Text = "Copy File";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // ToDirTextBox
            // 
            ToDirTextBox.Location = new Point(6, 341);
            ToDirTextBox.Name = "ToDirTextBox";
            ToDirTextBox.Size = new Size(372, 23);
            ToDirTextBox.TabIndex = 18;
            ToDirTextBox.Text = "C:\\TcAiEx\\temp2";
            // 
            // FromDirTextBox
            // 
            FromDirTextBox.Location = new Point(6, 297);
            FromDirTextBox.Name = "FromDirTextBox";
            FromDirTextBox.Size = new Size(372, 23);
            FromDirTextBox.TabIndex = 17;
            FromDirTextBox.Text = "C:\\TcAiEx\\temp";
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(6, 323);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(22, 15);
            ToLabel.TabIndex = 16;
            ToLabel.Text = "To:";
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(6, 279);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(38, 15);
            FromLabel.TabIndex = 15;
            FromLabel.Text = "From:";
            // 
            // DeleteSelectedButton
            // 
            DeleteSelectedButton.Location = new Point(684, 202);
            DeleteSelectedButton.Name = "DeleteSelectedButton";
            DeleteSelectedButton.Size = new Size(120, 23);
            DeleteSelectedButton.TabIndex = 14;
            DeleteSelectedButton.Text = "Delete Selected";
            DeleteSelectedButton.UseVisualStyleBackColor = true;
            DeleteSelectedButton.Click += DeleteSelectedButton_Click;
            // 
            // OpenSelectedButton
            // 
            OpenSelectedButton.Location = new Point(558, 202);
            OpenSelectedButton.Name = "OpenSelectedButton";
            OpenSelectedButton.Size = new Size(120, 23);
            OpenSelectedButton.TabIndex = 13;
            OpenSelectedButton.Text = "Open Selected";
            OpenSelectedButton.UseVisualStyleBackColor = true;
            OpenSelectedButton.Click += OpenSelectedButton_Click;
            // 
            // UpdateListBox
            // 
            UpdateListBox.Location = new Point(432, 202);
            UpdateListBox.Name = "UpdateListBox";
            UpdateListBox.Size = new Size(120, 23);
            UpdateListBox.TabIndex = 12;
            UpdateListBox.Text = "Update List";
            UpdateListBox.UseVisualStyleBackColor = true;
            UpdateListBox.Click += UpdateListBox_Click;
            // 
            // FileListBox
            // 
            FileListBox.FormattingEnabled = true;
            FileListBox.Location = new Point(432, 42);
            FileListBox.Name = "FileListBox";
            FileListBox.Size = new Size(372, 154);
            FileListBox.TabIndex = 11;
            // 
            // DelFileButton
            // 
            DelFileButton.Location = new Point(258, 202);
            DelFileButton.Name = "DelFileButton";
            DelFileButton.Size = new Size(120, 23);
            DelFileButton.TabIndex = 9;
            DelFileButton.Text = "Delete File";
            DelFileButton.UseVisualStyleBackColor = true;
            DelFileButton.Click += DelFileButton_Click;
            // 
            // OpenFileButton
            // 
            OpenFileButton.Location = new Point(132, 202);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(120, 23);
            OpenFileButton.TabIndex = 8;
            OpenFileButton.Text = "Open File";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // CreateFileButton
            // 
            CreateFileButton.Location = new Point(6, 202);
            CreateFileButton.Name = "CreateFileButton";
            CreateFileButton.Size = new Size(120, 23);
            CreateFileButton.TabIndex = 7;
            CreateFileButton.Text = "Create File";
            CreateFileButton.UseVisualStyleBackColor = true;
            CreateFileButton.Click += CreateFileButton_Click;
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.Location = new Point(6, 173);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new Size(372, 23);
            FileNameTextBox.TabIndex = 6;
            FileNameTextBox.Text = "NewTextDoc.txt";
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Location = new Point(6, 155);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(137, 15);
            FileNameLabel.TabIndex = 5;
            FileNameLabel.Text = "File Name and Extension";
            // 
            // DelDirButton
            // 
            DelDirButton.Location = new Point(258, 63);
            DelDirButton.Name = "DelDirButton";
            DelDirButton.Size = new Size(120, 23);
            DelDirButton.TabIndex = 4;
            DelDirButton.Text = "Delete Directory";
            DelDirButton.UseVisualStyleBackColor = true;
            DelDirButton.Click += DelDirButton_Click;
            // 
            // OpenDirButton
            // 
            OpenDirButton.Location = new Point(132, 63);
            OpenDirButton.Name = "OpenDirButton";
            OpenDirButton.Size = new Size(120, 23);
            OpenDirButton.TabIndex = 3;
            OpenDirButton.Text = "Open Directory";
            OpenDirButton.UseVisualStyleBackColor = true;
            OpenDirButton.Click += OpenDirButton_Click;
            // 
            // CreateDirButton
            // 
            CreateDirButton.Location = new Point(6, 63);
            CreateDirButton.Name = "CreateDirButton";
            CreateDirButton.Size = new Size(120, 23);
            CreateDirButton.TabIndex = 2;
            CreateDirButton.Text = "Create Directory";
            CreateDirButton.UseVisualStyleBackColor = true;
            CreateDirButton.Click += CreateDirButton_Click;
            // 
            // DirPathLabel
            // 
            DirPathLabel.AutoSize = true;
            DirPathLabel.Location = new Point(6, 16);
            DirPathLabel.Name = "DirPathLabel";
            DirPathLabel.Size = new Size(82, 15);
            DirPathLabel.TabIndex = 1;
            DirPathLabel.Text = "Directory Path";
            // 
            // DirPathTextBox
            // 
            DirPathTextBox.Location = new Point(6, 34);
            DirPathTextBox.Name = "DirPathTextBox";
            DirPathTextBox.Size = new Size(372, 23);
            DirPathTextBox.TabIndex = 0;
            DirPathTextBox.Text = "C:\\TcAiEx\\temp";
            // 
            // VisSudioTabPage
            // 
            VisSudioTabPage.Location = new Point(4, 24);
            VisSudioTabPage.Name = "VisSudioTabPage";
            VisSudioTabPage.Padding = new Padding(3);
            VisSudioTabPage.Size = new Size(999, 535);
            VisSudioTabPage.TabIndex = 0;
            VisSudioTabPage.Text = "Visual Studio";
            VisSudioTabPage.UseVisualStyleBackColor = true;
            // 
            // SlnTabPage
            // 
            SlnTabPage.Location = new Point(4, 24);
            SlnTabPage.Name = "SlnTabPage";
            SlnTabPage.Padding = new Padding(3);
            SlnTabPage.Size = new Size(999, 535);
            SlnTabPage.TabIndex = 1;
            SlnTabPage.Text = "Solution";
            SlnTabPage.UseVisualStyleBackColor = true;
            // 
            // TcProjectTabPage
            // 
            TcProjectTabPage.Location = new Point(4, 24);
            TcProjectTabPage.Name = "TcProjectTabPage";
            TcProjectTabPage.Size = new Size(999, 535);
            TcProjectTabPage.TabIndex = 3;
            TcProjectTabPage.Text = "Tc Project";
            TcProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // PlcProjTabPage
            // 
            PlcProjTabPage.Location = new Point(4, 24);
            PlcProjTabPage.Name = "PlcProjTabPage";
            PlcProjTabPage.Size = new Size(999, 535);
            PlcProjTabPage.TabIndex = 4;
            PlcProjTabPage.Text = "Plc Project";
            PlcProjTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 647);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Automation Interface Examples";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            WinFilesTabPage.ResumeLayout(false);
            WinFilesTabPage.PerformLayout();
            WinDirTabPage.ResumeLayout(false);
            WinDirTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage WinDirTabPage;
        private TabPage VisSudioTabPage;
        private TabPage SlnTabPage;
        private TabPage TcProjectTabPage;
        private TabPage PlcProjTabPage;
        private Button CreateDirButton;
        private Label DirPathLabel;
        private TextBox DirPathTextBox;
        private Button OpenDirButton;
        private Button DelDirButton;
        private Button CreateFileButton;
        private TextBox FileNameTextBox;
        private Label FileNameLabel;
        private Button OpenFileButton;
        private Button DelFileButton;
        private ListBox FileListBox;
        private Button UpdateListBox;
        private Button OpenSelectedButton;
        private Button DeleteSelectedButton;
        private Label FromLabel;
        private Button MoveButton;
        private Button CopyButton;
        private TextBox ToDirTextBox;
        private TextBox FromDirTextBox;
        private Label ToLabel;
        private Label CurFromDirLabel;
        private TabPage WinFilesTabPage;
        private Label DirLabelWinFiles;
        private ListBox DirListBoxWinFiles;
        private Button DelFileButtonWinFiles;
        private Button OpenFileButtonWinFiles;
        private Button CreateFileButtonWinFiles;
        private TextBox FileNameTextBoxWinFiles;
        private Label FileNameLabelWinFiles;
        private Button DelDirButtonWinFiles;
        private Button OpenDirButtonWinFiles;
        private Button CreateDirButtonWinFiles;
        private Label DirPathLabelWinFiles;
        private TextBox DirPathTextBoxWinFiles;
    }
}
