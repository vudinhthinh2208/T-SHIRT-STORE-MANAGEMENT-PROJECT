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
using _2.BUS.ViewModel;
using _3.GUI.Utilities;

namespace _3.BUS.View.Frm_NhanVien
{
    public partial class FrmNhanVien : Form
    {
        private IQLnhanVienServices _IqLnhanVienServices;
        private IQLchucVuServices _IQLchucVuServices;
        public nhanVien _NhanVien;
        private int _maclick;
        private List<ViewHienThi1> lstNv;
        public FrmNhanVien()
        {
            _IqLnhanVienServices = new QLnhanVienServices();
            _IQLchucVuServices = new QLchucVuServices();
            InitializeComponent();
            rd_hd.Checked = false;
            loadcbb();
            lstNv = new List<ViewHienThi1>();
            loadDuLieu();
        }
        public void loadDuLieu()
        {
            dgrid_Show.Rows.Clear();
            dgrid_Show.ColumnCount = 8;
            dgrid_Show.Columns[0].Name = "Mã nhân viên";
            dgrid_Show.Columns[1].Name = "Tên nhân viên";
            dgrid_Show.Columns[2].Name = "Địa chỉ";
            dgrid_Show.Columns[3].Name = "Số điện thoại";
            dgrid_Show.Columns[4].Name = "Email";
            dgrid_Show.Columns[5].Name = "Mật khẩu";
            dgrid_Show.Columns[6].Name = "Tình trạng";
            dgrid_Show.Columns[7].Name = "Chức vụ";
            
            foreach (var item in _IqLnhanVienServices.GetNhanVienFromDB())
            {
                dgrid_Show.Rows.Add(item.nhanViens.IDNhanVien, item.nhanViens.TenNV, item.nhanViens.diaChi, item.nhanViens.SDT, item.nhanViens.email, item.nhanViens.matKhau, item.nhanViens.tinhTrang == true ? "Hoạt động" : "Không hoạt động", item.chucVus.tenCV);
            }
            
        }
        
