 
-- CHẠY NÓ XONG VÀO DIAGRAMS XEM CÓ LỖI J 0 NHÉ VÀ CẦN BỔ XUNG THÊM J THÌ AE CẬP NHẬT VÀO CODE NÀY LUÔN XONG CMT LẠI CHO T BIẾT
CREATE DATABASE QuanLyThuVienMuonTraUTT
GO

USE QuanLyThuVienMuonTraUTT
GO

-- DROP DATABASE QUANLYTHUVIENMUONTRAUTT

-- Lớp học
CREATE TABLE LopHoc
(
	[TenLop] NVARCHAR(50) NOT NULL,
	[MoTa] NVARCHAR(500),

	CONSTRAINT PK_LopHoc PRIMARY KEY(TENlOP),
)
-- DROP TABLE LopHoc

--Chuyên ngành
CREATE TABLE ChuyenNganh
(
	[TenChuyenNganh] NVARCHAR(50) NOT NULL,
	[MoTa] NVARCHAR(500),

	CONSTRAINT PK_ChuyenNganh PRIMARY KEY(TenChuyenNganh),

)
-- DROP TABLE ChuyenNganh

-- Khoá học
CREATE TABLE KhoaHoc
(
	[TenKhoaHoc] NVARCHAR(50) NOT NULL,
	[MoTa] NVARCHAR(500),
	
	CONSTRAINT PK_KhoaHoc PRIMARY KEY (TenKhoaHoc),
)
-- DROP TABLE KhoaHoc

-- Nhà xuất bản
CREATE TABLE NhaXuatBan
(
	[MaNhaXuatBan] VARCHAR(10) NOT NULL,
	[TenNhaXuatBan] NVARCHAR(50) NOT NULL UNIQUE,
	[DienThoai] VARCHAR(20) NOT NULL UNIQUE,
	[Email] VARCHAR(30) NOT NULL UNIQUE,
	[DiaChi] NVARCHAR(60) NOT NULL,
	[LienHe] NVARCHAR(100),
	[GhiChu] NVARCHAR(500),
	
	CONSTRAINT PK_NhaXuatBan PRIMARY KEY(MaNhaXuatBan),
)
-- DROP TABLE NhaXuatBan

--Nguồn Tài Liệu
CREATE TABLE NguonTaiLieu
(
	[TenNguonTaiLieu] NVARCHAR(50) NOT NULL,
	[MoTa] NVARCHAR(500),

	CONSTRAINT PK_NguonTaiLieu PRIMARY KEY(TenNguonTaiLieu),
)
-- DROP TABLE NguoiTaiLieu

-- Loại lưu trữ
CREATE TABLE LoaiLuuTru
(
	[TenLoaiLuuTru] NVARCHAR(50) NOT NULL,
	[MoTa] NVARCHAR(500),

	CONSTRAINT PK_LoaiLuuTru PRIMARY KEY(TenLoaiLuuTru),
)
-- DROP TABLE LoaiLuuTru

-- Thể loại
CREATE TABLE TheLoai
(
	[TenTheLoai] NVARCHAR(50) NOT NULL,
	[MoTa] NVARCHAR(500),

	CONSTRAINT PK_TheLoai PRIMARY KEY(TenTheLoai),
)
-- DROP TABLE TheLoai

-- Tác giả
CREATE TABLE TacGia
(
	[MaTacGia] varchar(10) NOT NULL,
	[TenTacGia] NVARCHAR(50) NOT NULL,
	[MoTa] NVARCHAR(500),

	CONSTRAINT PK_TacGia PRIMARY KEY(MaTacGia),
)
-- DROP TABLE TacGia

-- Kệ
CREATE TABLE Ke
(	
	[TenKe] NVARCHAR(30) NOT NULL,
	[MOTA] NVARCHAR(500),
	
	-- KHOÁ CHÍNH
	CONSTRAINT PK_Ke PRIMARY KEY(TenKe),
)
-- DROP TABLE Ke

-- Ngăn
CREATE TABLE Ngan
(	
	[TenNgan] NVARCHAR(30) NOT NULL,
	[MOTA] NVARCHAR(500),

	CONSTRAINT PK_Ngan PRIMARY KEY([TenNgan]),
	
	
)
-- DROP TABLE Ngan

