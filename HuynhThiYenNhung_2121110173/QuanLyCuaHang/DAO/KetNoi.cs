using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.DAO
{
    internal class KetNoi
    {        
        public static string str = "Data Source=DESKTOP-4F58KTV\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(str);
                return connection;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
                return null;
            }
        }
    }
}
