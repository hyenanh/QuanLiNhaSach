namespace QLNS_GiaodienSach
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
            this.dgvDanhSachCongNo = new System.Windows.Forms.DataGridView();
            this.lblXemBaoCao = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCongNo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachCongNo
            // 
            this.dgvDanhSachCongNo.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDanhSachCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCongNo.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachCongNo.Location = new System.Drawing.Point(37, 147);
            this.dgvDanhSachCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachCongNo.Name = "dgvDanhSachCongNo";
            this.dgvDanhSachCongNo.RowHeadersWidth = 51;
            this.dgvDanhSachCongNo.Size = new System.Drawing.Size(762, 264);
            this.dgvDanhSachCongNo.TabIndex = 7;
            // 
            // lblXemBaoCao
            // 
            this.lblXemBaoCao.AutoSize = true;
            this.lblXemBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.lblXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblXemBaoCao.ForeColor = System.Drawing.Color.Black;
            this.lblXemBaoCao.ImageKey = "(none)";
            this.lblXemBaoCao.Location = new System.Drawing.Point(242, 23);
            this.lblXemBaoCao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXemBaoCao.Name = "lblXemBaoCao";
            this.lblXemBaoCao.Size = new System.Drawing.Size(351, 38);
            this.lblXemBaoCao.TabIndex = 8;
            this.lblXemBaoCao.Text = "BÁO CÁO CÔNG NỢ";
            // 
            // btnTroVe
            // 
            this.btnTroVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTroVe.Location = new System.Drawing.Point(692, 442);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(107, 36);
            this.btnTroVe.TabIndex = 9;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Transparent;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXem.Location = new System.Drawing.Point(536, 87);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(107, 36);
            this.btnXem.TabIndex = 11;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpThoiGian.CustomFormat = "MM/yyyy";
            this.dtpThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(180, 90);
            this.dtpThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(299, 26);
            this.dtpThoiGian.TabIndex = 10;
            // 
            // fXemBaoCaoCongNo
            // 
            this.AcceptButton = this.btnXem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTroVe;
            this.ClientSize = new System.Drawing.Size(830, 491);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.dgvDanhSachCongNo);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.lblXemBaoCao);
            this.Name = "fXemBaoCaoCongNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem báo cáo công nợ";
            this.Load += new System.EventHandler(this.fXemBaoCaoCongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCongNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachCongNo;
        private System.Windows.Forms.Label lblXemBaoCao;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
    }
}