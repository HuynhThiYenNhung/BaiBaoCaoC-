using QuanLyCuaHang.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.DAO
{
    internal class ChiTietHoaDonDAO
    {
        private QLBanhangContext db = new QLBanhangContext();
        public List<ReceiptDetail> GetList()
        {
            return db.ReceiptDetails.ToList();
        }
        public List<ReceiptDetail> GetProductsInReceiptDetail()
        {
            var query = from rd in db.ReceiptDetails
                        join p in db.Products on rd.ProductId equals p.id
                        select new
                        {
                            rd.MaCTHD,
                            rd.ProductId,
                            p.name,
                            p.price,
                            //rd.Count,
                            //p.Discount
                            //!= null ? (decimal)p.Discount : 0m,
                        };

            List<ReceiptDetail> resultList = new List<ReceiptDetail>();
            foreach (var item in query)
            {
                ReceiptDetail receiptDetail = new ReceiptDetail
                {
                    MaCTHD = item.MaCTHD,
                    ProductId = item.ProductId,
                    ProductName = item.name,
                    Price = item.price,
                    //Count = item.Count,
                    //Discount = item.Discount ?? 0m
                };

                resultList.Add(receiptDetail);
            }

            return resultList;
        }


        public ReceiptDetail getRow(int MaCTHD)
        {
            return db.ReceiptDetails.Find(MaCTHD);
        }
        public int getCount()
        {
            return db.ReceiptDetails.Count();
        }
        public void Insert(ReceiptDetail receiptDetail)
        {
            int? count = receiptDetail.Count ?? 0;
            decimal? discount = receiptDetail.Discount ?? 0m;
            ReceiptDetail entity = new ReceiptDetail
            {
                MaCTHD = receiptDetail.MaCTHD,
                ProductId = receiptDetail.ProductId,
                ProductName = receiptDetail.ProductName,
                Price = 0.0,
                Count = count,
                Discount = discount,
            };
            db.ReceiptDetails.Add(entity);
            db.SaveChanges();
        }
        public void Update(ReceiptDetail receiptDetail)
        {
            db.Entry(receiptDetail).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }





    }
}
