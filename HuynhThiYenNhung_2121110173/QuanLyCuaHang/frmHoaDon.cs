using QuanLyCuaHang.DAO;
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
    public partial class frmHoaDon : Form
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadHoaDon();
        }
        public void loadHoaDon()
        {
            dgvDSHoadon.DataSource = hoaDonDAO.getList();
        }

        private void dgvDSHoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSHoadon.Rows.Count)
            {
                int index = e.RowIndex;

            }
        }
    }
}
