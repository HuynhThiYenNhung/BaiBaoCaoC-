using QuanLyCuaHang.DAO;
using QuanLyCuaHang.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCuaHang
{
    public partial class frmThanhVien : Form
    {
        string[] Role = { "Admin", "User", "Saler" };
        UsersDAO usersDAO = new UsersDAO();
        private string AddOrEdit = null;
        int rowindex = -1;

        public frmThanhVien()
        {
            InitializeComponent();
        }
        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            List<User> userList = usersDAO.LoadCboGender();
            var genderList = userList.Select(u => u.gender).Distinct().ToList();
            foreach (var gender in genderList)
            {
                cbgender.Items.Add(gender);
            }
            loadThanhVien();

        }
        private void loadThanhVien()
        {
            cbRole.DataSource = Role;
            cbRole.SelectedItem = 0;
            dgvThongTinUser.DataSource = usersDAO.layDanhSach();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Add";
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Edit";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtHoten.Text) ||
                    string.IsNullOrEmpty(txtSĐT.Text)
                    )
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Email không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Tên tài khoản không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbgender.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn giá trị", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //string gender = string.Empty;
                //if (cbgender.Text == "nam")
                //{
                //    gender = "Nam";
                //}
                //else if (cbgender.Text == "nữ")
                //{
                //    gender = "Nữ";
                //}
                if (cbRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn giá trị", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //lấy thông tin
                
                    User adduser = new User();
                    adduser.hoten = txtHoten.Text;
                    adduser.email = txtEmail.Text;
                    adduser.tel = txtSĐT.Text;
                    if (DateTime.TryParseExact(txtDOB.Text, "MM/DD/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dob))
                    {
                        adduser.DOB = dob;
                    }
                    else
                    {
                        MessageBox.Show("Ngày sinh không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    adduser.gender = cbgender.Text;
                    adduser.userRole = cbRole.Text;
                    adduser.username = txtUsername.Text;
                if (AddOrEdit == "Add")
                {
                    int userId = Convert.ToInt32(txtID.Text);
                    if (usersDAO.CheckUserExists(adduser.id))
                    {
                        MessageBox.Show("Mã thành viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    usersDAO.Insert(adduser);
                    MessageBox.Show("Thêm thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(AddOrEdit == "Edit")
                {
                    int userId = Convert.ToInt32(txtID.Text);
                    if(usersDAO.CheckUserExists(adduser.id))
                    {
                        MessageBox.Show("Không tìm thấy thành viên cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    usersDAO.Update(adduser);
                    MessageBox.Show("Cập nhật thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         
                }
                loadThanhVien();
                dgvThongTinUser.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông báo", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvThongTinUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex >= 0 && rowindex < dgvThongTinUser.Rows.Count - 1)
            {
                DataGridViewRow row = dgvThongTinUser.Rows[e.RowIndex];
                if (row.Cells["ID"].Value != null)
                {
                    int selectedId;
                    if (int.TryParse(row.Cells["ID"].Value.ToString(), out selectedId))
                    {
                        User selectedUser = usersDAO.getRow(selectedId);
                        txtID.Text = selectedId.ToString();
                        txtHoten.Text = selectedUser.hoten;
                        txtEmail.Text = selectedUser.email;
                        txtSĐT.Text = selectedUser.tel.ToString();
                        txtDOB.Text = selectedUser.DOB.ToString();
                        txtAddress.Text = selectedUser.address;
                        txtUsername.Text = selectedUser.username;
                    }

                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    throw new Exception("Chưa chọn thành viên!");
                }
                int id = int.Parse(txtID.Text);
                User user = usersDAO.getRow(id);
                if (user != null)
                {
                    DialogResult confirmation = MessageBox.Show("Bạn có muốn xóa thành viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        UsersDAO.Delete(user);
                        MessageBox.Show("Đã xóa thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadThanhVien();
                    }
                }
                else
                {
                    MessageBox.Show("thành viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
