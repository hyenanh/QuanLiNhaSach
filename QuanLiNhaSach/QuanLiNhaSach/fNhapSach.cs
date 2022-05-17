using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach
{
    public partial class fNhapSach : Form
    {
        public fNhapSach()
        {
            InitializeComponent();
        }
        
      

                
        private void lPhieuNhapSach_Click(object sender, EventArgs e)
        {

        }

        private void fNhapSach_Load(object sender, EventArgs e)
        {

        }


        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gBNhapSach_Enter(object sender, EventArgs e)
        {

        }



        private void btnThem_Click(object sender, EventArgs e)
        {

            // trả về 0 hoặc 1
            DialogResult res = MessageBox.Show("Xác nhận hoàn tất đớn nhập sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // yes = 0
            if (res == DialogResult.Yes)
            {

                MessageBox.Show("Nhập thành công","", MessageBoxButtons.OK);

            }


        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy index ô đc chọn từ dgvPhieuNhap
            /* 
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];
            */
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCT_PhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
