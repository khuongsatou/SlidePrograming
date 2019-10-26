

GO
USE [QLSV]
GO
/****** Object:  User [F78-20\SV]    Script Date: 4/15/2019 10:15:08 PM ******/

GO
/****** Object:  Table [dbo].[LOPHOC]    Script Date: 4/15/2019 10:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPHOC](
	[MaLop] [nvarchar](10) NOT NULL,
	[TenLop] [nvarchar](100) NULL,
 CONSTRAINT [PK_LOPHOC] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 4/15/2019 10:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MaSV] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[MaLop] [nvarchar](10) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop]) VALUES (N'L01', N'CDTH17A')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop]) VALUES (N'L02', N'CDTH 17B')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop]) VALUES (N'L03', N'CDTH 17C')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop]) VALUES (N'L04', N'CDTH 17D')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [MaLop]) VALUES (N'SV01', N'Lê Anh Tuấn', CAST(0xEF220B00 AS Date), N'Nữ', N'TP HCM', N'L04')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [MaLop]) VALUES (N'SV02', N'Tạ Quốc Bảo', CAST(0xE9220B00 AS Date), N'Nam', N'TP HCM', N'L03')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [MaLop]) VALUES (N'SV03', N'Đinh Trung Hiếu', CAST(0xC9230B00 AS Date), N'Nữ', N'Đồng Nai', N'L02')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [MaLop]) VALUES (N'SV04', N'Võ Hoàng Phi Hùng', CAST(0x65230B00 AS Date), N'Nam', N'Bình Dương', N'L01')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [MaLop]) VALUES (N'SV05', N'Hà Văn Hóa', CAST(0x19400B00 AS Date), N'Nam', N'TP HCM', N'L03')
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [MaLop]) VALUES (N'SV06', N'Ta Quoc Bao', CAST(0x19400B00 AS Date), N'Nam', N'TP HCM', N'L01')
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOPHOC] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOPHOC] ([MaLop])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOPHOC]
GO
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO
