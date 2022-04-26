
namespace QuanLiNhaSach
{
    partial class fTheLoai
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
            this.dGvTheLoai = new System.Windows.Forms.DataGridView();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTheLoai = new System.Windows.Forms.Label();
            this.tbTheLoai = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gBTheLoai = new System.Windows.Forms.GroupBox();
            this.btTroVe = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGvTheLoai)).BeginInit();
            this.panel1.SuspendLayout();
            this.gBTheLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGvTheLoai
            // 
            this.dGvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGvTheLoai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTL,
            this.TheLoai});
            this.dGvTheLoai.Location = new System.Drawing.Point(11, 11);
            this.dGvTheLoai.Name = "dGvTheLoai";
            this.dGvTheLoai.Size = new System.Drawing.Size(401, 132);
            this.dGvTheLoai.TabIndex = 0;
            this.dGvTheLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaTL
            // 
            this.MaTL.HeaderText = "Mã Thể Loại";
            this.MaTL.Name = "MaTL";
            this.MaTL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MaTL.Width = 92;
            // 
            // TheLoai
            // 
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Width = 74;
            // 
            // lTheLoai
            // 
            this.lTheLoai.AutoSize = true;
            this.lTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTheLoai.Location = new System.Drawing.Point(3, 16);
            this.lTheLoai.Name = "lTheLoai";
            this.lTheLoai.Size = new System.Drawing.Size(61, 13);
            this.lTheLoai.TabIndex = 1;
            this.lTheLoai.Text = "Thể Loại:";
            this.lTheLoai.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbTheLoai
            // 
            this.tbTheLoai.Location = new System.Drawing.Point(83, 13);
            this.tbTheLoai.Name = "tbTheLoai";
            this.tbTheLoai.Size = new System.Drawing.Size(203, 20);
            this.tbTheLoai.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lTheLoai);
            this.panel1.Controls.Add(this.tbTheLoai);
            this.panel1.Location = new System.Drawing.Point(12, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 55);
            this.panel1.TabIndex = 4;
            // 
            // gBTheLoai
            // 
            this.gBTheLoai.Controls.Add(this.dGvTheLoai);
            this.gBTheLoai.Location = new System.Drawing.Point(1, 1);
            this.gBTheLoai.Name = "gBTheLoai";
            this.gBTheLoai.Size = new System.Drawing.Size(427, 159);
            this.gBTheLoai.TabIndex = 6;
            this.gBTheLoai.TabStop = false;
            this.gBTheLoai.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btTroVe
            // 
            this.btTroVe.Location = new System.Drawing.Point(326, 246);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(75, 23);
            this.btTroVe.TabIndex = 5;
            this.btTroVe.Text = "Trở Về";
            this.btTroVe.UseVisualStyleBackColor = true;
            this.btTroVe.Click += new System.EventHandler(this.button1_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(326, 187);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // fTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 279);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.gBTheLoai);
            this.Controls.Add(this.panel1);
            this.Name = "fTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thể Loại";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGvTheLoai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBTheLoai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGvTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.Label lTheLoai;
        private System.Windows.Forms.TextBox tbTheLoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gBTheLoai;
        private System.Windows.Forms.Button btTroVe;
        private System.Windows.Forms.Button btThem;
    }
}

