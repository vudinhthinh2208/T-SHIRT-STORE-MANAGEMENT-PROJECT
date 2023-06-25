namespace _3.GUI.View
{
    partial class FrmThongKe
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbb_nam = new System.Windows.Forms.ComboBox();
            this.cbb_thang = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_ngay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.dtgv_show = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_chuathanhtoan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_tonghd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_doanhthu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_show)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_sdt);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(878, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(463, 82);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thống kê theo sđt khách hàng";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(198, 39);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(196, 27);
            this.tb_sdt.TabIndex = 6;
            this.tb_sdt.TextChanged += new System.EventHandler(this.tb_sdt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số điện thoại khách hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbb_nam);
            this.groupBox3.Controls.Add(this.cbb_thang);
            this.groupBox3.Location = new System.Drawing.Point(435, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 82);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê theo tháng, năm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Năm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tháng";
            // 
            // cbb_nam
            // 
            this.cbb_nam.FormattingEnabled = true;
            this.cbb_nam.Location = new System.Drawing.Point(285, 48);
            this.cbb_nam.Name = "cbb_nam";
            this.cbb_nam.Size = new System.Drawing.Size(89, 28);
            this.cbb_nam.TabIndex = 1;
            this.cbb_nam.TextChanged += new System.EventHandler(this.cbb_nam_TextChanged);
            // 
            // cbb_thang
            // 
            this.cbb_thang.FormattingEnabled = true;
            this.cbb_thang.Location = new System.Drawing.Point(91, 48);
            this.cbb_thang.Name = "cbb_thang";
            this.cbb_thang.Size = new System.Drawing.Size(85, 28);
            this.cbb_thang.TabIndex = 0;
            this.cbb_thang.TextChanged += new System.EventHandler(this.cbb_thang_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_ngay);
            this.groupBox2.Location = new System.Drawing.Point(39, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 82);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê theo ngày";
            // 
            // dtp_ngay
            // 
            this.dtp_ngay.CustomFormat = "dd-MM-yyyy";
            this.dtp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay.Location = new System.Drawing.Point(18, 44);
            this.dtp_ngay.Name = "dtp_ngay";
            this.dtp_ngay.Size = new System.Drawing.Size(309, 27);
            this.dtp_ngay.TabIndex = 0;
            this.dtp_ngay.ValueChanged += new System.EventHandler(this.dtp_ngay_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xuat);
            this.groupBox1.Controls.Add(this.dtgv_show);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 351);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1384, 314);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàng hóa";
            // 
            // btn_xuat
            // 
            this.btn_xuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xuat.Location = new System.Drawing.Point(925, 27);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(198, 49);
            this.btn_xuat.TabIndex = 7;
            this.btn_xuat.Text = "Xuất Excel";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // dtgv_show
            // 
            this.dtgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_show.Location = new System.Drawing.Point(3, 82);
            this.dtgv_show.Name = "dtgv_show";
            this.dtgv_show.RowHeadersWidth = 51;
            this.dtgv_show.RowTemplate.Height = 29;
            this.dtgv_show.Size = new System.Drawing.Size(1378, 228);
            this.dtgv_show.TabIndex = 5;
            this.dtgv_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_show_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGreen;
            this.panel4.Controls.Add(this.lb_chuathanhtoan);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(958, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 113);
            this.panel4.TabIndex = 8;
            // 
            // lb_chuathanhtoan
            // 
            this.lb_chuathanhtoan.AutoSize = true;
            this.lb_chuathanhtoan.Location = new System.Drawing.Point(130, 76);
            this.lb_chuathanhtoan.Name = "lb_chuathanhtoan";
            this.lb_chuathanhtoan.Size = new System.Drawing.Size(17, 20);
            this.lb_chuathanhtoan.TabIndex = 3;
            this.lb_chuathanhtoan.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số hóa đơn chưa thanh toán";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGreen;
            this.panel3.Controls.Add(this.lb_tonghd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(572, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 113);
            this.panel3.TabIndex = 9;
            // 
            // lb_tonghd
            // 
            this.lb_tonghd.AutoSize = true;
            this.lb_tonghd.Location = new System.Drawing.Point(92, 76);
            this.lb_tonghd.Name = "lb_tonghd";
            this.lb_tonghd.Size = new System.Drawing.Size(17, 20);
            this.lb_tonghd.TabIndex = 2;
            this.lb_tonghd.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng số hóa đơn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lb_doanhthu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(129, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 113);
            this.panel2.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "VNĐ";
            // 
            // lb_doanhthu
            // 
            this.lb_doanhthu.AutoSize = true;
            this.lb_doanhthu.Location = new System.Drawing.Point(68, 76);
            this.lb_doanhthu.Name = "lb_doanhthu";
            this.lb_doanhthu.Size = new System.Drawing.Size(17, 20);
            this.lb_doanhthu.TabIndex = 1;
            this.lb_doanhthu.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doanh thu";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1384, 665);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmThongKe";
            this.Text = "FrmSanPham";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_show)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox4;
        private TextBox tb_sdt;
        private Label label7;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private ComboBox cbb_nam;
        private ComboBox cbb_thang;
        private GroupBox groupBox2;
        private DateTimePicker dtp_ngay;
        private GroupBox groupBox1;
        private DataGridView dtgv_show;
        private Panel panel4;
        private Label lb_chuathanhtoan;
        private Label label4;
        private Panel panel3;
        private Label lb_tonghd;
        private Label label3;
        private Panel panel2;
        private Label label10;
        private Label lb_doanhthu;
        private Label label2;
        private Button btn_xuat;
    }
}