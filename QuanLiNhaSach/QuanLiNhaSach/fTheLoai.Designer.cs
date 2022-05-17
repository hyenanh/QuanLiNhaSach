
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTheLoai));
            this.dGvTheLoai = new System.Windows.Forms.DataGridView();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.txbTheLoai = new System.Windows.Forms.TextBox();
            this.pnThemTheLoai = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.gBTheLoai = new System.Windows.Forms.GroupBox();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGvTheLoai)).BeginInit();
            this.pnThemTheLoai.SuspendLayout();
            this.gBTheLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGvTheLoai
            // 
            this.dGvTheLoai.AllowUserToDeleteRows = false;
            this.dGvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGvTheLoai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGvTheLoai.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dGvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.theloai});
            this.dGvTheLoai.Location = new System.Drawing.Point(0, 0);
            this.dGvTheLoai.Name = "dGvTheLoai";
            this.dGvTheLoai.ReadOnly = true;
            this.dGvTheLoai.Size = new System.Drawing.Size(427, 161);
            this.dGvTheLoai.TabIndex = 0;
            this.dGvTheLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvTheLoai_CellContentClick);
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoSize = true;
            this.lbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheLoai.Location = new System.Drawing.Point(3, 16);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(61, 13);
            this.lbTheLoai.TabIndex = 1;
            this.lbTheLoai.Text = "Thể Loại:";
            // 
            // txbTheLoai
            // 
            this.txbTheLoai.Location = new System.Drawing.Point(70, 14);
            this.txbTheLoai.Name = "txbTheLoai";
            this.txbTheLoai.Size = new System.Drawing.Size(213, 20);
            this.txbTheLoai.TabIndex = 2;
            // 
            // pnThemTheLoai
            // 
            this.pnThemTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.pnThemTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnThemTheLoai.Controls.Add(this.lbTheLoai);
            this.pnThemTheLoai.Controls.Add(this.btnThem);
            this.pnThemTheLoai.Controls.Add(this.txbTheLoai);
            this.pnThemTheLoai.Location = new System.Drawing.Point(12, 166);
            this.pnThemTheLoai.Name = "pnThemTheLoai";
            this.pnThemTheLoai.Size = new System.Drawing.Size(299, 71);
            this.pnThemTheLoai.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(208, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_click);
            // 
            // gBTheLoai
            // 
            this.gBTheLoai.Controls.Add(this.dGvTheLoai);
            this.gBTheLoai.Location = new System.Drawing.Point(1, -1);
            this.gBTheLoai.Name = "gBTheLoai";
            this.gBTheLoai.Size = new System.Drawing.Size(427, 161);
            this.gBTheLoai.TabIndex = 6;
            this.gBTheLoai.TabStop = false;
            // 
            // btnTroVe
            // 
            this.btnTroVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTroVe.Location = new System.Drawing.Point(341, 207);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 5;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_click);
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Width = 53;
            // 
            // theloai
            // 
            this.theloai.HeaderText = "Thể loại";
            this.theloai.Name = "theloai";
            this.theloai.ReadOnly = true;
            this.theloai.Width = 70;
            // 
            // fTheLoai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnTroVe;
            this.ClientSize = new System.Drawing.Size(428, 242);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.gBTheLoai);
            this.Controls.Add(this.pnThemTheLoai);
            this.MaximizeBox = false;
            this.Name = "fTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thể Loại";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGvTheLoai)).EndInit();
            this.pnThemTheLoai.ResumeLayout(false);
            this.pnThemTheLoai.PerformLayout();
            this.gBTheLoai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGvTheLoai;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.TextBox txbTheLoai;
        private System.Windows.Forms.Panel pnThemTheLoai;
        private System.Windows.Forms.GroupBox gBTheLoai;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
    }
}

