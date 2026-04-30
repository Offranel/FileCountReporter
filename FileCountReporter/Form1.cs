namespace FileCountReporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Connect buttons
            btnBrowse.Click += btnBrowse_Click;
            btnScan.Click += btnScan_Click;
            btnExit.Click += btnExit_Click;
        }

        // 🔹 Browse Button
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = dlg.SelectedPath;
                }
            }
        }

        // 🔹 Scan Button (MAIN LOGIC)
        private void btnScan_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text.Trim();

            if (!Directory.Exists(path))
            {
                MessageBox.Show("Folder does not exist.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get all files and folders (including subfolders)
                string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
                string[] dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

                // Display totals
                lblFiles.Text = $"Total Files: {files.Length}";
                lblFolders.Text = $"Total Folders: {dirs.Length}";

                // Count file types
                Dictionary<string, int> fileTypes = new Dictionary<string, int>();

                foreach (string file in files)
                {
                    string ext = Path.GetExtension(file).ToLower();

                    if (fileTypes.ContainsKey(ext))
                        fileTypes[ext]++;
                    else
                        fileTypes[ext] = 1;
                }

                // Show in ListBox
                listBoxTypes.Items.Clear();

                foreach (var item in fileTypes)
                {
                    listBoxTypes.Items.Add($"{item.Key} → {item.Value}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // 🔹 Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        
    

