
namespace ThietKeGiaoDien
{
    partial class fBaoCaoCongNo
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
            this.TieuDe = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtvDanhSachCongNo = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDanhSachCongNo)).BeginInit();
            this.SuspendLayout();
            // 
            // TieuDe
            // 
            this.TieuDe.AutoSize = true;
            this.TieuDe.BackColor = System.Drawing.Color.Transparent;
            this.TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieuDe.ForeColor = System.Drawing.Color.Black;
            this.TieuDe.ImageKey = "(none)";
            this.TieuDe.Location = new System.Drawing.Point(212, 60);
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Size = new System.Drawing.Size(289, 31);
            this.TieuDe.TabIndex = 0;
            this.TieuDe.Text = "BÁO CÁO CÔNG NỢ";
            this.TieuDe.Click += new System.EventHandler(this.TieuDe_Click);
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "MM/yyyy";
            this.dtpThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(190, 145);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(225, 24);
            this.dtpThoiGian.TabIndex = 1;
            this.dtpThoiGian.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Transparent;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(447, 145);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtvDanhSachCongNo
            // 
            this.dtvDanhSachCongNo.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtvDanhSachCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDanhSachCongNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clKhachHang,
            this.clNoDau,
            this.clPhatSinh,
            this.clNoCuoi});
            this.dtvDanhSachCongNo.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtvDanhSachCongNo.Location = new System.Drawing.Point(96, 218);
            this.dtvDanhSachCongNo.Name = "dtvDanhSachCongNo";
            this.dtvDanhSachCongNo.Size = new System.Drawing.Size(545, 150);
            this.dtvDanhSachCongNo.TabIndex = 3;
            this.dtvDanhSachCongNo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            // 
            // clKhachHang
            // 
            this.clKhachHang.HeaderText = "Khách hàng";
            this.clKhachHang.Name = "clKhachHang";
            // 
            // clNoDau
            // 
            this.clNoDau.HeaderText = "Nợ đầu";
            this.clNoDau.Name = "clNoDau";
            // 
            // clPhatSinh
            // 
            this.clPhatSinh.HeaderText = "Phát Sinh";
            this.clPhatSinh.Name = "clPhatSinh";
            // 
            // clNoCuoi
            // 
            this.clNoCuoi.HeaderText = "Nợ cuối";
            this.clNoCuoi.Name = "clNoCuoi";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(573, 410);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(68, 28);
            this.btnTroVe.TabIndex = 4;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // fBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ThietKeGiaoDien.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dtvDanhSachCongNo);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.TieuDe);
            this.Name = "fBaoCaoCongNo";
            this.Text = "Báo cáo công nợ";
            this.Load += new System.EventHandler(this.fBaoCaoCongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDanhSachCongNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TieuDe;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dtvDanhSachCongNo;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoCuoi;
    }
}

