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