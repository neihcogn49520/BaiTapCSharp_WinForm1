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

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void openDaTaSource()
        {
            string connect;
            
            connect = @"Data Source=DESKTOP-P3RMIME\SQLEXPRESS;Initial Catalog=nhanvien;Persist Security Info=True;User ID=sa;Password=hien0409";
            cnn = new SqlConnection(connect);
            

            cnn.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lv_NhanVien.View = View.Details;
            lv_NhanVien.GridLines = true;
            lv_NhanVien.FullRowSelect = true;

            lv_NhanVien.Columns.Add("Họ tên");
            lv_NhanVien.Columns.Add("Ngày sinh");
            lv_NhanVien.Columns.Add("Số điện thoại");
            lv_NhanVien.Columns.Add("Địa chỉ");

            addData();
        }
        public void addData()
        {
            openDaTaSource();
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            

            //lấy dữ liệu
            string sql = "Select * from thongtinnv";
            adapter.Fill(data);
            //lv_NhanVien.Items.Clear();
            ListViewItem row;
            for(int i = 0; i < data.Rows.Count; i++)
            {
                DataRow r = data.Rows[i];
                ListViewItem itm = new ListViewItem(data.Rows[i][1].ToString());
                ListViewItem.ListViewSubItem subitm = new ListViewItem.ListViewSubItem(itm, data.Rows[i][0].ToString());
                ListViewItem sta = new ListViewItem(data.Rows[i][2].ToString());
                if(sta.Text == "0")
                {
                    itm.SubItems.Add(subitm);
                    lv_NhanVien.Items.Add(itm);
                    itm.ImageIndex = 1;
                }
                else
                {
                    itm.SubItems.Add(subitm);
                    lv_NhanVien.Items.Add(itm);
                    itm.ImageIndex = 0;
                }
                
            }

            lv_NhanVien.View = View.Details;
            lv_NhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_NhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            cnn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] thongtin = new string[4];

            thongtin[0] = txt_name.Text;
            thongtin[1] = dtp_Ngaysinh.Text;
            thongtin[2] = txt_sdt.Text;
            thongtin[3] = txt_dc.Text;

            ListViewItem itm = new ListViewItem(thongtin);
            lv_NhanVien.Items.Add(itm);
        }
        
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_NhanVien.Items.Count; i++)
            {
                if (lv_NhanVien.Items[i].Checked)
                {
                    lv_NhanVien.Items[i].Remove();
                    i--;
                }
            }
        }
        bool sua = true;
        private void bt_Sua_Click(object sender, EventArgs e)
        {
            if (!sua)
            {
                sua = true;
                if (lv_NhanVien.SelectedItems.Count > 0)
                {
                    txt_name.Text = lv_NhanVien.SelectedItems[0].SubItems[0].Text;
                    dtp_Ngaysinh.Text = lv_NhanVien.SelectedItems[0].SubItems[1].Text;
                    txt_sdt.Text = lv_NhanVien.SelectedItems[0].SubItems[2].Text;
                    txt_dc.Text = lv_NhanVien.SelectedItems[0].SubItems[3].Text;
                }
            }
            else
            {
                sua = false;
                lv_NhanVien.SelectedItems[0].SubItems[0].Text = txt_name.Text;
                lv_NhanVien.SelectedItems[0].SubItems[1].Text = dtp_Ngaysinh.Text;
                lv_NhanVien.SelectedItems[0].SubItems[2].Text = txt_sdt.Text;
                lv_NhanVien.SelectedItems[0].SubItems[3].Text = txt_dc.Text;
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
