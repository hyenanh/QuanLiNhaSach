
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bNhap = new System.Windows.Forms.Button();
            this.bTroVe = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lPhieuNhapSach = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lNgayNhap = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gBNhapSach = new System.Windows.Forms.GroupBox();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBNhapSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // bNhap
            // 
            this.bNhap.Location = new System.Drawing.Point(28, 11);
            this.bNhap.Name = "bNhap";
            this.bNhap.Size = new System.Drawing.Size(75, 23);
            this.bNhap.TabIndex = 1;
            this.bNhap.Text = "Thêm Mới";
            this.bNhap.UseVisualStyleBackColor = true;
            // 
            // bTroVe
            // 
            this.bTroVe.Location = new System.Drawing.Point(139, 11);
            this.bTroVe.Name = "bTroVe";
            this.bTroVe.Size = new System.Drawing.Size(75, 23);
            this.bTroVe.TabIndex = 1;
            this.bTroVe.Text = "Trở Về";
            this.bTroVe.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bNhap);
            this.panel3.Controls.Add(this.bTroVe);
            this.panel3.Location = new System.Drawing.Point(568, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 42);
            this.panel3.TabIndex = 2;
            // 
            // lPhieuNhapSach
            // 
            this.lPhieuNhapSach.AutoSize = true;
            this.lPhieuNhapSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPhieuNhapSach.Location = new System.Drawing.Point(270, 9);
            this.lPhieuNhapSach.Name = "lPhieuNhapSach";
            this.lPhieuNhapSach.Size = new System.Drawing.Size(279, 31);
            this.lPhieuNhapSach.TabIndex = 0;
            this.lPhieuNhapSach.Text = "PHIẾU NHẬP SÁCH";
            this.lPhieuNhapSach.Click += new System.EventHandler(this.lPhieuNhapSach_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lNgayNhap);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(224, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 42);
            this.panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lNgayNhap
            // 
            this.lNgayNhap.AutoSize = true;
            this.lNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNgayNhap.Location = new System.Drawing.Point(25, 13);
            this.lNgayNhap.Name = "lNgayNhap";
            this.lNgayNhap.Size = new System.Drawing.Size(87, 16);
            this.lNgayNhap.TabIndex = 1;
            this.lNgayNhap.Text = "Ngày nhập:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clSach,
            this.clTheLoai,
            this.clTacGia,
            this.clSoLuong,
            this.clDonGiaNhap});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 278);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gBNhapSach
            // 
            this.gBNhapSach.Controls.Add(this.dataGridView1);
            this.gBNhapSach.Location = new System.Drawing.Point(12, 90);
            this.gBNhapSach.Name = "gBNhapSach";
            this.gBNhapSach.Size = new System.Drawing.Size(776, 285);
            this.gBNhapSach.TabIndex = 5;
            this.gBNhapSach.TabStop = false;
            // 
            // clSTT
            // 
            this.clSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.clSTT.DefaultCellStyle = dataGridViewCellStyle3;
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.Width = 53;
            // 
            // clSach
            // 
            this.clSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSach.DefaultCellStyle = dataGridViewCellStyle4;
            this.clSach.HeaderText = "Sách";
            this.clSach.Name = "clSach";
            this.clSach.Width = 57;
            // 
            // clTheLoai
            // 
            this.clTheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clTheLoai.HeaderText = "Thể Loại";
            this.clTheLoai.Name = "clTheLoai";
            this.clTheLoai.Width = 74;
            // 
            // clTacGia
            // 
            this.clTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clTacGia.HeaderText = "Tác Giả";
            this.clTacGia.Name = "clTacGia";
            this.clTacGia.Width = 70;
            // 
            // clSoLuong
            // 
            this.clSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.Width = 78;
            // 
            // clDonGiaNhap
            // 
            this.clDonGiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clDonGiaNhap.HeaderText = "Đơn Giá Nhập";
            this.clDonGiaNhap.Name = "clDonGiaNhap";
            // 
            // fNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.gBNhapSach);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lPhieuNhapSach);
            this.Name = "fNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fNhapSach";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBNhapSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bNhap;
        private System.Windows.Forms.Button bTroVe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lPhieuNhapSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lNgayNhap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gBNhapSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGiaNhap;
    }
}