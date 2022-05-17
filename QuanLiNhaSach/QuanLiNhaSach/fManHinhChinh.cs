using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach
{
    public partial class fManHinhChinh : Form
    {
        public fManHinhChinh()
        {
            InitializeComponent();
        }

 
        private void fManHinhChinh_Load(object sender, EventArgs e)
        {

        }


        // 1. Mở màn hình Thêm người dùng mới
        private void ThemNguoiDungMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*fThemNguoiDung f = new fThemNguoiDung();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        // 2 Mở màn hình Thông tin tài khoản
        private void ThongTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
       /*     fThongTInTaiKhoan f = new fThongTinTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        // 3 đăng xuất khỏi tài khoản hiện tại
        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản hiện tại?", "" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // 4 mở màn hình nhập sách
        private void NhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapSach f = new fNhapSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        // 5 mở màn hình chỉnh sửa sách
        private void ChinhSuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*fChinhSua f = new fChinhSua();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        //6 Mở màn hình Thể Loại
        private void TheLoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTheLoai f = new fTheLoai();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        // 6 Mở màn hình Hoá đơn
        private void HoaDonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*fHoaDon f = new fHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        // 7 Mở màn hình Phiếu thu tiền
        private void PhieuThuTienToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* fPhieuThuTien f = new fPhieuThuTien();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        // 8 Mở màn hình Khách hàng
        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* fKhachHang f = new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        // 9 Mở màn hình bcao công nợ
        private void BaoCaoCongNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* fBaoCaoCongNo f = new fBaoCaoCongNo();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        // 10 Mở màn hình bcao Tồn
        private void BaoCaoTonToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*  fBaoCaoTon f = new fBaoCaoTon();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        // 11 Mở màn hình thay đổi quy định
        private void ThayDoiQuyDinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*fThayDoiQuyDinh f = new fThayDoiQuyDinh();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

   
    }
}
