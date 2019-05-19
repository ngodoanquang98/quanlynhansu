USE [master]
GO
/****** Object:  Database [QLNS]    Script Date: 19-May-19 7:38:14 AM ******/
CREATE DATABASE [QLNS]
go
ALTER DATABASE [QLNS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLNS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLNS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLNS] SET  MULTI_USER 
GO
ALTER DATABASE [QLNS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLNS] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLNS]
GO
/****** Object:  User [Hoai]    Script Date: 19-May-19 7:38:14 AM ******/
CREATE USER [Hoai] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [Hoai]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Hoai]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Hoai]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Hoai]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Hoai]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Hoai]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Hoai]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [Hoai]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [Hoai]
GO
/****** Object:  Table [dbo].[Ca]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ca](
	[MaCa] [bit] NOT NULL,
	[TenCa] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MaChamCong] [bigint] IDENTITY(1,1) NOT NULL,
	[Ngay] [date] NULL,
	[MaCa] [bit] NULL,
	[MaNV] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietCV]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietCV](
	[MaCV] [bigint] NOT NULL,
	[MaNV] [bigint] NOT NULL,
	[MaPB] [bigint] NOT NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC,
	[MaNV] ASC,
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietLuong]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietLuong](
	[MaNV] [bigint] NOT NULL,
	[Luong] [money] NULL,
	[Ngay] [date] NULL,
	[TongNgay] [int] NULL,
	[TongDem] [int] NULL,
	[TienBaoHiem] [money] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [bigint] IDENTITY(1,1) NOT NULL,
	[TenCV] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CongTy]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongTy](
	[MaCTy] [int] IDENTITY(1,1) NOT NULL,
	[TenCTy] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[ChuTich] [nvarchar](30) NULL,
	[Hotline] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[MaHD] [bigint] IDENTITY(1,1) NOT NULL,
	[MaNV] [bigint] NULL,
	[MaLHD] [bigint] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHopDong]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHopDong](
	[TenLHD] [nchar](30) NULL,
	[MaLHD] [bigint] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LuongCoBan]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuongCoBan](
	[MaLCB] [bigint] IDENTITY(1,1) NOT NULL,
	[Luong] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLCB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaND] [bigint] NOT NULL,
	[MatKhau] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [bigint] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[QueQuan] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[email] [varchar](50) NULL,
	[MaPB] [bigint] NULL,
	[SDT] [char](10) NULL,
	[CMT] [nvarchar](20) NOT NULL,
	[NgayBatDau] [date] NULL,
	[MaLCB] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhatKy]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhatKy](
	[MaNK] [bigint] IDENTITY(1,1) NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[MaND] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPB] [bigint] IDENTITY(1,1) NOT NULL,
	[TenPB] [nvarchar](50) NOT NULL,
	[MaTP] [bigint] NULL,
	[NgayNhanChuc] [date] NULL,
	[TongNV] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanNhan]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThanNhan](
	[MaTN] [bigint] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[SDT] [char](10) NULL,
	[MaNV] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongTinTT]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinTT](
	[MaTT] [bigint] NOT NULL,
	[MaNV] [bigint] NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC,
	[MaNV] ASC,
	[NgayBatDau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangThai]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[MaTT] [bigint] IDENTITY(1,1) NOT NULL,
	[TenTT] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Ca] ([MaCa], [TenCa]) VALUES (0, N'Đêm')
INSERT [dbo].[Ca] ([MaCa], [TenCa]) VALUES (1, N'Ngày')
SET IDENTITY_INSERT [dbo].[ChamCong] ON 

INSERT [dbo].[ChamCong] ([MaChamCong], [Ngay], [MaCa], [MaNV]) VALUES (1, CAST(N'2019-05-15' AS Date), 1, 1)
INSERT [dbo].[ChamCong] ([MaChamCong], [Ngay], [MaCa], [MaNV]) VALUES (2, CAST(N'2019-05-16' AS Date), 1, 1)
SET IDENTITY_INSERT [dbo].[ChamCong] OFF
INSERT [dbo].[ChiTietCV] ([MaCV], [MaNV], [MaPB], [NgayBatDau], [NgayKetThuc]) VALUES (1, 1, 1, CAST(N'2016-05-02' AS Date), NULL)
INSERT [dbo].[ChiTietCV] ([MaCV], [MaNV], [MaPB], [NgayBatDau], [NgayKetThuc]) VALUES (1, 2, 2, CAST(N'2108-05-04' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (1, N'Trưởng phòng')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (2, N'Nhân viên')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (3, N'kế toán')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
SET IDENTITY_INSERT [dbo].[CongTy] ON 

INSERT [dbo].[CongTy] ([MaCTy], [TenCTy], [DiaChi], [ChuTich], [Hotline]) VALUES (1, N'SVN', N'236 Hoàng Quốc Việt', N'GIT', N'02417628734         ')
SET IDENTITY_INSERT [dbo].[CongTy] OFF
SET IDENTITY_INSERT [dbo].[LoaiHopDong] ON 

INSERT [dbo].[LoaiHopDong] ([TenLHD], [MaLHD]) VALUES (N'3 năm                         ', 1)
INSERT [dbo].[LoaiHopDong] ([TenLHD], [MaLHD]) VALUES (N'5 năm                         ', 2)
INSERT [dbo].[LoaiHopDong] ([TenLHD], [MaLHD]) VALUES (N'vô thời hạn                   ', 3)
SET IDENTITY_INSERT [dbo].[LoaiHopDong] OFF
SET IDENTITY_INSERT [dbo].[LuongCoBan] ON 

INSERT [dbo].[LuongCoBan] ([MaLCB], [Luong]) VALUES (1, 3500000.0000)
INSERT [dbo].[LuongCoBan] ([MaLCB], [Luong]) VALUES (2, 4000000.0000)
INSERT [dbo].[LuongCoBan] ([MaLCB], [Luong]) VALUES (3, 4500000.0000)
INSERT [dbo].[LuongCoBan] ([MaLCB], [Luong]) VALUES (4, 5000000.0000)
SET IDENTITY_INSERT [dbo].[LuongCoBan] OFF
INSERT [dbo].[NguoiDung] ([MaND], [MatKhau]) VALUES (1001, N'matkhau1')
INSERT [dbo].[NguoiDung] ([MaND], [MatKhau]) VALUES (1002, N'matkhau2')
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [QueQuan], [NgaySinh], [email], [MaPB], [SDT], [CMT], [NgayBatDau], [MaLCB]) VALUES (1, N'Nguyễn Văn Anh', N'Phù Lãng, Quế Võ, Bắc Ninh', CAST(N'1978-05-03' AS Date), N'a@gmail.com', 1, N'System.Win', N'0336458974', CAST(N'2012-06-05' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [QueQuan], [NgaySinh], [email], [MaPB], [SDT], [CMT], [NgayBatDau], [MaLCB]) VALUES (2, N'Nguyễn Thị Bích', N'Trần Cung, Cổ Nhuế, Bắc Từ Liêm, Hà Nội', CAST(N'1986-06-05' AS Date), N'b@gmail.com', 2, N'0364758765', N'3872387845274', CAST(N'2016-06-05' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [QueQuan], [NgaySinh], [email], [MaPB], [SDT], [CMT], [NgayBatDau], [MaLCB]) VALUES (3, N'Hoài', NULL, NULL, NULL, NULL, NULL, N'132743854', NULL, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [QueQuan], [NgaySinh], [email], [MaPB], [SDT], [CMT], [NgayBatDau], [MaLCB]) VALUES (8, N'Nguyễn Thị Hoài', N'Bắc Ninh', CAST(N'2019-05-13' AS Date), N'a@gmail.com', 1, N'System.Win', N'0958374658', CAST(N'2019-05-13' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [QueQuan], [NgaySinh], [email], [MaPB], [SDT], [CMT], [NgayBatDau], [MaLCB]) VALUES (10, N'Nguyễn Văn Anh', N'Phù Lãng, Quế Võ, Bắc Ninh', CAST(N'1978-05-03' AS Date), N'a@gmail.com', 1, N'System.Win', N'0336458974', CAST(N'2012-06-05' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [QueQuan], [NgaySinh], [email], [MaPB], [SDT], [CMT], [NgayBatDau], [MaLCB]) VALUES (12, N'Hoa', N'Hà Nội', CAST(N'2019-05-18' AS Date), N'c@gmail.com', 1, N'0123456789', N'826478325873', CAST(N'2019-05-18' AS Date), 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [QueQuan], [NgaySinh], [email], [MaPB], [SDT], [CMT], [NgayBatDau], [MaLCB]) VALUES (13, N'hoài', N'Hà Nội', CAST(N'2019-05-18' AS Date), N'c@gmail.com', 1, N'0123456789', N'826478325873', CAST(N'2019-05-18' AS Date), 1)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[NhatKy] ON 

INSERT [dbo].[NhatKy] ([MaNK], [Ngay], [MaND]) VALUES (1, CAST(N'2019-05-17 20:15:57.760' AS DateTime), 1001)
INSERT [dbo].[NhatKy] ([MaNK], [Ngay], [MaND]) VALUES (2, CAST(N'2019-05-17 20:17:46.290' AS DateTime), 1001)
INSERT [dbo].[NhatKy] ([MaNK], [Ngay], [MaND]) VALUES (3, CAST(N'2019-05-17 20:53:49.217' AS DateTime), 1001)
INSERT [dbo].[NhatKy] ([MaNK], [Ngay], [MaND]) VALUES (4, CAST(N'2019-05-17 20:54:12.463' AS DateTime), 1001)
INSERT [dbo].[NhatKy] ([MaNK], [Ngay], [MaND]) VALUES (5, CAST(N'2019-05-17 20:55:28.767' AS DateTime), 1001)
INSERT [dbo].[NhatKy] ([MaNK], [Ngay], [MaND]) VALUES (6, CAST(N'2019-05-17 20:59:21.180' AS DateTime), 1001)
INSERT [dbo].[NhatKy] ([MaNK], [Ngay], [MaND]) VALUES (7, CAST(N'2019-05-17 21:01:41.880' AS DateTime), 1001)
INSERT [dbo].[NhatKy] ([MaNK], [Ngay], [MaND]) VALUES (8, CAST(N'2019-05-17 21:03:25.277' AS DateTime), 1001)
INSERT [dbo].[NhatKy] ([MaNK], [Ngay], [MaND]) VALUES (9, CAST(N'2019-05-17 21:06:40.207' AS DateTime), 1001)
SET IDENTITY_INSERT [dbo].[NhatKy] OFF
SET IDENTITY_INSERT [dbo].[PhongBan] ON 

INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNhanChuc], [TongNV]) VALUES (1, N'kinh tế', 1, CAST(N'2017-05-26' AS Date), 1)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNhanChuc], [TongNV]) VALUES (2, N'Kĩ thuật', 2, CAST(N'2016-03-04' AS Date), 1)
SET IDENTITY_INSERT [dbo].[PhongBan] OFF
SET IDENTITY_INSERT [dbo].[TrangThai] ON 

INSERT [dbo].[TrangThai] ([MaTT], [TenTT]) VALUES (1, N'Bình thường')
INSERT [dbo].[TrangThai] ([MaTT], [TenTT]) VALUES (2, N'Thai sản')
INSERT [dbo].[TrangThai] ([MaTT], [TenTT]) VALUES (3, N'Nghỉ ốm dài ngày')
SET IDENTITY_INSERT [dbo].[TrangThai] OFF
ALTER TABLE [dbo].[ChiTietLuong] ADD  DEFAULT ((0)) FOR [TongNgay]
GO
ALTER TABLE [dbo].[ChiTietLuong] ADD  DEFAULT ((0)) FOR [TongDem]
GO
ALTER TABLE [dbo].[ChiTietLuong] ADD  DEFAULT ((525000)) FOR [TienBaoHiem]
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD FOREIGN KEY([MaCa])
REFERENCES [dbo].[Ca] ([MaCa])
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChiTietCV]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChiTietCV]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[ChiTietCV]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietCV_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[ChiTietCV] CHECK CONSTRAINT [FK_ChiTietCV_ChucVu]
GO
ALTER TABLE [dbo].[ChiTietLuong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDong_LoaiHopDong] FOREIGN KEY([MaLHD])
REFERENCES [dbo].[LoaiHopDong] ([MaLHD])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_HopDong_LoaiHopDong]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaLCB])
REFERENCES [dbo].[LuongCoBan] ([MaLCB])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[NhatKy]  WITH CHECK ADD FOREIGN KEY([MaND])
REFERENCES [dbo].[NguoiDung] ([MaND])
GO
ALTER TABLE [dbo].[ThanNhan]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ThongTinTT]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ThongTinTT]  WITH CHECK ADD FOREIGN KEY([MaTT])
REFERENCES [dbo].[TrangThai] ([MaTT])
GO
/****** Object:  StoredProcedure [dbo].[DSChamCong]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DSChamCong] @Ngay date
as
begin
	select MaNV, MaCa, Ngay
	from ChamCong 
	where Ngay = @Ngay
end
GO
/****** Object:  StoredProcedure [dbo].[LayLuong]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayLuong]
as
begin
	insert into ChiTietLuong(MaNV,TongNgay,TongDem)
	select cc.MaNV, n.Ngay, Dem
	from ChamCong cc, (select count(*) Ngay, MaNV from chamcong where MaCa = 1 group by MaNV) as n, (select count(*) Dem, MaNV from chamcong where MaCa = 0 group by MaNV) as d
	where cc.MaNV = n.MaNV and d.MaNV = cc.MaNV
	group by cc.MaNV, n.Ngay, Dem
end 
GO
/****** Object:  StoredProcedure [dbo].[Luong]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Luong]
as
begin
	insert into ChiTietLuong(MaNV,TongNgay,TongDem)
	select cc.MaNV, n.Ngay, Dem
	from ChamCong cc, (select count(*) Ngay, MaNV from chamcong where MaCa = 1 group by MaNV) as n, (select count(*) Dem, MaNV from chamcong where MaCa = 0 group by MaNV) as d
	where cc.MaNV = n.MaNV and d.MaNV = cc.MaNV
	group by cc.MaNV, n.Ngay, Dem
end 

GO
/****** Object:  StoredProcedure [dbo].[SuaCT]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaCT](@TenCTy nvarchar(50),@DiaChi nvarchar(200),@ChuTich nvarchar(30),@Hotline nchar(20))
as
begin
declare @ma int
select top 1 @ma = MaCty
from CongTy
	update CongTy
	set TenCTy = @TenCTy, DiaChi = @DiaChi ,ChuTich = @ChuTich ,Hotline = @Hotline
	where MaCTy = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[SuaCTy]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaCTy](@TenCTy nvarchar(50),@DiaChi nvarchar(200),@ChuTich nvarchar(30),@Hotline nchar(20))
as
begin
	update CongTy
	set TenCTy = @TenCTy, DiaChi = @DiaChi ,ChuTich = @ChuTich ,Hotline = @Hotline
end
GO
/****** Object:  StoredProcedure [dbo].[SuaNV]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuaNV](@HoTen nvarchar(50),@MaPB bigint,@NgaySinh date,@QueQuan nvarchar(100), @email nvarchar(50),@sdt char(10),@CMT NVARCHAR(20),@NgayBatDau DATE,@MaNV BIGINT)
as
begin
update NhanVien 
set HoTen = @HoTen, MaPB = @MaPB,NgaySinh = @NgaySinh, QueQuan = @QueQuan,email = @email, CMT = @CMT, NgayBatDau = @NgayBatDau, SDt = @SDT
where MaNV = @MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[ThemChamCong]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemChamCong](@Ngay date, @MaNV bigint, @MaCa bigint)
as
begin
	insert into ChamCong
	values (@Ngay,@MaCa,@MaNV)
end
GO
/****** Object:  StoredProcedure [dbo].[ThemCTCV]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemCTCV](@MaCV bigint, @MaNV bigint, @MaPB bigint, @NgayBD date)
as
begin
	insert into ChiTietCV(MaCV,MaNV,MaPB,NgayBatDau)
	values (@MaCV,@MaNV,@MaPB,@NgayBD)
end

GO
/****** Object:  StoredProcedure [dbo].[ThemCty]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemCty](@TenCTy nvarchar(50),@DiaChi nvarchar(200),@ChuTich nvarchar(30),@Hotline nchar(20))
as
begin
	insert into CongTy
	values ( @TenCTy, @DiaChi, @ChuTich, @HotLine)
end


GO
/****** Object:  StoredProcedure [dbo].[ThemHD]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemHD] @MaNV bigint, @MaLHD bigint
as
begin 
	insert into HopDong
	values (@MaNV,@MaLHd)
end
GO
/****** Object:  StoredProcedure [dbo].[ThemNK]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemNK] @MaND bigint
as
begin
	insert into NhatKy
	values (GETDATE(),@MaND)
end
GO
/****** Object:  StoredProcedure [dbo].[ThemNV]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemNV](@HoTen nvarchar(50), @QueQuan nvarchar(100), @NgaySinh date , @email nvarchar(50), @MaPB bigint, @SDT char(10), @CMT nvarchar(20) , @NgayBD date,@MaLCB bigint)
as
begin
	insert into NhanVien
	values (@HoTen , @QueQuan , @NgaySinh , @email , @MaPB , @SDT , @CMT , @NgayBD, @MaLCB)
end
GO
/****** Object:  StoredProcedure [dbo].[ThemTT]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemTT] @MaNV bigint, @MaTT bigint, @NgayBD date
as
begin
	insert into ThongTinTT
	values (@MaTT,@MaNV,@NgayBD,null)
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemLuongMa]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimKiemLuongMa] @ma bigint
as
begin
	select MaNV, TongSoNgay, TongSoDem, Luong
	from ChiTietLuong
	where MaNV = @Ma
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemLuongThang]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimKiemLuongThang] @Date date
as
begin
	select MaNV, TongSoNgay, TongSoDem, Luong
	from ChiTietLuong
	where year(Ngay) = year(@Date) and month(Ngay) = month(@Date)
end
GO
/****** Object:  StoredProcedure [dbo].[TimMaNV]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimMaNV] @Ma bigint
as
begin
	select  MaNV, MaCa, Ngay
	from ChamCong 
	where MaNV = @Ma
end
GO
/****** Object:  StoredProcedure [dbo].[TimNKMa]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimNKMa] (@Ma bigint)
as
begin
	select MaNK, MaND, Ngay
	from NhatKy
	where MaND = @Ma
	
end
GO
/****** Object:  StoredProcedure [dbo].[TimNKNgay]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimNKNgay] (@Ngay date)
as
begin
	select MaNK, MaND, Ngay
	from NhatKy
	where year(ngay) = year(@ngay) and month(ngay) = month(@ngay) and day(ngay) = day(@ngay)
	
end
GO
/****** Object:  StoredProcedure [dbo].[TimNV]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TimNV] @search nvarchar(30)
as
begin
	select * from NhanVien
	where HoTen like N'%'+@search+'%' or MaNV like @search
end

GO
/****** Object:  Trigger [dbo].[TongLuong]    Script Date: 19-May-19 7:38:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[TongLuong] on [dbo].[ChiTietLuong] for insert
as
begin
	declare @TongNgay int, @TongDem int, @MaNV bigint, @LCB money, @LN money
	select @TongNgay = TongNgay, @TongDem = TongDem, @MaNV = MaNV
	from inserted
	select @LCB = Luong from NhanVien nv, LuongCoBan lcb where nv.MaLCB = lcb.MaLCB and MaNV = @MaNV
	set @LN = @LCB / 26;
	update ChiTietLuong 
	set Luong = @TongNgay*@LN + @TongDem*(@LN + 200000) - TienBaoHiem
	where MaNV = @MaNV
end
GO
USE [master]
GO
ALTER DATABASE [QLNS] SET  READ_WRITE 
GO
