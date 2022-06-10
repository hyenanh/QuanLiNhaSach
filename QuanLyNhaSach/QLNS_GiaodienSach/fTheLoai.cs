using QLNS_GiaodienSach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLNS_GiaodienSach
{
    public partial class fTheLoai : Form
    {

        public fTheLoai()
        {
            InitializeComponent();
            LoadTheLoaiList();
        }

        DataTable dt = new DataTable();
        void LoadTheLoaiList()
        {
            string queryShowList = "SELECT MATL 'Mã Thể loại', TenTL 'Thể Loại' " +
                                         "from   THE_LOAI";
            dt = DataProvider.Instance.ExcuteQuery(queryShowList);
            dGvTheLoai.DataSource = dt;
        }

        // tạo mã thể loại
        private string createMaTheLoai()
        {
            string Ma = "";
            DataTable dt = new DataTable();
            string query = "select MaTL from THE_LOAI" ;
            dt = DataProvider.Instance.ExcuteQuery(query);

            // cú pháp cho mã sách SA + số
            int stt = dt.Rows.Count + 1;
            if (stt < 10)
            {
                Ma = "TL0" + stt;
            }
            else
                Ma = "TL" + stt;

            return Ma;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbTheLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên thể loại mới!");
            }
            else
            {
                string query_Add = "INSERT INTO THE_LOAI VALUES ( N'"+ createMaTheLoai() +"' , N'" + tbTheLoai.Text + "')";
                int add = DataProvider.Instance.ExcuteNonQuery(query_Add);
                if (add > 0)
                {
                    LoadTheLoaiList();
                    MessageBox.Show("Cập nhật thành công");
                    tbTheLoai.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            } 
                
            
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
