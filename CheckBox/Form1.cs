using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ms = "";
            if(checkBox1.Checked == true)
            {
                ms = "C#";
            }
            if (checkBox2.Checked == true)
            {
                ms = ms + "\nC++";
            }
            if(checkBox3.Checked == true)
            {
                ms = ms + "\nJava";
            }    
            if(ms.Length > 0)
            {
                MessageBox.Show(ms + "\nĐã được chọn.");
            }
            else
            {
                MessageBox.Show("Không môn nào được chọn.");
            }
        }
    }
}
