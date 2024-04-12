CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [HoVaTen] NVARCHAR(200) NOT NULL, 
    [GioiTinh] BIT NOT NULL, 
    [Email] NVARCHAR(200) NULL, 
    [SoDienThoai] NVARCHAR(20) NULL, 
    [SoCanCuoc] NVARCHAR(200) NULL, 
    [TenDangNhap] NVARCHAR(200) NULL, 
    [MatKhau] NVARCHAR(200) NULL, 
    [IdChucVu] BIGINT NULL, 
    [LaQuanTri] BIT NOT NULL, 
    [LaNhanVien] BIT NOT NULL
)
