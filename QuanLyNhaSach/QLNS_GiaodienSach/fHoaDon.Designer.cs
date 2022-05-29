namespace QLNS_GiaodienSach
{
    partial class fHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtSotienthu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHoanThanhHoaDon = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.btnChonSL = new System.Windows.Forms.Button();
            this.nUDSoLuong = new System.Windows.Forms.NumericUpDown();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDanhSachHD = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnXemKhachHang = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dtpNgayLap);
            this.groupBox2.Controls.Add(this.txtSotienthu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMaKH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(18, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 170);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Enabled = false;
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(172, 82);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayLap.TabIndex = 8;
            // 
            // txtSotienthu
            // 
            this.txtSotienthu.Location = new System.Drawing.Point(172, 130);
            this.txtSotienthu.Name = "txtSotienthu";
            this.txtSotienthu.Size = new System.Drawing.Size(200, 27);
            this.txtSotienthu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số tiền thu";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(172, 31);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(200, 27);
            this.txtMaKH.TabIndex = 4;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // btnHoanThanhHoaDon
            // 
            this.btnHoanThanhHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHoanThanhHoaDon.Location = new System.Drawing.Point(476, 602);
            this.btnHoanThanhHoaDon.Name = "btnHoanThanhHoaDon";
            this.btnHoanThanhHoaDon.Size = new System.Drawing.Size(203, 36);
            this.btnHoanThanhHoaDon.TabIndex = 24;
            this.btnHoanThanhHoaDon.Text = "Hoàn thành hóa đơn";
            this.btnHoanThanhHoaDon.UseVisualStyleBackColor = true;
            this.btnHoanThanhHoaDon.Click += new System.EventHandler(this.btnHoanThanhHoaDon_Click_1);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Location = new System.Drawing.Point(744, 262);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(107, 36);
            this.btnTim.TabIndex = 27;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSach.Location = new System.Drawing.Point(516, 267);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(205, 27);
            this.txtTenSach.TabIndex = 26;
            // 
            // btnChonSL
            // 
            this.btnChonSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonSL.Location = new System.Drawing.Point(744, 532);
            this.btnChonSL.Name = "btnChonSL";
            this.btnChonSL.Size = new System.Drawing.Size(107, 36);
            this.btnChonSL.TabIndex = 22;
            this.btnChonSL.Text = "Chọn";
            this.btnChonSL.UseVisualStyleBackColor = true;
            this.btnChonSL.Click += new System.EventHandler(this.btnChonSL_Click_1);
            // 
            // nUDSoLuong
            // 
            this.nUDSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nUDSoLuong.Location = new System.Drawing.Point(559, 540);
            this.nUDSoLuong.Name = "nUDSoLuong";
            this.nUDSoLuong.Size = new System.Drawing.Size(120, 27);
            this.nUDSoLuong.TabIndex = 20;
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(437, 334);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.Size = new System.Drawing.Size(414, 181);
            this.dgvSach.TabIndex = 19;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(437, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số lượng";
            // 
            // dgvDanhSachHD
            // 
            this.dgvDanhSachHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHD.Location = new System.Drawing.Point(18, 44);
            this.dgvDanhSachHD.Name = "dgvDanhSachHD";
            this.dgvDanhSachHD.RowHeadersWidth = 51;
            this.dgvDanhSachHD.Size = new System.Drawing.Size(388, 196);
            this.dgvDanhSachHD.TabIndex = 18;
            this.dgvDanhSachHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHD_CellClick_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 14;
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Location = new System.Drawing.Point(436, 45);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.RowHeadersWidth = 51;
            this.dgvChiTietHD.Size = new System.Drawing.Size(409, 195);
            this.dgvChiTietHD.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(432, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tên sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(437, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Chọn sách";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(433, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Chi tiết hóa đơn của khách hàng:";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(692, 24);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(22, 16);
            this.lbTenKH.TabIndex = 31;
            this.lbTenKH.Text = ".....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Danh sách các hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(24, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tổng tiền: ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Location = new System.Drawing.Point(190, 488);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(200, 27);
            this.txtTongTien.TabIndex = 8;
            // 
            // btnTroVe
            // 
            this.btnTroVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTroVe.Location = new System.Drawing.Point(744, 602);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(107, 36);
            this.btnTroVe.TabIndex = 34;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnXemKhachHang
            // 
            this.btnXemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemKhachHang.Location = new System.Drawing.Point(253, 261);
            this.btnXemKhachHang.Name = "btnXemKhachHang";
            this.btnXemKhachHang.Size = new System.Drawing.Size(153, 36);
            this.btnXemKhachHang.TabIndex = 35;
            this.btnXemKhachHang.Text = "Xem khách hàng";
            this.btnXemKhachHang.UseVisualStyleBackColor = true;
            this.btnXemKhachHang.Click += new System.EventHandler(this.btnXemKhachHang_Click);
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnTroVe;
            this.ClientSize = new System.Drawing.Size(892, 663);
            this.Controls.Add(this.btnXemKhachHang);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHoanThanhHoaDon);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.btnChonSL);
            this.Controls.Add(this.nUDSoLuong);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDanhSachHD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvChiTietHD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "fHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHoanThanhHoaDon;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Button btnChonSL;
        private System.Windows.Forms.NumericUpDown nUDSoLuong;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDanhSachHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSotienthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Button btnXemKhachHang;
    }
}