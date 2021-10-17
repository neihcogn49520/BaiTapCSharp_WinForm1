using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BT1
{
    public partial class Form1 : Form
    {
        private void openDaTaSource()
        {
            string connect;
            SqlConnection cnn;
            connect = @"Data Source=DESKTOP-P3RMIME\SQLEXPRESS;Initial Catalog=fastfood;Persist Security Info=True;User ID=sa;Password=hien0409";
            cnn = new SqlConnection(connect);
            cnn.Open();
        }
        
        public Form1()
        {
            InitializeComponent();
        }
        string monan = "";
        int soluong;
        DataTable tb_Order = new DataTable();
        private void addDGV()
        {
            bool k = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string dtfood = (string)dataGridView1[0, i].Value;
                if (monan.Equals(dtfood))
                {
                    soluong = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    soluong++;
                    dataGridView1.Rows[i].Cells[1].Value = soluong.ToString();
                    k = true;
                }
            }
            if (!k)
            {
                tb_Order.Rows.Add(new object[]
                    {monan, 1});
            }
        }

        SqlDataAdapter data;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fastfoodDataSet.ffood' table. You can move, or remove it, as needed.
            this.ffoodTableAdapter.Fill(this.fastfoodDataSet.ffood);
            tb_Order.Columns.Add("Món ăn");
            tb_Order.Columns.Add("Số lượng");

            //đối tượng đọc dữ liệu
            //data = new SqlDataAdapter("");
            //điền dữ liệu vào đối tượng
            


            dataGridView1.DataSource = tb_Order;
        }
        private void bt_bgBo_Click(object sender, EventArgs e)
        {
            monan = bt_bgBo.Text;
            addDGV();
        }

        private void bt_bgGa_Click(object sender, EventArgs e)
        {
            monan = bt_bgGa.Text;
            addDGV();
        }

        private void bt_bgTom_Click(object sender, EventArgs e)
        {
            monan = bt_bgTom.Text;
            addDGV();
        }

        private void bt_bgCa_Click(object sender, EventArgs e)
        {
            monan = bt_bgCa.Text;
            addDGV();
        }

        private void bt_TomCola_Click(object sender, EventArgs e)
        {
            monan = bt_TomCola.Text;
            addDGV();
        }

        private void bt_GaCola_Click(object sender, EventArgs e)
        {
            monan = bt_GaCola.Text;
            addDGV();
        }

        private void bt_GaRan_Click(object sender, EventArgs e)
        {
            monan = bt_GaRan.Text;
            addDGV();
        }

        private void bt_ComGa_Click(object sender, EventArgs e)
        {
            monan = bt_ComGa.Text;
            addDGV();
        }

        private void bt_Pepsi_Click(object sender, EventArgs e)
        {
            monan = bt_Pepsi.Text;
            addDGV();
        }

        private void bt_Coca_Click(object sender, EventArgs e)
        {
            monan = bt_Coca.Text;
            addDGV();
        }

        private void bt_7up_Click(object sender, EventArgs e)
        {
            monan = bt_7up.Text;
            addDGV();
        }

        private void bt_Lipton_Click(object sender, EventArgs e)
        {
            monan = bt_Lipton.Text;
            addDGV();
        }

        private void bt_Cafe_Click(object sender, EventArgs e)
        {
            monan = bt_Cafe.Text;
            addDGV();
        }

        private void bt_Cam_Click(object sender, EventArgs e)
        {
            monan = bt_Cam.Text;
            addDGV();
        }

        private void bt_Khoaitc_Click(object sender, EventArgs e)
        {
            monan = bt_Khoaitc.Text;
            addDGV();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0 && 
                dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                tb_Order.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void bt_Order_Click(object sender, EventArgs e)
        {
            string soban = cb_Tenban.Text;
            List<string> order = new List<string>();
            string data = "";

            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    if (j == 1)
                    {
                        data = data + ": ";
                    }
                    data = data + (string)dataGridView1[j, i].Value;
                    order.Add(data);
                }
                data += "\n";
            }

            MessageBox.Show(soban + ":\n" + data);
            
            cb_Tenban.SelectedIndex = 0;
        }
    }
}
