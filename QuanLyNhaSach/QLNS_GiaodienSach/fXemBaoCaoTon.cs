using QLNS_GiaodienSach.DAO;
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
    public partial class fXemBaoCaoTon : Form
    {
        public fXemBaoCaoTon()
        {
            InitializeComponent();
        }
        private void fXemBaoCaoTon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTon();
        }

        private void HienThiDanhSachTon()
        {
            string queryLayDSTK = "SELECT Thang, Nam, MaSach, TonDau, TonCuoi, PhatSinh " +
                                "FROM CT_BCTONKHO CT, BC_TONKHO BC " +
                                "WHERE CT.MaTonKho=BC.MaTonKho AND THANG <> 1";
            DataTable dtDanhSachTK = DataProvider.Instance.ExcuteQuery(queryLayDSTK);
            dgvDanhSachTon.DataSource = dtDanhSachTK;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int Thang = dtpThoiGian.Value.Month;
            int Nam = dtpThoiGian.Value.Year;
            string queryLayDSCNquaThangNam = "SELECT Thang, Nam, MaSach, TonDau, TonCuoi, PhatSinh " +
                                "FROM CT_BCTONKHO CT, BC_TONKHO BC " +
                                "WHERE CT.MaTonKho=BC.MaTonKho AND Thang=" + Thang + " AND Nam=" + Nam;
            DataTable dtDanhSachCN = DataProvider.Instance.ExcuteQuery(queryLayDSCNquaThangNam);
            dgvDanhSachTon.DataSource = dtDanhSachCN;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
