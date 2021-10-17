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

namespace VD_S15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*SqlConnection cnn;
        private void Connect()
        {
            string connect = @"Data Source=DESKTOP-P3RMIME\SQLEXPRESS;Initial Catalog=demotb;User ID=sa;Password=hien0409";
            
            cnn = new SqlConnection(connect);
            cnn.Open();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-P3RMIME\SQLEXPRESS;Initial Catalog=demotb;User ID=sa;Password=hien0409";
            SqlConnection cnn;
            cnn = new SqlConnection(connect);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select ID, Name from tb";

            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            MessageBox.Show(Output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-P3RMIME\SQLEXPRESS;Initial Catalog=demotb;User ID=sa;Password=hien0409";
            SqlConnection cnn;
            cnn = new SqlConnection(connect);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "Insert into tb (ID, Name) values(3, '" + "VB.Net" + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-P3RMIME\SQLEXPRESS;Initial Catalog=demotb;User ID=sa;Password=hien0409";
            SqlConnection cnn;
            cnn = new SqlConnection(connect);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "Update tb set Name='"+"VB.Net Complete"+"' where ID=3";

            command = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DESKTOP-P3RMIME\SQLEXPRESS;Initial Catalog=demotb;User ID=sa;Password=hien0409";
            SqlConnection cnn;
            cnn = new SqlConnection(connect);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "Delete tb where ID=3";
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }
    }
}
