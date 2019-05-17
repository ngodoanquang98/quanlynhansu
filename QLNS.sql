USE [master]
GO
/****** Object:  Database [QLNS]    Script Date: 14-May-19 11:39:08 AM ******/
CREATE DATABASE [QLNS]
GO
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
/****** Object:  User [Hoai]    Script Date: 14-May-19 11:39:08 AM ******/
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
/****** Object:  Table [dbo].[Ca]    Script Date: 14-May-19 11:39:08 AM ******/
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
/****** Object:  Table [dbo].[ChamCong]    Script Date: 14-May-19 11:39:08 AM ******/
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
/****** Object:  Table [dbo].[ChiTietCV]    Script Date: 14-May-19 11:39:08 AM ******/
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
/****** Object:  Table [dbo].[ChiTietLuong]    Script Date: 14-May-19 11:39:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietLuong](
	[MaNV] [bigint] NOT NULL,
	[MaLCB] [bigint] NOT NULL,
	[TienBaoHiem] [money] NULL,
	[Luong] [money] NULL,
	[TongSoNgay] [int] NULL,
	[TongSoDem] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[MaLCB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 14-May-19 11:39:08 AM ******/
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
/****** Object:  Table [dbo].[HopDong]    Script Date: 14-May-19 11:39:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[MaHD] [bigint] IDENTITY(1,1) NOT NULL,
	[MaNV] [bigint] NULL,
	[MalHD] [bigint] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHopDong]    Script Date: 14-May-19 11:39:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHopDong](
	[MaLHD] [bigint] NOT NULL,
	[TenLHD] [nchar](30) NULL,
 CONSTRAINT [PK_LoaiHopDong] PRIMARY KEY CLUSTERED 
(
	[MaLHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LuongCoBan]    Script Date: 14-May-19 11:39:08 AM ******/
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
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 14-May-19 11:39:08 AM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 14-May-19 11:39:08 AM ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhatKy]    Script Date: 14-May-19 11:39:08 AM ******/
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
/****** Object:  Table [dbo].[PhongBan]    Script Date: 14-May-19 11:39:08 AM ******/
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
/****** Object:  Table [dbo].[ThanNhan]    Script Date: 14-May-19 11:39:08 AM ******/
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
/****** Object:  Table [dbo].[ThongTinTT]    Script Date: 14-May-19 11:39:08 AM ******/
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
/****** Object:  Table [dbo].[TrangThai]    Script Date: 14-May-19 11:39:08 AM ******/
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
INSERT [dbo].[ChiTietCV] ([MaCV], [MaNV], [MaPB], [NgayBatDau], [NgayKetThuc]) VALUES (1, 1, 1, CAST(N'2016-05-02' AS Date), NULL)
INSERT [dbo].[ChiTietCV] ([MaCV], [MaNV], [MaPB], [NgayBatDau], [NgayKetThuc]) VALUES (1, 2, 2, CAST(N'2108-05-04' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (1, N'Trưởng phòng')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (2, N'Nhân viên')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (3, N'kế toán')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [QueQuan], [NgaySinh], [email], [MaPB], [SDT], [CMT], [NgayBatDau]) VALUES (1, N'Nguyễn Văn An', N'Phù Lãng, Quế Võ, Bắc Ninh', CAST(N'1978-05-03' AS Date), N'a@gmail.com', 1, N'0336458974', N'1284794635365', CAST(N'2012-06-05' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [QueQuan], [NgaySinh], [email], [MaPB], [SDT], [CMT], [NgayBatDau]) VALUES (2, N'Nguyễn Thị Bích', N'Trần Cung, Cổ Nhuế, Bắc Từ Liêm, Hà Nội', CAST(N'1986-06-05' AS Date), N'b@gmail.com', 2, N'0364758765', N'3872387845274', CAST(N'2016-06-05' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [QueQuan], [NgaySinh], [email], [MaPB], [SDT], [CMT], [NgayBatDau]) VALUES (3, N'Hoài', NULL, NULL, NULL, NULL, NULL, N'132743854', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [QueQuan], [NgaySinh], [email], [MaPB], [SDT], [CMT], [NgayBatDau]) VALUES (8, N'Nguyễn Thị Hoài', N'Bắc Ninh', CAST(N'2019-05-13' AS Date), N'a@gmail.com', 1, N'System.Win', N'0958374658', CAST(N'2019-05-13' AS Date))
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[PhongBan] ON 

INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNhanChuc], [TongNV]) VALUES (1, N'kinh tế', 1, CAST(N'2017-05-26' AS Date), 2)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [NgayNhanChuc], [TongNV]) VALUES (2, N'Kĩ thuật', 2, CAST(N'2016-03-04' AS Date), 2)
SET IDENTITY_INSERT [dbo].[PhongBan] OFF
SET IDENTITY_INSERT [dbo].[TrangThai] ON 

INSERT [dbo].[TrangThai] ([MaTT], [TenTT]) VALUES (1, N'Bình thường')
INSERT [dbo].[TrangThai] ([MaTT], [TenTT]) VALUES (2, N'Thai sản')
INSERT [dbo].[TrangThai] ([MaTT], [TenTT]) VALUES (3, N'Nghỉ ốm dài ngày')
SET IDENTITY_INSERT [dbo].[TrangThai] OFF
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
ALTER TABLE [dbo].[ChiTietLuong]  WITH CHECK ADD FOREIGN KEY([MaLCB])
REFERENCES [dbo].[LuongCoBan] ([MaLCB])
GO
ALTER TABLE [dbo].[ChiTietLuong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([MalHD])
REFERENCES [dbo].[LoaiHopDong] ([MaLHD])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
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
/****** Object:  StoredProcedure [dbo].[ThemCTCV]    Script Date: 14-May-19 11:39:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ThemCTCV](@MaCV bigint, @MaNV bigint, @MaPB bigint, @NgayBD date, @NgayKT date)
as
begin
	insert into ChiTietCV
	values (@MaCV,@MaNV,@MaPB,@NgayBD,@NgayKT)
end
GO
/****** Object:  StoredProcedure [dbo].[ThemNV]    Script Date: 14-May-19 11:39:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemNV](@HoTen nvarchar(50), @QueQuan nvarchar(100),@NgaySinh date, @email nvarchar(50), @MaPB bigint, @SDT char(10),
@CMT nvarchar(20),@NgayBD date, @SoHD bigint )
as
begin
	 insert into NHANVIEN
	 values(@HoTen,@QueQuan,@NgaySinh,@email,@MaPB,@SDT,@CMT,@NgayBD,@SoHD)
end
GO
/****** Object:  StoredProcedure [dbo].[TimNV]    Script Date: 14-May-19 11:39:08 AM ******/
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
USE [master]
GO
ALTER DATABASE [QLNS] SET  READ_WRITE 
GO
