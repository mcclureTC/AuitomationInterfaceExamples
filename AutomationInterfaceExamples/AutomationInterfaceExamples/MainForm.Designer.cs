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
            WinDirBasicTabPage = new TabPage();
            DirLabelBasic = new Label();
            DirListBoxBasic = new ListBox();
            DelFileButtonBasic = new Button();
            OpenFileButtonBasic = new Button();
            CreateFileButtonBasic = new Button();
            FileNameTextBoxBasic = new TextBox();
            FileNameLabelBasic = new Label();
            DelDirButtonBasic = new Button();
            OpenDirButtonBasic = new Button();
            CreateDirButtonBasic = new Button();
            DirPathLabelBasic = new Label();
            DirPathTextBoxBasic = new TextBox();
            WinDirAdvTabPage = new TabPage();
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
            WinDirBasicTabPage.SuspendLayout();
            WinDirAdvTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(WinDirBasicTabPage);
            tabControl.Controls.Add(WinDirAdvTabPage);
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
            // WinDirBasicTabPage
            // 
            WinDirBasicTabPage.Controls.Add(DirLabelBasic);
            WinDirBasicTabPage.Controls.Add(DirListBoxBasic);
            WinDirBasicTabPage.Controls.Add(DelFileButtonBasic);
            WinDirBasicTabPage.Controls.Add(OpenFileButtonBasic);
            WinDirBasicTabPage.Controls.Add(CreateFileButtonBasic);
            WinDirBasicTabPage.Controls.Add(FileNameTextBoxBasic);
            WinDirBasicTabPage.Controls.Add(FileNameLabelBasic);
            WinDirBasicTabPage.Controls.Add(DelDirButtonBasic);
            WinDirBasicTabPage.Controls.Add(OpenDirButtonBasic);
            WinDirBasicTabPage.Controls.Add(CreateDirButtonBasic);
            WinDirBasicTabPage.Controls.Add(DirPathLabelBasic);
            WinDirBasicTabPage.Controls.Add(DirPathTextBoxBasic);
            WinDirBasicTabPage.Location = new Point(4, 24);
            WinDirBasicTabPage.Name = "WinDirBasicTabPage";
            WinDirBasicTabPage.Padding = new Padding(3);
            WinDirBasicTabPage.Size = new Size(999, 535);
            WinDirBasicTabPage.TabIndex = 5;
            WinDirBasicTabPage.Text = "Windows Directory (Basic)";
            WinDirBasicTabPage.UseVisualStyleBackColor = true;
            // 
            // DirLabelBasic
            // 
            DirLabelBasic.AutoSize = true;
            DirLabelBasic.Location = new Point(429, 19);
            DirLabelBasic.Name = "DirLabelBasic";
            DirLabelBasic.Size = new Size(58, 15);
            DirLabelBasic.TabIndex = 23;
            DirLabelBasic.Text = "Directory:";
            // 
            // DirListBoxBasic
            // 
            DirListBoxBasic.FormattingEnabled = true;
            DirListBoxBasic.Location = new Point(429, 37);
            DirListBoxBasic.Name = "DirListBoxBasic";
            DirListBoxBasic.Size = new Size(372, 154);
            DirListBoxBasic.TabIndex = 22;
            // 
            // DelFileButtonBasic
            // 
            DelFileButtonBasic.Location = new Point(258, 168);
            DelFileButtonBasic.Name = "DelFileButtonBasic";
            DelFileButtonBasic.Size = new Size(120, 23);
            DelFileButtonBasic.TabIndex = 14;
            DelFileButtonBasic.Text = "Delete File";
            DelFileButtonBasic.UseVisualStyleBackColor = true;
            DelFileButtonBasic.Click += DelFileButtonBasic_Click;
            // 
            // OpenFileButtonBasic
            // 
            OpenFileButtonBasic.Location = new Point(132, 168);
            OpenFileButtonBasic.Name = "OpenFileButtonBasic";
            OpenFileButtonBasic.Size = new Size(120, 23);
            OpenFileButtonBasic.TabIndex = 13;
            OpenFileButtonBasic.Text = "Open File";
            OpenFileButtonBasic.UseVisualStyleBackColor = true;
            OpenFileButtonBasic.Click += OpenFileButtonBasic_Click;
            // 
            // CreateFileButtonBasic
            // 
            CreateFileButtonBasic.Location = new Point(6, 168);
            CreateFileButtonBasic.Name = "CreateFileButtonBasic";
            CreateFileButtonBasic.Size = new Size(120, 23);
            CreateFileButtonBasic.TabIndex = 12;
            CreateFileButtonBasic.Text = "Create File";
            CreateFileButtonBasic.UseVisualStyleBackColor = true;
            CreateFileButtonBasic.Click += CreateFileButtonBasic_Click;
            // 
            // FileNameTextBoxBasic
            // 
            FileNameTextBoxBasic.Location = new Point(6, 139);
            FileNameTextBoxBasic.Name = "FileNameTextBoxBasic";
            FileNameTextBoxBasic.Size = new Size(372, 23);
            FileNameTextBoxBasic.TabIndex = 11;
            FileNameTextBoxBasic.Text = "NewTextDoc.txt";
            // 
            // FileNameLabelBasic
            // 
            FileNameLabelBasic.AutoSize = true;
            FileNameLabelBasic.Location = new Point(6, 121);
            FileNameLabelBasic.Name = "FileNameLabelBasic";
            FileNameLabelBasic.Size = new Size(137, 15);
            FileNameLabelBasic.TabIndex = 10;
            FileNameLabelBasic.Text = "File Name and Extension";
            // 
            // DelDirButtonBasic
            // 
            DelDirButtonBasic.Location = new Point(258, 66);
            DelDirButtonBasic.Name = "DelDirButtonBasic";
            DelDirButtonBasic.Size = new Size(120, 23);
            DelDirButtonBasic.TabIndex = 9;
            DelDirButtonBasic.Text = "Delete Directory";
            DelDirButtonBasic.UseVisualStyleBackColor = true;
            DelDirButtonBasic.Click += DelDirButtonBasic_Click;
            // 
            // OpenDirButtonBasic
            // 
            OpenDirButtonBasic.Location = new Point(132, 66);
            OpenDirButtonBasic.Name = "OpenDirButtonBasic";
            OpenDirButtonBasic.Size = new Size(120, 23);
            OpenDirButtonBasic.TabIndex = 8;
            OpenDirButtonBasic.Text = "Open Directory";
            OpenDirButtonBasic.UseVisualStyleBackColor = true;
            OpenDirButtonBasic.Click += OpenDirButtonBasic_Click;
            // 
            // CreateDirButtonBasic
            // 
            CreateDirButtonBasic.Location = new Point(6, 66);
            CreateDirButtonBasic.Name = "CreateDirButtonBasic";
            CreateDirButtonBasic.Size = new Size(120, 23);
            CreateDirButtonBasic.TabIndex = 7;
            CreateDirButtonBasic.Text = "Create Directory";
            CreateDirButtonBasic.UseVisualStyleBackColor = true;
            CreateDirButtonBasic.Click += CreateDirButtonBasic_Click;
            // 
            // DirPathLabelBasic
            // 
            DirPathLabelBasic.AutoSize = true;
            DirPathLabelBasic.Location = new Point(6, 19);
            DirPathLabelBasic.Name = "DirPathLabelBasic";
            DirPathLabelBasic.Size = new Size(82, 15);
            DirPathLabelBasic.TabIndex = 6;
            DirPathLabelBasic.Text = "Directory Path";
            // 
            // DirPathTextBoxBasic
            // 
            DirPathTextBoxBasic.Location = new Point(6, 37);
            DirPathTextBoxBasic.Name = "DirPathTextBoxBasic";
            DirPathTextBoxBasic.Size = new Size(372, 23);
            DirPathTextBoxBasic.TabIndex = 5;
            DirPathTextBoxBasic.Text = "C:\\TcAiEx\\temp";
            // 
            // WinDirAdvTabPage
            // 
            WinDirAdvTabPage.Controls.Add(CurFromDirLabel);
            WinDirAdvTabPage.Controls.Add(MoveButton);
            WinDirAdvTabPage.Controls.Add(CopyButton);
            WinDirAdvTabPage.Controls.Add(ToDirTextBox);
            WinDirAdvTabPage.Controls.Add(FromDirTextBox);
            WinDirAdvTabPage.Controls.Add(ToLabel);
            WinDirAdvTabPage.Controls.Add(FromLabel);
            WinDirAdvTabPage.Controls.Add(DeleteSelectedButton);
            WinDirAdvTabPage.Controls.Add(OpenSelectedButton);
            WinDirAdvTabPage.Controls.Add(UpdateListBox);
            WinDirAdvTabPage.Controls.Add(FileListBox);
            WinDirAdvTabPage.Controls.Add(DelFileButton);
            WinDirAdvTabPage.Controls.Add(OpenFileButton);
            WinDirAdvTabPage.Controls.Add(CreateFileButton);
            WinDirAdvTabPage.Controls.Add(FileNameTextBox);
            WinDirAdvTabPage.Controls.Add(FileNameLabel);
            WinDirAdvTabPage.Controls.Add(DelDirButton);
            WinDirAdvTabPage.Controls.Add(OpenDirButton);
            WinDirAdvTabPage.Controls.Add(CreateDirButton);
            WinDirAdvTabPage.Controls.Add(DirPathLabel);
            WinDirAdvTabPage.Controls.Add(DirPathTextBox);
            WinDirAdvTabPage.Location = new Point(4, 24);
            WinDirAdvTabPage.Name = "WinDirAdvTabPage";
            WinDirAdvTabPage.Padding = new Padding(3);
            WinDirAdvTabPage.Size = new Size(999, 535);
            WinDirAdvTabPage.TabIndex = 2;
            WinDirAdvTabPage.Text = "Windows Directory (Adv)";
            WinDirAdvTabPage.UseVisualStyleBackColor = true;
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
            WinDirBasicTabPage.ResumeLayout(false);
            WinDirBasicTabPage.PerformLayout();
            WinDirAdvTabPage.ResumeLayout(false);
            WinDirAdvTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage WinDirAdvTabPage;
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
        private TabPage WinDirBasicTabPage;
        private Label DirLabelBasic;
        private ListBox DirListBoxBasic;
        private Button DelFileButtonBasic;
        private Button OpenFileButtonBasic;
        private Button CreateFileButtonBasic;
        private TextBox FileNameTextBoxBasic;
        private Label FileNameLabelBasic;
        private Button DelDirButtonBasic;
        private Button OpenDirButtonBasic;
        private Button CreateDirButtonBasic;
        private Label DirPathLabelBasic;
        private TextBox DirPathTextBoxBasic;
    }
}
