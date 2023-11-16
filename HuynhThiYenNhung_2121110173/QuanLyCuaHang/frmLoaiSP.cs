using QuanLyCuaHang.DAO;
using QuanLyCuaHang.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frmLoaiSP : Form
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        private string AddOrEdit = null;
        int rowindex = -1;
        int categoryId = -1;

        public frmLoaiSP()
        {
            InitializeComponent();
        }
        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            loadCategory();
        }
        private void loadCategory()
        {
            dgvDSLoai.DataSource = categoryDAO.layDanhSachCat();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Add";
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Edit";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenLoai.Text))
                {
                    MessageBox.Show("Vui lòng điền loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AddOrEdit == "Add")
                {
                    Category newcat = new Category();
                    newcat.name = txtTenLoai.Text;
                    //Thêm
                    if (categoryDAO.CheckCategoryExists(newcat.id))
                    {
                        MessageBox.Show("Mã loại sản phẩm đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    categoryDAO.ThemMauTin(newcat);
                    MessageBox.Show("Loại sản phẩm đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (AddOrEdit == "Edit")
                {
                    int id = categoryId;
                    Category categoryUpdate = categoryDAO.GetDB().Categories.Find(id);//kt tồn tại của lsp
                    if (categoryUpdate != null)
                    {
                        categoryUpdate.name = txtTenLoai.Text;
                        categoryDAO.CapnhatMauTin(categoryUpdate);
                        MessageBox.Show("Loại sản phẩm đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                loadCategory();
                dgvDSLoai.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông báo", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaLoai.Text))
                {
                    throw new Exception("Chưa chọn loại sản phẩm!");
                }
                int categoryId = int.Parse(txtMaLoai.Text);
                Category category = categoryDAO.getRow(categoryId);
                if (category != null)
                {
                    DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        CategoryDAO.Delete(category);
                        MessageBox.Show("Đã xóa loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadCategory();

                    }
                }
                else
                {
                    MessageBox.Show("loại sản phẩm không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvDSLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex >= 0 && rowindex < dgvDSLoai.Rows.Count - 1)
            {
                DataGridViewRow row = dgvDSLoai.Rows[e.RowIndex];
                if (row.Cells["Id"].Value != null)
                {
                    int selectedId;
                    if (int.TryParse(row.Cells["Id"].Value.ToString(), out selectedId))
                    {
                        Category selectedCategory = categoryDAO.getRow(selectedId);
                        txtMaLoai.Text = selectedCategory.id.ToString();
                        txtTenLoai.Text = selectedCategory.name;
                        categoryId = selectedId;
                    }
                }

            }
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void frmLoaiSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không!", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
