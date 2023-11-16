using QuanLyCuaHang.DAO;
using QuanLyCuaHang.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace QuanLyCuaHang
{
    public partial class frmDangNhap : Form
    {
        QLBanhangContext db = new QLBanhangContext();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }
            CheckLogin(username, password);
        }

        private void CheckLogin(string username, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.username == username);
            if (user != null)
            {
                if (user.password == password)
                {
                    this.Hide();
                    new frmMain().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng");
                }
            }
            //if (user != null && BCrypt.Net.BCrypt.Verify(password, user.password))
            
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }

        }

        private void llblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản trị viên qua số điện thoại: 0921 949 085 \n(để được hỗ trợ)!", "Quên mật khẩu?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?", "Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
