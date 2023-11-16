namespace QuanLyCuaHang
{
    partial class frmQLNhaphang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSanpham = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDsp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhaphang = new System.Windows.Forms.DataGridView();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.btnCapnhat = new Guna.UI.WinForms.GunaButton();
            this.btnXuatExcel = new Guna.UI.WinForms.GunaButton();
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.dtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhaphang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgaynhap);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaphieu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(551, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(141, 272);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(222, 36);
            this.txtTongTien.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(141, 210);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhanVien.Multiline = true;
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(222, 36);
            this.txtNhanVien.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhân viên";
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(141, 151);
            this.txtNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNCC.Multiline = true;
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(222, 36);
            this.txtNCC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày nhập";
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Location = new System.Drawing.Point(141, 36);
            this.txtMaphieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaphieu.Multiline = true;
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.Size = new System.Drawing.Size(222, 36);
            this.txtMaphieu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtQuan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSanpham);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIDsp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(557, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(687, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(138, 276);
            this.txtSum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSum.Multiline = true;
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(191, 36);
            this.txtSum.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng tiền";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(138, 218);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(191, 36);
            this.txtPrice.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giá nhập";
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(138, 155);
            this.txtQuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuan.Multiline = true;
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(191, 36);
            this.txtQuan.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng";
            // 
            // txtSanpham
            // 
            this.txtSanpham.Location = new System.Drawing.Point(138, 96);
            this.txtSanpham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSanpham.Multiline = true;
            this.txtSanpham.Name = "txtSanpham";
            this.txtSanpham.Size = new System.Drawing.Size(191, 36);
            this.txtSanpham.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sản phẩm";
            // 
            // txtIDsp
            // 
            this.txtIDsp.Location = new System.Drawing.Point(138, 40);
            this.txtIDsp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDsp.Multiline = true;
            this.txtIDsp.Name = "txtIDsp";
            this.txtIDsp.Size = new System.Drawing.Size(191, 36);
            this.txtIDsp.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPhieuNhaphang);
            this.groupBox3.Location = new System.Drawing.Point(0, 461);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1244, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu nhập";
            // 
            // dgvPhieuNhaphang
            // 
            this.dgvPhieuNhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhaphang.Location = new System.Drawing.Point(6, 24);
            this.dgvPhieuNhaphang.Name = "dgvPhieuNhaphang";
            this.dgvPhieuNhaphang.RowHeadersWidth = 51;
            this.dgvPhieuNhaphang.RowTemplate.Height = 24;
            this.dgvPhieuNhaphang.Size = new System.Drawing.Size(1080, 160);
            this.dgvPhieuNhaphang.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = null;
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(184, 390);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Radius = 12;
            this.btnThem.Size = new System.Drawing.Size(82, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.AnimationHoverSpeed = 0.07F;
            this.btnCapnhat.AnimationSpeed = 0.03F;
            this.btnCapnhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapnhat.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnCapnhat.BorderColor = System.Drawing.Color.Black;
            this.btnCapnhat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapnhat.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapnhat.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.White;
            this.btnCapnhat.Image = null;
            this.btnCapnhat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCapnhat.Location = new System.Drawing.Point(332, 390);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCapnhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapnhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapnhat.OnHoverImage = null;
            this.btnCapnhat.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapnhat.Radius = 12;
            this.btnCapnhat.Size = new System.Drawing.Size(82, 35);
            this.btnCapnhat.TabIndex = 3;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.AnimationHoverSpeed = 0.07F;
            this.btnXuatExcel.AnimationSpeed = 0.03F;
            this.btnXuatExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnXuatExcel.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatExcel.BorderColor = System.Drawing.Color.Black;
            this.btnXuatExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXuatExcel.FocusedColor = System.Drawing.Color.Empty;
            this.btnXuatExcel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Image = null;
            this.btnXuatExcel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXuatExcel.Location = new System.Drawing.Point(626, 390);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXuatExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXuatExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.OnHoverImage = null;
            this.btnXuatExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnXuatExcel.Radius = 12;
            this.btnXuatExcel.Size = new System.Drawing.Size(90, 39);
            this.btnXuatExcel.TabIndex = 3;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLuu
            // 
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = null;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(481, 390);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Radius = 12;
            this.btnLuu.Size = new System.Drawing.Size(82, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThoat
            // 
            this.btnThoat.AnimationHoverSpeed = 0.07F;
            this.btnThoat.AnimationSpeed = 0.03F;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.FocusedColor = System.Drawing.Color.Empty;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = null;
            this.btnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThoat.Location = new System.Drawing.Point(784, 390);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Radius = 12;
            this.btnThoat.Size = new System.Drawing.Size(82, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtNgaynhap
            // 
            this.dtNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaynhap.Location = new System.Drawing.Point(141, 93);
            this.dtNgaynhap.Name = "dtNgaynhap";
            this.dtNgaynhap.Size = new System.Drawing.Size(222, 27);
            this.dtNgaynhap.TabIndex = 2;
            // 
            // frmQLNhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 647);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQLNhaphang";
            this.Text = "frmQLNhaphang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhaphang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSanpham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDsp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI.WinForms.GunaButton btnCapnhat;
        private Guna.UI.WinForms.GunaButton btnXuatExcel;
        private System.Windows.Forms.DataGridView dgvPhieuNhaphang;
        private Guna.UI.WinForms.GunaButton btnLuu;
        private Guna.UI.WinForms.GunaButton btnThoat;
        private System.Windows.Forms.DateTimePicker dtNgaynhap;
    }
}