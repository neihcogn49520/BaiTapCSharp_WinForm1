
namespace BT1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Khoaitc = new System.Windows.Forms.Button();
            this.bt_Cam = new System.Windows.Forms.Button();
            this.bt_Lipton = new System.Windows.Forms.Button();
            this.bt_Coca = new System.Windows.Forms.Button();
            this.bt_Cafe = new System.Windows.Forms.Button();
            this.bt_7up = new System.Windows.Forms.Button();
            this.bt_Pepsi = new System.Windows.Forms.Button();
            this.bt_ComGa = new System.Windows.Forms.Button();
            this.bt_GaRan = new System.Windows.Forms.Button();
            this.bt_GaCola = new System.Windows.Forms.Button();
            this.bt_TomCola = new System.Windows.Forms.Button();
            this.bt_bgCa = new System.Windows.Forms.Button();
            this.bt_bgTom = new System.Windows.Forms.Button();
            this.bt_bgGa = new System.Windows.Forms.Button();
            this.bt_bgBo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Tenban = new System.Windows.Forms.ComboBox();
            this.bt_Order = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fastfoodDataSet = new BT1.fastfoodDataSet();
            this.ffoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ffoodTableAdapter = new BT1.fastfoodDataSetTableAdapters.ffoodTableAdapter();
            this.mónĂnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốLượngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastfoodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ffoodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(208, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fastfood Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Khoaitc);
            this.groupBox1.Controls.Add(this.bt_Cam);
            this.groupBox1.Controls.Add(this.bt_Lipton);
            this.groupBox1.Controls.Add(this.bt_Coca);
            this.groupBox1.Controls.Add(this.bt_Cafe);
            this.groupBox1.Controls.Add(this.bt_7up);
            this.groupBox1.Controls.Add(this.bt_Pepsi);
            this.groupBox1.Controls.Add(this.bt_ComGa);
            this.groupBox1.Controls.Add(this.bt_GaRan);
            this.groupBox1.Controls.Add(this.bt_GaCola);
            this.groupBox1.Controls.Add(this.bt_TomCola);
            this.groupBox1.Controls.Add(this.bt_bgCa);
            this.groupBox1.Controls.Add(this.bt_bgTom);
            this.groupBox1.Controls.Add(this.bt_bgGa);
            this.groupBox1.Controls.Add(this.bt_bgBo);
            this.groupBox1.Location = new System.Drawing.Point(44, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục món ăn";
            // 
            // bt_Khoaitc
            // 
            this.bt_Khoaitc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Khoaitc.ForeColor = System.Drawing.Color.LimeGreen;
            this.bt_Khoaitc.Location = new System.Drawing.Point(313, 133);
            this.bt_Khoaitc.Name = "bt_Khoaitc";
            this.bt_Khoaitc.Size = new System.Drawing.Size(159, 31);
            this.bt_Khoaitc.TabIndex = 14;
            this.bt_Khoaitc.Text = "Khoai tây chiên";
            this.bt_Khoaitc.UseVisualStyleBackColor = true;
            this.bt_Khoaitc.Click += new System.EventHandler(this.bt_Khoaitc_Click);
            // 
            // bt_Cam
            // 
            this.bt_Cam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cam.ForeColor = System.Drawing.Color.Red;
            this.bt_Cam.Location = new System.Drawing.Point(396, 96);
            this.bt_Cam.Name = "bt_Cam";
            this.bt_Cam.Size = new System.Drawing.Size(76, 31);
            this.bt_Cam.TabIndex = 13;
            this.bt_Cam.Text = "Cam";
            this.bt_Cam.UseVisualStyleBackColor = true;
            this.bt_Cam.Click += new System.EventHandler(this.bt_Cam_Click);
            // 
            // bt_Lipton
            // 
            this.bt_Lipton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Lipton.ForeColor = System.Drawing.Color.Red;
            this.bt_Lipton.Location = new System.Drawing.Point(396, 59);
            this.bt_Lipton.Name = "bt_Lipton";
            this.bt_Lipton.Size = new System.Drawing.Size(76, 31);
            this.bt_Lipton.TabIndex = 12;
            this.bt_Lipton.Text = "Lipton";
            this.bt_Lipton.UseVisualStyleBackColor = true;
            this.bt_Lipton.Click += new System.EventHandler(this.bt_Lipton_Click);
            // 
            // bt_Coca
            // 
            this.bt_Coca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Coca.ForeColor = System.Drawing.Color.Red;
            this.bt_Coca.Location = new System.Drawing.Point(396, 22);
            this.bt_Coca.Name = "bt_Coca";
            this.bt_Coca.Size = new System.Drawing.Size(76, 31);
            this.bt_Coca.TabIndex = 11;
            this.bt_Coca.Text = "Coca";
            this.bt_Coca.UseVisualStyleBackColor = true;
            this.bt_Coca.Click += new System.EventHandler(this.bt_Coca_Click);
            // 
            // bt_Cafe
            // 
            this.bt_Cafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cafe.ForeColor = System.Drawing.Color.Red;
            this.bt_Cafe.Location = new System.Drawing.Point(314, 96);
            this.bt_Cafe.Name = "bt_Cafe";
            this.bt_Cafe.Size = new System.Drawing.Size(76, 31);
            this.bt_Cafe.TabIndex = 10;
            this.bt_Cafe.Text = "Cafe";
            this.bt_Cafe.UseVisualStyleBackColor = true;
            this.bt_Cafe.Click += new System.EventHandler(this.bt_Cafe_Click);
            // 
            // bt_7up
            // 
            this.bt_7up.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_7up.ForeColor = System.Drawing.Color.Red;
            this.bt_7up.Location = new System.Drawing.Point(314, 59);
            this.bt_7up.Name = "bt_7up";
            this.bt_7up.Size = new System.Drawing.Size(76, 31);
            this.bt_7up.TabIndex = 9;
            this.bt_7up.Text = "7 up";
            this.bt_7up.UseVisualStyleBackColor = true;
            this.bt_7up.Click += new System.EventHandler(this.bt_7up_Click);
            // 
            // bt_Pepsi
            // 
            this.bt_Pepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Pepsi.ForeColor = System.Drawing.Color.Red;
            this.bt_Pepsi.Location = new System.Drawing.Point(314, 22);
            this.bt_Pepsi.Name = "bt_Pepsi";
            this.bt_Pepsi.Size = new System.Drawing.Size(76, 31);
            this.bt_Pepsi.TabIndex = 8;
            this.bt_Pepsi.Text = "Pepsi";
            this.bt_Pepsi.UseVisualStyleBackColor = true;
            this.bt_Pepsi.Click += new System.EventHandler(this.bt_Pepsi_Click);
            // 
            // bt_ComGa
            // 
            this.bt_ComGa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_ComGa.Location = new System.Drawing.Point(162, 133);
            this.bt_ComGa.Name = "bt_ComGa";
            this.bt_ComGa.Size = new System.Drawing.Size(145, 31);
            this.bt_ComGa.TabIndex = 7;
            this.bt_ComGa.Text = "Cơm Gà Tender";
            this.bt_ComGa.UseVisualStyleBackColor = true;
            this.bt_ComGa.Click += new System.EventHandler(this.bt_ComGa_Click);
            // 
            // bt_GaRan
            // 
            this.bt_GaRan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_GaRan.Location = new System.Drawing.Point(162, 96);
            this.bt_GaRan.Name = "bt_GaRan";
            this.bt_GaRan.Size = new System.Drawing.Size(145, 31);
            this.bt_GaRan.TabIndex = 6;
            this.bt_GaRan.Text = "Gà rán phần";
            this.bt_GaRan.UseVisualStyleBackColor = true;
            this.bt_GaRan.Click += new System.EventHandler(this.bt_GaRan_Click);
            // 
            // bt_GaCola
            // 
            this.bt_GaCola.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_GaCola.Location = new System.Drawing.Point(162, 59);
            this.bt_GaCola.Name = "bt_GaCola";
            this.bt_GaCola.Size = new System.Drawing.Size(145, 31);
            this.bt_GaCola.TabIndex = 5;
            this.bt_GaCola.Text = "Gà viên Cola";
            this.bt_GaCola.UseVisualStyleBackColor = true;
            this.bt_GaCola.Click += new System.EventHandler(this.bt_GaCola_Click);
            // 
            // bt_TomCola
            // 
            this.bt_TomCola.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_TomCola.Location = new System.Drawing.Point(162, 22);
            this.bt_TomCola.Name = "bt_TomCola";
            this.bt_TomCola.Size = new System.Drawing.Size(145, 31);
            this.bt_TomCola.TabIndex = 4;
            this.bt_TomCola.Text = "Tôm viên Cola";
            this.bt_TomCola.UseVisualStyleBackColor = true;
            this.bt_TomCola.Click += new System.EventHandler(this.bt_TomCola_Click);
            // 
            // bt_bgCa
            // 
            this.bt_bgCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_bgCa.Location = new System.Drawing.Point(7, 133);
            this.bt_bgCa.Name = "bt_bgCa";
            this.bt_bgCa.Size = new System.Drawing.Size(148, 31);
            this.bt_bgCa.TabIndex = 3;
            this.bt_bgCa.Text = "Burger Phô mai Cá";
            this.bt_bgCa.UseVisualStyleBackColor = true;
            this.bt_bgCa.Click += new System.EventHandler(this.bt_bgCa_Click);
            // 
            // bt_bgTom
            // 
            this.bt_bgTom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_bgTom.Location = new System.Drawing.Point(7, 96);
            this.bt_bgTom.Name = "bt_bgTom";
            this.bt_bgTom.Size = new System.Drawing.Size(148, 31);
            this.bt_bgTom.TabIndex = 2;
            this.bt_bgTom.Text = "Burger Phô mai Tôm";
            this.bt_bgTom.UseVisualStyleBackColor = true;
            this.bt_bgTom.Click += new System.EventHandler(this.bt_bgTom_Click);
            // 
            // bt_bgGa
            // 
            this.bt_bgGa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_bgGa.Location = new System.Drawing.Point(7, 59);
            this.bt_bgGa.Name = "bt_bgGa";
            this.bt_bgGa.Size = new System.Drawing.Size(148, 31);
            this.bt_bgGa.TabIndex = 1;
            this.bt_bgGa.Text = "Burger Phô mai Gà";
            this.bt_bgGa.UseVisualStyleBackColor = true;
            this.bt_bgGa.Click += new System.EventHandler(this.bt_bgGa_Click);
            // 
            // bt_bgBo
            // 
            this.bt_bgBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_bgBo.Location = new System.Drawing.Point(7, 22);
            this.bt_bgBo.Name = "bt_bgBo";
            this.bt_bgBo.Size = new System.Drawing.Size(148, 31);
            this.bt_bgBo.TabIndex = 0;
            this.bt_bgBo.Text = "Burger Phô mai Bò";
            this.bt_bgBo.UseVisualStyleBackColor = true;
            this.bt_bgBo.Click += new System.EventHandler(this.bt_bgBo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên bàn";
            // 
            // cb_Tenban
            // 
            this.cb_Tenban.FormattingEnabled = true;
            this.cb_Tenban.Items.AddRange(new object[] {
            "B01",
            "B02",
            "B03",
            "B04",
            "B05",
            "B06",
            "B07",
            "B08",
            "B09",
            "B10"});
            this.cb_Tenban.Location = new System.Drawing.Point(245, 375);
            this.cb_Tenban.Name = "cb_Tenban";
            this.cb_Tenban.Size = new System.Drawing.Size(179, 24);
            this.cb_Tenban.TabIndex = 5;
            // 
            // bt_Order
            // 
            this.bt_Order.Image = global::BT1.Properties.Resources.Order_icon;
            this.bt_Order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Order.Location = new System.Drawing.Point(448, 368);
            this.bt_Order.Name = "bt_Order";
            this.bt_Order.Size = new System.Drawing.Size(100, 35);
            this.bt_Order.TabIndex = 6;
            this.bt_Order.Text = "Order";
            this.bt_Order.UseVisualStyleBackColor = true;
            this.bt_Order.Click += new System.EventHandler(this.bt_Order_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Image = global::BT1.Properties.Resources.del_page;
            this.bt_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Xoa.Location = new System.Drawing.Point(27, 368);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(114, 35);
            this.bt_Xoa.TabIndex = 3;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // picture1
            // 
            this.picture1.Image = global::BT1.Properties.Resources.page_pin;
            this.picture1.Location = new System.Drawing.Point(13, 13);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(186, 167);
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mónĂnDataGridViewTextBoxColumn,
            this.sốLượngDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ffoodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 424);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(521, 269);
            this.dataGridView1.TabIndex = 7;
            // 
            // fastfoodDataSet
            // 
            this.fastfoodDataSet.DataSetName = "fastfoodDataSet";
            this.fastfoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ffoodBindingSource
            // 
            this.ffoodBindingSource.DataMember = "ffood";
            this.ffoodBindingSource.DataSource = this.fastfoodDataSet;
            // 
            // ffoodTableAdapter
            // 
            this.ffoodTableAdapter.ClearBeforeFill = true;
            // 
            // mónĂnDataGridViewTextBoxColumn
            // 
            this.mónĂnDataGridViewTextBoxColumn.DataPropertyName = "Món ăn";
            this.mónĂnDataGridViewTextBoxColumn.HeaderText = "Món ăn";
            this.mónĂnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mónĂnDataGridViewTextBoxColumn.Name = "mónĂnDataGridViewTextBoxColumn";
            this.mónĂnDataGridViewTextBoxColumn.Width = 125;
            // 
            // sốLượngDataGridViewTextBoxColumn
            // 
            this.sốLượngDataGridViewTextBoxColumn.DataPropertyName = "Số lượng";
            this.sốLượngDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sốLượngDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sốLượngDataGridViewTextBoxColumn.Name = "sốLượngDataGridViewTextBoxColumn";
            this.sốLượngDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 705);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Order);
            this.Controls.Add(this.cb_Tenban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastfoodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ffoodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Khoaitc;
        private System.Windows.Forms.Button bt_Cam;
        private System.Windows.Forms.Button bt_Lipton;
        private System.Windows.Forms.Button bt_Coca;
        private System.Windows.Forms.Button bt_Cafe;
        private System.Windows.Forms.Button bt_7up;
        private System.Windows.Forms.Button bt_Pepsi;
        private System.Windows.Forms.Button bt_ComGa;
        private System.Windows.Forms.Button bt_GaRan;
        private System.Windows.Forms.Button bt_GaCola;
        private System.Windows.Forms.Button bt_TomCola;
        private System.Windows.Forms.Button bt_bgCa;
        private System.Windows.Forms.Button bt_bgTom;
        private System.Windows.Forms.Button bt_bgGa;
        private System.Windows.Forms.Button bt_bgBo;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Tenban;
        private System.Windows.Forms.Button bt_Order;
        private System.Windows.Forms.DataGridView dataGridView1;
        private fastfoodDataSet fastfoodDataSet;
        private System.Windows.Forms.BindingSource ffoodBindingSource;
        private fastfoodDataSetTableAdapters.ffoodTableAdapter ffoodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mónĂnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốLượngDataGridViewTextBoxColumn;
    }
}

