
namespace ThietKeGiaoDien
{
    partial class fNhapBaoCaoTon
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
            this.lblNhapBaoCao = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMaTonKho = new System.Windows.Forms.TextBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.dtbNam = new System.Windows.Forms.DateTimePicker();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhapBaoCao
            // 
            this.lblNhapBaoCao.AutoSize = true;
            this.lblNhapBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.lblNhapBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapBaoCao.ForeColor = System.Drawing.Color.Black;
            this.lblNhapBaoCao.ImageKey = "(none)";
            this.lblNhapBaoCao.Location = new System.Drawing.Point(236, 83);
            this.lblNhapBaoCao.Name = "lblNhapBaoCao";
            this.lblNhapBaoCao.Size = new System.Drawing.Size(301, 31);
            this.lblNhapBaoCao.TabIndex = 7;
            this.lblNhapBaoCao.Text = "NHẬP BÁO CÁO TỒN";
            this.lblNhapBaoCao.Click += new System.EventHandler(this.lblNhapBaoCao_Click);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(255, 159);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(88, 20);
            this.lblMa.TabIndex = 8;
            this.lblMa.Text = "Mã tồn kho";
            // 
            // txtMaTonKho
            // 
            this.txtMaTonKho.Location = new System.Drawing.Point(422, 159);
            this.txtMaTonKho.Name = "txtMaTonKho";
            this.txtMaTonKho.Size = new System.Drawing.Size(100, 20);
            this.txtMaTonKho.TabIndex = 9;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(255, 229);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(54, 20);
            this.lblThang.TabIndex = 10;
            this.lblThang.Text = "Thang";
            this.lblThang.Click += new System.EventHandler(this.lblThang_Click);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(255, 296);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(42, 20);
            this.lblNam.TabIndex = 11;
            this.lblNam.Text = "Nam";
            // 
            // dtbNam
            // 
            this.dtbNam.CustomFormat = "yyyy";
            this.dtbNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbNam.Location = new System.Drawing.Point(422, 295);
            this.dtbNam.Name = "dtbNam";
            this.dtbNam.Size = new System.Drawing.Size(100, 20);
            this.dtbNam.TabIndex = 13;
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM";
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(422, 229);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(100, 20);
            this.dtpThang.TabIndex = 14;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(658, 401);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(68, 28);
            this.btnTroVe.TabIndex = 15;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.Transparent;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(532, 401);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 28);
            this.btnChon.TabIndex = 16;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            // 
            // fNhapBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::ThietKeGiaoDien.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.dtbNam);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.txtMaTonKho);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblNhapBaoCao);
            this.Name = "fNhapBaoCaoTon";
            this.Text = "fNhapBaoCaoTon";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapBaoCao;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMaTonKho;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.DateTimePicker dtbNam;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnChon;
    }
}