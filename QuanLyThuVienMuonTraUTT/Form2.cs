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
            pnlHome.Visible = true;
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
    }
}
