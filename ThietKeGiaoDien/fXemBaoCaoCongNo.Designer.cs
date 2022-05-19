
namespace ThietKeGiaoDien
{
    partial class fXemBaoCaoCongNo
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
            this.dtvDanhSachCongNo = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblXemBaoCao = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDanhSachCongNo)).BeginInit();
            this.SuspendLayout();
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
            this.dtvDanhSachCongNo.Location = new System.Drawing.Point(129, 146);
            this.dtvDanhSachCongNo.Name = "dtvDanhSachCongNo";
            this.dtvDanhSachCongNo.Size = new System.Drawing.Size(544, 174);
            this.dtvDanhSachCongNo.TabIndex = 4;
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
            // lblXemBaoCao
            // 
            this.lblXemBaoCao.AutoSize = true;
            this.lblXemBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.lblXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemBaoCao.ForeColor = System.Drawing.Color.Black;
            this.lblXemBaoCao.ImageKey = "(none)";
            this.lblXemBaoCao.Location = new System.Drawing.Point(225, 75);
            this.lblXemBaoCao.Name = "lblXemBaoCao";
            this.lblXemBaoCao.Size = new System.Drawing.Size(358, 31);
            this.lblXemBaoCao.TabIndex = 5;
            this.lblXemBaoCao.Text = "XEM BÁO CÁO CÔNG NỢ";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(605, 396);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(68, 28);
            this.btnTroVe.TabIndex = 6;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // fXemBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::ThietKeGiaoDien.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.lblXemBaoCao);
            this.Controls.Add(this.dtvDanhSachCongNo);
            this.Name = "fXemBaoCaoCongNo";
            this.Text = "fXemBaoCaoCongNo";
            ((System.ComponentModel.ISupportInitialize)(this.dtvDanhSachCongNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvDanhSachCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoCuoi;
        private System.Windows.Forms.Label lblXemBaoCao;
        private System.Windows.Forms.Button btnTroVe;
    }
}