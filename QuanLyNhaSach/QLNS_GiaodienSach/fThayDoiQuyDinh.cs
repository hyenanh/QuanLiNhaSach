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
    public partial class fThayDoiQuyDinh : Form
    {
        public fThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void fThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            HienThiQuyDinhCu();
        }

        private void HienThiQuyDinhCu()
        {
            string queryLayQuyDinh = "Select * from QUYDINH";
            DataTable dtQuyDinhCu = DataProvider.Instance.ExcuteQuery(queryLayQuyDinh);
            txbSoLuongNhapItNhat.Text = dtQuyDinhCu.Rows[0]["SoLuongNhapToiThieu"] + "";
            txbLuongTonToiThieu.Text = dtQuyDinhCu.Rows[0]["SoLuongTonItNhatSauBan"] + "";
            txbSoLuongTonToiDa.Text = dtQuyDinhCu.Rows[0]["SoLuongTonToiDa"]+"";
            txbTienNoToiDa.Text = dtQuyDinhCu.Rows[0]["TienNoToiDa"] + "";
            if (Convert.ToInt32(dtQuyDinhCu.Rows[0]["DuocThuVuotQuaSoTienKhachDangNoHayKo"]) == 0)
                cbSuDungQuyDinh.Checked = false;
            else cbSuDungQuyDinh.Checked = true;


        }
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            try
            {
                int KiemTra;
                if (cbSuDungQuyDinh.Checked)
                    KiemTra = 1;
                else KiemTra = 0;
                //double TienNoToiDa=Convert.ToDouble(txbTienNoToiDa.Text);

                DateTime NgayThayDoi = dtpThayDoiQuyDinh.Value;
                string queryThayDoiQuyDinh = "UPDATE QUYDINH " +
                                            "SET SoLuongNhapToiThieu=" + int.Parse(txbSoLuongNhapItNhat.Text)
                                            + ", SoLuongTonItNhatSauBan=" + int.Parse(txbLuongTonToiThieu.Text)
                                            + ", SoLuongTonToiDa=" + int.Parse(txbSoLuongTonToiDa.Text)
                                            + ", TienNoToiDa=" + Convert.ToDouble(txbTienNoToiDa.Text)
                                            + ", DuocThuVuotQuaSoTienKhachDangNoHayKo=" + KiemTra
                                            + ", NgayCapNhat='" + NgayThayDoi.ToString("yyyy-MM-dd") + "'";
                int kqCapNhat = DataProvider.Instance.ExcuteNonQuery(queryThayDoiQuyDinh);
                if (kqCapNhat > 0)
                    MessageBox.Show("Thay đổi quy định thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
