/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLNS_GiaodienSach.DAO;*/

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
using System.Data.SqlClient;

namespace QLNS_GiaodienSach
{
    public partial class fPhieuThuTien : Form
    {
        public fPhieuThuTien()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;//cong tac ket noi
        string sqlConn = "Data Source=LAPTOP-3PESOL36\\SQLEXPRESS;Database=QUAN_LY_NHA_SACH;Integrated Security=SSPI";//thoong tin de ket noi
        SqlDataAdapter adapter;// cai nay de lay dl tu csdl
        DataSet ds = null;//cai nay de chua du lieu lay dc
        private void fPhieuThuTien_Load_1(object sender, EventArgs e)
        {
            HienThiThongTinKH();
        }
        private void HienThiThongTinKH()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            adapter = new SqlDataAdapter("select*from khach_hang", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            ds = new DataSet();
            adapter.Fill(ds, "KhachHang");

            
            dgvHienThiThongTinKH.DataSource = ds.Tables["KhachHang"];
        }
        int vt = -1;
        string MaKH = "";
       

        private void btnTroVe_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        DataTable dt = new DataTable();
        private void btnTim_Click_1(object sender, EventArgs e)
        {
            string queryTimKiem = "Select * from KHACH_HANG where SDT like N'%" + txtTimKiem.Text + "%'";
            dt = DataProvider.Instance.ExcuteQuery(queryTimKiem);
            dgvHienThiThongTinKH.DataSource = dt;
        }

        public string TaoMaCongNo()
        {
            DataTable dtCongNo = new DataTable();
            string queryLayDongCongNo = "SELECT * FROM BC_CONGNO";
            dtCongNo = DataProvider.Instance.ExcuteQuery(queryLayDongCongNo);
            string MaCN = "";
            int stt = dtCongNo.Rows.Count + 1;
            if (stt < 10)
            {
                MaCN = "CN0" + stt;
            }
            else
            {
                MaCN = "CN" + stt;
            }
            return MaCN;
        }

        private void btnThemPhieu_Click_1(object sender, EventArgs e)
        {
            try
            {
                //ma phieu thu se dc tu tinh= "PT"+so ptu trong csdl +1
                // minh muon lay MaKH tu dgv .ngaythu , sotienthu,matk lay tu txt
                //lấy cấu trúc hàng(Bang phiếu thu) để chứa dữ liệu mới, sau đó mới add lại vô csdl
                
                DataTable phieuthu = new DataTable();
                adapter = new SqlDataAdapter("select*from PHIEU_THU_TIEN", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Fill(phieuthu);
                DataRow row = phieuthu.NewRow();
                int stt = phieuthu.Rows.Count + 1;
                if (stt < 10)
                {
                    row["MaPT"] = "PT0" + stt;
                }
                else
                {
                    row["MaPT"] = "PT" + stt;
                }
                DateTime NgayThuTien = dtpNgayThuTien.Value;
                row["MaKH"] = MaKH;
                MaKH = "";
                row["NgayThuTien"] = NgayThuTien.ToString("yyyy-MM-dd");
                row["SoTienThu"] = txtSoTienThu.Text;
                row["MaTk"] = PhanQuyen.MaTK;

                phieuthu.Rows.Add(row);

                int kq = adapter.Update(phieuthu);

                if (kq > 0)
                {
                    HienThiThongTinKH();
                    MessageBox.Show("thêm phiếu thu thành công");
                    //Kiem tra va insert BCCN
                    //Lay ra tháng của phiếu vừa thêm vào csdl
                    string queryLayThangNam = "SELECT MONTH(NgayThuTien), YEAR(NgayThuTien) FROM" +
                                             " PHIEU_THU_TIEN WHERE MaPT='" + row["MaPT"] + "'";
                    DataTable dtThangNam=new DataTable();
                    dtThangNam=DataProvider.Instance.ExcuteQuery(queryLayThangNam);
                    
                    int thang= (int)dtThangNam.Rows[0][0]; 
                    int nam= (int)dtThangNam.Rows[0][1];
                    //Kiểm tra xem tháng năm có tồn tại trong bảng BCCN chưa
                    string queryLayThangNamBaoCaoCN = "SELECT Thang, nam FROM BC_CONGNO WHERE Thang=" + thang + " and nam=" + nam;
                    DataTable dtCheckThangNam=DataProvider.Instance.ExcuteQuery(queryLayThangNamBaoCaoCN);

                    if (dtCheckThangNam.Rows.Count ==0)//Neu thang nam chua co thi insert
                    {
                        string MaCN = TaoMaCongNo();
                        string queryInsertBAOCAO_CN = "INSERT INTO BC_CONGNO (MaCongNo, Thang, nam) " +
                                                    "VALUES ('" + MaCN+ "', " + thang + ", " + nam+")";
                        DataProvider.Instance.ExcuteNonQuery(queryInsertBAOCAO_CN);
                    }
                    //Lay maCN trong thang moi nhat
                    string querylayMACN = " SELECT MaCongNo from BC_CONGNO where Thang IN (SELECT max(Thang) FROM BC_CONGNO) and nam IN(SELECT max(nam) FROM BC_CONGNO) ";
                    string MACN= (string)DataProvider.Instance.ExcuteScalar(querylayMACN);
                    // thêm va update CT_BCCN
                    string queryMaKH_trong_1BCCN = "SELECT MaKH FROM CT_BCCONGNO WHERE MaCongNo='" + MACN + "' and MaKH='" + row["MaKH"]+"'";
                    string dt = (string)DataProvider.Instance.ExcuteScalar(queryMaKH_trong_1BCCN);

                    if (dt == null)
                    {
                        string queryinsert = "insert into CT_BCCONGNO(MaCongNo,MaKH) values ('" + MACN + "','" + row["MaKH"] + "')";

                        DataProvider.Instance.ExcuteNonQuery(queryinsert);
                    }
                    else
                    {
                        string queryupdate = "update CT_BCCONGNO" +
                            " set NoCuoi=NoCuoi-" + row["SoTienThu"]
                            + "where MACongNo='" + MACN + "' and MaKH='" + row["MaKH"]+"'";
                        DataProvider.Instance.ExcuteNonQuery(queryupdate);

                    }

                    
                }
                else
                {
                    MessageBox.Show("thêm phiếu thu thất bại");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"lỗi nhập liệu");
            }


        }

        private void dgvHienThiThongTinKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            //muốn lấy cái dòng vt để trích ra MaKH,mà dòng này nó ở trog bảng khachhang nên tìm tới bảng đó
            DataRow row = ds.Tables["KhachHang"].Rows[vt];
            MaKH = row["MaKH"] + "";
        }
    }
}