-- Sách 
CREATE TABLE Sach
(
	[MaSach] VARCHAR(10) NOT NULL,
	[TenSach] NVARCHAR(50) NOT NULL,
	[TenChuyenNganh] NVARCHAR(50) NOT NULL,
	[TenKhoaHoc] NVARCHAR(50) NOT NULL,
	[TenTheLoai] NVARCHAR(50) NOT NULL,
	[MaTacGia] VARCHAR(10) NOT NULL,
	[MaNhaXuatBan] VARCHAR(10) NOT NULL,
	[TenNguonTaiLieu] NVARCHAR(50) NOT NULL,
	[TenLoaiLuuTru] NVARCHAR(50) NOT NULL,
	[TaiBan] INT NOT NULL,
	[NamXuatBan] DATETIME NOT NULL,
	[NgonNgu] NVARCHAR(50) NOT NULL,
	[TenKe] NVARCHAR(30) NOT NULL,
	[TenNgan] NVARCHAR(30) NOT NULL,
	[GiaBan] REAL NOT NULL,
	[GiaThue] REAL NOT NULL,
	[SoLuong] INT NOT NULL,
	[MoTa] NVARCHAR(500),

	-- Khoá chính
	CONSTRAINT PK_Sach PRIMARY KEY(MaSach),
	-- Khoá phụ
	CONSTRAINT FK_Sach_TenChuyeNganh FOREIGN KEY(TenChuyenNganh) REFERENCES ChuyenNganh(TenChuyenNganh),
	CONSTRAINT FK_Sach_TenKhoaHoc FOREIGN KEY(TenKhoaHoc) REFERENCES KhoaHoc(TenKhoaHoc),
	CONSTRAINT FK_Sach_TenTheLoai FOREIGN KEY(TenTheLoai) REFERENCES TheLoai(TenTheLoai),
	CONSTRAINT FK_Sach_MaTacGia FOREIGN KEY(MaTacGia) REFERENCES TacGia(MaTacGia),
	CONSTRAINT FK_Sach_MaNhaXuatBan FOREIGN KEY(MaNhaXuatBan) REFERENCES NhaXuatBan(MaNhaXuatBan),
	CONSTRAINT FK_Sach_TenNguonTaiLieu FOREIGN KEY(TenNguonTaiLieu) REFERENCES NguonTaiLieu(TenNguonTaiLieu),
	CONSTRAINT FK_Sach_TenLoaiLuuTru FOREIGN KEY(TenLoaiLuuTru) REFERENCES LoaiLuuTru(TenLoaiLuuTru),
	CONSTRAINT FK_Sach_Ke FOREIGN KEY(TenKe) REFERENCES KE(TenKe),
	CONSTRAINT FK_Sach_Ngan FOREIGN KEY(TenNgan) REFERENCES Ngan(TenNgan),
	
)
-- DROP TABLE Sach

-- Bạn đọc
CREATE TABLE BanDoc
(
	[MaBanDoc] VARCHAR(20) NOT NULL,
	[TenBanDoc] NVARCHAR(50) NOT NULL,
	[TenLop] NVARCHAR(50) NOT NULL,
	[TenChuyenNganh] NVARCHAR(50) NOT NULL,
	[GioiTinh] INT NOT NULL,
	[NgaySinh] DATETIME NOT NULL,
	[DienThoai] VARCHAR(20) NOT NULL UNIQUE,
	[Email] VARCHAR(30) NOT NULL UNIQUE,
	[DiaChi] NVARCHAR(60) NOT NULL,
	[SoCMT] NVARCHAR(12) NOT NULL UNIQUE,
	[DangMuon] INT,
	[GhiChu] NVARCHAR(500),
	--KHOÁ CHÍNH
	CONSTRAINT PK_BanDoc PRIMARY KEY(MaBanDoc),
	--Khoá phụ
	CONSTRAINT FK_BanDoc_TenLop FOREIGN KEY(TenLop) REFERENCES LopHoc(TenLop),

)
-- DROP TABLE BanDoc

-- Tài khoản
CREATE TABLE TaiKhoan
(	 
	[MaCanBo] VARCHAR(10) NOT NULL,
	[MatKhau] VARCHAR(20) NOT NULL,
	[TenCanBo] NVARCHAR(50) NOT NULL,
	[SoCMT] VARCHAR(12) NOT NULL UNIQUE,
	[GioiTinh] INT NOT NULL,
	[NgaySinh] DATETIME NOT NULL,
	[DienThoai] VARCHAR(20) NOT NULL UNIQUE,
	[Email] VARCHAR(30) NOT NULL UNIQUE,
	[DiaChi] NVARCHAR(60) NOT NULL,
	[ChucVu] INT NOT NULL,
	[MoTa] NVARCHAR(500),
	[TrangThai] INT
	
	CONSTRAINT PK_TaiKhoan PRIMARY KEY(MaCanBo),

)
--DROP TABLE TaiKhoan

