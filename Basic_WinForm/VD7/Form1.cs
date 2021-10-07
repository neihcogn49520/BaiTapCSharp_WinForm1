using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //tiêu đề mỗi cột
            listView1.Columns.Add("Tên sản phẩm", 100);
            listView1.Columns.Add("Giá", 70);
            listView1.Columns.Add("Số lượng", 70);

            //thêm item
            string[] arr = new string[4];
            ListViewItem it;

            //thêm item 1
            arr[0] = "Sản phẩm 01";
            arr[1] = "100";
            arr[2] = "10";
            it = new ListViewItem(arr);
            listView1.Items.Add(it);

            //thêm item 2
            arr[0] = "Sản phẩm 02";
            arr[1] = "200";
            arr[2] = "20";
            it = new ListViewItem(arr);
            listView1.Items.Add(it);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prodName = null;
            string price = null;
            string quantity = null;

            if(listView1.SelectedItems.Count > 0)
            {
                prodName = listView1.SelectedItems[0].SubItems[0].Text;
                price = listView1.SelectedItems[0].SubItems[1].Text;
                quantity = listView1.SelectedItems[0].SubItems[2].Text;

                MessageBox.Show(prodName + " , " + price + " , " + quantity);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm!");
            }
        }
    }
}
