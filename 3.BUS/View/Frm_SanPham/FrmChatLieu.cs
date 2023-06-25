using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.BUS.View.Frm_SanPham
{
    public partial class FrmChatLieu : Form
    {
        private IQLchatLieuServices _QLchatLieuServices;
        public chatLieu _chatlieu;
        public FrmChatLieu()
        {
            InitializeComponent();
            _QLchatLieuServices = new QLchatLieuServices();
            _chatlieu = new chatLieu();
            loadData();
        }
        public void loadData()
        {
            dtgv_ChatLieu.Rows.Clear();
            foreach (var item in _QLchatLieuServices.GetchatLieuFromDB())
            {
                dtgv_ChatLieu.Rows.Add(item.IDChatlieu, item.ChatLieu,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            chatLieu chatlieus = _QLchatLieuServices.GetchatLieuFromDB().FirstOrDefault
              (p => p.ChatLieu == tbt_chatlieu.Text);
            if (tbt_chatlieu.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (chatlieus != null)
            {
                MessageBox.Show("Chất liệu đã tồn tại");
                tbt_chatlieu.Text = "";
            }
            else
            {
                chatLieu addchatlieu = new chatLieu()
                {
                    ChatLieu = tbt_chatlieu.Text,
                    trangThai = rb_HoatDong.Checked,
                };
                _QLchatLieuServices.addchatLieu(addchatlieu);
                MessageBox.Show("Thêm thành công");
                loadData();
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            if (_chatlieu == null)
            {
                MessageBox.Show("Vui lòng chọn chát liệu");
            }
            else
            {
                if (_chatlieu.ChatLieu == tbt_chatlieu.Text || (_chatlieu.ChatLieu != tbt_chatlieu.Text && _QLchatLieuServices.GetchatLieuFromDB().FirstOrDefault(x => x.ChatLieu == tbt_chatlieu.Text) == null))
                {
                    _chatlieu.ChatLieu = tbt_chatlieu.Text;
                    _chatlieu.trangThai = rb_HoatDong.Checked;
                    _QLchatLieuServices.UpdatechatLieu(_chatlieu);
                    MessageBox.Show("Cập nhật thành công");
                    loadData();
                    tbt_chatlieu.Text = "";
                }
                else
                {
                    MessageBox.Show("Chất liệu đã tồn tại");
                }
            }
        }

        private void dtgv_ChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_ChatLieu.Rows[e.RowIndex];
                _chatlieu = _QLchatLieuServices.GetchatLieuFromDB().FirstOrDefault(x => x.IDChatlieu == Convert.ToInt32(row.Cells[0].Value));
                tbt_chatlieu.Text = row.Cells[1].Value.ToString();
                rb_HoatDong.Checked = row.Cells[2].Value.ToString() == "Còn hàng" ? true : false;
                rb_KHD.Checked = row.Cells[2].Value.ToString() == "Hết hàng" ? true : false;
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            tbt_chatlieu.Text = null;
        }

        private void dtgv_ChatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