-- Phiếu đăng ký mượn
CREATE TABLE PhieuDangKyMuon
(
	[MaPhieu] VARCHAR(10) NOT NULL,
	[MaBanDoc] VARCHAR(20) NOT NULL,
	[TenBanDoc] NVARCHAR(50) NOT NULL,
	[Sach] NVARCHAR(500) NOT NULL,
	[MaCanBo] VARCHAR(10) NOT NULL, -- MÃ NGƯỜI TẠO PHIẾU
	[NgayTao] DATETIME NOT NULL,
	[NgayHetHan] DATETIME NOT NULL,
	[GiaMuon] REAL NOT NULL,
	[GhiChu] NVARCHAR(500),
	-- Khoá chính
	CONSTRAINT PK_PhieuDangKyMuon PRIMARY KEY(MaPhieu),
	-- Khoá phụ
	CONSTRAINT FK_PhieuDangKyMuon_MaBanDoc FOREIGN KEY(MaBanDoc) REFERENCES BanDoc(MaBanDoc),
	CONSTRAINT FK_PhieuDangKyMuon_MaCanBo FOREIGN KEY(MaCanBo) REFERENCES TaiKhoan(MaCanBo),

)
-- DROP TABLE PhieuDangKyMuon

-- Phiếu trả
CREATE TABLE PhieuTra
(
	[MaPhieu] VARCHAR(10) NOT NULL,
	[MaBanDoc] VARCHAR(20) NOT NULL,
	[TenBanDoc] NVARCHAR(50) NOT NULL,
	[MaCanBo] VARCHAR(10) NOT NULL,
	[NgayTra] DATETIME NOT NULL,
	[Sach] NVARCHAR(500) NOT NULL,
	[SachDaMuon] NVARCHAR(500) NOT NULL,
	[GiaPhat] Real,
	
)
-- DROP TABLE PhieuTra

CREATE TABLE DoanhThu
(
	[MaBanDoc] VARCHAR(20) NOT NULL,
	[TenBanDoc] NVARCHAR(50) NOT NULL,
	[GiaMuon] REAL NOT NULL,
	[GiaPhat] REAL,
	[Tong] REAL,
	[TonTai] INT

	CONSTRAINT PK_DoanhThu PRIMARY KEY(MaBanDoc)

)
-- DROP TABLE DoanhThu



SELECT * FROM NhaXuatBan















CREATE FUNCTION [FUNC_MANHAXUATBAN]
(
	@LASTMANXB VARCHAR(6),
	@PREFIX VARCHAR (4),
	@SIZE INT
)
RETURNS VARCHAR(6)
AS
	BEGIN
	IF(@LASTMANXB = NULL)
		SET @LASTMANXB = @PREFIX + REPLICATE(0, @SIZE - LEN(@PREFIX))
		                                                                                                                                                                                             
	DECLARE @NUM_NEXTMANXB INT, @NEXTMANXB VARCHAR(6)
	SET @LASTMANXB = LTRIM(RTRIM(@LASTMANXB))
	SET @NUM_NEXTMANXB = REPLACE(@LASTMANXB, @PREFIX, '')+1
	SET @SIZE = @SIZE - LEN(@PREFIX)
	SET @NEXTMANXB = @PREFIX + REPLICATE(0, @SIZE - LEN(@PREFIX))
	SET @NEXTMANXB = @PREFIX + RIGHT(REPLICATE(0, @SIZE) + CONVERT (VARCHAR(MAX), @NUM_NEXTMANXB), @SIZE)
	RETURN @NEXTMANXB
END
GO

-- DROP FUNCTION [FUNC_MANHAXUATBAN]
CREATE TRIGGER TR_MANHAXUATBAN ON NHAXUATBAN
FOR INSERT
AS
	BEGIN
		DECLARE @LASTMANXB  VARCHAR(6)
		IF((SELECT TOP 1 MANHAXUATBAN from NHAXUATBAN  WHERE MANHAXUATBAN LIKE 'NXB%' ORDER BY  MANHAXUATBAN DESC) != NULL)
			SET @LASTMANXB = (SELECT TOP 1 MANHAXUATBAN from NHAXUATBAN  WHERE MANHAXUATBAN LIKE '%NXB%' ORDER BY  MANHAXUATBAN DESC)
		ELSE 
			SET @LASTMANXB = (SELECT TOP 1 MANHAXUATBAN from NHAXUATBAN ORDER BY MANHAXUATBAN DESC)
		UPDATE [NHAXUATBAN] SET MANHAXUATBAN = DBO.FUNC_MANHAXUATBAN(@LASTMANXB,'NXB',5) WHERE  MANHAXUATBAN =''
		END
GO
-- drop TRIGGER TR_MANHAXUATBAN

insert into NHAXUATBAN values ('',N'tenNXB',N'dienThoai',N'email',N'diaChi',N'lienHe',N'ghiChu')

DROP TRIGGER TR_MANHAXUATBAN
SELECT TOP 1 MANHAXUATBAN from NHAXUATBAN  WHERE MANHAXUATBAN LIKE 'NXB%' ORDER BY  MANHAXUATBAN DESC
SELECT TOP 1 MANHAXUATBAN from NHAXUATBAN ORDER BY MANHAXUATBAN DESC

