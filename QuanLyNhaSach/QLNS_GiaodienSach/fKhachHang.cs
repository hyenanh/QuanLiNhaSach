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
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlConn = "Data Source=LAPTOP-3PESOL36\\SQLEXPRESS;Database=QUAN_LI_NHA_SACH;Integrated Security=SSPI";
        SqlDataAdapter adapter;
        DataSet ds = null;

        
        private void fKhachHang_Load_1(object sender, EventArgs e)
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

            dgvThongTinKhachHang.DataSource = ds.Tables["KhachHang"];
        }

        int vt = -1;
        private void dgvThongTinKhachHang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = ds.Tables["KhachHang"].Rows[vt];
        
            txtHoTen.Text = row["hoten"] + "";
            dtpNgaySinh.Text = row["ngaysinh"] + "";
            txtDiaChi.Text = row["diachi"] + "";
            txtEmail.Text = row["email"] + "";
            txtSDT.Text = row["SDT"] + "";
            txtTienNo.Text = row["TienNo"] + "";
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            int n = dgvThongTinKhachHang.RowCount;// n=số dòng dữ liệu+1 vì tính cả dòng null ở cuối
            bool tim = false;
            for (int i = 0; i < n - 1; i++)
            {
                DataRow row = ds.Tables["KhachHang"].Rows[i];
                if (txtTimKiem.Text == row["SDT"] + "")
                {
                    
                    txtHoTen.Text = row["hoten"] + "";
                    dtpNgaySinh.Text = row["ngaysinh"] + "";
                    txtDiaChi.Text = row["diachi"] + "";
                    txtEmail.Text = row["email"] + "";
                    txtSDT.Text = row["SDT"] + "";
                    txtTienNo.Text = row["TienNo"] + "";
                    //txtTienNo.Text = n + "";
                    tim = true;
                    txtTimKiem.Clear();
                    return;
                }
            }
            if (tim == false)
            {
                MessageBox.Show("Không tìm thấy khách hàng.");
            }

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DateTime NgaySinh = dtpNgaySinh.Value;
            if (vt == -1) return;//vt==-1 la chua chon nen nhan vo ko lm j ca
            DataRow row = ds.Tables["KhachHang"].Rows[vt];
            row.BeginEdit();
            row["hoten"] = txtHoTen.Text;
            row["ngaysinh"] = NgaySinh.ToString("yyyy-MM-dd");
            row["diachi"] = txtDiaChi.Text;
            row["email"] = txtEmail.Text;
            row["SDT"] = txtSDT.Text;
            row["TienNo"] = txtTienNo.Text;

            row.EndEdit();
            int kq = adapter.Update(ds.Tables["KhachHang"]);// update trong csdl
            if (kq > 0)
            {
                HienThiThongTinKH();// cai nay la show lai bang sao update
                MessageBox.Show("Update thành công");
            }
            else
            {
                MessageBox.Show("Update thất bại");
            }
        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime NgaySinh = dtpNgaySinh.Value;

                DataRow row = ds.Tables["KhachHang"].NewRow();
                int stt = ds.Tables["KhachHang"].Rows.Count + 1;
                if (stt < 10)
                {
                    row["maKH"] = "KH0"+stt;
                }
                else
                {
                    row["maKH"] = "KH" + stt;
                }

               
                row["hoten"] = txtHoTen.Text;
                row["ngaysinh"] = NgaySinh.ToString("yyyy-MM-dd");
                row["diachi"] = txtDiaChi.Text;
                row["email"] = txtEmail.Text;
                row["SDT"] = txtSDT.Text;
                row["TienNo"] = txtTienNo.Text;

                ds.Tables["KhachHang"].Rows.Add(row);

                int kq = adapter.Update(ds.Tables["KhachHang"]);
                if (kq > 0)
                {
                    HienThiThongTinKH();
                }
                else
                {
                    MessageBox.Show("them that bai");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi nhập liệu");
            }
        }

        private void btnTroVe_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
