using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            first_label.Text = "This is my first label";
            first_label.BorderStyle = BorderStyle.FixedSingle;
            first_label.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
