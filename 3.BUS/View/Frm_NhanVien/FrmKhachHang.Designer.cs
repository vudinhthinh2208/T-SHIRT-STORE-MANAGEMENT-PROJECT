namespace _3.BUS.View.Frm_NhanVien
{
    partial class FrmKhachHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbt_Search = new System.Windows.Forms.TextBox();
            this.dgrid_Show = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_gt = new System.Windows.Forms.ComboBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_diem = new System.Windows.Forms.TextBox();
            this.rd_khd = new System.Windows.Forms.RadioButton();
            this.rd_hd = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Show)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbt_Search);
            this.panel2.Controls.Add(this.dgrid_Show);
            this.panel2.Location = new System.Drawing.Point(335, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 695);
            this.panel2.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Tìm kiếm theo tên khách hàng";
            // 
            // tbt_Search
            // 
            this.tbt_Search.Location = new System.Drawing.Point(453, 10);
            this.tbt_Search.Name = "tbt_Search";
            this.tbt_Search.Size = new System.Drawing.Size(633, 27);
            this.tbt_Search.TabIndex = 46;
            this.tbt_Search.TextChanged += new System.EventHandler(this.tbt_Search_TextChanged);
            // 
            // dgrid_Show
            // 
            this.dgrid_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Show.Location = new System.Drawing.Point(14, 40);
            this.dgrid_Show.Name = "dgrid_Show";
            this.dgrid_Show.RowHeadersWidth = 51;
            this.dgrid_Show.RowTemplate.Height = 29;
            this.dgrid_Show.Size = new System.Drawing.Size(1072, 641);
            this.dgrid_Show.TabIndex = 0;
            this.dgrid_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbb_gt);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.tb_diem);
            this.panel1.Controls.Add(this.rd_khd);
            this.panel1.Controls.Add(this.rd_hd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.tb_ten);
            this.panel1.Controls.Add(this.tb_diachi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 695);
            this.panel1.TabIndex = 33;
            // 
            // cbb_gt
            // 
            this.cbb_gt.FormattingEnabled = true;
            this.cbb_gt.Location = new System.Drawing.Point(129, 287);
            this.cbb_gt.Name = "cbb_gt";
            this.cbb_gt.Size = new System.Drawing.Size(177, 28);
            this.cbb_gt.TabIndex = 46;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(93, 627);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(138, 54);
            this.btn_Sua.TabIndex = 45;
            this.btn_Sua.Text = "Sửa khách hàng";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(93, 559);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(138, 55);
            this.btn_Add.TabIndex = 44;
            this.btn_Add.Text = "Thêm khách hàng";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_diem
            // 
            this.tb_diem.Location = new System.Drawing.Point(129, 484);
            this.tb_diem.Name = "tb_diem";
            this.tb_diem.Size = new System.Drawing.Size(177, 27);
            this.tb_diem.TabIndex = 42;
            // 
            // rd_khd
            // 
            this.rd_khd.AutoSize = true;
            this.rd_khd.Location = new System.Drawing.Point(129, 407);
            this.rd_khd.Name = "rd_khd";
            this.rd_khd.Size = new System.Drawing.Size(146, 24);
            this.rd_khd.TabIndex = 37;
            this.rd_khd.TabStop = true;
            this.rd_khd.Text = "Không hoạt động";
            this.rd_khd.UseVisualStyleBackColor = true;
            // 
            // rd_hd
            // 
            this.rd_hd.AutoSize = true;
            this.rd_hd.Location = new System.Drawing.Point(129, 377);
            this.rd_hd.Name = "rd_hd";
            this.rd_hd.Size = new System.Drawing.Size(102, 24);
            this.rd_hd.TabIndex = 36;
            this.rd_hd.TabStop = true;
            this.rd_hd.Text = "Hoạt động";
            this.rd_hd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Điểm";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(129, 195);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(177, 27);
            this.tb_sdt.TabIndex = 20;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(129, 14);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(177, 27);
            this.tb_ten.TabIndex = 19;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(129, 106);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(177, 27);
            this.tb_diachi.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "SDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên khách hàng";
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Show)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label7;
        private TextBox tbt_Search;
        private DataGridView dgrid_Show;
        private Panel panel1;
        private Button btn_Sua;
        private Button btn_Add;
        private TextBox tb_diem;
        private RadioButton rd_khd;
        private RadioButton rd_hd;
        private Label label6;
        private Label label5;
        private TextBox tb_sdt;
        private TextBox tb_ten;
        private TextBox tb_diachi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbb_gt;
    }
}