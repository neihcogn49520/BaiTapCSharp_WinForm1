using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa nhấp vào Menu1.");
        }

        private void menu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa nhấp vào Menu2.");
        }
    }
}
