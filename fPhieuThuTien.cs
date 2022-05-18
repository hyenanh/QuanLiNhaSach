using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qliNhasach
{
    public partial class fPhieuThuTien : Form
    {
        public fPhieuThuTien()
        {
            InitializeComponent();
        }

        private void fPhieuThuTien_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void fPhieuThuTien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;// cancel la ko thoat giao dien
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
