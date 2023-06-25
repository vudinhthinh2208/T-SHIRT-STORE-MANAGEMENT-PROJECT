using _3.BUS.View.Frm_NhanVien;
using _3.GUI.View;
using _3.GUI.View.BanHang;
using _3.GUI.View.FromSanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.BUS.View.ALL
{
    public partial class MenuNV : Form
    {
        public MenuNV()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panel_sanpham.Visible = false;
            panel_thongtin.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panel_sanpham.Visible == true)
                panel_sanpham.Visible = false;
            if (panel_thongtin.Visible == true)
                panel_thongtin.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_sanpham);
        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_thongtin);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmGioHang());
            hideSubMenu();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmHoaDonn());
            hideSubMenu();
        }

        private void btn_spct_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmSanPhamChiTiet());
            hideSubMenu();
        }

        private void btn_aophong_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmSanPham());
            hideSubMenu();
        }

        private void btn_mausac_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMauSac());
            hideSubMenu();
        }

        private void btn_size_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmSize());
            hideSubMenu();
        }

        private void btn_nsx_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmNhaSX());
            hideSubMenu();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmKhachHang());
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông Báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng xuất thành công");
            }
        }
    }
}
