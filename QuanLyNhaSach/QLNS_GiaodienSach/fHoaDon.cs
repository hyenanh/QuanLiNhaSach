using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLNS_GiaodienSach.DAO;
namespace QLNS_GiaodienSach
{
    public partial class fHoaDon : Form
    {
        public fHoaDon()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlConn = "Data Source=LAPTOP-3PESOL36\\SQLEXPRESS;Database=QUAN_LI_NHA_SACH;Integrated Security=SSPI";
        SqlDataAdapter adapter;
        DataSet ds_sach = null;
        DataSet ds_HD = null;
        DataSet ds_CTHD = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiThongTinSACH();
            //HienThiThongTinCTHD();
            HienThiThongTinHD();
        }
        private void HienThiThongTinSACH()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            adapter = new SqlDataAdapter("select*from SACH", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            ds_sach = new DataSet();
            adapter.Fill(ds_sach, "SACH");

            dgvSach.DataSource = ds_sach.Tables["SACH"];
        }
        private void HienThiThongTinCTHD(string MaHD)
        {
            
            adapter = new SqlDataAdapter("select*from CT_HD where MaHD='"+MaHD+"'", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            ds_CTHD = new DataSet();
            adapter.Fill(ds_CTHD, "CTHD");

            dgvChiTietHD.DataSource = ds_CTHD.Tables["CTHD"];
        }
        private void HienThiThongTinHD()
        {
            
            adapter = new SqlDataAdapter("select*from HOA_DON", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            ds_HD = new DataSet();
            adapter.Fill(ds_HD, "HOADON");

            dgvDanhSachHD.DataSource = ds_HD.Tables["HOADON"];
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string queryTimKiem = "Select * from SACH where TenSach like N'%" + txtTenSach.Text + "%'";
            dt = DataProvider.Instance.ExcuteQuery(queryTimKiem);
            dgvSach.DataSource = dt;
        }

        string MaSach = "";
        int vt = -1;
        private void dgvSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = ds_sach.Tables["SACH"].Rows[vt];
            MaSach = row["MaSach"] + "";
            //MessageBox.Show(MaSach);
        }
        int total = 0;
        private void btnChonSL_Click_1(object sender, EventArgs e)
        {
            try
            {
                // mỗi lần chọn sẽ thêm 1 chi tiết hóa đơn của hóa đơn
                
                //mã hóa đơn tự tạo bằng cách đếm số hd trong bảng HD
                //Masach lấy từ dgv sach, số lượng lấy từ ô só lượng
                
                string MaHD = "";
                int stt = ds_HD.Tables["HOADON"].Rows.Count + 1;
                if (stt < 10)
                {
                    MaHD = "HD0" + stt;
                }
                else
                {
                    MaHD= "HD" + stt;
                }

                string query = "insert into CT_HD(MaHD,MaSach,SoLuongMua) values ('"+MaHD+"','"+MaSach+"'," + nUDSoLuong.Value + ")";
                string queryLayDonGiaSach = "SELECT DonGiaBan FROM SACH WHERE MASACH='" + MaSach + "'";
                int dongiaban = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(queryLayDonGiaSach));
                int kq1 = 0;
                if (nUDSoLuong.Value != 0)
                {
                    kq1 = DataProvider.Instance.ExcuteNonQuery(query);
                }
                if (kq1 > 0)
                {
                    total += int.Parse(nUDSoLuong.Value.ToString()) * dongiaban;
                    txtTongTien.Text= total.ToString();
                    HienThiThongTinCTHD(MaHD);
                    MessageBox.Show("Thêm chi tiết hóa đơn của hóa đơn thành công");
                }
                else
                {
                    MessageBox.Show("Chưa chọn số lượng");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Nhập lỗi");
            }
        }

        private void btnHoanThanhHoaDon_Click_1(object sender, EventArgs e)
        {
            try
            {
                //mỗi lần nhấn hoàn thành hóa đơn thì sẽ insert 1 hóa đơn
                string MaHD = "";
                int stt = ds_HD.Tables["HOADON"].Rows.Count + 1;
                if (stt < 10)
                {
                    MaHD = "HD0" + stt;
                }
                else
                {
                    MaHD = "HD" + stt;
                }
                DateTime NgayLap=dtpNgayLap.Value;
                string query = "insert into HOA_DON(MaHD,MaKH,NgayLapHoaDon,SoTienTra,MaTK) values ('" + MaHD + "','" + txtMaKH.Text +
                    "','" + NgayLap.ToString("yyyy-MM-dd") + "'," + int.Parse(txtSotienthu.Text) + ",'" + PhanQuyen.MaTK + "')";
                int kq = DataProvider.Instance.ExcuteNonQuery(query);
                if (kq > 0)
                {
                    HienThiThongTinHD();
                    HienThiThongTinSACH();
                    MessageBox.Show("Thêm hóa đơn thành công");
                    ThemMoiVaCapNhatCTHD(MaHD);
                    txtMaKH.Text = "";
                    txtSotienthu.Text = "";
                    txtTongTien.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string TaoMaTonKho()
        {
            DataTable dtTonKho = new DataTable();
            string queryLayDongTonKho = "SELECT * FROM BC_TONKHO";
            dtTonKho = DataProvider.Instance.ExcuteQuery(queryLayDongTonKho);
            string MaTK = "";
            int stt = dtTonKho.Rows.Count + 1;
            if (stt < 10)
            {
                MaTK = "TKh0" + stt;
            }
            else
            {
                MaTK = "TKh" + stt;
            }
            return MaTK;
        }

        private void ThemMoiVaCapNhatCTHD(string MaHD)
        {
            //Kiem tra va insert BCTONKHO
            //Lay ra tháng của phiếu vừa thêm vào csdl
            string queryLayThangNam = "SELECT MONTH(NgayLapHoaDon), YEAR(NgayLapHoaDon) FROM" +
                                     " HOA_DON WHERE MaHD='" + MaHD + "'";
            DataTable dtThangNam = new DataTable();
            dtThangNam = DataProvider.Instance.ExcuteQuery(queryLayThangNam);

            int thang = (int)dtThangNam.Rows[0][0];
            int nam = (int)dtThangNam.Rows[0][1];
            //Kiểm tra xem tháng năm có tồn tại trong bảng BCTONKHO chưa
            string queryLayThangNamBaoCaoTK = "SELECT Thang, nam FROM BC_TONKHO WHERE Thang=" + thang + " and nam=" + nam;
            DataTable dtCheckThangNam = DataProvider.Instance.ExcuteQuery(queryLayThangNamBaoCaoTK);

            if (dtCheckThangNam.Rows.Count == 0)//Neu thang nam chua co thi insert
            {
                string MaTonKho = TaoMaTonKho();
                string queryInsertBAOCAO_CN = "INSERT INTO BC_TONKHO (MaTonKho, Thang, nam) " +
                                            "VALUES ('" + MaTonKho + "', " + thang + ", " + nam + ")";
                DataProvider.Instance.ExcuteNonQuery(queryInsertBAOCAO_CN);
            }
            //Lay maTK trong thang moi nhat
            string querylayMATK = " SELECT MaTonKho from BC_TONKHO where Thang IN (SELECT max(Thang) FROM BC_TONKHO) and nam IN(SELECT max(nam) FROM BC_TONKHO) ";
            string MATK = (string)DataProvider.Instance.ExcuteScalar(querylayMATK);

            // thêm va update CT_BCCN cho tung MaSach
            //-Lay cac ma sach tu hoa don và duyet
            string queryLayNhieuMaSach_QuaMaHD = "SELECT MaSach, SoLuongMua FROM CT_HD " +
                                                    "WHERE MaHD='" + MaHD+"'";
            DataTable dtMaSach= DataProvider.Instance.ExcuteQuery(queryLayNhieuMaSach_QuaMaHD);
            for(int i = 0; i < dtMaSach.Rows.Count; i++)
            {
                string queryMaSach = "SELECT MaSach FROM CT_BCTONKHO WHERE MaTonKho='" + MATK +"' AND MaSach='" + dtMaSach.Rows[i][0]+"'" ;
                string dt = (string)DataProvider.Instance.ExcuteScalar(queryMaSach);

                if (dt == null)
                {
                    string queryinsert = "insert into CT_BCTONKHO(MaTonKho,MaSach) values ('" + MATK + "','" + dtMaSach.Rows[i][0] + "')";

                    DataProvider.Instance.ExcuteNonQuery(queryinsert);
                }
                else
                {
                    string queryupdate = "update CT_BCTONKHO" +
                        " set TonCuoi=TonCuoi-" + dtMaSach.Rows[i][1]
                        + " where MaTonKho='" + MATK + "' and MaSach='" + dtMaSach.Rows[i][0] + "'";
                    DataProvider.Instance.ExcuteNonQuery(queryupdate);
                }
            }
        }

        //int chon = -1;
        private void dgvDanhSachHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*chon = e.RowIndex;
            if (chon == -1) return;
            DataRow r = ds_HD.Tables["HOADON"].Rows[chon];
            txtMaKH.Text = r["MaKH"] + "";
            txtMaTK.Text = r["MaTK"] + "";
            dtpNgayLap.Text = r["NgayLapHoaDon"] + "";
            txtSotienthu.Text = r["SoTienTra"] + "";*/
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            string queryTimKiemKH = "SELECT HoTen FROM KHACH_HANG WHERE MAKH='" + txtMaKH.Text + "'";
            lbTenKH.Text = (string)DataProvider.Instance.ExcuteScalar(queryTimKiemKH);

        }

        private void btnXemKhachHang_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
