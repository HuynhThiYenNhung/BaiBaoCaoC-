using QuanLyCuaHang.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.DAO
{   
    internal class HoaDonDAO
    {
        QLBanhangContext db = new QLBanhangContext();
        public List<Receipt> getList()
        {
            return db.Receipts.ToList();
        }
        public Receipt getRow (int MaHD)
        {
            return db.Receipts.Find(MaHD);
        }
        public void Insert (Receipt receipt)
        {
            db.Receipts.Add(receipt);
            db.SaveChanges();
        }
        public void Update (Receipt receipt)
        {
            db.Entry(receipt).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete( Receipt receipt)
        {
            db.Receipts.Remove(receipt);
            db.SaveChanges();
        }
        public void Delete (int MaHD)
        {
            Receipt receipt = db.Receipts.Find(MaHD);
            db.Receipts.Remove(receipt);
            db.SaveChanges();
        }
    }
}
