using QuanLyCuaHang.DAO;
using QuanLyCuaHang.EF;
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

    public partial class frmCTHoaDon : Form
    {
        ChiTietHoaDonDAO chiTietHoaDonDAO = new ChiTietHoaDonDAO();
        ProductDAO ProductDAO = new ProductDAO();
        int rowindex = -1;
        public frmCTHoaDon()
        {
            InitializeComponent();
        }
        private void frmCTHoaDon_Load(object sender, EventArgs e)
        {
            txtCount.KeyPress += new KeyPressEventHandler(txtCount_KeyPress);//nhập từ bàn phím
            txtDiscount.KeyPress += new KeyPressEventHandler(txtDiscount_KeyPress);
            loadProduct();
            loadCTHoaDon();
            cbNamePr.Enabled = true;
        }
        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void loadCTHoaDon()
        {
            dgvDSHoaDon.DataSource = chiTietHoaDonDAO.GetProductsInReceiptDetail();
        }
        private void loadProduct()
        {
            List<Product> products = ProductDAO.LoadCboMasp();
            products.Sort((x, y) => x.name.CompareTo(y.name));//sắp xếp tên sp
            cbMasp.DataSource = products;
            cbMasp.DisplayMember = "id"; // Hiển thị id sản phẩm
            cbMasp.ValueMember = "id";
            cbNamePr.DataSource = products;
            cbNamePr.DisplayMember = "name"; // Hiển thị tên sản phẩm
            cbNamePr.ValueMember = "id";
            cbPrice.DataSource = products; //hiển thị giá sản phẩm
            cbPrice.DisplayMember = "price";
            cbPrice.ValueMember = "id";

        }
        private void btnXuatHĐ_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbMasp.Text) && cbNamePr.SelectedValue != null)
                {
                    int ProductId;
                    if (int.TryParse(cbMasp.SelectedValue.ToString(), out ProductId))
                    {
                        if (!string.IsNullOrEmpty(txtCount.Text) && !string.IsNullOrEmpty(txtDiscount.Text))
                        {
                            int Count, Discount;
                            if (int.TryParse(txtCount.Text, out Count) && int.TryParse(txtDiscount.Text, out Discount))
                            {
                                ReceiptDetail newReceiptDetail = new ReceiptDetail
                                {
                                    ProductId = ProductId,
                                    Count = Count,
                                    Discount = Discount
                                };
                                //chiTietHoaDonDAO.Insert(newReceiptDetail);
                                DataGridViewRow newRow = new DataGridViewRow();
                                dgvDSHoaDon.Rows.Add(
                                 newReceiptDetail.MaCTHD,
                                 newReceiptDetail.ProductId,
                                 newReceiptDetail.ProductName,
                                 newReceiptDetail.Price,
                                 newReceiptDetail.Count,
                                 newReceiptDetail.Discount
                                
                                );

                                chiTietHoaDonDAO.Insert(newReceiptDetail);
                                MessageBox.Show("Xuất hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Số lượng và giảm giá phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số lượng và giảm giá phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadCTHoaDon();
                dgvDSHoaDon.Refresh();
            }


            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }

        private void dgvDSHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 && rowindex < dgvDSHoaDon.Rows.Count - 1)
            {
                ReceiptDetail selectedReceiptDetail = (ReceiptDetail)dgvDSHoaDon.Rows[rowindex].DataBoundItem;
                txtMaHĐ.Text = selectedReceiptDetail.MaCTHD.ToString();
                cbMasp.SelectedValue = selectedReceiptDetail.ProductId;
                cbNamePr.SelectedValue = selectedReceiptDetail.ProductName;
                cbPrice.SelectedValue = selectedReceiptDetail.Price;
                txtCount.Text = selectedReceiptDetail.Count.ToString();
                txtDiscount.Text = selectedReceiptDetail.Discount.ToString();
            }
            btnCapnhat.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
