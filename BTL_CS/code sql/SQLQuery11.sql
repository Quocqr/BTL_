                                          use [QuanLyBanGiay]
go
--lay nhap hang 
 CREATE VIEW vwNhapHang AS
SELECT
    MaNH,
    NgayNhap,
    MaNV,
    TongGiaTriNhapHang
FROM tblNhapHang;
go
--them nhap hang 
CREATE PROCEDURE sp_InsertNhapHang
    @MaNH NVARCHAR(12),
    @NgayNhap DATETIME,
    @MaNV NVARCHAR(12)
AS
BEGIN
    INSERT INTO tblNhapHang (MaNH, NgayNhap, MaNV, TongGiaTriNhapHang)
    VALUES (@MaNH, @NgayNhap, @MaNV, 0);
END;
go 
drop PROCEDURE sp_InsertNhapHang
GO
-- tim kiem nhap hang 
CREATE PROCEDURE searchnhaphang
      @MaNH NVARCHAR(12) = NULL,
	  @MaNV NVARCHAR(12) = NULL,
	  @NgayNhap DATETIME = NULL
	 
      AS
	    BEGIN
	      SELECT * FROM [dbo].[tblNhapHang]
		         WHERE (@MaNH IS NULL OR @MaNH=[MaNH])
				       AND (@MaNV IS NULL OR [MaNV] LIKE '%'+@MaNV+'%')
					   AND (@NgayNhap IS NULL OR  [NgayNhap]= @NgayNhap)
                       ;
         END;
GO
DROP PROCEDURE searchnhaphang
GO
-- THU NGHIEM 0034
CREATE PROCEDURE searchnhaphang
      @MaNH NVARCHAR(12) = NULL,
	  @MaNV NVARCHAR(12) = NULL,
	  @NgayNhap VARCHAR(12) = NULL
	 
      AS
	    BEGIN
	      SELECT * FROM [dbo].[tblNhapHang]
		         WHERE (@MaNH IS NULL OR @MaNH=[MaNH])
				       AND (@MaNV IS NULL OR [MaNV] LIKE '%'+@MaNV+'%')
					   AND (@NgayNhap IS NULL OR  [NgayNhap]= @NgayNhap)
                       ;
         END;
GO
EXEC searchnhaphang @NgayNhap="05/19/2021"
-- sua nhap hang 
go
CREATE PROCEDURE UpdateTblNhapHang
	@MaNH NVARCHAR(12), 
	@NgayNhap DATETIME, 
	@MaNV NVARCHAR(12)
  AS
BEGIN
	UPDATE tblNhapHang
	SET NgayNhap = @NgayNhap, 
		MaNV = @MaNV
	WHERE MaNH = @MaNH
END
go
DROP PROCEDURE UpdateTblNhapHang
go
EXEC UpdateTblNhapHang NH6,"2014-10-06",NV1
go
--tim kiem checkbox nhap hang 
CREATE PROCEDURE searchnhaphangcheckbox
      @TongGiaTriNhapHang1 FLOAT = NULL,
      @TongGiaTriNhapHang2 FLOAT = NULL,
	  @NgayNhap1 DATETIME = NULL,
	  @NgayNhap2 DATETIME = NULL
      AS
	    BEGIN
	      SELECT * FROM [dbo].[tblNhapHang]
		         WHERE (@TongGiaTriNhapHang1 IS NULL OR @TongGiaTriNhapHang1<=[TongGiaTriNhapHang])
				       AND (@TongGiaTriNhapHang2 IS NULL OR @TongGiaTriNhapHang2>=[TongGiaTriNhapHang] )
					   AND (@NgayNhap1 IS NULL OR  [NgayNhap]>= @NgayNhap1)
					   AND (@NgayNhap2 IS NULL OR  [NgayNhap]<= @NgayNhap2)

                       ;
         END;
go
DROP PROCEDURE searchnhaphangcheckbox

GO
EXEC searchnhaphangcheckbox @TongGiaTriNhapHang1=100, @TongGiaTriNhapHang2=66000.0
GO 
-- lay chi tiet nhap hang 
CREATE PROCEDURE viewCTnhaphang
      @MaNH NVARCHAR(12) =NULL,
	  @MaSP NVARCHAR(12) =NULL,
	  @TenSP NVARCHAR(50)=NULL,
	  @SoLuong FLOAT=NULL,
	  @GiaNhap FLOAT=NULL
      AS
	    BEGIN
	      SELECT MaNH ,[dbo].[tblChiTietNhapHang].MaSP ,TenSP,[dbo].[tblChiTietNhapHang].SoLuong,GiaNhap,ThanhTien
		  FROM [dbo].[tblChiTietNhapHang] LEFT JOIN[dbo].[tblSanPham]
		       ON [dbo].[tblChiTietNhapHang].MaSP=[dbo].[tblSanPham].MaSP
		         WHERE ((@MaNH IS NULL OR [dbo].[tblChiTietNhapHang].MaNH=@MaNH)
				       AND(@MaSP IS NULL OR [dbo].[tblChiTietNhapHang].MaSP=@MaSP)
				       AND (@TenSP IS NULL OR [dbo].[tblSanPham].TenSP LIKE '%'+@TenSP+'%')
					   AND (@SoLuong IS NULL OR  [dbo].[tblChiTietNhapHang].SoLuong= @SoLuong)
					   AND (@GiaNhap IS NULL OR  [dbo].[tblChiTietNhapHang].GiaNhap= @GiaNhap))

                       ;
         END;
