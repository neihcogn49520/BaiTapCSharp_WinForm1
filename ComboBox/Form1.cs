using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            
            string ms = "";
            for (int i = 0; i < cbox1.Items.Count; i++)
            {
                ms = ms + cbox1.Items[i];
            }
            MessageBox.Show(ms + "\n");
        }
    }
}
