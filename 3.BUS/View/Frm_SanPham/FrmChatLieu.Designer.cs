namespace _3.BUS.View.Frm_SanPham
{
    partial class FrmChatLieu
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
            this.rb_KHD = new System.Windows.Forms.RadioButton();
            this.rb_HoatDong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbt_chatlieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgv_ChatLieu = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btb_CapNhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChatLieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_KHD);
            this.groupBox1.Controls.Add(this.rb_HoatDong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbt_chatlieu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 200);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chất Liệu";
            // 
            // rb_KHD
            // 
            this.rb_KHD.AutoSize = true;
            this.rb_KHD.Location = new System.Drawing.Point(379, 131);
            this.rb_KHD.Name = "rb_KHD";
            this.rb_KHD.Size = new System.Drawing.Size(91, 24);
            this.rb_KHD.TabIndex = 6;
            this.rb_KHD.TabStop = true;
            this.rb_KHD.Text = "Hết hàng";
            this.rb_KHD.UseVisualStyleBackColor = true;
            // 
            // rb_HoatDong
            // 
            this.rb_HoatDong.AutoSize = true;
            this.rb_HoatDong.Location = new System.Drawing.Point(259, 131);
            this.rb_HoatDong.Name = "rb_HoatDong";
            this.rb_HoatDong.Size = new System.Drawing.Size(93, 24);
            this.rb_HoatDong.TabIndex = 5;
            this.rb_HoatDong.TabStop = true;
            this.rb_HoatDong.Text = "Còn hàng";
            this.rb_HoatDong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trạng thái";
            // 
            // tbt_chatlieu
            // 
            this.tbt_chatlieu.Location = new System.Drawing.Point(259, 67);
            this.tbt_chatlieu.Name = "tbt_chatlieu";
            this.tbt_chatlieu.Size = new System.Drawing.Size(211, 27);
            this.tbt_chatlieu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chất Liệu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_ChatLieu);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(933, 331);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng Chất Liệu";
            // 
            // dtgv_ChatLieu
            // 
            this.dtgv_ChatLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ChatLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgv_ChatLieu.Location = new System.Drawing.Point(3, 37);
            this.dtgv_ChatLieu.Name = "dtgv_ChatLieu";
            this.dtgv_ChatLieu.RowHeadersWidth = 51;
            this.dtgv_ChatLieu.RowTemplate.Height = 29;
            this.dtgv_ChatLieu.Size = new System.Drawing.Size(927, 291);
            this.dtgv_ChatLieu.TabIndex = 0;
            this.dtgv_ChatLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ChatLieu_CellClick);
            this.dtgv_ChatLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ChatLieu_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Chất Liệu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Chất Liệu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tình trạng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_lamMoi);
            this.groupBox2.Controls.Add(this.btb_CapNhat);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(526, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 200);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(3, 137);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(401, 55);
            this.btn_lamMoi.TabIndex = 2;
            this.btn_lamMoi.Text = "Clear";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btb_CapNhat
            // 
            this.btb_CapNhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btb_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btb_CapNhat.Location = new System.Drawing.Point(3, 82);
            this.btb_CapNhat.Name = "btb_CapNhat";
            this.btb_CapNhat.Size = new System.Drawing.Size(401, 55);
            this.btb_CapNhat.TabIndex = 1;
            this.btb_CapNhat.Text = "Cập nhật";
            this.btb_CapNhat.UseVisualStyleBackColor = true;
            this.btb_CapNhat.Click += new System.EventHandler(this.btb_CapNhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(3, 23);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(401, 59);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // FrmChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmChatLieu";
            this.Text = "FrmChatLieu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChatLieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rb_KHD;
        private RadioButton rb_HoatDong;
        private Label label3;
        private TextBox tbt_chatlieu;
        private Label label2;
        private GroupBox groupBox3;
        private DataGridView dtgv_ChatLieu;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox groupBox2;
        private Button btn_lamMoi;
        private Button btb_CapNhat;
        private Button btn_them;
    }
}