-- Stored Procedure
CREATE PROC TaiKhoan_DangNhap
@Email VARCHAR(30),
@DienThoai VARCHAR(20),
@Password NVARCHAR(20)
AS
BEGIN
    IF EXISTS (SELECT * FROM TaiKhoan WHERE Email = @Email AND MatKhau = @Password AND ChucVu = 0) 
	BEGIN
		UPDATE TaiKhoan SET [TrangThai] = 1 WHERE Email = @Email;
		SELECT 0 AS code 
	END
	ELSE 
		IF EXISTS (SELECT * FROM TaiKhoan WHERE DienThoai = @DienThoai AND MatKhau = @Password AND ChucVu = 0)
		BEGIN
			UPDATE TaiKhoan SET [TrangThai] = 1 WHERE DienThoai = @DienThoai;
			SELECT 0 AS code 
		END
			ELSE 
				IF EXISTS (SELECT * FROM TaiKhoan WHERE Email = @Email AND MatKhau = @Password AND ChucVu = 1)
				BEGIN
					UPDATE TaiKhoan SET [TrangThai] = 1 WHERE Email = @Email;
					SELECT 1 AS code 
				END
				ELSE 
					IF EXISTS (SELECT * FROM TaiKhoan WHERE DienThoai = @DienThoai AND MatKhau = @Password AND ChucVu = 1)
					BEGIN
						UPDATE TaiKhoan SET [TrangThai] = 1 WHERE DienThoai = @DienThoai;
						SELECT 1 AS code
					END
					ELSE 
						IF EXISTS (SELECT * FROM TaiKhoan WHERE Email = @Email AND MatKhau = @Password AND ChucVu = 2)
						BEGIN
							UPDATE TaiKhoan SET [TrangThai] = 1 WHERE Email = @Email;
							SELECT 2 AS code
						END
						ELSE 
							IF EXISTS (SELECT * FROM TaiKhoan WHERE DienThoai = @DienThoai AND MatKhau = @Password AND ChucVu = 2) 
							BEGIN
								UPDATE TaiKhoan SET [TrangThai] = 1 WHERE DienThoai = @DienThoai;
								SELECT 2 AS code
							END
						    ELSE SELECT 3 AS code 
	 
END
-- DROP PROC TaiKhoan_DangNhap
-- INSERT Lớp
INSERT INTO LopHoc VALUES (N'71DCHT24', '16 nữ, 30 nam chăm chỉ học được cộng điểm')
INSERT INTO LopHoc VALUES (N'71DCHT23', '')
INSERT INTO LopHoc VALUES (N'71DCHT22', '')
INSERT INTO LopHoc VALUES (N'71DCTT23', '')
INSERT INTO LopHoc VALUES (N'71DCTT22', '')
INSERT INTO LopHoc VALUES (N'71DCTT21', '')
INSERT INTO LopHoc VALUES (N'70DCTD24', '')
INSERT INTO LopHoc VALUES (N'70DCTD23', '')
INSERT INTO LopHoc VALUES (N'70DCTD22', '')
INSERT INTO LopHoc VALUES (N'70DCTD21', '')
INSERT INTO LopHoc VALUES (N'70DCCM22', 'Không chịu được nhiệt')
INSERT INTO LopHoc VALUES (N'70DCCM21', 'Không chịu được nhiệt')
INSERT INTO LopHoc VALUES (N'70DCCM20', 'Không chịu được nhiệt')


