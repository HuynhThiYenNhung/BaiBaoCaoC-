using QuanLyCuaHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frmMain : Form
    {
        //private static Users users = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        private void btnQLHoadon(object sender, EventArgs e)
        {
            Form frm = new frmHoaDon();
            frm.ShowDialog();
        }

        private void btnQLNhapHang_Click(object sender, EventArgs e)
        {
            Form frm = new frmQLNhaphang();
            frm.ShowDialog();
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            ProductDAO ProductDAO = new ProductDAO();
            DataTable productsTable = ProductDAO.layDanhSach();
            frmSanPham formSanpham = new frmSanPham(productsTable);
            //Form frm = new frmSanPham();
            formSanpham.ShowDialog();
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            Form frm = new frmLoaiSP();
            frm.ShowDialog();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Form frm = new frmCTHoaDon();
            frm.ShowDialog();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có muốn đăng xuất không?",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            if (result == DialogResult.Yes)
            {
                frmDangNhap frmDN = new frmDangNhap();
                this.Close();
                frmDN.ShowDialog();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnQLThanhVie_Click(object sender, EventArgs e)
        {
            Form frm = new frmThanhVien();
            frm.ShowDialog();
        }
    }
}
