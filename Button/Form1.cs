using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb1.AutoSize = true;
            lb1.Text = "Do you want to submit this project?";
            lb1.Font = new Font("French Script MT", 18);

            //setting button1
            button1.Text = "Submit";
            button1.AutoSize = true;
            button1.BackColor = Color.LightBlue;
            button1.Padding = new Padding(6);
            button1.Font = new Font("French Script MT", 18);

            //setting button2
            button2.Text = "Cancel";
            button2.AutoSize = true;
            button2.BackColor = Color.LightPink;
            button2.Padding = new Padding(6);
            button2.Font = new Font("French Script MT", 18);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
