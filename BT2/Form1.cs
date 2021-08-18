using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int tien = 0;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void setColor(Button a)
        {
            if(a.BackColor != Color.Yellow)
            {
                if (a.BackColor == Color.White)
                    a.BackColor = Color.Blue;
                else
                    a.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Vé của ghế này đã được mua! Vui lòng chọn ghế khác.");
            }
        }
        List<Button> LoA = new List<Button>();
        List<Button> LoB = new List<Button>();
        List<Button> LoC = new List<Button>();
        private void bt1_Click(object sender, EventArgs e)
        {
            setColor(bt1);
            LoA.Add(bt1);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            setColor(bt2);
            LoA.Add(bt2);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            setColor(bt3);
            LoA.Add(bt3);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            setColor(bt4);
            LoA.Add(bt4);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            setColor(bt5);
            LoA.Add(bt5);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            setColor(bt6);
            LoB.Add(bt6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setColor(bt7);
            LoB.Add(bt7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setColor(bt8);
            LoB.Add(bt8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            setColor(bt9);
            LoB.Add(bt9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setColor(bt10);
            LoB.Add(bt10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            setColor(bt11);
            LoC.Add(bt11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            setColor(bt12);
            LoC.Add(bt12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            setColor(bt13);
            LoC.Add(bt13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            setColor(bt14);
            LoC.Add(bt14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            setColor(bt15);
            LoC.Add(bt15);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_chon_Click(object sender, EventArgs e)
        {
            foreach (Button a in LoA)
            {
                a.BackColor = Color.Yellow;
                tien += 5000;
            }
            foreach (Button b in LoB)
            {
                b.BackColor = Color.Yellow;
                tien += 6500;
            }
            foreach (Button c in LoC)
            {
                c.BackColor = Color.Yellow;
                tien += 8000;
            }
            txt_ThanhTien.Text = tien.ToString();
            tien = 0;
            LoA = new List<Button>();
            LoB = new List<Button>();
            LoC = new List<Button>();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            foreach (Button a in LoA)
            {
                a.BackColor = Color.White;
            }
            foreach (Button b in LoB)
            {
                b.BackColor = Color.White;
            }
            foreach (Button c in LoC)
            {
                c.BackColor = Color.White;
            }
            txt_ThanhTien.Text = "";
            LoA = new List<Button>();
            LoB = new List<Button>();
            LoC = new List<Button>();
        }

        private void bt_KT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
