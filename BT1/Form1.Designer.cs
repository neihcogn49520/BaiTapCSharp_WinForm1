
namespace VD1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.list_city = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_other = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.check_Python = new System.Windows.Forms.CheckBox();
            this.check_java = new System.Windows.Forms.CheckBox();
            this.check_Cs = new System.Windows.Forms.CheckBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_address);
            this.groupBox1.Controls.Add(this.text_name);
            this.groupBox1.Controls.Add(this.lb_address);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Location = new System.Drawing.Point(54, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(127, 107);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(291, 22);
            this.text_address.TabIndex = 3;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(127, 46);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(291, 22);
            this.text_name.TabIndex = 2;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(47, 113);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(64, 17);
            this.lb_address.TabIndex = 1;
            this.lb_address.Text = "Address:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(44, 52);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(49, 17);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Name:";
            // 
            // list_city
            // 
            this.list_city.FormattingEnabled = true;
            this.list_city.ItemHeight = 16;
            this.list_city.Items.AddRange(new object[] {
            "Ho Chi Minh",
            "Ha Noi",
            "Da Nang",
            "Hue",
            "Nghe An",
            "Da Lat"});
            this.list_city.Location = new System.Drawing.Point(54, 267);
            this.list_city.Name = "list_city";
            this.list_city.Size = new System.Drawing.Size(458, 196);
            this.list_city.TabIndex = 1;
            this.list_city.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.list_city.SelectedValueChanged += new System.EventHandler(this.list_city_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_male);
            this.panel1.Controls.Add(this.rb_other);
            this.panel1.Controls.Add(this.rb_female);
            this.panel1.Location = new System.Drawing.Point(560, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 146);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(55, 23);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(59, 21);
            this.rb_male.TabIndex = 2;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            this.rb_male.CheckedChanged += new System.EventHandler(this.rb_male_CheckedChanged);
            // 
            // rb_other
            // 
            this.rb_other.AutoSize = true;
            this.rb_other.Location = new System.Drawing.Point(55, 99);
            this.rb_other.Name = "rb_other";
            this.rb_other.Size = new System.Drawing.Size(72, 21);
            this.rb_other.TabIndex = 1;
            this.rb_other.TabStop = true;
            this.rb_other.Text = "Others";
            this.rb_other.UseVisualStyleBackColor = true;
            this.rb_other.CheckedChanged += new System.EventHandler(this.rb_other_CheckedChanged);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(55, 62);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(75, 21);
            this.rb_female.TabIndex = 0;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            this.rb_female.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.check_Python);
            this.panel2.Controls.Add(this.check_java);
            this.panel2.Controls.Add(this.check_Cs);
            this.panel2.Location = new System.Drawing.Point(560, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 161);
            this.panel2.TabIndex = 3;
            // 
            // check_Python
            // 
            this.check_Python.AutoSize = true;
            this.check_Python.Location = new System.Drawing.Point(55, 115);
            this.check_Python.Name = "check_Python";
            this.check_Python.Size = new System.Drawing.Size(74, 21);
            this.check_Python.TabIndex = 2;
            this.check_Python.Text = "Python";
            this.check_Python.UseVisualStyleBackColor = true;
            // 
            // check_java
            // 
            this.check_java.AutoSize = true;
            this.check_java.Location = new System.Drawing.Point(55, 70);
            this.check_java.Name = "check_java";
            this.check_java.Size = new System.Drawing.Size(60, 21);
            this.check_java.TabIndex = 1;
            this.check_java.Text = "Java";
            this.check_java.UseVisualStyleBackColor = true;
            // 
            // check_Cs
            // 
            this.check_Cs.AutoSize = true;
            this.check_Cs.Location = new System.Drawing.Point(55, 23);
            this.check_Cs.Name = "check_Cs";
            this.check_Cs.Size = new System.Drawing.Size(47, 21);
            this.check_Cs.TabIndex = 0;
            this.check_Cs.Text = "C#";
            this.check_Cs.UseVisualStyleBackColor = true;
            // 
            // bt_submit
            // 
            this.bt_submit.BackColor = System.Drawing.Color.Aqua;
            this.bt_submit.Location = new System.Drawing.Point(615, 459);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(109, 42);
            this.bt_submit.TabIndex = 4;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = false;
            this.bt_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 527);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.list_city);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox list_city;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_other;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.CheckBox check_Python;
        private System.Windows.Forms.CheckBox check_java;
        private System.Windows.Forms.CheckBox check_Cs;
    }
}

