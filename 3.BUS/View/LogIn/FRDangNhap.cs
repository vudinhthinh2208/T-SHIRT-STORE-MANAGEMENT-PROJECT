using _2.BUS.IServices;
using _2.BUS.Services;
using _3.BUS.View.ALL;
using _3.GUI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _3.BUS.View.LogIn
{
    public partial class FRDangNhap : Form
    {
        IQLnhanVienServices _sv;
        public FRDangNhap()
        {
            _sv = new QLnhanVienServices();
            InitializeComponent();
            this.CenterToScreen();
        }
        public void Check()
        {
            var Acc = _sv.GetNhanVienFromDB().ToList();

            if (tb_user.Text.Trim() == "" || tb_pass.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền tài khoản mật khẩu");
            }
            else
            {
                for (int i = 0; i < Acc.Count; i++)
                {
                    if (tb_user.Text == Acc[i].nhanViens.email && tb_pass.Text == Acc[i].nhanViens.matKhau && Acc[i].nhanViens.IDChucVu == 1)
                    {
                        MessageBox.Show("Chào mừng quản lý");

                        MenuQL f = new MenuQL();
                        f.ShowDialog();
                        return;
                    }
                    else if (tb_user.Text == Acc[i].nhanViens.email && tb_pass.Text == Acc[i].nhanViens.matKhau && Acc[i].nhanViens.IDChucVu == 2)
                    {
                        MessageBox.Show("Xin chào nhân viên");
                        MenuNV f1 = new MenuNV();
                        f1.ShowDialog();
                        return;
                    }
                }
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác");
            }
        }

        private void chk_remmember_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_user.Text != "" || tb_pass.Text != "")
            {
                if (chk_remmember.Checked == true)
                {
                    string user = tb_user.Text;
                    string pass = tb_pass.Text;
                    Properties.Settings.Default.tk = user;
                    Properties.Settings.Default.mk = pass;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void chk_hienpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienpass.Checked == true)
            {
                tb_pass.PasswordChar = '\0';
            }
            else
            {
                tb_pass.PasswordChar = '*';
            }
        }

        private void FRDangNhap_Load(object sender, EventArgs e)
        {
            tb_user.Text = Properties.Settings.Default.tk;
            tb_pass.Text = Properties.Settings.Default.mk;
            if (Properties.Settings.Default.tk != "")
            {
                chk_remmember.Checked = true;
            }
        }
    }
}
