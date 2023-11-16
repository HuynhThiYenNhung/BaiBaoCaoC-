using QuanLyCuaHang.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.DAO
{
    internal class CategoryDAO
    {
        private QLBanhangContext db = new QLBanhangContext();
        //Truy vấn trả về DataTable
        public DataTable layDanhSachCat()
        {
            var query = from p in db.Categories select p;
            List<Category> categoryList = query.ToList();
            DataTable dataTable = ConvertToDataTable(categoryList);// Chuyển danh sách sản phẩm sang DataTable (Nếu cần)
            return dataTable;
        }

        private DataTable ConvertToDataTable(List<Category> categoryList)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Loại sp", typeof(string));
            foreach (var category in categoryList)
            {
                dataTable.Rows.Add(category.id, category.name);
            }

            return dataTable;
        }
        public QLBanhangContext GetDB()
        {
            return db;
        }
        public List<Category> LoadCboLoai()
        {
            return db.Categories.ToList<Category>();
        }
        public Category getRow(int categoryId)
        {
            return db.Categories.Find(categoryId);
        }

        public void ThemMauTin(Category cat)
        {
            db.Categories.Add(cat);
            db.SaveChanges();
        }
        public void CapnhatMauTin(Category categoryUpdate)
        {
            db.Entry(categoryUpdate).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public static void Delete(Category category)
        {
            using (var db = new QLBanhangContext())
            {
                Category existingCategory = db.Categories.Find(category.id);
                if (existingCategory != null)
                {
                    db.Categories.Remove(existingCategory);
                    db.SaveChanges();
                }
            }

        }
        public bool CheckCategoryExists(int categoryId)
        {
            using (QLBanhangContext db = new QLBanhangContext())
            {
                var existingCategory = db.Categories.FirstOrDefault(p => p.id == categoryId);
                // Nếu sản phẩm tồn tại, ID bị trùng
                if (existingCategory != null)
                {
                    return true; // ID bị trùng
                }

                return false; // ID không bị trùng
            }
        }
    }
}