-- INSERT Chuyên ngành
INSERT INTO ChuyenNganh VALUES (N'Hệ Thống Thông Tin', N'Hệ thống thông tin là một hệ thống bao gồm các yếu tố có quan hệ với nhau cùng làm nhiệm vụ thu thập, xử lý, lưu trữ và phân phối thông tin và dữ liệu và cung cấp một cơ chế phản hồi để đạt được một mục tiêu định trước')
INSERT INTO ChuyenNganh VALUES (N'Mạng máy tính và truyền thông dữ liệu', N'Mạng máy tính và truyền thông dữ liệu bao gồm việc thiết kế, xây dựng, vận hành toàn bộ hạ tầng truyền tải thông tin và thiết kế, xây dựng, quản trị toàn bộ hệ thống và mạng máy tính, quản trị người sử dụng, giám sát và điều phối các hoạt động khác liên quan đến toàn bộ hệ thống, mạng máy tính.')
INSERT INTO ChuyenNganh VALUES (N'Công nghệ thông tin', N'Công nghệ thông tin, viết tắt CNTT, là một nhánh ngành kỹ thuật sử dụng máy tính và phần mềm máy tính để chuyển đổi, lưu trữ, bảo vệ, xử lý, truyền tải và thu thập thông tin.')
INSERT INTO ChuyenNganh VALUES (N'Logistics và Quản lý chuỗi cung ứng', N'Logistics và Quản lý chuỗi cung ứng là việc quản lý một mạng lưới kết nối của các doanh nghiệp tham gia vào việc cung cấp hàng hoá và dịch vụ đến tận tay người tiêu dùng.')
INSERT INTO ChuyenNganh VALUES (N'Quản trị kinh doanh', N'Quản trị kinh doanh là việc thực hiện quản lý một hoạt động kinh doanh')
INSERT INTO ChuyenNganh VALUES (N'Khai thác vận tải', N'Khai thác vận tải là quá trình lên kế hoạch, áp dụng và kiểm soát các luồng chuyển dịch của hàng hóa hay thông tin liên quan tới nguyên nhiên liệu vật tư (đầu vào) và sản phẩm cuối cùng (đầu ra) từ điểm xuất phát tới điểm tiêu thụ hay còn gọi là hậu cần trong vận chuyển.')
INSERT INTO ChuyenNganh VALUES (N'Thương mại điện tử', N'Thương mại điện tử, hay còn gọi là e-commerce, e-comm hay EC, là sự mua bán sản phẩm hay dịch vụ trên các hệ thống điện tử như Internet và các mạng máy tính. ')
INSERT INTO ChuyenNganh VALUES (N'Tài chính - Ngân hàng', N'Tài chính - Ngân hàng là một ngành có lĩnh vực khá rộng, liên quan đến tất cả các dịch vụ giao dịch tài chính, lưu thông tiền tệ. Có nhiều lĩnh vực chuyên ngành khác nhau như Ngân hàng, Tài chính Doanh nghiệp, Tài chính thuế, Tài chính Bảo hiểm')
INSERT INTO ChuyenNganh VALUES (N'Công nghệ kỹ thuật giao thông', N'')
INSERT INTO ChuyenNganh VALUES (N'Công nghệ kỹ thuật Cơ khí', N'')
INSERT INTO ChuyenNganh VALUES (N'Công nghệ kỹ thuật cơ điện tử', N'')
INSERT INTO ChuyenNganh VALUES (N'Công nghệ kỹ thuật Ô tô', N'')
INSERT INTO ChuyenNganh VALUES (N'Quản lý xây dựng', N'')



-- INSERT Khoá học
INSERT INTO KhoaHoc VALUES(N'Cấu trúc dữ liệu và giải thuật', N'Cấu trúc dữ liệu và giải thuật(CTDL & GT) là sự kết hợp và áp dụng một hoặc nhiều cấu trúc dữ liệu nào đó vào một hoặc nhiều thuật toán nào đó để có được đầu ra mong muốn một cách tối ưu và tốt nhất khi dữ liệu có số lượng cực lớn.')
INSERT INTO KhoaHoc VALUES(N'Công nghệ phần mềm', N'')
INSERT INTO KhoaHoc VALUES(N'Điện toán đám mây', N'')
INSERT INTO KhoaHoc VALUES(N'Hệ quản trị Cơ sở dữ liệu', N'')
INSERT INTO KhoaHoc VALUES(N'Lập trình hướng đối tượng C++', N'')
INSERT INTO KhoaHoc VALUES(N'Lập trình trên môi trường Web', N'')
INSERT INTO KhoaHoc VALUES(N'Lập trình trực quan C#', N'')
INSERT INTO KhoaHoc VALUES(N'Nguyên lý Hệ điều hành', N'')
INSERT INTO KhoaHoc VALUES(N'Nhập môn Cơ sở dữ liệu', N'')
INSERT INTO KhoaHoc VALUES(N'Nhập môn mạng máy tính', N'')
INSERT INTO KhoaHoc VALUES(N'Phần mềm mã nguồn mở', N'')
INSERT INTO KhoaHoc VALUES(N'Toán học rời rạc', N'')
INSERT INTO KhoaHoc VALUES(N'Giao thông thông minh - ITS', N'')
INSERT INTO KhoaHoc VALUES(N'Kiến trúc máy tính', N'')
INSERT INTO KhoaHoc VALUES(N'Lập trình Java cơ bản', N'')
INSERT INTO KhoaHoc VALUES(N'Ngôn ngữ lập trình C', N'')
INSERT INTO KhoaHoc VALUES(N'Thương mại điện tử', N'')
INSERT INTO KhoaHoc VALUES(N'Chủ nghĩa xã hội khoa học', N'')
INSERT INTO KhoaHoc VALUES(N'Kỹ thuật xây dựng và trình bày báo cáo', N'')
INSERT INTO KhoaHoc VALUES(N'Tin học cơ sở', N'')
INSERT INTO KhoaHoc VALUES(N'Toán 2', N'')
INSERT INTO KhoaHoc VALUES(N'Lập trình Java nâng cao', N'')
INSERT INTO KhoaHoc VALUES(N'Kiến trúc và thiết kế phần mềm', N'')
INSERT INTO KhoaHoc VALUES(N'Trí tuệ nhân tạo', N'')
INSERT INTO KhoaHoc VALUES(N'Quản lý dự án phần mềm', N'')
INSERT INTO KhoaHoc VALUES(N'An toàn và bảo mật hệ thống thông tin', N'')

