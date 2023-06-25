using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.GUI.Utilities;

namespace _3.BUS.View.Frm_NhanVien
{
    public partial class FrmKhachHang : Form
    {
        private IQLkhachHangServices _QLkhachHangServices;
        private IQLhoaDonServices _qlhoadon;
        private khachHang _khachHang;
        string sdt = "";
        public FrmKhachHang()
        {
            InitializeComponent();
            _QLkhachHangServices = new QLkhachHangServices();
            _khachHang = new khachHang();
            _qlhoadon = new QLhoaDonServices();
            loaddata();
            loadgt();
            rd_khd.Checked = true;
        }
        private void loadgt()
        {
            cbb_gt.Items.Clear();
            cbb_gt.Items.Add("Nam");
            cbb_gt.Items.Add("Nữ");
            cbb_gt.SelectedIndex = 0;

        }
        private void loaddata()
        {
            dgrid_Show.ColumnCount = 6;
            dgrid_Show.Columns[0].Name = "Số Điện Thoại";
            dgrid_Show.Columns[1].Name = "Tên Khách Hàng";
            dgrid_Show.Columns[2].Name = "Giới Tính";
            dgrid_Show.Columns[3].Name = "Địa Chỉ";
            dgrid_Show.Columns[4].Name = "Điểm tích lũy";
            dgrid_Show.Columns[5].Name = "Trạng thái";
            dgrid_Show.Rows.Clear();
            foreach (var item in _QLkhachHangServices.GetkhachHangFromDB())
            {
                dgrid_Show.Rows.Add(item.SDT_KH, item.TenKH, item.gioiTinh == true ? "Nam" : "Nữ", item.diaChi, item.diem,item.trangThai == true ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void tbt_Search_TextChanged(object sender, EventArgs e)
        {
            dgrid_Show.ColumnCount = 6;
            dgrid_Show.Columns[0].Name = "Số Điện Thoại";
            dgrid_Show.Columns[1].Name = "Tên Khách Hàng";
            dgrid_Show.Columns[2].Name = "Giới Tính";
            dgrid_Show.Columns[3].Name = "Địa Chỉ";
            dgrid_Show.Columns[4].Name = "Điểm tích lũy";
            dgrid_Show.Columns[5].Name = "Trạng thái";
            dgrid_Show.Rows.Clear();
            foreach (var item in _QLkhachHangServices.GetkhachHangFromDB().Where(x => x.TenKH.ToLower().Contains(tbt_Search.Text.ToLower()) || x.SDT_KH.Contains(tbt_Search.Text)))
            {
                dgrid_Show.Rows.Add(item.SDT_KH, item.TenKH, item.gioiTinh == true ? "Nam" : "Nữ", item.diaChi, item.diem, item.trangThai == true ? "Hoạt động" : "Không hoạt động");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            khachHang accKH = _QLkhachHangServices.GetkhachHangFromDB().FirstOrDefault
              (p => p.SDT_KH == tb_sdt.Text);
            if (tb_sdt.Text.Trim() == "" || tb_diachi.Text.Trim() == "" || tb_ten.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (accKH != null)
            {
                MessageBox.Show("Số điện thoại khách hàng đã tồn tại");
                tb_sdt.Text = "";
            }
            else if (ValidateInput.CheckSDT(tb_sdt.Text) == false)
            {
                MessageBox.Show("Bạn phải nhập đúng SĐT");
            }
            else
            {
                khachHang addKH = new khachHang()
                {
                    SDT_KH = tb_sdt.Text,
                    TenKH = tb_ten.Text,
                    diaChi = tb_diachi.Text,
                    gioiTinh = cbb_gt.SelectedIndex == 1 ? true : false,
                    trangThai = rd_hd.Checked == true ? true : false,
                    diem = 0,
                };
                _QLkhachHangServices.addkhachHang(addKH);
                MessageBox.Show("Thêm khách hàng thành công");
                loaddata();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var update = _QLkhachHangServices.GetkhachHangFromDB().FirstOrDefault(p => p.SDT_KH == tb_sdt.Text);
            if (tb_ten.Text.Trim() == "" || tb_diachi.Text.Trim() == "" || tb_sdt.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (update.SDT_KH == "0123456789")
            {
                MessageBox.Show("Không được sửa khách hàng này");
            }
            else if (update == null)
            {
                MessageBox.Show("Số điện thoại khách hàng không tồn tại");
                tb_sdt.Text = "";
            }
            else
            {
                update.TenKH = tb_ten.Text;
                update.SDT_KH = tb_sdt.Text;
                update.diaChi = tb_diachi.Text;
                update.gioiTinh = cbb_gt.SelectedIndex == 1 ? true : false;
                update.trangThai=rd_hd.Checked == true ? true : false;
                _QLkhachHangServices.UpdateKhachHang(update);
                MessageBox.Show("Cập nhật khách hàng thành công");
                loaddata();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && dgrid_Show.Rows[e.RowIndex].Cells[0].Value != null)
            {
            DataGridViewRow row = dgrid_Show.Rows[e.RowIndex];
            tb_sdt.Text = row.Cells[0].Value.ToString();
            tb_ten.Text = row.Cells[1].Value.ToString();
            cbb_gt.SelectedIndex = row.Cells[2].Value.ToString() == "Nam" ? 1 : 0;
            tb_diachi.Text = row.Cells[3].Value.ToString();
            rd_hd.Checked = row.Cells[5].Value.ToString() == "Hoạt động";
            rd_khd.Checked = row.Cells[5].Value.ToString() == "Không hoạt động";
            }
        }
    }
}
