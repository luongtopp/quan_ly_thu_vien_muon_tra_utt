using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienMuonTraUTT
{
    public partial class frmNhaXuatBan_DanhMuc : Form
    {
        public frmNhaXuatBan_DanhMuc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pnlNhap.Visible = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnlNhap.Visible = false;

        }
    }
}
