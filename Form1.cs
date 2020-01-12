using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crom.Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dockContainer1_Load(object sender, EventArgs e)
        {
            DockableToolWindow childForm = new DockableToolWindow();

            // Add the form to the dock container
            dockContainer1.AddToolWindow(childForm);

            // Show the form
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DockableToolWindow childForm = new DockableToolWindow();

            // Add the form to the dock container
            dockContainer1.AddToolWindow(childForm);

            // Show the form
            childForm.Show();
        }
    }
}
