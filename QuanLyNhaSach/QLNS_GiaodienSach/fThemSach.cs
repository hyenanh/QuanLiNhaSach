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
    public partial class fThemSach : Form
    {
        public fThemSach()
        {
            InitializeComponent();
            LoadSachList();
            LoadCbbTheLoai(cbbTheLoai);       
        }

        DataTable dt = new DataTable();
        void LoadSachList()
        {
            string queryShowList = "SELECT B.MaSach 'Mã Sách' , TenSach 'Tên Sách' , TacGia 'Tác Giả'  , TenTL 'Thể Loại' , DonGiaNhap 'Đơn Giá Nhập' , DonGiaBan 'Đơn Giá Bán'  " +
                                   "from   THE_LOAI A , SACH B , CTTL C " +
                                   "where   B.MaSach = C.MaSach " +
                                   "AND     C.MaTL = A.MaTL";
            dt = DataProvider.Instance.ExcuteQuery(queryShowList);
            dgvDsSach.DataSource = dt;
        }

        private string createMaSach()
        {         
            string MaSach = "";
            DataTable dt = new DataTable();
            string query = "select MaSach from SACH";
            dt = DataProvider.Instance.ExcuteQuery(query);

            // cú pháp cho mã sách SA + số
            int stt = dt.Rows.Count + 1;
            MaSach = "SA" + stt;

            return MaSach  ;
        }
               

        DataTable dtTL = new DataTable();

        private void LoadCbbTheLoai(ComboBox cbbTheLoai)
        {
            string query = "Select TenTL from THE_LOAI";
            DataTable dtTL = DataProvider.Instance.ExcuteQuery(query);
        
            cbbTheLoai.DataSource = dtTL;
            cbbTheLoai.DisplayMember = "TenTL";
            cbbTheLoai.ValueMember = "TenTL";
           
        }
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (txbTenSach.Text == "" || txbTacGia.Text == "" || cbbTheLoai.Text == "" )
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            else
            {
                txbMaSach.Text =  createMaSach();
                
                string query = "insert into SACH (MaSach , TenSach , TacGia , DonGiaNhap, DonGiaBan ) values ( '" + txbMaSach.Text + "' , N'" + txbTenSach.Text + "' , N'" + txbTacGia.Text + "' , 0 , 0  )";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                // them vao bang chi tiet the loai
                string query_addCTTL = "insert into CTTL values ( (select MaTL from THE_LOAI where TenTL = N'" + cbbTheLoai.Text.ToString() + "') , '" + txbMaSach.Text + "' )";
                DataTable dtCTTL = DataProvider.Instance.ExcuteQuery(query_addCTTL);
                MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                txbTenSach.Text = "";
                LoadSachList();
                txbTenSach.Clear();
                
            }
        }

       
        private void lbThemTheLoai_Click(object sender, EventArgs e)
        {
            fTheLoai f = new fTheLoai();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadCbbTheLoai(cbbTheLoai);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
