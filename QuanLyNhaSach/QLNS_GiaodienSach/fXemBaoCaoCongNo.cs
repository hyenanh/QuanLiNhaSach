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
    public partial class fXemBaoCaoCongNo : Form
    {
        public fXemBaoCaoCongNo()
        {
            InitializeComponent();
        }

        private void fXemBaoCaoCongNo_Load(object sender, EventArgs e)
        {
            HienThiDanhSachCongNo();
        }

        private void HienThiDanhSachCongNo()
        {
            string queryLayDSCN = "SELECT Thang, Nam, MaKH, NoDau, NoCuoi, PhatSinh " +
                                "FROM CT_BCCONGNO CT, BC_CONGNO BC " +
                                "WHERE CT.MaCongNo=BC.MaCongNo AND THANG <> 1";
            DataTable dtDanhSachCN = DataProvider.Instance.ExcuteQuery(queryLayDSCN);
            dgvDanhSachCongNo.DataSource= dtDanhSachCN;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int Thang = dtpThoiGian.Value.Month;
            int Nam = dtpThoiGian.Value.Year;
            string queryLayDSCNquaThangNam = "SELECT Thang, Nam, MaKH, NoDau, NoCuoi, PhatSinh " +
                                "FROM CT_BCCONGNO CT, BC_CONGNO BC " +
                                "WHERE CT.MaCongNo=BC.MaCongNo AND Thang=" + Thang + " AND Nam=" + Nam;
            DataTable dtDanhSachCN = DataProvider.Instance.ExcuteQuery(queryLayDSCNquaThangNam);
            dgvDanhSachCongNo.DataSource = dtDanhSachCN;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
