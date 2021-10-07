using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Employee");

            //thêm cột
            dt.Columns.Add("First Name", System.Type.GetType("System.String"));
            dt.Columns.Add("Last Name", System.Type.GetType("System.String"));
            dt.Columns.Add("Occupation", System.Type.GetType("System.String"));
            dt.Columns.Add("Salary", System.Type.GetType("System.Int32"));

            //thêm dữ liệu mỗi cột
            dt.Rows.Add(new object[]
                {"Nguyễn", "Hiền", "Author", 20000});
            dt.Rows.Add(new object[]
                {"Nguyễn", "Oanh", "Catoonist", 15000});
            dt.Rows.Add(new object[]
                {"Đoàn", "Nhất", "Tourism", 30000});

            dataGridView1.DataSource = dt;
        }
    }
}
