﻿namespace QLNS_GiaodienSach
{
    partial class fDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDoiMatKhau));
            this.cbHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txbNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.txbTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbHienThiMatKhau
            // 
            this.cbHienThiMatKhau.AutoSize = true;
            this.cbHienThiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.cbHienThiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHienThiMatKhau.Location = new System.Drawing.Point(400, 166);
            this.cbHienThiMatKhau.Name = "cbHienThiMatKhau";
            this.cbHienThiMatKhau.Size = new System.Drawing.Size(162, 24);
            this.cbHienThiMatKhau.TabIndex = 20;
            this.cbHienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.cbHienThiMatKhau.UseVisualStyleBackColor = false;
            this.cbHienThiMatKhau.CheckedChanged += new System.EventHandler(this.cbHienThiMatKhau_CheckedChanged);
            // 
            // btnTroVe
            // 
            this.btnTroVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTroVe.Location = new System.Drawing.Point(455, 196);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(107, 36);
            this.btnTroVe.TabIndex = 19;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Location = new System.Drawing.Point(337, 196);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(107, 36);
            this.btnCapNhat.TabIndex = 18;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txbNhapLaiMatKhau
            // 
            this.txbNhapLaiMatKhau.Location = new System.Drawing.Point(260, 121);
            this.txbNhapLaiMatKhau.Name = "txbNhapLaiMatKhau";
            this.txbNhapLaiMatKhau.PasswordChar = '●';
            this.txbNhapLaiMatKhau.Size = new System.Drawing.Size(302, 22);
            this.txbNhapLaiMatKhau.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // txbMatKhauMoi
            // 
            this.txbMatKhauMoi.Location = new System.Drawing.Point(260, 70);
            this.txbMatKhauMoi.Name = "txbMatKhauMoi";
            this.txbMatKhauMoi.PasswordChar = '●';
            this.txbMatKhauMoi.Size = new System.Drawing.Size(302, 22);
            this.txbMatKhauMoi.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txbMatKhauHienTai
            // 
            this.txbMatKhauHienTai.Location = new System.Drawing.Point(260, 19);
            this.txbMatKhauHienTai.Name = "txbMatKhauHienTai";
            this.txbMatKhauHienTai.PasswordChar = '●';
            this.txbMatKhauHienTai.Size = new System.Drawing.Size(302, 22);
            this.txbMatKhauHienTai.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mật khẩu hiện tại:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbHienThiMatKhau);
            this.panel1.Controls.Add(this.btnTroVe);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.txbNhapLaiMatKhau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbMatKhauMoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbMatKhauHienTai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 245);
            this.panel1.TabIndex = 21;
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTaiKhoan.Location = new System.Drawing.Point(375, 21);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(81, 20);
            this.lbTaiKhoan.TabIndex = 22;
            this.lbTaiKhoan.Text = "Tài khoản";
            // 
            // txbTenTaiKhoan
            // 
            this.txbTenTaiKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txbTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTenTaiKhoan.Location = new System.Drawing.Point(474, 19);
            this.txbTenTaiKhoan.Name = "txbTenTaiKhoan";
            this.txbTenTaiKhoan.ReadOnly = true;
            this.txbTenTaiKhoan.Size = new System.Drawing.Size(132, 27);
            this.txbTenTaiKhoan.TabIndex = 23;
            // 
            // fDoiMatKhau
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnTroVe;
            this.ClientSize = new System.Drawing.Size(618, 316);
            this.Controls.Add(this.txbTenTaiKhoan);
            this.Controls.Add(this.lbTaiKhoan);
            this.Controls.Add(this.panel1);
            this.Name = "fDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHienThiMatKhau;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txbNhapLaiMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMatKhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMatKhauHienTai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.TextBox txbTenTaiKhoan;
    }
}