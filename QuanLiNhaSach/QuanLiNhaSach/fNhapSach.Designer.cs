
namespace QuanLiNhaSach
{
    partial class fNhapSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapSach));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.lPhieuNhapSach = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lNgayNhap = new System.Windows.Forms.Label();
            this.dgvCT_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBNhapSach = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dgvCT_PhieuDaNhap = new System.Windows.Forms.DataGridView();
            this.gbPNS = new System.Windows.Forms.GroupBox();
            this.gbCT_PNS = new System.Windows.Forms.GroupBox();
            this.lbCT_PhieuDaNhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuNhap)).BeginInit();
            this.gBNhapSach.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuDaNhap)).BeginInit();
            this.gbPNS.SuspendLayout();
            this.gbCT_PNS.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(336, 163);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(43, 45);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "<";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(980, 638);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 1;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // lPhieuNhapSach
            // 
            this.lPhieuNhapSach.AutoSize = true;
            this.lPhieuNhapSach.BackColor = System.Drawing.Color.Transparent;
            this.lPhieuNhapSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPhieuNhapSach.Location = new System.Drawing.Point(509, 8);
            this.lPhieuNhapSach.Name = "lPhieuNhapSach";
            this.lPhieuNhapSach.Size = new System.Drawing.Size(279, 31);
            this.lPhieuNhapSach.TabIndex = 0;
            this.lPhieuNhapSach.Text = "PHIẾU NHẬP SÁCH";
            this.lPhieuNhapSach.Click += new System.EventHandler(this.lPhieuNhapSach_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(605, 46);
            this.dtpNgayNhap.MaxDate = new System.DateTime(2022, 12, 25, 23, 59, 59, 0);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(174, 20);
            this.dtpNgayNhap.TabIndex = 2;
            this.dtpNgayNhap.ValueChanged += new System.EventHandler(this.dtpNgayNhap_ValueChanged);
            // 
            // lNgayNhap
            // 
            this.lNgayNhap.AutoSize = true;
            this.lNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNgayNhap.Location = new System.Drawing.Point(512, 50);
            this.lNgayNhap.Name = "lNgayNhap";
            this.lNgayNhap.Size = new System.Drawing.Size(87, 16);
            this.lNgayNhap.TabIndex = 1;
            this.lNgayNhap.Text = "Ngày nhập:";
            // 
            // dgvCT_PhieuNhap
            // 
            this.dgvCT_PhieuNhap.AllowUserToResizeColumns = false;
            this.dgvCT_PhieuNhap.AllowUserToResizeRows = false;
            this.dgvCT_PhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_PhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCT_PhieuNhap.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCT_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_PhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clSach,
            this.clTheLoai,
            this.clTacGia,
            this.clSoLuong,
            this.clDonGiaNhap});
            this.dgvCT_PhieuNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvCT_PhieuNhap.Location = new System.Drawing.Point(0, 6);
            this.dgvCT_PhieuNhap.Name = "dgvCT_PhieuNhap";
            this.dgvCT_PhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCT_PhieuNhap.Size = new System.Drawing.Size(651, 526);
            this.dgvCT_PhieuNhap.TabIndex = 4;
            this.dgvCT_PhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_PhieuNhap_CellContentClick);
            // 
            // clSTT
            // 
            this.clSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Format = "N2";
            this.clSTT.DefaultCellStyle = dataGridViewCellStyle1;
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clSTT.Width = 53;
            // 
            // clSach
            // 
            this.clSach.HeaderText = "Sách";
            this.clSach.Name = "clSach";
            // 
            // clTheLoai
            // 
            this.clTheLoai.HeaderText = "Thể Loại";
            this.clTheLoai.Name = "clTheLoai";
            // 
            // clTacGia
            // 
            this.clTacGia.HeaderText = "Tác Giả";
            this.clTacGia.Name = "clTacGia";
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.Name = "clSoLuong";
            // 
            // clDonGiaNhap
            // 
            this.clDonGiaNhap.HeaderText = "Đơn Giá Nhập";
            this.clDonGiaNhap.Name = "clDonGiaNhap";
            // 
            // gBNhapSach
            // 
            this.gBNhapSach.BackColor = System.Drawing.Color.Transparent;
            this.gBNhapSach.Controls.Add(this.dgvCT_PhieuNhap);
            this.gBNhapSach.ForeColor = System.Drawing.Color.Black;
            this.gBNhapSach.Location = new System.Drawing.Point(404, 86);
            this.gBNhapSach.Name = "gBNhapSach";
            this.gBNhapSach.Size = new System.Drawing.Size(651, 532);
            this.gBNhapSach.TabIndex = 5;
            this.gBNhapSach.TabStop = false;
            this.gBNhapSach.Enter += new System.EventHandler(this.gBNhapSach_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dtpNgayNhap);
            this.panel1.Controls.Add(this.lPhieuNhapSach);
            this.panel1.Controls.Add(this.lNgayNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 79);
            this.panel1.TabIndex = 6;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AllowUserToResizeColumns = false;
            this.dgvPhieuNhap.AllowUserToResizeRows = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 7);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(297, 187);
            this.dgvPhieuNhap.TabIndex = 7;
            this.dgvPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellContentClick);
            // 
            // dgvCT_PhieuDaNhap
            // 
            this.dgvCT_PhieuDaNhap.AllowUserToAddRows = false;
            this.dgvCT_PhieuDaNhap.AllowUserToDeleteRows = false;
            this.dgvCT_PhieuDaNhap.AllowUserToResizeColumns = false;
            this.dgvCT_PhieuDaNhap.AllowUserToResizeRows = false;
            this.dgvCT_PhieuDaNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCT_PhieuDaNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCT_PhieuDaNhap.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCT_PhieuDaNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_PhieuDaNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvCT_PhieuDaNhap.Location = new System.Drawing.Point(0, 29);
            this.dgvCT_PhieuDaNhap.Name = "dgvCT_PhieuDaNhap";
            this.dgvCT_PhieuDaNhap.ReadOnly = true;
            this.dgvCT_PhieuDaNhap.Size = new System.Drawing.Size(367, 311);
            this.dgvCT_PhieuDaNhap.TabIndex = 4;
            // 
            // gbPNS
            // 
            this.gbPNS.BackColor = System.Drawing.Color.Transparent;
            this.gbPNS.Controls.Add(this.dgvPhieuNhap);
            this.gbPNS.ForeColor = System.Drawing.Color.Transparent;
            this.gbPNS.Location = new System.Drawing.Point(12, 78);
            this.gbPNS.Name = "gbPNS";
            this.gbPNS.Size = new System.Drawing.Size(297, 196);
            this.gbPNS.TabIndex = 5;
            this.gbPNS.TabStop = false;
            this.gbPNS.Enter += new System.EventHandler(this.gBNhapSach_Enter);
            // 
            // gbCT_PNS
            // 
            this.gbCT_PNS.BackColor = System.Drawing.Color.Transparent;
            this.gbCT_PNS.Controls.Add(this.lbCT_PhieuDaNhap);
            this.gbCT_PNS.Controls.Add(this.dgvCT_PhieuDaNhap);
            this.gbCT_PNS.ForeColor = System.Drawing.Color.Black;
            this.gbCT_PNS.Location = new System.Drawing.Point(12, 278);
            this.gbCT_PNS.Name = "gbCT_PNS";
            this.gbCT_PNS.Size = new System.Drawing.Size(367, 340);
            this.gbCT_PNS.TabIndex = 5;
            this.gbCT_PNS.TabStop = false;
            this.gbCT_PNS.Enter += new System.EventHandler(this.gBNhapSach_Enter);
            // 
            // lbCT_PhieuDaNhap
            // 
            this.lbCT_PhieuDaNhap.AutoSize = true;
            this.lbCT_PhieuDaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCT_PhieuDaNhap.Location = new System.Drawing.Point(150, 10);
            this.lbCT_PhieuDaNhap.Name = "lbCT_PhieuDaNhap";
            this.lbCT_PhieuDaNhap.Size = new System.Drawing.Size(61, 16);
            this.lbCT_PhieuDaNhap.TabIndex = 5;
            this.lbCT_PhieuDaNhap.Text = "Chi Tiết";
            // 
            // fNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 673);
            this.Controls.Add(this.gbCT_PNS);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbPNS);
            this.Controls.Add(this.gBNhapSach);
            this.MaximizeBox = false;
            this.Name = "fNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.fNhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuNhap)).EndInit();
            this.gBNhapSach.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuDaNhap)).EndInit();
            this.gbPNS.ResumeLayout(false);
            this.gbCT_PNS.ResumeLayout(false);
            this.gbCT_PNS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Label lPhieuNhapSach;
        private System.Windows.Forms.Label lNgayNhap;
        private System.Windows.Forms.DataGridView dgvCT_PhieuNhap;
        private System.Windows.Forms.GroupBox gBNhapSach;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.DataGridView dgvCT_PhieuDaNhap;
        private System.Windows.Forms.GroupBox gbPNS;
        private System.Windows.Forms.GroupBox gbCT_PNS;
        private System.Windows.Forms.Label lbCT_PhieuDaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGiaNhap;
    }
}