USE [master]
GO
/****** Object:  Database [QuanLyThuVien]    Script Date: 8/1/2021 9:47:33 PM ******/
CREATE DATABASE [QuanLyThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyThuVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyThuVien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyThuVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyThuVien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyThuVien] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyThuVien] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyThuVien] SET QUERY_STORE = OFF
GO
USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[CTPM]    Script Date: 8/1/2021 9:47:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPM](
	[MASACH] [varchar](10) NOT NULL,
	[MAPHIEUMUON] [varchar](10) NOT NULL,
	[SOLUONG] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC,
	[MAPHIEUMUON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DAUSACH]    Script Date: 8/1/2021 9:47:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAUSACH](
	[MASACH] [varchar](10) NOT NULL,
	[TENSACH] [nvarchar](30) NULL,
	[NAMXUATBAN] [char](4) NULL,
	[MATHELOAI] [varchar](10) NOT NULL,
	[MANXB] [varchar](10) NOT NULL,
	[MATACGIA] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 8/1/2021 9:47:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MADOCGIA] [varchar](10) NOT NULL,
	[TENDOCGIA] [nvarchar](30) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[SDTDOCGIA] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MADOCGIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 8/1/2021 9:47:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [varchar](10) NOT NULL,
	[HOTENNV] [nvarchar](30) NULL,
	[GIOITINHNV] [nvarchar](10) NULL,
	[NGAYSINHNV] [datetime] NULL,
	[DIACHINV] [nvarchar](100) NULL,
	[DIENTHOAINV] [char](10) NULL,
	[EMAILNV] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 8/1/2021 9:47:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MANXB] [varchar](10) NOT NULL,
	[TENNXB] [nvarchar](100) NULL,
	[DIACHINXB] [nvarchar](100) NULL,
	[DIENTHOAIXB] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUMUONTRA]    Script Date: 8/1/2021 9:47:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUONTRA](
	[MAPHIEUMUON] [varchar](10) NOT NULL,
	[NGAYMUON] [datetime] NULL,
	[NGAYTRA] [datetime] NULL,
	[MANV] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUMUON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 8/1/2021 9:47:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MATACGIA] [varchar](10) NOT NULL,
	[TENTACGIA] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MATACGIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 8/1/2021 9:47:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TENTAIKHOAN] [varchar](20) NOT NULL,
	[MATKHAU] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[TENTAIKHOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THEDOCGIA]    Script Date: 8/1/2021 9:47:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THEDOCGIA](
	[MADOCGIA] [varchar](10) NOT NULL,
	[MANV] [varchar](10) NOT NULL,
	[MATHE] [varchar](10) NOT NULL,
	[NGAYLAP] [datetime] NULL,
	[NGAYHETHAN] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MADOCGIA] ASC,
	[MATHE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 8/1/2021 9:47:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MATHELOAI] [varchar](10) NOT NULL,
	[TENTHELOAI] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MATHELOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DAUSACH] ([MASACH], [TENSACH], [NAMXUATBAN], [MATHELOAI], [MANXB], [MATACGIA]) VALUES (N'HT1', N'Công Nghệ Phần Mềm', N'2020', N'1832', N'1813', N'1801')
