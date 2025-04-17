namespace TcAiExamples
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        #region WinDirBasic
        private void CreateDirButtonBasic_Click(object sender, EventArgs e)
        {
            // Create a new directory at DirPathTextBoxBasic.Text
            string path = DirPathTextBoxBasic.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show($"Directory created at {path}");
                }
                else
                {
                    MessageBox.Show($"Directory already exists at {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating directory: {ex.Message}");
            }

            UpdateDirLabelBasic();
            UpdateListBoxBasic();

        }

        private void OpenDirButtonBasic_Click(object sender, EventArgs e)
        {
            // Open the directory at DirPathTextBoxBasic.Text
            string path = DirPathTextBoxBasic.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            try
            {
                if (Directory.Exists(path))
                {
                    System.Diagnostics.Process.Start("explorer.exe", path);
                }
                else
                {
                    MessageBox.Show($"Directory does not exist at {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening directory: {ex.Message}");
            }
            UpdateDirLabelBasic();
            UpdateListBoxBasic();
        }

        private void DelDirButtonBasic_Click(object sender, EventArgs e)
        {
            // Delete the directory at DirPathTextBoxBasic.Text
            string path = DirPathTextBoxBasic.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            try
            {
                if (Directory.Exists(path))
                {
                    // Confirm deletion
                    var result = MessageBox.Show($"Are you sure you want to delete the directory at {path}?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    // Delete the directory
                    Directory.Delete(path, true);
                    MessageBox.Show($"Directory deleted at {path}");
                }
                else
                {
                    MessageBox.Show($"Directory does not exist at {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting directory: {ex.Message}");
            }
            UpdateDirLabelBasic();
            UpdateListBoxBasic();
        }

        private void UpdateListBoxBasic()
        {
            // Update the ListBox with the contents of the directory at DirPathTextBoxBasic.Text
            string path = DirPathTextBoxBasic.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            try
            {
                if (Directory.Exists(path))
                {
                    // Clear the ListBox
                    DirListBoxBasic.Items.Clear();
                    // Get the files and directories in the specified path
                    string[] files = Directory.GetFiles(path);
                    string[] directories = Directory.GetDirectories(path);
                    // Add the files to the ListBox
                    foreach (string file in files)
                    {
                        DirListBoxBasic.Items.Add(Path.GetFileName(file));
                    }
                    // Add the directories to the ListBox
                    foreach (string directory in directories)
                    {
                        DirListBoxBasic.Items.Add(Path.GetFileName(directory));
                    }
                }
                else
                {
                    MessageBox.Show($"Directory does not exist at {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating ListBox: {ex.Message}");
            }
        }

        private void CreateFileButtonBasic_Click(object sender, EventArgs e)
        {
            // Create a new file at DirPathTextBoxBasic.Text with the name at FileNameTextBoxBasic.Text
            string path = DirPathTextBoxBasic.Text;
            string fileName = FileNameTextBoxBasic.Text;
            // Check if the path and file name are valid
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter a valid file name.");
                return;
            }
            try
            {
                string filePath = Path.Combine(path, fileName);
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                    MessageBox.Show($"File created at {filePath}");
                }
                else
                {
                    MessageBox.Show($"File already exists at {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating file: {ex.Message}");
            }
            // Update the DirListBoxBasic.text
            UpdateListBoxBasic();
        }

        private void UpdateDirLabelBasic()
        {
            // Update the label with the current directory path
            DirLabelBasic.Text = $"Directory: {DirPathTextBoxBasic.Text}";
        }
        #endregion

        #region WinDirAdv
        private void CreateDirButton_Click(object sender, EventArgs e)
        {
            //Create a new directory at DirPathTextBox.Text
            string path = DirPathTextBox.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show($"Directory created at {path}");
                }
                else
                {
                    MessageBox.Show($"Directory already exists at {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating directory: {ex.Message}");
            }
        }

        private void OpenDirButton_Click(object sender, EventArgs e)
        {
            //Open the directory at DirPathTextBox.Text
            string path = DirPathTextBox.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            try
            {
                if (Directory.Exists(path))
                {
                    System.Diagnostics.Process.Start("explorer.exe", path);
                }
                else
                {
                    MessageBox.Show($"Directory does not exist at {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening directory: {ex.Message}");
            }

        }

        private void DelDirButton_Click(object sender, EventArgs e)
        {
            //Delete the directory at DirPathTextBox.Text
            string path = DirPathTextBox.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            try
            {
                if (Directory.Exists(path))
                {
                    // Confirm deletion
                    var result = MessageBox.Show($"Are you sure you want to delete the directory at {path}?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    // Delete the directory
                    Directory.Delete(path, true);
                    MessageBox.Show($"Directory deleted at {path}");
                }
                else
                {
                    MessageBox.Show($"Directory does not exist at {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting directory: {ex.Message}");
            }
        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            // Create a new file at DirPathTextBox.Text with the name at FileNameTextBox.Text
            string path = DirPathTextBox.Text;
            string fileName = FileNameTextBox.Text;
            // Check if the path and file name are valid
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter a valid file name.");
                return;
            }
            try
            {
                string filePath = Path.Combine(path, fileName);
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                    MessageBox.Show($"File created at {filePath}");
                }
                else
                {
                    MessageBox.Show($"File already exists at {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating file: {ex.Message}");
            }

        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            // Open the file at DirPathTextBox.Text with the name at FileNameTextBox.Text
            string path = DirPathTextBox.Text;
            string fileName = FileNameTextBox.Text;
            // Check if the path and file name are valid
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter a valid file name.");
                return;
            }
            try
            {
                string filePath = Path.Combine(path, fileName);
                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start("explorer.exe", filePath);
                }
                else
                {
                    MessageBox.Show($"File does not exist at {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.Message}");
            }
        }

        private void DelFileButton_Click(object sender, EventArgs e)
        {
            // Delete the file at DirPathTextBox.Text with the name at FileNameTextBox.Text
            string path = DirPathTextBox.Text;
            string fileName = FileNameTextBox.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter a valid file name.");
                return;
            }
            try
            {
                string filePath = Path.Combine(path, fileName);
                if (File.Exists(filePath))
                {
                    // Confirm deletion
                    var result = MessageBox.Show($"Are you sure you want to delete the file at {filePath}?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    // Delete the file
                    File.Delete(filePath);
                    MessageBox.Show($"File deleted at {filePath}");
                }
                else
                {
                    MessageBox.Show($"File does not exist at {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting file: {ex.Message}");
            }
        }

        private void UpdateListBox_Click(object sender, EventArgs e)
        {
            // Update the label with the current directory path
            CurFromDirLabel.Text = $"From Directory: {FromDirTextBox.Text}";

            // Update the ListBox with the contents of the directory at DirPathTextBox.Text
            string path = FromDirTextBox.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            try
            {
                if (Directory.Exists(path))
                {
                    // Clear the ListBox
                    FileListBox.Items.Clear();
                    // Get the files and directories in the specified path
                    string[] files = Directory.GetFiles(path);
                    string[] directories = Directory.GetDirectories(path);
                    // Add the files to the ListBox
                    foreach (string file in files)
                    {
                        FileListBox.Items.Add(Path.GetFileName(file));
                    }
                    // Add the directories to the ListBox
                    foreach (string directory in directories)
                    {
                        FileListBox.Items.Add(Path.GetFileName(directory));
                    }
                }
                else
                {
                    MessageBox.Show($"Directory does not exist at {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating ListBox: {ex.Message}");
            }
        }

        private void OpenSelectedButton_Click(object sender, EventArgs e)
        {
            // Open the selected file or directory in the ListBox
            if (FileListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a file or directory from the ListBox.");
                return;
            }
            string selectedItem = FileListBox.SelectedItem.ToString();
            string path = DirPathTextBox.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            try
            {
                string fullPath = Path.Combine(path, selectedItem);
                if (File.Exists(fullPath))
                {
                    System.Diagnostics.Process.Start("explorer.exe", fullPath);
                }
                else if (Directory.Exists(fullPath))
                {
                    System.Diagnostics.Process.Start("explorer.exe", fullPath);
                }
                else
                {
                    MessageBox.Show($"File or directory does not exist at {fullPath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening selected item: {ex.Message}");
            }
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            // Delete the selected file or directory in the ListBox
            if (FileListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a file or directory from the ListBox.");
                return;
            }
            string selectedItem = FileListBox.SelectedItem.ToString();
            string path = DirPathTextBox.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            try
            {
                string fullPath = Path.Combine(path, selectedItem);
                if (File.Exists(fullPath))
                {
                    // Confirm deletion
                    var result = MessageBox.Show($"Are you sure you want to delete the file at {fullPath}?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    // Delete the file
                    File.Delete(fullPath);
                    MessageBox.Show($"File deleted at {fullPath}");
                }
                else if (Directory.Exists(fullPath))
                {
                    // Confirm deletion
                    var result = MessageBox.Show($"Are you sure you want to delete the directory at {fullPath}?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    // Delete the directory
                    Directory.Delete(fullPath, true);
                    MessageBox.Show($"Directory deleted at {fullPath}");
                }
                else
                {
                    MessageBox.Show($"File or directory does not exist at {fullPath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting selected item: {ex.Message}");
            }

            // Update the ListBox after deletion
            UpdateListBox_Click(sender, e);

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            // Copy the selected file or directory in the ListBox from the FromDirTextBox.Text to the ToDirTextBox.Text
            if (FileListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a file or directory from the ListBox.");
                return;
            }
            string selectedItem = FileListBox.SelectedItem.ToString();
            string fromPath = FromDirTextBox.Text;
            string toPath = ToDirTextBox.Text;
            if (string.IsNullOrEmpty(fromPath) || string.IsNullOrEmpty(toPath))
            {
                MessageBox.Show("Please enter valid paths.");
                return;
            }
            try
            {
                string fullFromPath = Path.Combine(fromPath, selectedItem);
                string fullToPath = Path.Combine(toPath, selectedItem);
                if (File.Exists(fullFromPath))
                {
                    File.Copy(fullFromPath, fullToPath, true);
                    MessageBox.Show($"File copied from {fullFromPath} to {fullToPath}");
                }
                else
                {
                    MessageBox.Show($"File or directory does not exist at {fullFromPath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying selected item: {ex.Message}");
            }
        }


        #endregion







        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Update DirLabelBasic with the current directory path
            if (e.TabPage == WinDirBasicTabPage)
            {
                UpdateDirLabelBasic();
            }
            else if (e.TabPage == WinDirAdvTabPage)
            {
                CurFromDirLabel.Text = $"From Directory: {FromDirTextBox.Text}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the initial directory path for the basic tab
            UpdateDirLabelBasic();

        }

        private void OpenFileButtonBasic_Click(object sender, EventArgs e)
        {
            // Open the file at DirPathTextBoxBasic.Text with the name at FileNameTextBoxBasic.Text
            string path = DirPathTextBoxBasic.Text;
            string fileName = FileNameTextBoxBasic.Text;
            // Check if the path and file name are valid
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter a valid file name.");
                return;
            }
            try
            {
                string filePath = Path.Combine(path, fileName);
                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start("explorer.exe", filePath);
                }
                else
                {
                    MessageBox.Show($"File does not exist at {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.Message}");
            }
            // Update the DirListBoxBasic.text
            UpdateListBoxBasic();
        }

        private void DelFileButtonBasic_Click(object sender, EventArgs e)
        {
            // Delete the file at DirPathTextBoxBasic.Text with the name at FileNameTextBoxBasic.Text
            string path = DirPathTextBoxBasic.Text;
            string fileName = FileNameTextBoxBasic.Text;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter a valid file name.");
                return;
            }
            try
            {
                string filePath = Path.Combine(path, fileName);
                if (File.Exists(filePath))
                {
                    // Confirm deletion
                    var result = MessageBox.Show($"Are you sure you want to delete the file at {filePath}?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    // Delete the file
                    File.Delete(filePath);
                    MessageBox.Show($"File deleted at {filePath}");
                }
                else
                {
                    MessageBox.Show($"File does not exist at {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting file: {ex.Message}");
            }
            // Update the DirListBoxBasic.text
            UpdateListBoxBasic();
        }
    }
}
