using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.DAO
{
    internal class GetProductsInReceiptDetail
    {
        public int MaCTHD { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public decimal Discount { get; set; }
        public int Count { get; set; }
    }
}
