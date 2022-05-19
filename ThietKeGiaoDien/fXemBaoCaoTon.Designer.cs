
namespace ThietKeGiaoDien
{
    partial class fXemBaoCaoTon
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
            this.lblXemBaoCao = new System.Windows.Forms.Label();
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
            // lblXemBaoCao
            // 
            this.lblXemBaoCao.AutoSize = true;
            this.lblXemBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.lblXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemBaoCao.ForeColor = System.Drawing.Color.Black;
            this.lblXemBaoCao.ImageKey = "(none)";
            this.lblXemBaoCao.Location = new System.Drawing.Point(252, 101);
            this.lblXemBaoCao.Name = "lblXemBaoCao";
            this.lblXemBaoCao.Size = new System.Drawing.Size(282, 31);
            this.lblXemBaoCao.TabIndex = 6;
            this.lblXemBaoCao.Text = "XEM BÁO CÁO TỒN";
            this.lblXemBaoCao.Click += new System.EventHandler(this.lblXemBaoCao_Click);
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
            this.dgvDanhSachTon.Location = new System.Drawing.Point(128, 180);
            this.dgvDanhSachTon.Name = "dgvDanhSachTon";
            this.dgvDanhSachTon.Size = new System.Drawing.Size(545, 150);
            this.dgvDanhSachTon.TabIndex = 7;
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
            this.btnTroVe.Location = new System.Drawing.Point(676, 410);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(68, 28);
            this.btnTroVe.TabIndex = 8;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // fXemBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ThietKeGiaoDien.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dgvDanhSachTon);
            this.Controls.Add(this.lblXemBaoCao);
            this.Name = "fXemBaoCaoTon";
            this.Text = "fXemBaoCaoTon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXemBaoCao;
        private System.Windows.Forms.DataGridView dgvDanhSachTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTonDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTonCuoi;
        private System.Windows.Forms.Button btnTroVe;
    }
}