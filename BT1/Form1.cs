using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gender;
        string ms = "";
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        public string checkBox(CheckBox cs, CheckBox java, CheckBox python)
        {
            string cb = "";
            if (cs.Checked == true)
            {
                cb = cs.Text;
            }
            if (java.Checked == true)
            {
                cb = cb + ", " + java.Text;
            }
            if (python.Checked == true)
            {
                cb = cb + ", " + python.Text;
            }

            return cb;
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            string cb = checkBox(check_Cs, check_java, check_Python);
            
            bool kt = false;  
            if(kt == false)
            {
                if (text_name.Text == "")
                {
                    ms = "Name is empty!";
                }

                if (text_address.Text == "")
                {
                    ms = ms + "\nAddress is empty!";
                }

                if (list_city.SelectedItem == null)
                {
                    ms = ms + "\nNo city is selected!";
                }
                if (check_Cs.Checked != true && check_java.Checked != true && check_Python.Checked != true)
                {
                    ms = ms + "\nNo subject is selected!";
                }

                if (rb_male.Checked != true && rb_female.Checked != true && rb_other.Checked != true)
                {
                    ms = ms + "\nNo gender is selected!";
                }
                MessageBox.Show(ms);
                //kt = true;
            }   
            else
            {
                MessageBox.Show("Name: " + text_name.Text + 
                                "\nAddress: " + text_address.Text + 
                                "\nCity: " + list_city.SelectedItem.ToString() + 
                                "\nGender: "  + gender + 
                                "\nSubject: " + cb);
            }
        }

        private void list_city_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void rb_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = rb_male.Text;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = rb_female.Text;
        }
        private void rb_other_CheckedChanged(object sender, EventArgs e)
        {
            gender = rb_other.Text;
        }
    }
}
