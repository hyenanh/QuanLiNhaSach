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
    public partial class fTheLoai : Form
    {
        public fTheLoai()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // load ds thể loại
        void LoadTheLoaiList()
        {

        }

        //
        // lấy thể loại mới từ txb, rồi clear txb
        int stt = 1;
        void ThemTheLoai (string txt_TL)
        {
            if (txt_TL != "")
            {
                dGvTheLoai.Rows.Add("TL" + stt, txbTheLoai.Text);
                stt++;
                txbTheLoai.Clear();
            }    
            else
            {
                MessageBox.Show("Không được để trống","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }                                             
        }

        private void btnThem_click(object sender, EventArgs e)
        {

            ThemTheLoai(txbTheLoai.Text);
        }

        /*private void txbTheLoai_Enter(object sender, EventArgs e)
        {
            ThemTheLoai(txbTheLoai.Text);
        }*/

        private void dGvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTroVe_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
