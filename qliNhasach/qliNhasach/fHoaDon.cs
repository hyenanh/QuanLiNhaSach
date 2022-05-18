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
    public partial class fHoaDon : Form
    {
        public fHoaDon()
        {
            InitializeComponent();
        }

        private void btnChonSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnChonSL_Click(object sender, EventArgs e)
        {

        }

        private void btnHoanThanhHoaDon_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = txtMaHD.Text;
        }

        private void txtSuaMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuaTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void fHoaDon_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
