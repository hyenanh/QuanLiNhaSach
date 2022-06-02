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
    public partial class fPhieuNhapSach : Form
    {
        public fPhieuNhapSach()
        {
            InitializeComponent();
            LoadPhieuDaNhap();
            LoadCT_PNS();
            LoadCbbTenSach();
            createMaPhieuNhap(txbMaPhieu);
                       
        }
        // load bảng phiếu đã nhập
        private void LoadPhieuDaNhap()
        {
            string query_HienThiDSPhieuNhap = "select MaPhieuNhap 'Mã Phiếu Nhập' , NgayTaoPhieu 'Ngày Tạo Phiếu'" +
                                                "from   PHIEU_NHAP_SACH";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery(query_HienThiDSPhieuNhap);
            dgvPhieuNhap.DataSource = dt;
        }

        // load phiếu đang nhập
        private void LoadCT_PNS()
        {
            string query_HienThiCT_PNS = "select TenSach 'Tên Sách'  , DonGiaNhap 'Đơn Giá Nhập'  , SoLuong 'Số Lượng'  " +
                                   "from  CT_PNS A , SACH B " +
                                   "where A.MaPhieuNhap = '" + txbMaPhieu.Text + "'" +
                                   "and     B.MaSach = A.MaSach";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery(query_HienThiCT_PNS);
            dgvCT_PhieuNhap.DataSource = dt;
        }

        // load CT phiếu đã nhập
        private void LoadCT_PhieuDaNhap(string ma)
        {
            string query_HienThiCT_PDN = "select TenSach 'Tên Sách'  , DonGiaNhap 'Đơn Giá Nhập'  , SoLuong 'Số Lượng'  " +
                                   "from  CT_PNS A , SACH B " +
                                   "where A.MaPhieuNhap = '" + ma + "'" +
                                   "and     B.MaSach = A.MaSach";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery(query_HienThiCT_PDN);
            dgvCT_PhieuDaNhap.DataSource = dt;
        }

        // load combobox danh sach sach
        private void LoadCbbTenSach()
        {
            string query_HienThiDSSach = "Select TenSach from SACH";
            DataTable data = DataProvider.Instance.ExcuteQuery(query_HienThiDSSach);
            cbbSach.DataSource = data;
            cbbSach.DisplayMember = "TenSach";
            cbbSach.ValueMember = "TenSach";
        }
        
        
        /// <summary>
        /// ở trên là load các loại cbb, dgv
        /////////////////////////////////////
        ///
        /// bắt đầu sử dụng
        /// </summary>
        /// 


        // 2. add phiếu mơi
        private void addPhieuMoi(string MaPhieuNhap)
        {
            //txbMaPhieu.Text = createMaPhieuNhap();
            //dtpNgayNhap.MaxDate = DateTime.Today;
            DateTime NgayNhap = dtpNgayNhap.Value;
            string query_addPhieu = "insert into PHIEU_NHAP_SACH values ( '" + MaPhieuNhap + "' , '"+ NgayNhap.ToString("yyyy-MM-dd") +"' , '" + NgayNhap.ToString("yyyy-MM-dd") + "' , '" + PhanQuyen.MaTK +"')";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query_addPhieu);
        }

        

        // 4. thể loại đổi theo đầu sách
        private void txbTL_changed()
        {
            string query = "SELECT TenTL  " +
                           "from   THE_LOAI A , SACH B , CTTL C " +
                           "where   B.MaSach = C.MaSach " +
                           "AND     C.MaTL = A.MaTL" +
                           " AND     B.TenSach = N'" + cbbSach.Text.ToString() + "'";
            txbTheLoai.Text = (string)DataProvider.Instance.ExcuteScalar(query);
        }

        // 5. tác giá đổi theo đầu sách
        private void txbTacGia_changed()
        {
            string query = "SELECT TacGia from Sach" +
                            " where TenSach = N'" + cbbSach.Text.ToString() + "'";                         
            txbTacGia.Text = (string)DataProvider.Instance.ExcuteScalar(query);
        }


        // 1. tạo mã phiếu
        // tao mã phiếu nhập
        private void createMaPhieuNhap(TextBox txvMaPhieu)
        {
            
            DataTable dt = new DataTable();
            string query = "select MaPhieuNhap from PHIEU_NHAP_SACH";
            dt = DataProvider.Instance.ExcuteQuery(query);

            int stt = dt.Rows.Count + 1;
            if (stt < 10)
            {

            txbMaPhieu.Text = "PN0" + stt; 
            }
            else txbMaPhieu.Text = "PN" + stt;

            
        }

        // 3. chọn đầu sách
       
        private void cbbSach_SelectedValueChanged(object sender, EventArgs e)
        {
           if (cbbSach.SelectedValue != null)
            {
                txbTL_changed();
                txbTacGia_changed();
            }    
        }

        

        // (chọn số lượng, nhập đơn giá)
        // 6. thêm sách vào CT_PNS
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbSach.Text == "" || txbMaPhieu.Text == "" || txbTheLoai.Text == "" || txbTacGia.Text == "" || txbDonGiaNhap.Text == "" || nUDSoLuong.Value == 0)
                {
                    MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
                }
                else
                {
                    // đơn giá nhập phải khác 0
                    if (txbDonGiaNhap.Text == "0") MessageBox.Show("Đơn giá nhập không hợp lệ!", "THÔNG BÁO");
                    else
                    {
                        string query_layMaSach = "select MaSach from SACH where TenSach = N'" + cbbSach.Text + "'";
                        string MaSach = (string)DataProvider.Instance.ExcuteScalar(query_layMaSach);
                                                
                        string query_addSach = "insert into CT_PNS values ( '" + MaSach + "'," +
                                                                          " '" + txbMaPhieu.Text + "' , " + nUDSoLuong.Value + " )";
                        DataTable dt_PNS = DataProvider.Instance.ExcuteQuery(query_addSach);

                        string query_updateDonGia = "update SACH set DonGiaNhap = " + Int32.Parse(txbDonGiaNhap.Text) + " " +
                                                    " where MaSach = '" + MaSach + "' ";
                        DataProvider.Instance.ExcuteQuery(query_updateDonGia);
                        LoadCT_PNS();
                           
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập liệu lỗi: " + ex.Message, "THÔNG BÁO");
            }
                        
        }

        //Hàm tạo mã tồn kho
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
        //Hàm thêm báo cáo tồn
        private void ThemMoiVaCapNhatBaoCaoTonQuaPNS(string MaPhieuNhap)
        {
            //Kiem tra va insert BCTONKHO
            //Lay ra tháng của phiếu vừa thêm vào csdl
            string queryLayThangNam = "SELECT MONTH(NgayNhap), YEAR(NgayNhap) FROM" +
                                     " PHIEU_NHAP_SACH WHERE MaPhieuNhap='" + MaPhieuNhap +"'";
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
            //-Lay cac ma sach tu CT_PNS và duyet
            string queryLayNhieuMaSach_QuaMaHD = "SELECT MaSach, SoLuong FROM CT_PNS " +
                                                    "WHERE MaPhieuNhap='" + MaPhieuNhap +"'";
            DataTable dtMaSach = DataProvider.Instance.ExcuteQuery(queryLayNhieuMaSach_QuaMaHD);
            for (int i = 0; i < dtMaSach.Rows.Count; i++)
            {
                string queryMaSach = "SELECT MaSach FROM CT_BCTONKHO WHERE MaTonKho='" + MATK + "' AND MaSach='" + dtMaSach.Rows[i][0] + "'";
                string dt = (string)DataProvider.Instance.ExcuteScalar(queryMaSach);

                if (dt == null)
                {
                    string queryinsert = "insert into CT_BCTONKHO(MaTonKho,MaSach, TonDau) values ('" + MATK + "','" + dtMaSach.Rows[i][0] + "', 0)";

                    DataProvider.Instance.ExcuteNonQuery(queryinsert);
                }
                else
                {
                    string queryupdate = "update CT_BCTONKHO" +
                        " set TonCuoi=" +dtMaSach.Rows[i][1]
                        + " where MaTonKho='" + MATK + "' and MaSach='" + dtMaSach.Rows[i][0] + "'";
                    DataProvider.Instance.ExcuteNonQuery(queryupdate);
                }
            }
        }

        //7. hoàn tất phiếu đã nhập
        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xác nhận hoàn tất phiếu này?", "XÁC NHẬN", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {


                    dgvCT_PhieuNhap.ClearSelection();
                    LoadPhieuDaNhap();
                    ThemMoiVaCapNhatBaoCaoTonQuaPNS(txbMaPhieu.Text);
                    createMaPhieuNhap(txbMaPhieu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }
            

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
         {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];

            string ma = row.Cells[0].Value.ToString() ;
            LoadCT_PhieuDaNhap(ma);

        }


        // các btn thêm


        private void lbThemSachMoi_Click(object sender, EventArgs e)
        {
            fThemSach f = new fThemSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadCbbTenSach();
        }

        private void btnThemPhieuMoi_Click(object sender, EventArgs e)
        {
            addPhieuMoi(txbMaPhieu.Text);
            MessageBox.Show("Thêm phiếu thành công. Mời bạn thêm sách");
        }

        private void btnTroVe_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }



       
}

