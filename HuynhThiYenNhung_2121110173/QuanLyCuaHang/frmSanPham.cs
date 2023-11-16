using Guna.UI.WinForms;
using QuanLyCuaHang.DAO;
using QuanLyCuaHang.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCuaHang
{
    public partial class frmSanPham : Form
    {
        ProductDAO ProductDAO = new ProductDAO();
        CategoryDAO CategoryDAO = new CategoryDAO();
        private DataTable productsTable;
        private string AddOrEdit = null;
        private byte[] selectedImageBytes;
        //private int id;
        int rowindex = -1;
        public frmSanPham(DataTable productsTable)
        {
            InitializeComponent();
            this.productsTable = productsTable;
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            DataTable productsTable = ProductDAO.layDanhSach();
            dgvDSSanpham.DataSource = productsTable;
            loadCategory();
            loadProduct();
            txtMasp.Enabled = true;
        }

        private void loadProduct()
        {
            dgvDSSanpham.DataSource = ProductDAO.layDanhSach();
        }
        private void loadCategory()
        {
            List<Category> categories = CategoryDAO.LoadCboLoai();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "name"; // Hiển thị tên danh mục
            cbCategory.ValueMember = "id";

        }
        private void btnImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath = openFileDialog.FileName;
                    picbImg.Image = Image.FromFile(imagePath);
                    selectedImageBytes = File.ReadAllBytes(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                if (string.IsNullOrEmpty(txtTensp.Text) ||
                string.IsNullOrEmpty(txtQuantity.Text) ||
                string.IsNullOrEmpty(txtPrice.Text) ||
                string.IsNullOrEmpty(txtDescription.Text)
                )

                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txtMasp.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int productId  = Convert.ToInt32(txtMasp.Text);;
                if (!int.TryParse(txtMasp.Text, out productId) || productId <= 0)
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int quantity;
                if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float price;
                if (!float.TryParse(txtPrice.Text, out price) || price < 0)
                {
                    MessageBox.Show("Giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int categoryId;
                if (cbCategory.SelectedValue != null && int.TryParse(cbCategory.SelectedValue.ToString(), out categoryId))
                {
                    categoryId = (int)cbCategory.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Danh mục không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AddOrEdit == "Add")
                {
                    Product newPr = new Product();
                    newPr.id = productId;
                    newPr.name = txtTensp.Text;
                    newPr.quantity = int.Parse(txtQuantity.Text);
                    newPr.price = float.Parse(txtPrice.Text);
                    newPr.description = txtDescription.Text;
                    newPr.categoryId = categoryId;
                    newPr.img = selectedImageBytes;
                    //Thêm
                    if (ProductDAO.CheckProductExists(newPr.id))
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ProductDAO.ThemMauTin(newPr);
                    MessageBox.Show("Sản phẩm đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (AddOrEdit == "Edit")
                {
                    int id = productId; 
                    Product productUpdate = ProductDAO.GetDB().Products.Find(id);//kt tồn tại của sp
                    if (productUpdate != null)
                    {
                        productUpdate.name = txtTensp.Text;
                        productUpdate.quantity = int.Parse(txtQuantity.Text);
                        productUpdate.price = float.Parse(txtPrice.Text);
                        productUpdate.description = txtDescription.Text;
                        productUpdate.categoryId = categoryId;
                        productUpdate.img = selectedImageBytes;
                        //Cập nhật
                        ProductDAO.CapnhatMauTin(productUpdate);
                        MessageBox.Show("Sản phẩm đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                loadProduct();
                dgvDSSanpham.Refresh();

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
                if (string.IsNullOrEmpty(txtMasp.Text))
                {
                    throw new Exception("Chưa chọn sản phẩm!");
                }
                int productId = int.Parse(txtMasp.Text);
                Product Product = ProductDAO.getRow(productId);
                if (Product != null)
                {
                    DialogResult confirmation = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        ProductDAO.Delete(Product);
                        MessageBox.Show("Đã xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadProduct();
                    }
                }
                else
                {
                    MessageBox.Show("sản phẩm không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDSSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex >= 0 && rowindex < dgvDSSanpham.Rows.Count - 1)
            {
                DataGridViewRow row = dgvDSSanpham.Rows[e.RowIndex];
                if (row.Cells["Mã sp"].Value != null)
                {
                    int selectedId;
                    if (int.TryParse(row.Cells["Mã sp"].Value.ToString(), out selectedId))
                    {
                        Product selectedProduct = ProductDAO.getRow(selectedId);
                        txtMasp.Text = selectedProduct.id.ToString();
                        txtTensp.Text = selectedProduct.name; 
                        txtPrice.Text = selectedProduct.price.ToString();
                        txtQuantity.Text = selectedProduct.quantity.ToString();
                        txtDescription.Text = selectedProduct.description;
                        cbCategory.SelectedValue = selectedProduct.categoryId;
                        if (selectedProduct.img != null)
                        {
                            using (MemoryStream ms = new MemoryStream(selectedProduct.img))
                            {
                                picbImg.SizeMode = PictureBoxSizeMode.StretchImage;
                                picbImg.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }               

            }
            btnCapnhat.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void frmSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không!", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string input = txtSearch.Text;
            string name = txtTensp.Text;
            if (int.TryParse(input, out int number))
            {
                ProductDAO productDAO = new ProductDAO();
                List<Product> foundProducts = productDAO.TimKiemSanPham(number, string.Empty);
                if (foundProducts.Count > 0)
                {
                    dgvDSSanpham.DataSource = foundProducts;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm với ID hoặc tên đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                ProductDAO productDAO = new ProductDAO();
                List<Product> foundProducts = productDAO.TimKiemSanPham(0, input);

                if (foundProducts.Count > 0)
                {
                    dgvDSSanpham.DataSource = foundProducts;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm với tên đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }

}

