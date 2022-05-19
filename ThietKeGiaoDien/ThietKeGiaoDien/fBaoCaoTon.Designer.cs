
namespace ThietKeGiaoDien
{
    partial class fBaoCaoTon
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
            this.dgvDanhSachTon = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTonDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTonCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTon)).BeginInit();
            this.SuspendLayout();
            // 
            // TieuDe
            // 
            this.TieuDe.AutoSize = true;
            this.TieuDe.BackColor = System.Drawing.Color.Transparent;
            this.TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieuDe.ForeColor = System.Drawing.Color.Black;
            this.TieuDe.ImageKey = "(none)";
            this.TieuDe.Location = new System.Drawing.Point(247, 60);
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Size = new System.Drawing.Size(213, 31);
            this.TieuDe.TabIndex = 1;
            this.TieuDe.Text = "BÁO CÁO TỒN";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.CustomFormat = "MM/yyyy";
            this.dtpThoiGian.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(196, 138);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(225, 23);
            this.dtpThoiGian.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Transparent;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(460, 138);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // dgvDanhSachTon
            // 
            this.dgvDanhSachTon.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDanhSachTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clSach,
            this.clTonDau,
            this.clPhatSinh,
            this.clTonCuoi});
            this.dgvDanhSachTon.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachTon.Location = new System.Drawing.Point(106, 228);
            this.dgvDanhSachTon.Name = "dgvDanhSachTon";
            this.dgvDanhSachTon.Size = new System.Drawing.Size(545, 150);
            this.dgvDanhSachTon.TabIndex = 4;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            // 
            // clSach
            // 
            this.clSach.HeaderText = "Sách";
            this.clSach.Name = "clSach";
            // 
            // clTonDau
            // 
            this.clTonDau.HeaderText = "Tồn đầu";
            this.clTonDau.Name = "clTonDau";
            // 
            // clPhatSinh
            // 
            this.clPhatSinh.HeaderText = "Phát Sinh";
            this.clPhatSinh.Name = "clPhatSinh";
            // 
            // clTonCuoi
            // 
            this.clTonCuoi.HeaderText = "Tồn cuối";
            this.clTonCuoi.Name = "clTonCuoi";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(653, 410);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(68, 28);
            this.btnTroVe.TabIndex = 5;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // fBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ThietKeGiaoDien.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dgvDanhSachTon);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.TieuDe);
            this.Name = "fBaoCaoTon";
            this.Text = "Báo cáo tồn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TieuDe;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dgvDanhSachTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTonDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTonCuoi;
        private System.Windows.Forms.Button btnTroVe;
    }
}