-- INSERT Nhà xuất bản
INSERT INTO NhaXuatBan VALUES(N'NXB00', N'Nhà xuất bản Kim Đồng', '1900571595', 'cskh_online@nxbkimdong.com.vn', N'55 Quang Trung, Hai Bà Trưng, Hà Nội', N'Website: http://www.nxbkimdong.com.vn/ Facebook: https://www.facebook.com/nxbkimdong/', N'Nhà xuất bản Kim Đồng là nhà xuất bản sách nổi tiếng cho thiếu nhi thuộc trực thuộc Trung ương Đoàn TNCS Hồ Chí Minh. Các nhà văn trẻ có thể gửi tác phẩm của mình cho nhà xuất bản Kim Đồng. Nhà xuất bản Kim Đồng chuyên in ấn, xuất bản sách dành cho thiếu nhi và các bậc phụ huynh trong cả nước. ')
INSERT INTO NhaXuatBan VALUES(N'NXB01', N'Nhà xuất bản Trẻ', '02839316211 ', 'hopthubandoc@nxbtre.com.vn', N'161B Lý Chính Thắng, Phường 7, Quận 3, Thành phố Hồ Chí Minh', N'Website: http://www.nxbtre.com.vn', N'Nhà xuất bản Trẻ xuất bản sách và văn hóa phẩm các loại, phục vụ chủ yếu là các đối tượng trẻ như thanh niên, thiếu nhi, tổ chức Đoàn các cấp của thành phố, phục vụ bạn đọc trong và ngoài nước. Nhà xuất bản có nhận xuất bản nhiều thể loại sách như: tài liệu chính trị, kiến thức phổ thông, văn hóa – xã hội, nghệ thuật, văn học, từ điển,...')
INSERT INTO NhaXuatBan VALUES(N'NXB02', N'Nhà xuất bản Tổng hợp thành phố Hồ Chí Minh', '02838256804', ' nstonghop@gmail.com', N'62 Nguyễn Thị Minh Khai, Phường Đa Kao, Quận 1, TP.HCM', N'Website: http://www.nxbhcm.com.vn', N'Nhà xuất bản Tổng hợp thành phố Hồ Chí Minh được thành lập từ năm 1977. Đúng như tên gọi của nhà xuất bản là cơ quan hội tụ về tư tưởng, văn hóa, chính trị của Đảng bộ và nhân dân thành phố. Nhà xuất bản Tổng hợp thành phố Hồ chí Minh xuất bản hàng ngàn tựa sách gồm nhiều thể loại.')
INSERT INTO NhaXuatBan VALUES(N'NXB03', N'Nhà xuất bản chính trị quốc gia sự thật', '02438221633', 'suthat@nxbctqg.vn', N'Số 6/86 Duy Tân, Cầu Giấy, Hà Nội', N'Website: http://www.nxbctqg.org.vn', N'Nhà xuất bản Chính trị quốc gia sự thật là đơn vị sự nghiệp trung ương của Đảng, xuất bản những cuốn sách về chính trị của Đảng và Nhà nước. Tổ chức biên tập, xuất bản các sách chính trị, xã hội, lý luận và pháp luật. Nhà xuất bản xuất bản sách chính trị nhằm nâng cao các kiến thức của nhân dân về chính trị, xã hội, lý luận và pháp luật. Phục vụ sự nghiệp đổi mới và hai nhiệm vụ chiến lược xây dựng và bảo vệ Tổ quốc.')
INSERT INTO NhaXuatBan VALUES(N'NXB04', N'Nhà xuất bản giáo dục', '02438220801', 'giaoduc@nxbgd.vn', N'Số 81 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', N'Website: http://www.nxbgd.vn', N'Nhà xuất bản Giáo dục Việt Nam (trước đây là Nhà xuất bản Giáo dục) trực thuộc Bộ Giáo dục và Đào tạo, được thành lập ngày 01 tháng 6 năm 1957.')
INSERT INTO NhaXuatBan VALUES(N'NXB05', N'Nhà xuất bản Bách khoa Hà Nội', '02438684569', 'nxbbk@hust.edu.vn', N'Nhà E – Ngõ 17 – Tạ Quang Bửu – Hai Bà Trưng – Hà Nội.',N'' ,N'')
INSERT INTO NhaXuatBan VALUES(N'NXB06', N'Nhà xuất bản Khoa học Tự nhiên và Công nghệ', '02422149041', 'nxb@vap.ac.vn', N'18B Hoàng Quốc Việt, Nghĩa Đô, Cầu Giấy, Hà Nội',N'', N'')


