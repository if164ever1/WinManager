using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinManager.Views;

namespace WinManager
{
    public partial class mainWindow : Form
    {
        private FilePaneView filePaneView;
        public mainWindow()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
        private void InitializeUI()
        {
            filePaneView = new FilePaneView();

            // Set the user control's position, size, and other properties within a panel.
            // Optionally, set its Dock or Anchor properties to control resizing behavior.

            // Attach event handlers or set up communication as needed.

            panelLeft.Controls.Add(filePaneView); // Add the user control to the panel.
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button_view_F3_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MessageBox.Show(button.Text + "was clicked");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
