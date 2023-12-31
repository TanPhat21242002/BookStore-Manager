USE [master]
GO
/****** Object:  Database [QUANLYNHASACH]    Script Date: 6/7/2022 10:38:53 AM ******/
CREATE DATABASE [QUANLYNHASACH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYNHASACH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TANPHAT\MSSQL\DATA\QUANLYNHASACH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLYNHASACH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TANPHAT\MSSQL\DATA\QUANLYNHASACH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QUANLYNHASACH] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYNHASACH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYNHASACH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYNHASACH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYNHASACH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLYNHASACH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYNHASACH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET RECOVERY FULL 
GO
ALTER DATABASE [QUANLYNHASACH] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYNHASACH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYNHASACH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYNHASACH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYNHASACH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYNHASACH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLYNHASACH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUANLYNHASACH', N'ON'
GO
ALTER DATABASE [QUANLYNHASACH] SET QUERY_STORE = OFF
GO
USE [QUANLYNHASACH]
GO
/****** Object:  Table [dbo].[CT_TACGIA]    Script Date: 6/7/2022 10:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_TACGIA](
	[MaDauSach] [int] NOT NULL,
	[TenTacGia] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDauSach] ASC,
	[TenTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 6/7/2022 10:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[Passwd] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DAUSACH]    Script Date: 6/7/2022 10:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAUSACH](
	[MaDauSach] [int] IDENTITY(1,1) NOT NULL,
	[TenDauSach] [nvarchar](50) NOT NULL,
	[TenTacGia] [nvarchar](50) NULL,
	[MaTheLoai] [int] NOT NULL,
 CONSTRAINT [PK__DAUSACH__AB6F2B5F9F846E05] PRIMARY KEY CLUSTERED 
(
	[MaDauSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 6/7/2022 10:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[SoHD] [int] IDENTITY(1,1) NOT NULL,
	[MaSach] [int] NULL,
	[MaNV] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgHD] [smalldatetime] NOT NULL,
	[TongTien] [int] NOT NULL,
	[SoTienTra] [int] NOT NULL,
	[ConLai]  AS ([TongTien]-[SoTienTra]),
 CONSTRAINT [PK__HOADON__BC3CAB57F9E701F3] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 6/7/2022 10:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[SDT] [char](15) NULL,
	[SoTienNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 6/7/2022 10:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[MaDauSach] [int] NOT NULL,
	[NhaXuatBan] [nvarchar](50) NOT NULL,
	[NamXuatBan] [int] NOT NULL,
	[SoLuongTon] [int] NOT NULL,
	[DonGiaBan] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 6/7/2022 10:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTheLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenTheLoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_TACGIA]  WITH CHECK ADD  CONSTRAINT [FK__CT_TACGIA__MaDau__29572725] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DAUSACH] ([MaDauSach])
GO
ALTER TABLE [dbo].[CT_TACGIA] CHECK CONSTRAINT [FK__CT_TACGIA__MaDau__29572725]
GO
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD  CONSTRAINT [FK_DAUSACH_THELOAI] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[THELOAI] ([MaTheLoai])
GO
ALTER TABLE [dbo].[DAUSACH] CHECK CONSTRAINT [FK_DAUSACH_THELOAI]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HOADON__MaKH__36B12243] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HOADON__MaKH__36B12243]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HOADON__MaNV__35BCFE0A] FOREIGN KEY([MaNV])
REFERENCES [dbo].[DANGNHAP] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HOADON__MaNV__35BCFE0A]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_SACH]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK__SACH__MaDauSach__2C3393D0] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DAUSACH] ([MaDauSach])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK__SACH__MaDauSach__2C3393D0]
GO
USE [master]
GO
ALTER DATABASE [QUANLYNHASACH] SET  READ_WRITE 
GO
