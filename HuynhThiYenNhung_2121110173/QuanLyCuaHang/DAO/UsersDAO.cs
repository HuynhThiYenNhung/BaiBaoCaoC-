using QuanLyCuaHang.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.DAO
{
    internal class UsersDAO
    {
        private KetNoi data = new KetNoi();
        QLBanhangContext db = new QLBanhangContext();
        public DataTable layDanhSach()
        {
            var query = from p in db.Users select p;
            List<User> userList = query.ToList();
            DataTable dataTable = ConvertToDataTable(userList);// Chuyển danh sách thành viên sang DataTable (Nếu cần)
            return dataTable;
        }
        private DataTable ConvertToDataTable(List<User> userList)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Họ tên", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Điện thoại", typeof(string));
            dataTable.Columns.Add("Ngày sinh", typeof(DateTime));
            dataTable.Columns.Add("Giới tính", typeof(string));
            dataTable.Columns.Add("Địa chỉ", typeof(string));
            dataTable.Columns.Add("Role", typeof(string));
            dataTable.Columns.Add("username", typeof(string));

            foreach (var user in userList)
            {
                
                dataTable.Rows.Add(user.id, user.hoten, user.email, user.tel, user.DOB, user.gender, user.address, user.userRole, user.username);
            }
            return dataTable;
        }
        public User getRow(int id)
        {
            return db.Users.Find(id);
        }
        public List<User> LoadCboGender()
        {
            return db.Users.ToList<User>();
        }
        public void Insert(User u)
        {
            if (CheckUserExists(u.id))
            {
                throw new Exception("Mã thành viên đã tồn tại");
            }
            db.Users.Add(u);
            db.SaveChanges();
        }
        public void Update(User userUpdate)
        {
            db.Entry(userUpdate).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public static void Delete(User user)
        {
            using (var db = new QLBanhangContext())
            {
                User existingUser = db.Users.Find(user.id);
                if (existingUser != null)
                {
                    db.Users.Remove(existingUser);
                    db.SaveChanges();
                }
            }

        }
        public bool CheckUserExists(int userId)
        {
            using (QLBanhangContext db = new QLBanhangContext())
            {
                var existingUser = db.Users.FirstOrDefault(p => p.id == userId);
                if (existingUser != null)
                {
                    return true; // ID bị trùng
                }

                return false; // ID không bị trùng
            }
        }
    }
}
