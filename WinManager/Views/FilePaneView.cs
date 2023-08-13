using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinManager.Views
{
    public partial class FilePaneView : UserControl
    {
        public FilePaneView()
        {
            InitializeComponent();
            PopulateListView("C:\\"); // Initial directory path
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateListView(string directoryPath)
        {
            // Clear existing items in the ListView
            listView1.Items.Clear();

            // Get files and folders in the directory
            try
            {
                string[] directories = Directory.GetDirectories(directoryPath);
                string[] files = Directory.GetFiles(directoryPath);

                foreach (string dir in directories)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { Path.GetFileName(dir), "Folder" }));
                }

                foreach (string file in files)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file), "File" }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
