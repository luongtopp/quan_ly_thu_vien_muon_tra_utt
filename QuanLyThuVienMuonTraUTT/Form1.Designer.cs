namespace QuanLyThuVienMuonTraUTT
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.chkHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.txtEmailSDT = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.chkHienThiMatKhau);
            this.panel1.Controls.Add(this.txtEmailSDT);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.lblMatKhau);
            this.panel1.Controls.Add(this.txtTaiKhoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 450);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Controls.Add(this.lblDangNhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(541, 154);
            this.panel2.TabIndex = 7;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::QuanLyThuVienMuonTraUTT.Properties.Resources._1447346931LOGO_GTVT;
            this.picLogo.Location = new System.Drawing.Point(7, 7);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(527, 79);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblDangNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(50)))));
            this.lblDangNhap.Location = new System.Drawing.Point(7, 86);
            this.lblDangNhap.Margin = new System.Windows.Forms.Padding(0);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(527, 61);
            this.lblDangNhap.TabIndex = 6;
            this.lblDangNhap.Text = "Đăng nhập";
            this.lblDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkHienThiMatKhau
            // 
            this.chkHienThiMatKhau.AutoSize = true;
            this.chkHienThiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(50)))));
            this.chkHienThiMatKhau.Location = new System.Drawing.Point(205, 261);
            this.chkHienThiMatKhau.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.chkHienThiMatKhau.Name = "chkHienThiMatKhau";
            this.chkHienThiMatKhau.Size = new System.Drawing.Size(130, 20);
            this.chkHienThiMatKhau.TabIndex = 6;
            this.chkHienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.chkHienThiMatKhau.UseVisualStyleBackColor = true;
            this.chkHienThiMatKhau.CheckedChanged += new System.EventHandler(this.chkHienThiMatKhau_CheckedChanged);
            // 
            // txtEmailSDT
            // 
            this.txtEmailSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailSDT.ForeColor = System.Drawing.Color.Gray;
            this.txtEmailSDT.Location = new System.Drawing.Point(205, 191);
            this.txtEmailSDT.Margin = new System.Windows.Forms.Padding(3, 10, 50, 3);
            this.txtEmailSDT.Name = "txtEmailSDT";
            this.txtEmailSDT.Size = new System.Drawing.Size(233, 22);
            this.txtEmailSDT.TabIndex = 0;
            this.txtEmailSDT.TabStop = false;
            this.txtEmailSDT.Text = "Email hoặc số điện thoại";
            this.txtEmailSDT.TextChanged += new System.EventHandler(this.txtEmailSDT_Click);
            this.txtEmailSDT.MouseEnter += new System.EventHandler(this.txtEmailSDT_Enter);
            this.txtEmailSDT.MouseLeave += new System.EventHandler(this.txtEmailSDT_Leave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(50)))));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.Location = new System.Drawing.Point(205, 296);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(233, 40);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(205, 229);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 10, 50, 3);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(233, 22);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.TabStop = false;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(50)))));
            this.lblMatKhau.Location = new System.Drawing.Point(102, 229);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(61, 16);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AutoSize = true;
            this.txtTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(50)))));
            this.txtTaiKhoan.Location = new System.Drawing.Point(102, 194);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(67, 16);
            this.txtTaiKhoan.TabIndex = 3;
            this.txtTaiKhoan.Text = "Tài khoản";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.CheckBox chkHienThiMatKhau;
        private System.Windows.Forms.TextBox txtEmailSDT;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label txtTaiKhoan;
    }
}

