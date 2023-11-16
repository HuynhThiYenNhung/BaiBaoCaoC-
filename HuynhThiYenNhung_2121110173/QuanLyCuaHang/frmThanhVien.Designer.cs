namespace QuanLyCuaHang
{
    partial class frmThanhVien
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
            this.dgvThongTinUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnCapnhat = new Guna.UI.WinForms.GunaButton();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinUser
            // 
            this.dgvThongTinUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvThongTinUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinUser.Location = new System.Drawing.Point(8, 206);
            this.dgvThongTinUser.Name = "dgvThongTinUser";
            this.dgvThongTinUser.RowHeadersWidth = 51;
            this.dgvThongTinUser.RowTemplate.Height = 24;
            this.dgvThongTinUser.Size = new System.Drawing.Size(1164, 180);
            this.dgvThongTinUser.TabIndex = 4;
            this.dgvThongTinUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinUser_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(487, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông Tin User";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnCapnhat);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(-5, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 131);
            this.panel2.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = null;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.Location = new System.Drawing.Point(837, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.HotPink;
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(110, 45);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLuu
            // 
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = null;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(682, 65);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.HotPink;
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Size = new System.Drawing.Size(110, 45);
            this.btnLuu.TabIndex = 0;
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
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = null;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(517, 65);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.HotPink;
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(110, 45);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.AnimationHoverSpeed = 0.07F;
            this.btnCapnhat.AnimationSpeed = 0.03F;
            this.btnCapnhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapnhat.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapnhat.BorderColor = System.Drawing.Color.Black;
            this.btnCapnhat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapnhat.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapnhat.Image = null;
            this.btnCapnhat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCapnhat.Location = new System.Drawing.Point(363, 65);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.OnHoverBaseColor = System.Drawing.Color.HotPink;
            this.btnCapnhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapnhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapnhat.OnHoverImage = null;
            this.btnCapnhat.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapnhat.Size = new System.Drawing.Size(110, 45);
            this.btnCapnhat.TabIndex = 0;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = null;
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(210, 65);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.HotPink;
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(110, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(637, 17);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(183, 27);
            this.txtSearch.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRole);
            this.groupBox1.Controls.Add(this.cbgender);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgvThongTinUser);
            this.groupBox1.Controls.Add(this.txtDOB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSĐT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-5, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 392);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(956, 137);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(171, 29);
            this.cbRole.TabIndex = 16;
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Location = new System.Drawing.Point(956, 73);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(148, 29);
            this.cbgender.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(889, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Vai trò";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(377, 139);
            this.txtDOB.Multiline = true;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(170, 27);
            this.txtDOB.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(869, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày sinh";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(688, 139);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(174, 27);
            this.txtUsername.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tên tài khoản";
            // 
            // txtSĐT
            // 
            this.txtSĐT.Location = new System.Drawing.Point(665, 75);
            this.txtSĐT.Multiline = true;
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(171, 27);
            this.txtSĐT.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(376, 81);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 27);
            this.txtEmail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 139);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(148, 27);
            this.txtAddress.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Địa chỉ";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(102, 81);
            this.txtHoten.Multiline = true;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(148, 27);
            this.txtHoten.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, -9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 19);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 27);
            this.txtID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // frmThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1163, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "frmThanhVien";
            this.Text = "QUẢN LÝ USER";
            this.Load += new System.EventHandler(this.frmThanhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvThongTinUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaButton btnLuu;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnCapnhat;
        private Guna.UI.WinForms.GunaButton btnThem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label11;
    }
}