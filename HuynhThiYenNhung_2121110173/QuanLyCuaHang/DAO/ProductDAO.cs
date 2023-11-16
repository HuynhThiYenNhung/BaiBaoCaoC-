using QuanLyCuaHang.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Drawing;

namespace QuanLyCuaHang.DAO
{
    internal class ProductDAO
    {
        private QLBanhangContext db = new QLBanhangContext();
        public QLBanhangContext GetDB()
        {
            return db;
        }
        //Truy vấn trả về DataTable
        public DataTable layDanhSach()
        {
            var query = from p in db.Products select p;
            List<Product> productList = query.ToList();
            DataTable dataTable = ConvertToDataTable(productList);// Chuyển danh sách sản phẩm sang DataTable (Nếu cần)
            return dataTable;
        }
        private DataTable ConvertToDataTable(List<Product> productList)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mã sp", typeof(int));
            dataTable.Columns.Add("Tên sp", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("Giá", typeof(float));
            dataTable.Columns.Add("Mô tả", typeof(string));
            dataTable.Columns.Add("Loại sp", typeof(int));
            dataTable.Columns.Add("Hình ảnh", typeof(byte[]));

            foreach (var product in productList)
            {
                dataTable.Rows.Add(product.id, product.name, product.quantity, product.price, product.description, product.categoryId, product.img);
            }

            return dataTable;
        }
        public Product getRow(int productID)
        {
            return db.Products.Find(productID);
        }
        public int getCount()
        {
            return db.Products.Count();
        }
        public List<Product> LoadCboMasp()
        {
            return db.Products.ToList<Product>();
        }

        public void ThemMauTin(Product pr)
        {
            if (CheckProductExists(pr.id))
            {
                throw new Exception("Mã sản phẩm đã tồn tại trong CSDL.");
            }
            db.Products.Add(pr);
            db.SaveChanges();
        }
        public void CapnhatMauTin(Product productUpdate)
        {
            db.Entry(productUpdate).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public static void Delete(Product product)
        {
            using (var db = new QLBanhangContext())
            {
                Product existingProduct = db.Products.Find(product.id);
                if (existingProduct != null)
                {
                    db.Products.Remove(existingProduct);
                    db.SaveChanges(); 
                }
            }

        }
        public List<Product> TimKiemSanPham(int id, string name)
        {
            using (var context = new QLBanhangContext())
            {
                // Thực hiện tìm kiếm sản phẩm dựa trên mã sản phẩm và tên sản phẩm
                var query = context.Products.AsQueryable();

                if (id != 0)
                {
                    query = query.Where(p => p.id == id);
                }

                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(p => p.name.Contains(name));
                }


                return query.ToList();
            }
        }
        public bool CheckProductExists(int productId)
        {
            using (QLBanhangContext db = new QLBanhangContext())
            {
                var existingProduct = db.Products.FirstOrDefault(p => p.id == productId);
                // Nếu sản phẩm tồn tại, ID bị trùng
                if (existingProduct != null)
                {
                    return true; // ID bị trùng
                }

                return false; // ID không bị trùng
            }
        }
    }
}
