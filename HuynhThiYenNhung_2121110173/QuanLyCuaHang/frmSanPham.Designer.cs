namespace QuanLyCuaHang
{
    partial class frmSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new Guna.UI.WinForms.GunaTileButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImages = new Guna.UI.WinForms.GunaButton();
            this.picbImg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCategory = new Guna.UI.WinForms.GunaComboBox();
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnCapnhat = new Guna.UI.WinForms.GunaButton();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTensp = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMasp = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.dgvDSSanpham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbImg)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 425);
            this.panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = null;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(52, 52);
            this.btnTimKiem.Location = new System.Drawing.Point(670, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Radius = 5;
            this.btnTimKiem.Size = new System.Drawing.Size(88, 31);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnImages);
            this.panel3.Controls.Add(this.picbImg);
            this.panel3.Location = new System.Drawing.Point(659, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 355);
            this.panel3.TabIndex = 4;
            // 
            // btnImages
            // 
            this.btnImages.AnimationHoverSpeed = 0.07F;
            this.btnImages.AnimationSpeed = 0.03F;
            this.btnImages.BackColor = System.Drawing.Color.Transparent;
            this.btnImages.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnImages.BorderColor = System.Drawing.Color.Black;
            this.btnImages.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImages.FocusedColor = System.Drawing.Color.Empty;
            this.btnImages.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImages.ForeColor = System.Drawing.Color.Black;
            this.btnImages.Image = null;
            this.btnImages.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImages.Location = new System.Drawing.Point(92, 216);
            this.btnImages.Name = "btnImages";
            this.btnImages.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnImages.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImages.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImages.OnHoverImage = null;
            this.btnImages.OnPressedColor = System.Drawing.Color.Black;
            this.btnImages.Radius = 10;
            this.btnImages.Size = new System.Drawing.Size(160, 42);
            this.btnImages.TabIndex = 1;
            this.btnImages.Text = "Chọn ảnh";
            this.btnImages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // picbImg
            // 
            this.picbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbImg.Location = new System.Drawing.Point(57, 18);
            this.picbImg.Name = "picbImg";
            this.picbImg.Size = new System.Drawing.Size(235, 180);
            this.picbImg.TabIndex = 0;
            this.picbImg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnCapnhat);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTensp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMasp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 355);
            this.panel2.TabIndex = 3;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BaseColor = System.Drawing.Color.White;
            this.cbCategory.BorderColor = System.Drawing.Color.LightGray;
            this.cbCategory.BorderSize = 1;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(138, 109);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbCategory.Radius = 10;
            this.cbCategory.Size = new System.Drawing.Size(210, 31);
            this.cbCategory.TabIndex = 3;
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
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = null;
            this.btnLuu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(531, 301);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Radius = 5;
            this.btnLuu.Size = new System.Drawing.Size(86, 35);
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
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = null;
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(368, 301);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 5;
            this.btnXoa.Size = new System.Drawing.Size(86, 35);
            this.btnXoa.TabIndex = 2;
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
            this.btnCapnhat.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapnhat.Image = null;
            this.btnCapnhat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCapnhat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCapnhat.Location = new System.Drawing.Point(200, 301);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCapnhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapnhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapnhat.OnHoverImage = null;
            this.btnCapnhat.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapnhat.Radius = 5;
            this.btnCapnhat.Size = new System.Drawing.Size(86, 35);
            this.btnCapnhat.TabIndex = 2;
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
            this.btnThem.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = null;
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(37, 301);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Radius = 5;
            this.btnThem.Size = new System.Drawing.Size(86, 35);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantity.BaseColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.LightGray;
            this.txtQuantity.BorderSize = 1;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.Location = new System.Drawing.Point(449, 71);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.Radius = 10;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(165, 30);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = " 0";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.LightGray;
            this.txtPrice.BorderSize = 1;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(449, 18);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.Radius = 10;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(165, 30);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Text = " 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = " Giá";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BaseColor = System.Drawing.Color.White;
            this.txtDescription.BorderColor = System.Drawing.Color.LightGray;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(138, 161);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.Radius = 10;
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(427, 118);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục";
            // 
            // txtTensp
            // 
            this.txtTensp.BackColor = System.Drawing.Color.Transparent;
            this.txtTensp.BaseColor = System.Drawing.Color.White;
            this.txtTensp.BorderColor = System.Drawing.Color.LightGray;
            this.txtTensp.BorderSize = 1;
            this.txtTensp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTensp.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTensp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTensp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTensp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTensp.Location = new System.Drawing.Point(138, 63);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.PasswordChar = '\0';
            this.txtTensp.Radius = 10;
            this.txtTensp.SelectedText = "";
            this.txtTensp.Size = new System.Drawing.Size(210, 30);
            this.txtTensp.TabIndex = 1;
            this.txtTensp.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtMasp
            // 
            this.txtMasp.BackColor = System.Drawing.Color.Transparent;
            this.txtMasp.BaseColor = System.Drawing.Color.White;
            this.txtMasp.BorderColor = System.Drawing.Color.LightGray;
            this.txtMasp.BorderSize = 1;
            this.txtMasp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMasp.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMasp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMasp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMasp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMasp.Location = new System.Drawing.Point(138, 18);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.PasswordChar = '\0';
            this.txtMasp.Radius = 10;
            this.txtMasp.SelectedText = "";
            this.txtMasp.Size = new System.Drawing.Size(210, 30);
            this.txtMasp.TabIndex = 1;
            this.txtMasp.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(301, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 5;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(363, 38);
            this.txtSearch.TabIndex = 2;
            // 
            // dgvDSSanpham
            // 
            this.dgvDSSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSanpham.Location = new System.Drawing.Point(3, 23);
            this.dgvDSSanpham.Name = "dgvDSSanpham";
            this.dgvDSSanpham.RowHeadersWidth = 51;
            this.dgvDSSanpham.RowTemplate.Height = 24;
            this.dgvDSSanpham.Size = new System.Drawing.Size(1046, 215);
            this.dgvDSSanpham.TabIndex = 0;
            this.dgvDSSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSanpham_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.dgvDSSanpham);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 656);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSanPham";
            this.Text = "Quản lý sản phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPham_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSanPham_FormClosed);
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picbImg;
        private Guna.UI.WinForms.GunaButton btnThem;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtTensp;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtMasp;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cbCategory;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private System.Windows.Forms.DataGridView dgvDSSanpham;
        private Guna.UI.WinForms.GunaButton btnLuu;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnCapnhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton btnImages;
        private Guna.UI.WinForms.GunaTileButton btnTimKiem;
    }
}