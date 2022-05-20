using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_GiaodienSach
{
    public partial class fManHinhChinh : Form
    {
        public fManHinhChinh()
        {
            InitializeComponent();
        }

        private void ChinhSuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDuLieuSach f = new fDuLieuSach();
            this.Hide();
            f.ShowDialog();//Xu ly xong Showdialog mới tới các hiển thị khác
            this.Show();
/*            f.MdiParent = this;
            f.Show();*/
        }

        private void fManHinhChinh_Load(object sender, EventArgs e)
        {

        }

        private void ThemNguoiDungMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemTaiKhoan f=new fThemTaiKhoan();
            this.Hide();
            f.ShowDialog();//Xu ly xong Showdialog mới tới các hiển thị khác
            this.Show();
        }

        private void ThongTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTaiKhoan f=new fTaiKhoan();
            this.Hide();
            f.ShowDialog();//Xu ly xong Showdialog mới tới các hiển thị khác
            this.Show();
        }

        private void NhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhieuNhapSach f=new fPhieuNhapSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void TheLoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTheLoai f=new fTheLoai();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHoaDon f = new fHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void phiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhieuThuTien f=new fPhieuThuTien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhachHang f=new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ThayDoiQuyDinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThayDoiQuyDinh f = new fThayDoiQuyDinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BaoCaoCongNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXemBaoCaoCongNo f=new fXemBaoCaoCongNo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BaoCaoTonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXemBaoCaoTon f=new fXemBaoCaoTon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