-- INSERT Nguồn tài liệu
INSERT INTO NguonTaiLieu VALUES(N'Sách', N'')
INSERT INTO NguonTaiLieu VALUES(N'Bài viết khoa học', N'')
INSERT INTO NguonTaiLieu VALUES(N'Kỷ yếu', N'')
INSERT INTO NguonTaiLieu VALUES(N'Báo - Tạp chí', N'')
INSERT INTO NguonTaiLieu VALUES(N'Luận văn', N'')
INSERT INTO NguonTaiLieu VALUES(N'Khoá luận', N'')
INSERT INTO NguonTaiLieu VALUES(N'Đề tài nghiên cứu', N'')

-- INSERT Loại lưu trữ
INSERT INTO LoaiLuuTru VALUES(N'Tài liệu in', N'')
INSERT INTO LoaiLuuTru VALUES(N'Tài liệu số', N'')

-- INSERT Thể loại
INSERT INTO TheLoai VALUES(N'Tài chính kế toán ngân hàng', N'')
INSERT INTO TheLoai VALUES(N'Cơ bản', N'')
INSERT INTO TheLoai VALUES(N'Luật', N'')
INSERT INTO TheLoai VALUES(N'Quản trị Kinh doanh', N'')
INSERT INTO TheLoai VALUES(N'Công nghệ Thông tin', N'')
INSERT INTO TheLoai VALUES(N'Kiến trúc', N'')
INSERT INTO TheLoai VALUES(N'Quan hệ công chúng', N'')
INSERT INTO TheLoai VALUES(N'Y học cổ truyền', N'')
INSERT INTO TheLoai VALUES(N'Công nghệ thông tin', N'')
INSERT INTO TheLoai VALUES(N'Quản lý Kinh tế', N'')

-- INSERT Tác giả
INSERT INTO TacGia VALUES(N'TCG00', N'Nguyễn Mạnh Hùng', N'')
INSERT INTO TacGia VALUES(N'TCG01', N'Lê Thị Liễu', N'')
INSERT INTO TacGia VALUES(N'TCG02', N'Nguyễn Thành Trung', N'')
INSERT INTO TacGia VALUES(N'TCG03', N'Phạm Đăng Phước', N'')
INSERT INTO TacGia VALUES(N'TCG04', N'Đỗ Như Tráng', N'')
INSERT INTO TacGia VALUES(N'TCG05', N'Bùi Văn Hùng', N'')
INSERT INTO TacGia VALUES(N'TCG06', N'Bùi Văn Trầm', N'')
INSERT INTO TacGia VALUES(N'TCG07', N'Nguyễn Đức Nghĩa', N'')

-- INSERT Kệ
INSERT INTO Ke VALUES(N'Kệ 1', N'')
INSERT INTO Ke VALUES(N'Kệ 2', N'')
INSERT INTO Ke VALUES(N'Kệ 3', N'')
INSERT INTO Ke VALUES(N'Kệ 4', N'')
INSERT INTO Ke VALUES(N'Kệ 5', N'')
INSERT INTO Ke VALUES(N'Kệ 6', N'')
INSERT INTO Ke VALUES(N'Kệ 7', N'')
INSERT INTO Ke VALUES(N'Kệ 8', N'')
INSERT INTO Ke VALUES(N'Kệ 9', N'')

-- INSERT Ngăn
INSERT INTO Ngan VALUES(N'Ngăn 1', N'')
INSERT INTO Ngan VALUES(N'Ngăn 2', N'')
INSERT INTO Ngan VALUES(N'Ngăn 3', N'')
INSERT INTO Ngan VALUES(N'Ngăn 4', N'')
INSERT INTO Ngan VALUES(N'Ngăn 5', N'')          
INSERT INTO Ngan VALUES(N'Ngăn 6', N'')          
INSERT INTO Ngan VALUES(N'Ngăn 7', N'')          
INSERT INTO Ngan VALUES(N'Ngăn 8', N'')          

