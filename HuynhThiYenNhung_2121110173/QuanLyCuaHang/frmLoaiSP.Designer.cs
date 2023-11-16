namespace QuanLyCuaHang
{
    partial class frmLoaiSP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.txtTenLoai = new Guna.UI.WinForms.GunaTextBox();
            this.txtMaLoai = new Guna.UI.WinForms.GunaTextBox();
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnCapNhat = new Guna.UI.WinForms.GunaButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSLoai = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại sp";
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderColor = System.Drawing.Color.LightGray;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = null;
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(126, 323);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Radius = 12;
            this.btnThem.Size = new System.Drawing.Size(108, 43);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.txtTenLoai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtMaLoai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 394);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiem.BaseColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderColor = System.Drawing.Color.LightGray;
            this.txtTimKiem.BorderSize = 1;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTimKiem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Location = new System.Drawing.Point(283, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.Radius = 10;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(282, 37);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.Text = "Tìm kiếm...";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BackColor = System.Drawing.Color.Transparent;
            this.txtTenLoai.BaseColor = System.Drawing.Color.White;
            this.txtTenLoai.BorderColor = System.Drawing.Color.LightGray;
            this.txtTenLoai.BorderSize = 1;
            this.txtTenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoai.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenLoai.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenLoai.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenLoai.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Location = new System.Drawing.Point(136, 134);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.PasswordChar = '\0';
            this.txtTenLoai.Radius = 10;
            this.txtTenLoai.SelectedText = "";
            this.txtTenLoai.Size = new System.Drawing.Size(224, 32);
            this.txtTenLoai.TabIndex = 3;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.BackColor = System.Drawing.Color.Transparent;
            this.txtMaLoai.BaseColor = System.Drawing.Color.White;
            this.txtMaLoai.BorderColor = System.Drawing.Color.LightGray;
            this.txtMaLoai.BorderSize = 1;
            this.txtMaLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLoai.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaLoai.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaLoai.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaLoai.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.Location = new System.Drawing.Point(136, 74);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.PasswordChar = '\0';
            this.txtMaLoai.Radius = 10;
            this.txtMaLoai.SelectedText = "";
            this.txtMaLoai.Size = new System.Drawing.Size(160, 32);
            this.txtMaLoai.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderColor = System.Drawing.Color.LightGray;
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = null;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(621, 323);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Radius = 12;
            this.btnLuu.Size = new System.Drawing.Size(108, 43);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderColor = System.Drawing.Color.LightGray;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = null;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(452, 323);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 12;
            this.btnXoa.Size = new System.Drawing.Size(108, 43);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AnimationHoverSpeed = 0.07F;
            this.btnCapNhat.AnimationSpeed = 0.03F;
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderColor = System.Drawing.Color.LightGray;
            this.btnCapNhat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapNhat.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Image = null;
            this.btnCapNhat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCapNhat.Location = new System.Drawing.Point(283, 323);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCapNhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapNhat.OnHoverImage = null;
            this.btnCapNhat.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapNhat.Radius = 12;
            this.btnCapNhat.Size = new System.Drawing.Size(108, 43);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSLoai);
            this.groupBox1.Location = new System.Drawing.Point(397, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 229);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách loại sản phẩm";
            // 
            // dgvDSLoai
            // 
            this.dgvDSLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLoai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLoai.Location = new System.Drawing.Point(6, 19);
            this.dgvDSLoai.Name = "dgvDSLoai";
            this.dgvDSLoai.RowHeadersWidth = 51;
            this.dgvDSLoai.RowTemplate.Height = 24;
            this.dgvDSLoai.Size = new System.Drawing.Size(451, 204);
            this.dgvDSLoai.TabIndex = 0;
            this.dgvDSLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLoai_CellContentClick);
            // 
            // frmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 392);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLoaiSP";
            this.Text = "Loại Sản Phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLoaiSP_FormClosed);
            this.Load += new System.EventHandler(this.frmLoaiSP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnThem;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox txtTenLoai;
        private Guna.UI.WinForms.GunaTextBox txtMaLoai;
        private Guna.UI.WinForms.GunaButton btnLuu;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnCapNhat;
        private Guna.UI.WinForms.GunaTextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSLoai;
    }
}