        public void loadcbb()
        {
            var cv = _IQLchucVuServices.GetchucVuFromDB();
            foreach (var item in cv)
            {
                cbb_cv.Items.Add(item.tenCV);
            }
            cbb_cv.SelectedIndex = 0;
        }
        private ViewHienThi1 GetData()
        {
            ViewHienThi1 nhan = new ViewHienThi1();
            nhan.nhanViens = new nhanVien();
            {
                nhan.nhanViens.IDNhanVien = _maclick;
                nhan.nhanViens.TenNV = tb_ten.Text;
                nhan.nhanViens.SDT = tb_sdt.Text;
                nhan.nhanViens.email = tb_email.Text;
                nhan.nhanViens.IDChucVu = _IQLchucVuServices.GetchucVuFromDB()[cbb_cv.SelectedIndex].IDChucVu;
                nhan.nhanViens.diaChi = tb_diachi.Text;
                nhan.nhanViens.matKhau = tb_matkhau.Text;
                nhan.nhanViens.tinhTrang = rd_hd.Checked == true ? true : false; ;

            }
            return nhan;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double s1;
            bool checksdt = double.TryParse(tb_sdt.Text, out s1);
            DialogResult dialogResult = MessageBox.Show("bạn có muốn thêm không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (ValidateInput.CheckSDT(tb_sdt.Text) == false)
            {
                MessageBox.Show("Bạn phải nhập đúng số điện thoại");
            }
            else if (_IqLnhanVienServices.GetNhanVienFromDB().Any(p => p.nhanViens.SDT == tb_sdt.Text))
            {
                MessageBox.Show("SĐT này đã bị trùng");
            }
            else if (ValidateInput.IsEmail(tb_email.Text) == false)
            {
                MessageBox.Show("Nhập đúng email");
            }
            else if (_IqLnhanVienServices.GetNhanVienFromDB().Any(c => c.nhanViens.email == tb_email.Text))
            {
                MessageBox.Show("Email đã bị trùng");
            }
            else if (rd_hd.Checked == false && rd_khd.Checked == false)
            {
                MessageBox.Show("Không được để trống trạng thái");
            }
            else if (string.IsNullOrWhiteSpace(tb_ten.Text))
            {
                MessageBox.Show("Không đước để trống tên");
            }
            else if (string.IsNullOrWhiteSpace(tb_diachi.Text))
            {
                MessageBox.Show("Không được để trống địa chỉ");
            }
            else if (string.IsNullOrWhiteSpace(tb_email.Text))
            {
                MessageBox.Show("Không được để trống email");
            }
            else if (string.IsNullOrWhiteSpace(tb_matkhau.Text))
            {
                MessageBox.Show("Không được để trống mật khẩu");
            }
            else if (string.IsNullOrWhiteSpace(tb_email.Text))
            {
                MessageBox.Show("Không được để trống email");
            }
            else if (string.IsNullOrWhiteSpace(cbb_cv.Text))
            {
                MessageBox.Show("Không được để trống chức vụ");
            }
            else if (dialogResult == DialogResult.Yes)
            {

                nhanVien nhan = new nhanVien();
                {
                    nhan.TenNV = tb_ten.Text;
                    nhan.SDT = tb_sdt.Text;
                    nhan.email = tb_email.Text;
                    nhan.IDChucVu = _IQLchucVuServices.GetchucVuFromDB()[cbb_cv.SelectedIndex].IDChucVu;
                    nhan.diaChi = tb_diachi.Text;
                    nhan.matKhau = tb_matkhau.Text;
                    nhan.tinhTrang = rd_hd.Checked == true ? true : false;

                }
                MessageBox.Show(_IqLnhanVienServices.addNhanVien(GetData()));
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("bạn đã hủy thêm");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có muốn sửa không ? ", "cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var x = GetData();
                x.nhanViens.IDNhanVien = _maclick;
                MessageBox.Show(_IqLnhanVienServices.UpdateNhanVien(x));
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("bạn đã hủy sửa");
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            dgrid_Show.Rows.Clear();
            dgrid_Show.ColumnCount = 8;
            dgrid_Show.Columns[0].Name = "Mã nhân viên";
            dgrid_Show.Columns[1].Name = "Tên nhân viên";
            dgrid_Show.Columns[2].Name = "Địa chỉ";
            dgrid_Show.Columns[3].Name = "Số điện thoại";
            dgrid_Show.Columns[4].Name = "Email";
            dgrid_Show.Columns[5].Name = "Mật khẩu";
            dgrid_Show.Columns[6].Name = "Tình trạng";
            dgrid_Show.Columns[7].Name = "Chức vụ";
            foreach (var item in _IqLnhanVienServices.GetNhanVienFromDB().Where(x => x.nhanViens.TenNV.ToLower().Contains(tb_Search.Text.ToLower()) || x.nhanViens.SDT.Contains(tb_Search.Text)))
            {
                dgrid_Show.Rows.Add(item.nhanViens.IDNhanVien, item.nhanViens.TenNV, item.nhanViens.diaChi, item.nhanViens.SDT, item.nhanViens.email, item.nhanViens.matKhau, item.nhanViens.tinhTrang == true ? "Hoạt động" : "Không hoạt động", item.chucVus.tenCV);
            }
        }

        private void dgrid_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgrid_Show.Rows[e.RowIndex].Cells[0].Value != null)
            {
                _maclick = Convert.ToInt32(dgrid_Show.CurrentRow.Cells[0].Value.ToString());
                //tb_manv.Text = dtg_show.CurrentRow.Cells[0].Value.ToString();
                tb_ten.Text = dgrid_Show.CurrentRow.Cells[1].Value.ToString();
                tb_diachi.Text = dgrid_Show.CurrentRow.Cells[2].Value.ToString();
                tb_sdt.Text = dgrid_Show.CurrentRow.Cells[3].Value.ToString();
                tb_email.Text = dgrid_Show.CurrentRow.Cells[4].Value.ToString();
                tb_matkhau.Text = dgrid_Show.CurrentRow.Cells[5].Value.ToString();
                //if(dtg_show.CurrentRow.Cells[6].Value.ToString() == "Hoạt dộng")
                //{

                //}
                rd_hd.Checked = dgrid_Show.CurrentRow.Cells[6].Value.ToString() == "Hoạt động" ? true : false;
                rd_khd.Checked = dgrid_Show.CurrentRow.Cells[6].Value.ToString() == "Không hoạt động" ? true : false;
                cbb_cv.Text = dgrid_Show.CurrentRow.Cells[7].Value.ToString();
            }
        }
    }
}
