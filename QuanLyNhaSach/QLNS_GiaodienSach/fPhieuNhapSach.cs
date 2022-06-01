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
            addPhieuMoi();
                       
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
        private void addPhieuMoi()
        {
            txbMaPhieu.Text = createMaPhieuNhap();
            //dtpNgayNhap.MaxDate = DateTime.Today;
            dtpNgayNhap.Text = DateTime.Today.ToString();
            string query_addPhieu = "insert into PHIEU_NHAP_SACH values ( '" + txbMaPhieu.Text + "' , '"+ dtpNgayNhap.Text+"' , '" + dtpNgayNhap.Text + "' , 'TK01' )";
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
        private string createMaPhieuNhap()
        {
            string MaPNS = "";
            DataTable dt = new DataTable();
            string query = "select MaPhieuNhap from PHIEU_NHAP_SACH";
            dt = DataProvider.Instance.ExcuteQuery(query);

            int stt = dt.Rows.Count + 1;
            MaPNS = "PN" + stt; 

            return MaPNS;
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

                        string query_KiemTraSLT = "Select SoLuongTon from SACH where MaSach = '" + MaSach + "'";
                        object SoLuong = DataProvider.Instance.ExcuteScalar(query_KiemTraSLT);

                        if (SoLuong == null)
                        {
                            string query_GetSllTonToiDa = "Select SoLuongTonToiDa from QUYDINH";
                            int SllTonToiDa = (int)DataProvider.Instance.ExcuteScalar(query_GetSllTonToiDa);
                            MessageBox.Show("slll");

                            if (nUDSoLuong.Value > SllTonToiDa)
                            {
                                MessageBox.Show("Vượt quá số lượng tồn tối đa: " + SllTonToiDa, "THÔNG BÁO");
                            }
                            else
                            {
                                string query_updateSoLuong = "update SACH set SoLuongTon = " + nUDSoLuong.Value + "" +
                                                                        " , DonGiaNhap = " + Int32.Parse(txbDonGiaNhap.Text) + " " +
                                                    " where MaSach = '" + MaSach + "' ";
                                DataTable dt_PNS = DataProvider.Instance.ExcuteQuery(query_addSach);
                                DataProvider.Instance.ExcuteQuery(query_updateSoLuong);
                                MessageBox.Show("nhánh trên");
                                LoadCT_PNS();
                            } 
                                                        
                        }
                        else
                        {
                            string query_updateSoLuong = "update SACH set SoLuongTon += " + nUDSoLuong.Value + " " +
                                                                    " , DonGiaNhap = " + Int32.Parse(txbDonGiaNhap.Text) + " " +
                                                     " where MaSach = '" + MaSach + "' ";
                            DataTable dt_PNS = DataProvider.Instance.ExcuteQuery(query_addSach);
                            MessageBox.Show("xún nhánh dứi");

                            // dư, đã có trigger tự động cập nhật sl tồn
                            //DataProvider.Instance.ExcuteQuery(query_updateSoLuong);

                            LoadCT_PNS();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập liệu lỗi: " + ex.Message, "THÔNG BÁO");
            }
                        
        }

        //7. hoàn tất phiếu đã nhập
        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xác nhận hoàn tất phiếu này?", "XÁC NHẬN", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                dgvCT_PhieuNhap.ClearSelection();
                LoadPhieuDaNhap();
                addPhieuMoi();
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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbThemSachMoi_Click(object sender, EventArgs e)
        {
            fThemSach f = new fThemSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadCbbTenSach();
        }
    }



       
}

