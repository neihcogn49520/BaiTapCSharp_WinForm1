using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb1.Width = 250;
            tb1.Height = 50;
            tb1.Multiline = true;
            tb1.BackColor = Color.LightBlue;
            tb1.ForeColor = Color.White;
            tb1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string var;
            var = tb1.Text;
            MessageBox.Show(var);
        }
    }
}
