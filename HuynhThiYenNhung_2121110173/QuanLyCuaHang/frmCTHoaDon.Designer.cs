namespace QuanLyCuaHang
{
    partial class frmCTHoaDon
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPrice = new System.Windows.Forms.ComboBox();
            this.cbNamePr = new System.Windows.Forms.ComboBox();
            this.cbMasp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHĐ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.btnXuatHĐ = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.dgvDSHoaDon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(995, 451);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPrice);
            this.groupBox1.Controls.Add(this.cbNamePr);
            this.groupBox1.Controls.Add(this.cbMasp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaHĐ);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbPrice
            // 
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Location = new System.Drawing.Point(768, 96);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(161, 24);
            this.cbPrice.TabIndex = 2;
            // 
            // cbNamePr
            // 
            this.cbNamePr.FormattingEnabled = true;
            this.cbNamePr.Location = new System.Drawing.Point(441, 96);
            this.cbNamePr.Name = "cbNamePr";
            this.cbNamePr.Size = new System.Drawing.Size(161, 24);
            this.cbNamePr.TabIndex = 2;
            // 
            // cbMasp
            // 
            this.cbMasp.FormattingEnabled = true;
            this.cbMasp.Location = new System.Drawing.Point(90, 103);
            this.cbMasp.Name = "cbMasp";
            this.cbMasp.Size = new System.Drawing.Size(161, 24);
            this.cbMasp.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(685, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn giá";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(442, 154);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(160, 26);
            this.txtDiscount.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giảm giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên sản phẩm";
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(91, 161);
            this.txtCount.Multiline = true;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(160, 26);
            this.txtCount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sp";
            // 
            // txtMaHĐ
            // 
            this.txtMaHĐ.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHĐ.Location = new System.Drawing.Point(91, 39);
            this.txtMaHĐ.Multiline = true;
            this.txtMaHĐ.Name = "txtMaHĐ";
            this.txtMaHĐ.Size = new System.Drawing.Size(160, 26);
            this.txtMaHĐ.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐ";
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Location = new System.Drawing.Point(3, 234);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.RowHeadersWidth = 51;
            this.dgvDSHoaDon.RowTemplate.Height = 24;
            this.dgvDSHoaDon.Size = new System.Drawing.Size(963, 211);
            this.dgvDSHoaDon.TabIndex = 1;
            this.dgvDSHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHoaDon_CellContentClick);
            // 
            // btnXuatHĐ
            // 
            this.btnXuatHĐ.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnXuatHĐ.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHĐ.Location = new System.Drawing.Point(96, 521);
            this.btnXuatHĐ.Name = "btnXuatHĐ";
            this.btnXuatHĐ.Size = new System.Drawing.Size(112, 41);
            this.btnXuatHĐ.TabIndex = 1;
            this.btnXuatHĐ.Text = "Xuất HĐ";
            this.btnXuatHĐ.UseVisualStyleBackColor = false;
            this.btnXuatHĐ.Click += new System.EventHandler(this.btnXuatHĐ_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(687, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(786, 474);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(160, 26);
            this.txtThanhTien.TabIndex = 1;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapnhat.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(244, 521);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(112, 41);
            this.btnCapnhat.TabIndex = 1;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(396, 521);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 41);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnThanhtoan.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.Location = new System.Drawing.Point(545, 521);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(133, 41);
            this.btnThanhtoan.TabIndex = 1;
            this.btnThanhtoan.Text = "Thanh Toán";
            this.btnThanhtoan.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(713, 521);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 41);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // frmCTHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(965, 595);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXuatHĐ);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmCTHoaDon";
            this.Text = "frmCTHoaDon";
            this.Load += new System.EventHandler(this.frmCTHoaDon_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHĐ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.Button btnXuatHĐ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbNamePr;
        private System.Windows.Forms.ComboBox cbMasp;
        private System.Windows.Forms.ComboBox cbPrice;
    }
}