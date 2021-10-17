using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VD_S10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-P3RMIME\SQLEXPRESS;Initial Catalog=Demodb;User ID=sa;Password=hien0409";
            SqlConnection cnn;
            cnn = new SqlConnection(connect);
            cnn.Open();
            MessageBox.Show("Connection Open!");

            cnn.Close();
        }
    }
}