go
exec viewCTnhaphang
-- TRIGGER cho [ThanhTien] va [TongGiaTriNhapHang] chop don nhap hang --
go
CREATE TRIGGER trg_UpdateThanhTien ON tblChiTietNhapHang
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    -- Cập nhật ThanhTien trong bảng tblChiTietNhapHang
    UPDATE tblChiTietNhapHang
    SET ThanhTien = [dbo].[tblChiTietNhapHang].SoLuong * [dbo].[tblChiTietNhapHang].GiaNhap
    FROM tblChiTietNhapHang
    INNER JOIN inserted
    ON tblChiTietNhapHang.MaSP = inserted.MaSP
    AND tblChiTietNhapHang.MaNH = inserted.MaNH;

    -- Cập nhật TongGiaTriNhapHang trong bảng tblNhapHang
    UPDATE tblNhapHang
    SET TongGiaTriNhapHang = (SELECT SUM(ThanhTien) FROM tblChiTietNhapHang WHERE tblChiTietNhapHang.MaNH = tblNhapHang.MaNH)
    FROM tblNhapHang
    INNER JOIN inserted
    ON tblNhapHang.MaNH = inserted.MaNH;
END;
--TRIGGER cho [ThanhTien] va [TongGiaTriNhapHang] khi  xóa tất cả bản ghi trong bẳng tblChiTietNhapHang  --
go
CREATE TRIGGER trg_DeleteChiTietNhapHang ON tblNhapHang
FOR DELETE
AS
BEGIN
    DELETE FROM tblChiTietNhapHang
    WHERE MaNH IN (SELECT MaNH FROM deleted);
END;
GO 
CREATE PROCEDURE TENSP
      @MaSP NVARCHAR(12) =NULL  
AS 
BEGIN 
      SELECT  [dbo].[tblSanPham].TenSP
	       FROM [dbo].[tblSanPham]
		   WHERE [dbo].[tblSanPham].MaSP=@MaSP
END 		       
go
exec TENSP SP1
-- sửa ro ngu (phan nay khong can de y)
GO
ALTER TABLE [dbo].[tblChiTietDonHang]
ADD PRIMARY KEY ([MaDH]);
go
ALTER TABLE [dbo].[tblChiTietDonHang]
DROP CONSTRAINT PK__tblChiTi__1E4E40F00CB05F75;

go
ALTER TABLE [dbo].[tblChiTietDonHang]
DROP COLUMN MaCTDH;
go
SELECT name AS constraint_name 
FROM sys.key_constraints 
WHERE type = 'PK' AND OBJECT_NAME(parent_object_id) = 'tblChiTietDonHang';
go
INSERT INTO tblChiTietNhapHang (MaSP, MaNH, SoLuong,GiaNhap,ThanhTien) 
VALUES('SP3', 'NH6', '5','125000', '0');
GO
-- sua chi tiet nhap hang 
CREATE PROCEDURE UpdatetblChiTietNhapHang
	@MaSP NVARCHAR(12) = NULL, 
	@MaNH NVARCHAR(12),
	@SoLuong FLOAT = NULL,
	@GiaNhap FLOAT = NULL
AS
BEGIN
	UPDATE tblChiTietNhapHang
	SET 
		SoLuong = ISNULL(@SoLuong, SoLuong),
		GiaNhap = ISNULL(@GiaNhap, GiaNhap)
	WHERE MaNH = @MaNH
	      AND [MaSP]=@MaSP;
END;

GO
DROP PROCEDURE dulieubaocao
GO 
-- lay du lieu cho bao cao 
CREATE PROCEDURE dulieubaocao
    @MaNH NVARCHAR(12)
AS
BEGIN
    SELECT
        sp.MaSP,
        sp.TenSP,
        nv.MaNV,
        nv.TenNV,
        nh.NgayNhap,
        ctnh.SoLuong,
        ctnh.GiaNhap,
        ctnh.ThanhTien
    FROM
        tblSanPham sp
    INNER JOIN
        tblChiTietNhapHang ctnh ON sp.MaSP = ctnh.MaSP
    INNER JOIN
        tblNhapHang nh ON ctnh.MaNH = nh.MaNH
    INNER JOIN
        tblNhanVien nv ON nh.MaNV = nv.MaNV
    WHERE
        nh.MaNH = @MaNH;
END;
GO
EXEC dulieubaocao NH1