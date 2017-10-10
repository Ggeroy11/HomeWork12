using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TopLevelMenu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TopLevelMenuTextbox.Text)) MenuStrip.Items.Add(TopLevelMenuTextbox.Text);
        }

        private void SubItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SubItemTextBox.Text)) fileToolStripMenuItem.DropDownItems.Add(SubItemTextBox.Text);
        }
    }
}