-- INSERT Sách
INSERT INTO Sach VALUES(N'SCH01', N'Cấu trúc dữ liệu và giải thuật', N'Hệ thống thông tin', N'Cấu trúc dữ liệu và giải thuật', N'Công nghệ thông tin', 'TCG07', 'NXB02', N'Sách', N'Tài liệu in', 3, N'2008/04/16', N'Tiếng Việt', N'Kệ 1', N'Ngăn 2', 120000, 10000, 100, N'Sách mới')
INSERT INTO Sach VALUES(N'SCH02', N'Ngôn ngữ lập trình C', N'Hệ thống thông tin', N'Ngôn ngữ lập trình C', N'Công nghệ thông tin', 'TCG01', 'NXB00', N'Sách', N'Tài liệu in', 5, N'2002/04/16', N'Tiếng Việt', N'Kệ 2', N'Ngăn 2', 200000, 15000, 100, N'Sách mới')
INSERT INTO Sach VALUES(N'SCH03', N'PYTHON cơ bản', N'Hệ thống thông tin', N'Trí tuệ nhân tạo', N'Công nghệ thông tin', 'TCG07', 'NXB04', N'Sách', N'Tài liệu in', 1, N'2021/04/16', N'Tiếng Việt', N'Kệ 3', N'Ngăn 2', 400000, 30000, 100, N'Sách mới')
INSERT INTO Sach VALUES(N'SCH04', N'Hàm Excel', N'Quản trị kinh doanh', N'Thương mại điện tử ', N'Công nghệ thông tin', 'TCG01', 'NXB01', N'Sách', N'Tài liệu in', 2, N'2016/04/16', N'Tiếng Việt', N'Kệ 1', N'Ngăn 2', 100000, 5000, 100, N'Sách mới')

-- INSERT Tài khoản
INSERT INTO TaiKhoan VALUES('MCB00', 'utt1232022', N'Nguyễn Việt Thành', '034202003056',1, N'1988/02/01', '0392109654', 'thanhnguyenviet@utt.edu.vn', N'Số 10 Ngách 45 Ngõ 68 Triều Khúc Thanh Xuân Hà Nội', 0, N'3 năm kinh nghiệm', 0)
INSERT INTO TaiKhoan VALUES('MCB01', 'utt1242022', N'Nguyễn Thị Bích Hằng', '034202003057',0, N'1980/02/01', '0392109655', 'bichhangnguyen@utt.edu.vn', N'Số 10 Ngách 45 Ngõ 68 Triều Khúc Thanh Xuân Hà Nội', 1, N'3 năm kinh nghiệm', 0)
INSERT INTO TaiKhoan VALUES('MCB02', 'utt1252022', N'Nguyễn Thị Trang Hoa', '034202003058',0, N'1993/02/01', '0392109656', 'tranghoanguyen@utt.edu.vn', N'Số 10 Ngách 45 Ngõ 68 Triều Khúc Thanh Xuân Hà Nội', 2, N'3 năm kinh nghiệm', 0)

--INSERT Bạn đọc
INSERT INTO BanDoc VALUES('71DCHT22075', N'Trần Đức Lương', N'71DCHT22', N'Hệ thống thông tin', 1, N'2002/04/16', '0392109642', 'tranducluong1642002@gmail.com', N'Tân Triều Thanh Xuân Hà Nội', '034202003031', 0, N'Đẹp trai')
INSERT INTO BanDoc VALUES('71DCHT22072', N'Trần Nhật Lâm', N'71DCHT22', N'Hệ thống thông tin', 1, N'2002/07/16', '0392109643', 'lam@gmail.com', N'Tân Triều Thanh Xuân Hà Nội', '034202009031', 0, N'Đẹp trai')
INSERT INTO BanDoc VALUES('71DCHT22074', N'Trần Huyền Linh', N'71DCHT22', N'Hệ thống thông tin', 1, N'2002/06/16', '0392109644', 'linh@gmail.com', N'Tân Triều Thanh Xuân Hà Nội', '034202003032', 0, N'Đẹp trai')
INSERT INTO BanDoc VALUES('71DCHT22073', N'Lương Nguyên', N'71DCHT22', N'Hệ thống thông tin', 1, N'2002/05/16', '0392109645', 'luong@gmail.com', N'Tân Triều Thanh Xuân Hà Nội', '034202003033', 0, N'Đẹp trai')

-- INSERT Phiếu đăng ký mượn
INSERT INTO PhieuDangKyMuon VALUES('MP00', '71DCHT22075', N'Trần Đức Lương', 'SCH0', N'Kỹ thuật lập trình C', 'MCB02', 2022/05/16, 2022/08/16, 12000, 'Sách mới')
INSERT INTO PhieuDangKyMuon VALUES('MP01', '71DCHT22075', N'Trần Đức Lương', 'SCH1', N'Cấu trúc dữ liệu và giải thuật', 'MCB02', 2022/05/16, 2022/08/16, 12000, 'Sách mới')
INSERT INTO PhieuDangKyMuon VALUES('MP02', '71DCHT22072', N'Trần Nhật Lâm', N'Cấu trúc dữ liệu và giải thuật', 'MCB02', 2022/05/16, 2022/08/16, 12000, 'Sách mới')

-- INSERT Phiếu trả
UPDATE TaiKhoan SET [TrangThai] = 0
SELECT * FROM PhieuDangKyMuon

INSERT INTO PhieuDangKyMuon VALUES ('MPsof', '71DCHT22075', N'Trần Đức Lương', N'ádnfkjadgdfgd\\\\\gkjgkbag', 'MCB00', N'2022/06/11', N'2022/07/11', 2000, N'sbkjdbf||dfsdsdg')