INSERT [dbo].[DAUSACH] ([MASACH], [TENSACH], [NAMXUATBAN], [MATHELOAI], [MANXB], [MATACGIA]) VALUES (N'HT2', N'Thuỷ Thủ Mặt Trăng', N'1   ', N'1833', N'1812', N'1801')
GO
INSERT [dbo].[DOCGIA] ([MADOCGIA], [TENDOCGIA], [DIACHI], [SDTDOCGIA]) VALUES (N'1811060740', N'Nguyễn Đức Thịnh', N'123 Trần Đình Xu, Phường Cô Giang, Quận 1,TP.HCM', N'0778923654')
INSERT [dbo].[DOCGIA] ([MADOCGIA], [TENDOCGIA], [DIACHI], [SDTDOCGIA]) VALUES (N'1811061212', N'Lê Quốc Bảo', N'12 Lê Hồng Phong , Huyện Hoài Ân, Tỉnh Bình Định', N'0908885988')
INSERT [dbo].[DOCGIA] ([MADOCGIA], [TENDOCGIA], [DIACHI], [SDTDOCGIA]) VALUES (N'1811061230', N'Trần Phan Minh Trường', N'123/7 Nguyễn Thiện Thuật, Phường 7, Quận 3,Tp.HCM', N'0769713139')
INSERT [dbo].[DOCGIA] ([MADOCGIA], [TENDOCGIA], [DIACHI], [SDTDOCGIA]) VALUES (N'1811061325', N'Lê Trọng Nhân', N'381/21a, Ấp 4, Xã Phước Kiểng, Huyện Nhà Bè, Tp.HCM', N'0907778677')
INSERT [dbo].[DOCGIA] ([MADOCGIA], [TENDOCGIA], [DIACHI], [SDTDOCGIA]) VALUES (N'1811061525', N'Bùi Doãn Minh Châu', N'34 Nguyễn Thái Sơn, phường 8, Quận Gò Vấp,TP.HCM', N'0906543789')
INSERT [dbo].[DOCGIA] ([MADOCGIA], [TENDOCGIA], [DIACHI], [SDTDOCGIA]) VALUES (N'1811062212', N'Nguyễn Văn Nam', N'12 Võ Văn Ngân, Tp.Thủ Đức,Tp.HCM', N'0907861234')
INSERT [dbo].[DOCGIA] ([MADOCGIA], [TENDOCGIA], [DIACHI], [SDTDOCGIA]) VALUES (N'1811062345', N'Trần Phan Minh Anh', N'34/23a, Ấp 8 , Xã Bình Điền, Huyện Bình Chánh, Tp.HCM', N'0773546112')
INSERT [dbo].[DOCGIA] ([MADOCGIA], [TENDOCGIA], [DIACHI], [SDTDOCGIA]) VALUES (N'1811063421', N'Phạm Đặng Minh Triết', N'34/24a Ấp 5, Xã Nhơn Tây, Huyện Nhơn Trạch, Tỉnh Đồng Nai', N'0789543216')
INSERT [dbo].[DOCGIA] ([MADOCGIA], [TENDOCGIA], [DIACHI], [SDTDOCGIA]) VALUES (N'1811063456', N'Trần Phan Minh Em', N'56 Trần Hưng Đạo , Phường Cầu Kho,Quận 1,Tp.HCM', N'0906783452')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HOTENNV], [GIOITINHNV], [NGAYSINHNV], [DIACHINV], [DIENTHOAINV], [EMAILNV]) VALUES (N'118805', N'Trần Phan Minh Trường', N'Nam', CAST(N'2000-02-29T13:49:01.000' AS DateTime), N'12/34a Huỳnh Tấn Phát,Phường 5,Quận 7,TP.HCM', N'0986652134', N'truong@gmail.com')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTENNV], [GIOITINHNV], [NGAYSINHNV], [DIACHINV], [DIENTHOAINV], [EMAILNV]) VALUES (N'118806', N'Nguyễn Văn Nam', N'Nam', CAST(N'2000-02-29T13:49:01.000' AS DateTime), N'12 Trần Phú, Phường 5 , TP Vũng Tàu', N'0971235532', N'namkut3@gmail.com')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTENNV], [GIOITINHNV], [NGAYSINHNV], [DIACHINV], [DIENTHOAINV], [EMAILNV]) VALUES (N'118807', N'Lê Bảo Hân', N'Nữ', CAST(N'2000-04-12T13:49:01.000' AS DateTime), N'15 Lê Thánh Tôn , Phường Cô Bắc, Quận 1,TP.HCM', N'0905563212', N'han@gmail.com')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTENNV], [GIOITINHNV], [NGAYSINHNV], [DIACHINV], [DIENTHOAINV], [EMAILNV]) VALUES (N'118808', N'Nguyễn Hà Phương', N'Nữ', CAST(N'2000-09-24T13:49:01.000' AS DateTime), N'25 Nguyễn Kiệm, Phường 6, Quận Phú Nhuận,TP.HCM', N'0907894562', N'Phuong@gmail.com')
GO
INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [DIACHINXB], [DIENTHOAIXB]) VALUES (N'1811', N'Kim Đồng', N'55 Quang Trung, Hai Bà Trưng, Hà Nội', N'907861234 ')
INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [DIACHINXB], [DIENTHOAIXB]) VALUES (N'1812', N'Nhà Xuất Bản Trẻ', N' 161B Lý Chính Thắng, Phường 7, Quận 3, Thành phố Hồ Chí Minh', N'39317849  ')
INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [DIACHINXB], [DIENTHOAIXB]) VALUES (N'1813', N'Tổng Hợp', N'62 Nguyễn Thị Minh Khai, Phường Đa Kao, Quận 1, TP.HCM', N'38296764  ')
INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [DIACHINXB], [DIENTHOAIXB]) VALUES (N'1814', N'Nhà xuất bản giáo dục', N' 81 Trần Hưng Đạo, Hà Nội', N'0901234561')
INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [DIACHINXB], [DIENTHOAIXB]) VALUES (N'1815', N'Nhà xuất bản Hội Nhà văn', N'Số 65 Nguyễn Du, Hà Nộ', N'38222135  ')
INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [DIACHINXB], [DIENTHOAIXB]) VALUES (N'1816', N'Nhà xuất bản Tư pháp', N' Số 35 Trần Quốc Toản, Hoàn Kiếm, Hà Nội', N'62632079  ')
INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [DIACHINXB], [DIENTHOAIXB]) VALUES (N'1817', N'Đại học Quốc Gia Hà Nộ', N'16 Hàng Chuối, Phạm Đình Hổ, Hai Bà Trưng, Hà Nội', N' 3971 4896')
GO
INSERT [dbo].[TACGIA] ([MATACGIA], [TENTACGIA]) VALUES (N'1801', N'Trần Phan Minh Trường')
INSERT [dbo].[TACGIA] ([MATACGIA], [TENTACGIA]) VALUES (N'1802', N'Trần Phan Minh Trường.')
GO
INSERT [dbo].[TAIKHOAN] ([TENTAIKHOAN], [MATKHAU]) VALUES (N'123', N'123')
GO
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'1830', N'Giáo Dục')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'1831', N'Trẻ Em')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'1832', N'Công nghệ')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'1833', N'Truyện')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'1834', N'Xã hội')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'1835', N'Kinh Tế')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'1836', N'Toiec')
GO
ALTER TABLE [dbo].[CTPM]  WITH CHECK ADD FOREIGN KEY([MAPHIEUMUON])
REFERENCES [dbo].[PHIEUMUONTRA] ([MAPHIEUMUON])
GO
ALTER TABLE [dbo].[CTPM]  WITH CHECK ADD FOREIGN KEY([MASACH])
REFERENCES [dbo].[DAUSACH] ([MASACH])
GO
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD FOREIGN KEY([MANXB])
REFERENCES [dbo].[NHAXUATBAN] ([MANXB])
GO
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD FOREIGN KEY([MATACGIA])
REFERENCES [dbo].[TACGIA] ([MATACGIA])
GO
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD FOREIGN KEY([MATHELOAI])
REFERENCES [dbo].[THELOAI] ([MATHELOAI])
GO
ALTER TABLE [dbo].[PHIEUMUONTRA]  WITH CHECK ADD FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[THEDOCGIA]  WITH CHECK ADD FOREIGN KEY([MADOCGIA])
REFERENCES [dbo].[DOCGIA] ([MADOCGIA])
GO
ALTER TABLE [dbo].[THEDOCGIA]  WITH CHECK ADD FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVien] SET  READ_WRITE 
GO
