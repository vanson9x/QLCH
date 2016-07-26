use QLCHDT

-- Procedure them nha cung cap
CREATE PROC SP_InsertNCC
	@ma varchar(100),
	@ten nvarchar(50),
	@diachi nvarchar(50),
	@email varchar(35),
	@hotline varchar(15)
AS
BEGIN
	INSERT into tbl_NhaCungCap Values (@ma,@ten,@diachi,@email,@hotline)
END


--Procedure them san pham
CREATE PROC SP_ThemSanPham(
@sMaSP varchar(10),	
@sTenSP nvarchar(50),	
@sThongTinCT nvarchar(500),	
@fGia float,	
@FK_sMaNCC varchar(10))
AS
BEGIN
	INSERT INTO tbl_SanPham VALUES(@sMaSP,@sTenSP,@sThongTinCT,@fGia,@FK_sMaNCC)
END

--Procedure them chi tiet phieu nhap
CREATE Proc SP_InsertCTPN
	@maCTPN varchar(10),
	@maSP varchar(10),
	@soluong int
AS
BEGIN
	INSERT into tbl_CTPhieuNhap(sMaCTPN,FK_sMaSP,iSoLuong) VALUES (@maCTPN,@maSP,@soluong)
END

--Procedure them phieu nhap
Alter Proc SP_InsertPN
	@maPN varchar(10),
	@ten nvarchar(50),
	@maCTPN varchar(10),
	@maNV varchar(10)
AS
BEGIN
	INSERT into tbl_PhieuNhap(sMaPN,sTenPN,FK_sMaCTPN,FK_sMaNV) VALUES (@maPN,@ten,@maCTPN,@maNV)
END

--Trigger khi thêm một phiếu nhập sẽ tự động điền ngày lập lấy ngày hiện tại
CREATE Trigger TG_INSERT_PhieuNhap
ON tbl_PhieuNhap
AFTER INSERT
AS
BEGIN
	UPDATE tbl_PhieuNhap
	SET dNgayLap = GETDATE()
	WHERE sMaPN = (SELECT sMaPN From inserted)
END

--Sửa Trigger tình thành tiền trong bảng tbl_CTPhieuNhap
ALTER TRIGGER TG_Thanhtien
ON tbl_CTPhieuNhap
AFTER UPDATE,INSERT
AS 
BEGIN
DECLARE @maCTPN varchar(10), @maSP varchar(10), @soluong int, @thanhtien float
	SET @maCTPN = (SELECT sMaCTPN FROM inserted)
	SET @maSP = (SELECT FK_sMaSP FROM inserted)
	SET @soluong = (SELECT iSoLuong FROM inserted)
	SET @thanhtien = (SELECT fGia FROM tbl_SanPham WHERE sMaSP = @maSP) * @soluong
	UPDATE tbl_CTPhieuNhap
	SET fThanhTien = @thanhtien
	WHERE sMaCTPN = @maCTPN   	
END

--Sửa Trigger tính tổng tiền trong bảng  tbl_PhieuNhap
ALTER TRIGGER TG_tongtien
   ON tbl_PhieuNhap
   AFTER INSERT,UPDATE
AS 
BEGIN
	DECLARE @maPN varchar(10), @maCTPN varchar(10)
	SET @maPN = (SELECT sMaPN FROM inserted)
	SET @maCTPN = (SELECT FK_sMaCTPN FROM inserted)
	UPDATE tbl_PhieuNhap
	SET fTongTien = (SELECT fThanhTien FROM tbl_CTPhieuNhap WHERE sMaCTPN = @maCTPN)
	WHERE sMaPN = @maPN
END

--Sửa Trigger tính tổng tiền tbl_PhieuNhap
ALTER TRIGGER [dbo].[TG_tongtien]
   ON [dbo].[tbl_PhieuNhap]
   AFTER INSERT,UPDATE
AS 
BEGIN
	DECLARE @maPN varchar(10), @maCTPN varchar(10)
	SET @maPN = (SELECT sMaPN FROM inserted)
	SET @maCTPN = (SELECT FK_sMaCTPN FROM inserted)
	UPDATE tbl_PhieuNhap
	SET fTongTien = (SELECT fThanhTien FROM tbl_CTPhieuNhap WHERE sMaCTPN = @maCTPN)
	WHERE sMaPN = @maPN AND FK_sMaCTPN = @maCTPN
END

-- Sửa Trigger tự động lấy ngày hiện tại thêm vào cột dNgaylap on tbl_PhieuNhap
ALTER Trigger [dbo].[TG_INSERT_PhieuNhap]
ON [dbo].[tbl_PhieuNhap]
AFTER INSERT
AS
BEGIN
	DECLARE @maPN varchar(10), @maCTPN varchar(10)
	SET @maPN = (SELECT sMaPN From inserted)
	SET @maCTPN = (SELECT FK_sMaCTPN From inserted)
	UPDATE tbl_PhieuNhap
	SET dNgayLap = GETDATE()
	WHERE sMaPN = @maPN AND FK_sMaCTPN = @maCTPN
END


--Tạo Procedure Thêm Bảo hành
CREATE PROC SP_InsertBaoHanh
@maBH varchar(10),
@thoihan int
AS
BEGIN
	INSERT INTO tbl_BaoHanh(sMaBH,dNgayKH,iThoiGian) VALUES (@maBH,GETDATE(),@thoihan)
END

--Tạo Proc thêm khách hàng
CREATE PROC SP_InsertKhachHang
@maKH varchar(10),
@ten nvarchar(50),
@diachi nvarchar(50),
@sdt varchar(15),
@email varchar(35)
AS
BEGIN
	INSERT INTO tbl_KhachHang(sMaKH,sTenKH,sDiaChi,sSDT,sEmail) VALUES (@maKh,@ten,@diachi,@sdt,@email)
END

--Tao Proc them Chi tiet hoa don
CREATE PROC SP_InsertCTHD
	@maCTHD varchar(10),
	@maSP varchar(10),
	@maBH varchar(10),
	@soluong int
AS
BEGIN
	INSERT INTO tbl_CTHoaDon(sMaCTHD,FK_sMaSP,FK_sMaBH,iSoLuong) VALUES (@maCTHD,@maSP,@maBH,@soluong)
END

--Tao PROC them HoaDon
CREATE PROC SP_InsertHD
	@maHD varchar(10),
	@tenHD nvarchar(100),
	@maCTHD varchar(10),
	@maKH varchar(10),
	@maNV varchar(10)
AS
BEGIN
	INSERT INTO tbl_HoaDon(sMaHD,sTenHD,FK_sMaCTHD,FK_sMaKH,FK_sMaNV) VALUES (@maHD,@tenHD,@maCTHD,@maKH,@maNV)
END