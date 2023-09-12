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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void pnlDanhMuc_Click(object sender, EventArgs e)
        {
            
        }

        private void lblAnMenuSubDanhMuc_Click(object sender, EventArgs e)
        {
            pnlDanhMucCon.Visible = false;
            lblAnMenuSubDanhMuc.Visible = false;
            pnlDanhMucCha.BackColor = Color.Transparent;


        }
        private void lblMoSubMenuDanhMuc_Click(object sender, EventArgs e)
        {
            showPanel(1);
        }
      
        private void showPanel(int x)
        {
           


            switch (x)
            {
               
                case 1:
                    lblAnMenuSubDanhMuc.Visible = true;
                    lblAnMenuSubQuanLyKhoKe.Visible = false;
                    lblAnMenuSubQuanLyXuatNhap.Visible = false;
                    lblAnMenuSubQuanLyMuonTra.Visible = false;
                    lblAnMenuSubBaoCao.Visible = false;
                    lblAnMenuSubCaiDat.Visible = false;

                    pnlDanhMucCon.Visible= true;
                    pnlQuanLyKhoKeCon.Visible = false;
                    pnlQuanLyNhapXuatCon.Visible = false;
                    pnlQuanLyMuonTraCon.Visible = false;
                    pnlBaoCaoCon.Visible = false;
                    pnlCaiDatCon.Visible = false;

                    pnlDanhMucCha.BackColor = Color.FromArgb(252, 170, 50);
                    pnlQuanLyKhoKeCha.BackColor = Color.Transparent;
                    pnlQuanLyXuatNhapCha.BackColor = Color.Transparent;
                    pnlQuanLyMuonTraCha.BackColor = Color.Transparent;
                    pnlBaoCaoCha.BackColor = Color.Transparent;
                    pnlCaiDatCha.BackColor = Color.Transparent;

                    break;

                case 2:
                    lblAnMenuSubDanhMuc.Visible = false;
                    lblAnMenuSubQuanLyKhoKe.Visible = true;
                    lblAnMenuSubQuanLyXuatNhap.Visible = false;
                    lblAnMenuSubQuanLyMuonTra.Visible = false;
                    lblAnMenuSubBaoCao.Visible = false;
                    lblAnMenuSubCaiDat.Visible = false;

                    pnlDanhMucCon.Visible = false;
                    pnlQuanLyKhoKeCon.Visible = true;
                    pnlQuanLyNhapXuatCon.Visible = false;
                    pnlQuanLyMuonTraCon.Visible = false;
                    pnlBaoCaoCon.Visible = false;
                    pnlCaiDatCon.Visible = false;


                    pnlDanhMucCha.BackColor = Color.Transparent;
                    pnlQuanLyKhoKeCha.BackColor = Color.FromArgb(252, 170, 50);
                    pnlQuanLyXuatNhapCha.BackColor = Color.Transparent;
                    pnlQuanLyMuonTraCha.BackColor = Color.Transparent;
                    pnlBaoCaoCha.BackColor = Color.Transparent;
                    pnlCaiDatCha.BackColor = Color.Transparent;

                    break;

                case 3:
                    lblAnMenuSubDanhMuc.Visible = false;
                    lblAnMenuSubQuanLyKhoKe.Visible = false;
                    lblAnMenuSubQuanLyXuatNhap.Visible = true;
                    lblAnMenuSubQuanLyMuonTra.Visible = false;
                    lblAnMenuSubBaoCao.Visible = false;
                    lblAnMenuSubCaiDat.Visible = false;

                    pnlDanhMucCon.Visible = false;
                    pnlQuanLyKhoKeCon.Visible = false;
                    pnlQuanLyNhapXuatCon.Visible = true;
                    pnlQuanLyMuonTraCon.Visible = false;
                    pnlBaoCaoCon.Visible = false;
                    pnlCaiDatCon.Visible = false;


                    pnlDanhMucCha.BackColor = Color.Transparent;
                    pnlQuanLyKhoKeCha.BackColor = Color.Transparent;
                    pnlQuanLyXuatNhapCha.BackColor = Color.FromArgb(252, 170, 50);
                    pnlQuanLyMuonTraCha.BackColor = Color.Transparent;
                    pnlBaoCaoCha.BackColor = Color.Transparent;

                    break;

                case 4:
                    lblAnMenuSubDanhMuc.Visible = false;
                    lblAnMenuSubQuanLyKhoKe.Visible = false;
                    lblAnMenuSubQuanLyXuatNhap.Visible = false;
                    lblAnMenuSubQuanLyMuonTra.Visible = true;
                    lblAnMenuSubBaoCao.Visible = false;
                    lblAnMenuSubCaiDat.Visible = false;

                    pnlDanhMucCon.Visible = false;
                    pnlQuanLyKhoKeCon.Visible = false;
                    pnlQuanLyNhapXuatCon.Visible = false;
                    pnlQuanLyMuonTraCon.Visible = true;
                    pnlBaoCaoCon.Visible = false;
                    pnlCaiDatCon.Visible = false;


                    pnlDanhMucCha.BackColor = Color.Transparent;
                    pnlQuanLyKhoKeCha.BackColor = Color.Transparent;
                    pnlQuanLyXuatNhapCha.BackColor = Color.Transparent;
                    pnlQuanLyMuonTraCha.BackColor = Color.FromArgb(252, 170, 50);
                    pnlBaoCaoCha.BackColor = Color.Transparent;
                    pnlCaiDatCha.BackColor = Color.Transparent;

                    break;

                case 5:
                    lblAnMenuSubDanhMuc.Visible = false;
                    lblAnMenuSubQuanLyKhoKe.Visible = false;
                    lblAnMenuSubQuanLyXuatNhap.Visible = false;
                    lblAnMenuSubQuanLyMuonTra.Visible = false;
                    lblAnMenuSubBaoCao.Visible = true;
                    lblAnMenuSubCaiDat.Visible = false;

                    pnlDanhMucCon.Visible = false;
                    pnlQuanLyKhoKeCon.Visible = false;
                    pnlQuanLyNhapXuatCon.Visible = false;
                    pnlQuanLyMuonTraCon.Visible = false;
                    pnlBaoCaoCon.Visible = true;
                    pnlCaiDatCon.Visible = false;

                    pnlDanhMucCha.BackColor = Color.Transparent;
                    pnlQuanLyKhoKeCha.BackColor = Color.Transparent;
                    pnlQuanLyXuatNhapCha.BackColor = Color.Transparent;
                    pnlQuanLyMuonTraCha.BackColor = Color.Transparent;
                    pnlBaoCaoCha.BackColor = Color.FromArgb(252, 170, 50);
                    pnlCaiDatCha.BackColor = Color.Transparent;

                    break;

                case 6:
                    lblAnMenuSubDanhMuc.Visible = false;
                    lblAnMenuSubQuanLyKhoKe.Visible = false;
                    lblAnMenuSubQuanLyXuatNhap.Visible = false;
                    lblAnMenuSubQuanLyMuonTra.Visible = false;
                    lblAnMenuSubBaoCao.Visible = false;
                    lblAnMenuSubCaiDat.Visible = true;

                    pnlDanhMucCon.Visible = false;
                    pnlQuanLyKhoKeCon.Visible = false;
                    pnlQuanLyNhapXuatCon.Visible = false;
                    pnlQuanLyMuonTraCon.Visible = false;
                    pnlBaoCaoCon.Visible = false;
                    pnlCaiDatCon.Visible = true;

                    pnlDanhMucCha.BackColor = Color.Transparent;
                    pnlQuanLyKhoKeCha.BackColor = Color.Transparent;
                    pnlQuanLyXuatNhapCha.BackColor = Color.Transparent;
                    pnlQuanLyMuonTraCha.BackColor = Color.Transparent;
                    pnlBaoCaoCha.BackColor = Color.Transparent;
                    pnlCaiDatCha.BackColor = Color.FromArgb(252, 170, 50);

                    break;
            }
            lblMoMenuSubDanhMuc.Visible = true;
            lblMoMenuSubQuanLyKhoKe.Visible = true;
            lblMoMenuSubQuanLyXuatNhap.Visible = true;
            lblMoMenuSubQuanLyMuonTra.Visible = true;
            lblMoMenuSubBaoCao.Visible = true;
            lblMoMenuSubCaiDat.Visible = true;








        }

        private void lblAnMenuSubQuanLyKhoKe_Click(object sender, EventArgs e)
        {
            lblAnMenuSubQuanLyKhoKe.Visible = false;
            pnlQuanLyKhoKeCon.Visible=false;
            pnlQuanLyKhoKeCha.BackColor = Color.Transparent;

        }

        private void lblMoMenuSubQuanLyKhoKe_Click(object sender, EventArgs e)
        {
            showPanel(2);
        }

        private void lblAnMenuSubQuanLyXuatNhap_Click(object sender, EventArgs e)
        {
            lblAnMenuSubQuanLyXuatNhap.Visible = false;
            pnlQuanLyNhapXuatCon.Visible = false;
            pnlQuanLyXuatNhapCha.BackColor = Color.Transparent;

        }

        private void lblMoMenuSubQuanLyXuatNhap_Click(object sender, EventArgs e)
        {
            showPanel(3);

        }

        private void lblAnMenuSubQuanLyMuonTra_Click(object sender, EventArgs e)
        {
            lblAnMenuSubQuanLyMuonTra.Visible = false;
            pnlQuanLyMuonTraCon.Visible = false;
            pnlQuanLyMuonTraCha.BackColor = Color.Transparent;

        }

        private void lblMoMenuSubQuanLyMuonTra_Click(object sender, EventArgs e)
        {
            showPanel(4);

        }

        private void lblMoMenuSubBaoCao_Click(object sender, EventArgs e)
        {
            showPanel(5);

        }

        private void lblAnMenuSubBaoCao_Click(object sender, EventArgs e)
        {
            lblAnMenuSubBaoCao.Visible = false;
            pnlBaoCaoCon.Visible = false;
            pnlBaoCaoCha.BackColor = Color.Transparent;

        }

        private void lblLogoUTT_Click(object sender, EventArgs e)
        {
           
        }

        private void lblMoMenuSubCaiDat_Click(object sender, EventArgs e)
        {
            showPanel(6);

        }

        private void lblAnMenuSubCaiDat_Click(object sender, EventArgs e)
        {
            lblAnMenuSubCaiDat.Visible = false;
            pnlCaiDatCon.Visible = false;
            pnlCaiDatCha.BackColor = Color.Transparent;

        }
        private void lblSach_DanhMuc_Click(object sender, EventArgs e)
        {
            pnlSach_DanhMuc.Visible = true;
            pnlKhoaHoc_DanhMuc.Visible = false;
            pnlChuyenNganh_DanhMuc.Visible = false;
            pnlLopHoc_DanhMuc.Visible = false;
            pnlBanDoc_DanhMuc.Visible = false;
            pnlNhaXuatBan_DanhMuc.Visible = false;
            pnlNguonTaiLieu_DanhMuc.Visible = false;
            pnlLoaiLuuTru_DanhMuc.Visible = false;
            pnlTheLoai_DanhMuc.Visible = false;
            pnlTacGia_DanhMuc.Visible = false;
            pnlSach_DanhMuc.Visible = true;

            frmSach_DanhMuc frmSach = new frmSach_DanhMuc();
            frmSach.TopLevel = false;
            pnlSach_DanhMuc.Controls.Add(frmSach);
            frmSach.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmSach.Dock = DockStyle.Fill;
            frmSach.Show();
        }
        private void lblKhoaHoc_DanhMuc_Click(object sender, EventArgs e)
        {
            pnlSach_DanhMuc.Visible = false;
            pnlKhoaHoc_DanhMuc.Visible = true;
            pnlChuyenNganh_DanhMuc.Visible = false;
            pnlLopHoc_DanhMuc.Visible = false;
            pnlBanDoc_DanhMuc.Visible = false;
            pnlNhaXuatBan_DanhMuc.Visible = false;
            pnlNguonTaiLieu_DanhMuc.Visible = false;
            pnlLoaiLuuTru_DanhMuc.Visible = false;
            pnlTheLoai_DanhMuc.Visible = false;
            pnlTacGia_DanhMuc.Visible = false;


            frmKhoaHoc_DanhMuc frmKhoaHoc = new frmKhoaHoc_DanhMuc();
            frmKhoaHoc.TopLevel = false;
            pnlKhoaHoc_DanhMuc.Controls.Add(frmKhoaHoc);
            frmKhoaHoc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmKhoaHoc.Dock = DockStyle.Fill;
            frmKhoaHoc.Show();
        }

        private void lblChuyenNganh_DanhMuc_Click(object sender, EventArgs e)
        {
            pnlSach_DanhMuc.Visible = false;
            pnlKhoaHoc_DanhMuc.Visible = false;
            pnlChuyenNganh_DanhMuc.Visible = true;
            pnlLopHoc_DanhMuc.Visible = false;
            pnlBanDoc_DanhMuc.Visible = false;
            pnlNhaXuatBan_DanhMuc.Visible = false;
            pnlNguonTaiLieu_DanhMuc.Visible = false;
            pnlLoaiLuuTru_DanhMuc.Visible = false;
            pnlTheLoai_DanhMuc.Visible = false;
            pnlTacGia_DanhMuc.Visible = false;


            frmChuyenNganh_DanhMuc frmChuyenNganh = new frmChuyenNganh_DanhMuc();
            frmChuyenNganh.TopLevel = false;
            pnlChuyenNganh_DanhMuc.Controls.Add(frmChuyenNganh);
            frmChuyenNganh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmChuyenNganh.Dock = DockStyle.Fill;
            frmChuyenNganh.Show();
        }

        private void lblLopHoc_DanhMuc_Click(object sender, EventArgs e)
        {
            pnlSach_DanhMuc.Visible = false;
            pnlKhoaHoc_DanhMuc.Visible = false;
            pnlChuyenNganh_DanhMuc.Visible = false;
            pnlLopHoc_DanhMuc.Visible = true;
            pnlBanDoc_DanhMuc.Visible = false;
            pnlNhaXuatBan_DanhMuc.Visible = false;
            pnlNguonTaiLieu_DanhMuc.Visible = false;
            pnlLoaiLuuTru_DanhMuc.Visible = false;
            pnlTheLoai_DanhMuc.Visible = false;
            pnlTacGia_DanhMuc.Visible = false;


            frmLopHoc_DanhMuc frmLopHoc = new frmLopHoc_DanhMuc();
            frmLopHoc.TopLevel = false;
            pnlLopHoc_DanhMuc.Controls.Add(frmLopHoc);
            frmLopHoc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmLopHoc.Dock = DockStyle.Fill;
            frmLopHoc.Show();
        }

        private void lblBanDoc_DanhMuc_Click(object sender, EventArgs e)
        {
            pnlSach_DanhMuc.Visible = false;
            pnlKhoaHoc_DanhMuc.Visible = false;
            pnlChuyenNganh_DanhMuc.Visible = false;
            pnlLopHoc_DanhMuc.Visible = false;
            pnlBanDoc_DanhMuc.Visible = true;
            pnlNhaXuatBan_DanhMuc.Visible = false;
            pnlNguonTaiLieu_DanhMuc.Visible = false;
            pnlLoaiLuuTru_DanhMuc.Visible = false;
            pnlTheLoai_DanhMuc.Visible = false;
            pnlTacGia_DanhMuc.Visible = false;


            frmBanDoc_DanhMuc frmBanDoc = new frmBanDoc_DanhMuc();
            frmBanDoc.TopLevel = false;
            pnlBanDoc_DanhMuc.Controls.Add(frmBanDoc);
            frmBanDoc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmBanDoc.Dock = DockStyle.Fill;
            frmBanDoc.Show();
        }

        private void lblNhaXuatBan_DanhMuc_Click(object sender, EventArgs e)
        {
            pnlSach_DanhMuc.Visible = false;
            pnlKhoaHoc_DanhMuc.Visible = false;
            pnlChuyenNganh_DanhMuc.Visible = false;
            pnlLopHoc_DanhMuc.Visible = false;
            pnlBanDoc_DanhMuc.Visible = false;
            pnlNhaXuatBan_DanhMuc.Visible = true;
            pnlNguonTaiLieu_DanhMuc.Visible = false;
            pnlLoaiLuuTru_DanhMuc.Visible = false;
            pnlTheLoai_DanhMuc.Visible = false;
            pnlTacGia_DanhMuc.Visible = false;


            frmNhaXuatBan_DanhMuc frmNhaXuatBan = new frmNhaXuatBan_DanhMuc();
            frmNhaXuatBan.TopLevel = false;
            pnlNhaXuatBan_DanhMuc.Controls.Add(frmNhaXuatBan);
            frmNhaXuatBan.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmNhaXuatBan.Dock = DockStyle.Fill;
            frmNhaXuatBan.Show();
        }

        private void lblNguonTaiLieu_DanhMuc_Click(object sender, EventArgs e)
        {
            pnlSach_DanhMuc.Visible = false;
            pnlKhoaHoc_DanhMuc.Visible = false;
            pnlChuyenNganh_DanhMuc.Visible = false;
            pnlLopHoc_DanhMuc.Visible = false;
            pnlBanDoc_DanhMuc.Visible = false;
            pnlNhaXuatBan_DanhMuc.Visible = false;
            pnlNguonTaiLieu_DanhMuc.Visible = true;
            pnlLoaiLuuTru_DanhMuc.Visible = false;
            pnlTheLoai_DanhMuc.Visible = false;
            pnlTacGia_DanhMuc.Visible = false;


            frmNguonTaiLieu_DanhMuc frmNguonTaiLieu = new frmNguonTaiLieu_DanhMuc();
            frmNguonTaiLieu.TopLevel = false;
            pnlNguonTaiLieu_DanhMuc.Controls.Add(frmNguonTaiLieu);
            frmNguonTaiLieu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmNguonTaiLieu.Dock = DockStyle.Fill;
            frmNguonTaiLieu.Show();
        }

        private void lblLoaiLuuTru_DanhMuc_Click(object sender, EventArgs e)
        {
            pnlSach_DanhMuc.Visible = false;
            pnlKhoaHoc_DanhMuc.Visible = false;
            pnlChuyenNganh_DanhMuc.Visible = false;
            pnlLopHoc_DanhMuc.Visible = false;
            pnlBanDoc_DanhMuc.Visible = false;
            pnlNhaXuatBan_DanhMuc.Visible = false;
            pnlNguonTaiLieu_DanhMuc.Visible = false;
            pnlLoaiLuuTru_DanhMuc.Visible = true;
            pnlTheLoai_DanhMuc.Visible = false;
            pnlTacGia_DanhMuc.Visible = false;


            frmLoaiLuuTru_DanhMuc frmLoaiLuuTru = new frmLoaiLuuTru_DanhMuc();
            frmLoaiLuuTru.TopLevel = false;
            pnlLoaiLuuTru_DanhMuc.Controls.Add(frmLoaiLuuTru);
            frmLoaiLuuTru.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmLoaiLuuTru.Dock = DockStyle.Fill;
            frmLoaiLuuTru.Show();
        }

        private void lblTheLoai_DanhMuc_Click(object sender, EventArgs e)
        {
            pnlSach_DanhMuc.Visible = false;
            pnlKhoaHoc_DanhMuc.Visible = false;
            pnlChuyenNganh_DanhMuc.Visible = false;
            pnlLopHoc_DanhMuc.Visible = false;
            pnlBanDoc_DanhMuc.Visible = false;
            pnlNhaXuatBan_DanhMuc.Visible = false;
            pnlNguonTaiLieu_DanhMuc.Visible = false;
            pnlLoaiLuuTru_DanhMuc.Visible = false;
            pnlTheLoai_DanhMuc.Visible = true;
            pnlTacGia_DanhMuc.Visible = false;


            frmTheLoai_DanhMuc frmTheLoai = new frmTheLoai_DanhMuc();
            frmTheLoai.TopLevel = false;
            pnlTheLoai_DanhMuc.Controls.Add(frmTheLoai);
            frmTheLoai.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmTheLoai.Dock = DockStyle.Fill;
            frmTheLoai.Show();
        }

        private void lblTacGia_DanhMuc_Click(object sender, EventArgs e)
        {
            pnlSach_DanhMuc.Visible = false;
            pnlKhoaHoc_DanhMuc.Visible = false;
            pnlChuyenNganh_DanhMuc.Visible = false;
            pnlLopHoc_DanhMuc.Visible = false;
            pnlBanDoc_DanhMuc.Visible = false;
            pnlNhaXuatBan_DanhMuc.Visible = false;
            pnlNguonTaiLieu_DanhMuc.Visible = false;
            pnlLoaiLuuTru_DanhMuc.Visible = false;
            pnlTheLoai_DanhMuc.Visible = false;
            pnlTacGia_DanhMuc.Visible = true;


            frmTacGia_DanhMuc frmTacGia = new frmTacGia_DanhMuc();
            frmTacGia.TopLevel = false;
            pnlTacGia_DanhMuc.Controls.Add(frmTacGia);
            frmTacGia.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmTacGia.Dock = DockStyle.Fill;
            frmTacGia.Show();
        }

        private void lblSach_DanhMuc_MouseHover(object sender, EventArgs e)
        {
            lblSach_DanhMuc.BackColor = Color.FromArgb(255, 180, 50);
        }

        private void lblSach_DanhMuc_MouseLeave(object sender, EventArgs e)
        {
            lblSach_DanhMuc.BackColor = Color.Transparent;
        }

        private void lblKhoaHoc_DanhMuc_MouseHover(object sender, EventArgs e)
        {
            lblKhoaHoc_DanhMuc.BackColor = Color.FromArgb(255, 180, 50);

        }

        private void lblKhoaHoc_DanhMuc_MouseLeave(object sender, EventArgs e)
        {
            lblKhoaHoc_DanhMuc.BackColor = Color.Transparent;

        }

        private void lblChuyenNganh_DanhMuc_MouseHover(object sender, EventArgs e)
        {
            lblChuyenNganh_DanhMuc.BackColor = Color.FromArgb(255, 180, 50);

        }

        private void lblChuyenNganh_DanhMuc_MouseLeave(object sender, EventArgs e)
        {
            lblChuyenNganh_DanhMuc.BackColor = Color.Transparent;

        }

        private void lblLopHoc_DanhMuc_MouseHover(object sender, EventArgs e)
        {
            lblLopHoc_DanhMuc.BackColor = Color.FromArgb(255, 180, 50);

        }

        private void lblLopHoc_DanhMuc_MouseLeave(object sender, EventArgs e)
        {
            lblLopHoc_DanhMuc.BackColor = Color.Transparent;

        }

        private void lblBanDoc_DanhMuc_MouseHover(object sender, EventArgs e)
        {
            lblBanDoc_DanhMuc.BackColor = Color.FromArgb(255, 180, 50);

        }

        private void lblBanDoc_DanhMuc_MouseLeave(object sender, EventArgs e)
        {
            lblBanDoc_DanhMuc.BackColor = Color.Transparent;

        }

        private void lblNhaXuatBan_DanhMuc_MouseHover(object sender, EventArgs e)
        {
            lblNhaXuatBan_DanhMuc.BackColor = Color.FromArgb(255, 180, 50);

        }

        private void lblNhaXuatBan_DanhMuc_MouseLeave(object sender, EventArgs e)
        {
            lblNhaXuatBan_DanhMuc.BackColor = Color.Transparent;

        }

        private void lblNguonTaiLieu_DanhMuc_MouseHover(object sender, EventArgs e)
        {
            lblNguonTaiLieu_DanhMuc.BackColor = Color.FromArgb(255, 180, 50);

        }

        private void lblNguonTaiLieu_DanhMuc_MouseLeave(object sender, EventArgs e)
        {
            lblNguonTaiLieu_DanhMuc.BackColor = Color.Transparent;

        }

        private void lblLoaiLuuTru_DanhMuc_MouseHover(object sender, EventArgs e)
        {
            lblLoaiLuuTru_DanhMuc.BackColor = Color.FromArgb(255, 180, 50);

        }

        private void lblLoaiLuuTru_DanhMuc_MouseLeave(object sender, EventArgs e)
        {
            lblLoaiLuuTru_DanhMuc.BackColor = Color.Transparent;

        }

        private void lblTheLoai_DanhMuc_MouseHover(object sender, EventArgs e)
        {
            lblTheLoai_DanhMuc.BackColor = Color.FromArgb(255, 180, 50);

        }

        private void lblTheLoai_DanhMuc_MouseLeave(object sender, EventArgs e)
        {
            lblTheLoai_DanhMuc.BackColor = Color.Transparent;

        }

        private void lblTacGia_DanhMuc_MouseHover(object sender, EventArgs e)
        {
            lblTacGia_DanhMuc.BackColor = Color.FromArgb(255, 180, 50);

        }

        private void lblTacGia_DanhMuc_MouseLeave(object sender, EventArgs e)
        {
            lblTacGia_DanhMuc.BackColor = Color.Transparent;

        }
    }
}
