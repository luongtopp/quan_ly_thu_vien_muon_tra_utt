using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyThuVienMuonTraUTT
{
    public partial class frmDangNhap : Form
    {
        public static string UserName = "";
        string strCon = @"Data Source=TXT;Initial Catalog=QuanLyMuonTraSach;Integrated Security=True";
        SqlConnection sqlCon = null;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void openSQL()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.Close();
                Program.th.Start();
                openSQL();

                if (txtEmailSDT.Text == "Email hoặc số điện thoại")
                {
                    MessageBox.Show("Vui lòng nhập ô tài khoản!", "Thông báo!");
                    txtEmailSDT.Focus();
                    return;
                }
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập ô mật khẩu!", "Thông báo!");
                    txtMatKhau.Focus();
                    return;
                }
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("@Email", txtEmailSDT.Text);
                cmd.Parameters.AddWithValue("@SDT", txtEmailSDT.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                cmd.Connection = sqlCon;

                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 1)
                {



                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo!");

                }
                sqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Thông báo!");
            }
        }



        private void txtEmailSDT_Enter(object sender, EventArgs e)
        {
            if (txtEmailSDT.Text == "Email hoặc số điện thoại")
            {
                txtEmailSDT.Text = "";
            }
        }

        private void txtEmailSDT_Leave(object sender, EventArgs e)
        {

            if (txtEmailSDT.Text == "")
            {
                txtEmailSDT.Text = "Email hoặc số điện thoại";
                txtEmailSDT.ForeColor = Color.Gray;

            }
        }

        private void txtEmailSDT_Click(object sender, EventArgs e)
        {
           
            txtEmailSDT.ForeColor = Color.Black;

        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

       

       

       
    }
}
