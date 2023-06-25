namespace _3.BUS.View.Frm_NhanVien
{
    partial class FrmChucVu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbt_Ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgrid_Show = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbt_Ten);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 104);
            this.panel1.TabIndex = 0;
            // 
            // tbt_Ten
            // 
            this.tbt_Ten.Location = new System.Drawing.Point(108, 39);
            this.tbt_Ten.Name = "tbt_Ten";
            this.tbt_Ten.Size = new System.Drawing.Size(238, 27);
            this.tbt_Ten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chức vụ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Location = new System.Drawing.Point(380, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 104);
            this.panel2.TabIndex = 1;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(25, 61);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(150, 29);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "Sửa chức vụ";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(25, 15);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 29);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm chức vụ";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrid_Show);
            this.panel3.Location = new System.Drawing.Point(12, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 239);
            this.panel3.TabIndex = 2;
            // 
            // dgrid_Show
            // 
            this.dgrid_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Show.Location = new System.Drawing.Point(16, 13);
            this.dgrid_Show.Name = "dgrid_Show";
            this.dgrid_Show.RowHeadersWidth = 51;
            this.dgrid_Show.RowTemplate.Height = 29;
            this.dgrid_Show.Size = new System.Drawing.Size(527, 212);
            this.dgrid_Show.TabIndex = 0;
            this.dgrid_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 370);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChucVu";
            this.Text = "FrmChucVu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btn_Edit;
        private Button btn_Add;
        private Panel panel3;
        private DataGridView dgrid_Show;
        private TextBox tbt_Ten;
    }
}