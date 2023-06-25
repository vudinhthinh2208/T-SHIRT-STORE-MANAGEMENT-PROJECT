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

namespace _3.BUS.View.Frm_NhanVien
{
    public partial class FrmChucVu : Form
    {
        private IQLchucVuServices qLchucVuServices;
        public chucVu _chucVu;
        public FrmChucVu()
        {
            _chucVu = new chucVu();
            InitializeComponent();
            qLchucVuServices = new QLchucVuServices();
            Load();
        }
        public void Load()
        {
            dgrid_Show.Rows.Clear();
            dgrid_Show.ColumnCount = 2;
            dgrid_Show.Columns[0].Name = "Mã chức vụ";
            dgrid_Show.Columns[1].Name = "Tên chức vụ";
            foreach (var item in qLchucVuServices.GetchucVuFromDB())
            {
                dgrid_Show.Rows.Add(item.IDChucVu, item.tenCV);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (tbt_Ten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (dialogResult == DialogResult.Yes)
            {
                chucVu chucVu = new chucVu();
                {
                    chucVu.tenCV = tbt_Ten.Text;
                }
                qLchucVuServices.addChucVu(chucVu);
                Load();
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thêm");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_chucVu == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
            }
            else
            {
                if (_chucVu.tenCV == tbt_Ten.Text || (_chucVu.tenCV != tbt_Ten.Text && qLchucVuServices.GetchucVuFromDB().FirstOrDefault(x => x.tenCV == tbt_Ten.Text) == null))
                {
                    _chucVu.tenCV = tbt_Ten.Text;
                    qLchucVuServices.UpdateChucVu(_chucVu);
                    MessageBox.Show("Cập nhật thành công");
                    Load();
                    tbt_Ten.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên chức vụ đã tồn tại");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgrid_Show.Rows[e.RowIndex];
                _chucVu = qLchucVuServices.GetchucVuFromDB().FirstOrDefault(x => x.IDChucVu == Convert.ToInt32(row.Cells[0].Value));
                tbt_Ten.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
