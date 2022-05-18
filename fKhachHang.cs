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
namespace qliNhasach
{
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlConn = "server=LAPTOP-IFIGITIA;database=QUAN_LI_NHA_SACH;User Id=sa;pwd=1";
        SqlDataAdapter adapter;
        DataSet ds = null;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int n = dgvThongTinKhachHang.RowCount;// n=số dòng dữ liệu+1 vì tính cả dòng null ở cuối
            bool tim = false;
            for(int i = 0; i < n-1; i++)
            {
                DataRow row = ds.Tables["KhachHang"].Rows[i];
                if (txtTimKiem.Text == row["SDT"] + "")
                {
                    txtMaKh.Text = row["maKH"] + "";
                    txtHoTen.Text = row["hoten"] + "";
                    txtNgaysinh.Text = row["ngaysinh"] + "";
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["KhachHang"].NewRow();
            row["maKH"] = txtMaKh.Text;
            row["hoten"] = txtHoTen.Text;
            row["ngaysinh"] = txtNgaysinh.Text;
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

            /*DataTable QUYDINH = new DataTable();// hứng dữ liệu
            adapter = new SqlDataAdapter("select*from QUYDINH", conn);//lấy dl từ csdl
            adapter.Fill(QUYDINH);// đổ vào 
            DataRow rowqd = QUYDINH.Rows[0];



            if (int.Parse(txtTienNo.Text) > int.Parse(rowqd["TienNoToida"] + ""))
            {
                MessageBox.Show("Tiền nợ vượt quá tiền nợ tối đa");
            }
            else
            {

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
            }*/
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            
        }

        private void fKhachHang_Load(object sender, EventArgs e)
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
        private void txtMaKh_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTienNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void fKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        int vt = -1;
        private void dgvThongTinKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = ds.Tables["KhachHang"].Rows[vt];
            txtMaKh.Text=row["maKH"]+"";
            txtHoTen.Text=row["hoten"]+"";
            txtNgaysinh.Text = row["ngaysinh"] + "";
            txtDiaChi.Text=row["diachi"]+"";
            txtEmail.Text=row["email"]+"";
            txtSDT.Text=row["SDT"]+"";
            txtTienNo.Text=row["TienNo"]+"";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;//vt==-1 la chua chon nen nhan vo ko lm j ca
            DataRow row = ds.Tables["KhachHang"].Rows[vt];
            row.BeginEdit();
            row["maKH"] = txtMaKh.Text;
            row["hoten"] = txtHoTen.Text;
            row["ngaysinh"] = txtNgaysinh.Text;
            row["ngaysinh"] = txtNgaysinh.Text;
            row["diachi"] = txtDiaChi.Text;
            row["email"] = txtEmail.Text;
            row["SDT"] = txtSDT.Text;
            row["TienNo"] = txtTienNo.Text;

            row.EndEdit();
            int kq = adapter.Update(ds.Tables["KhachHang"]);// update trong csdl
            if (kq > 0)
            {
                HienThiThongTinKH();// cai nay la show lai bang sao update
                MessageBox.Show("update thanh cong");
            }
            else
            {
                MessageBox.Show("update that bai");
            }

        }

        
    }
}
