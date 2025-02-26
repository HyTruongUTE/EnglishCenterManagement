USE [master]
GO
/****** Object:  Database [QL_EnglishCenter_Test]    Script Date: 5/15/2023 10:17:38 PM ******/
CREATE DATABASE [QL_EnglishCenter_Test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_EnglishCenter_Test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\QL_EnglishCenter_Test.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_EnglishCenter_Test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\QL_EnglishCenter_Test_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_EnglishCenter_Test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET  MULTI_USER 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET QUERY_STORE = OFF
GO
USE [QL_EnglishCenter_Test]
GO
USE [QL_EnglishCenter_Test]
GO
/****** Object:  Sequence [dbo].[giaovienSeq]    Script Date: 5/15/2023 10:17:38 PM ******/
CREATE SEQUENCE [dbo].[giaovienSeq] 
 AS [bigint]
 START WITH 1100
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [QL_EnglishCenter_Test]
GO
/****** Object:  Sequence [dbo].[LopHocSeq]    Script Date: 5/15/2023 10:17:38 PM ******/
CREATE SEQUENCE [dbo].[LopHocSeq] 
 AS [bigint]
 START WITH 1100
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [QL_EnglishCenter_Test]
GO
/****** Object:  Sequence [dbo].[sinhvienSeq]    Script Date: 5/15/2023 10:17:38 PM ******/
CREATE SEQUENCE [dbo].[sinhvienSeq] 
 AS [bigint]
 START WITH 1100
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tentaikhoan] [varchar](50) NOT NULL,
	[note] [nvarchar](max) NULL,
	[matkhau] [varchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[tentaikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDaDoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDaDoc](
	[mathongbao] [varchar](50) NOT NULL,
	[manguoidoc] [varchar](50) NOT NULL,
	[dadoc] [int] NULL,
 CONSTRAINT [PK_tblDaDoc] PRIMARY KEY CLUSTERED 
(
	[mathongbao] ASC,
	[manguoidoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDiem]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDiem](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](50) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](50) NULL,
	[mahocvien] [varchar](50) NOT NULL,
	[malophoc] [varchar](50) NOT NULL,
	[lanhoc] [int] NOT NULL,
	[diemthigiuaki] [float] NULL,
	[diemthicuoiki] [float] NULL,
 CONSTRAINT [PK_tblDiem_1] PRIMARY KEY CLUSTERED 
(
	[mahocvien] ASC,
	[malophoc] ASC,
	[lanhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiaoVien](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](50) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](50) NULL,
	[magiaovien] [varchar](50) NOT NULL,
	[ho] [nvarchar](50) NOT NULL,
	[tendem] [nvarchar](50) NULL,
	[ten] [nvarchar](50) NOT NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [tinyint] NULL,
	[diachi] [nvarchar](150) NULL,
	[email] [varchar](150) NULL,
	[dienthoai] [varchar](50) NULL,
	[thuong] [float] NULL,
	[luong] [float] NULL,
	[note] [nvarchar](max) NULL,
	[ielts] [float] NULL,
	[toeic] [float] NULL,
	[matkhau] [varchar](50) NULL,
 CONSTRAINT [PK_tblGiaoVien] PRIMARY KEY CLUSTERED 
(
	[magiaovien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHocVien](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](50) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](50) NULL,
	[mahocvien] [varchar](50) NOT NULL,
	[ho] [nvarchar](50) NOT NULL,
	[tendem] [nvarchar](50) NULL,
	[ten] [nvarchar](50) NOT NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [tinyint] NULL,
	[diachi] [nvarchar](150) NULL,
	[dienthoai] [varchar](50) NULL,
	[email] [varchar](150) NULL,
	[note] [nvarchar](max) NULL,
	[hocbong] [float] NULL,
	[hocphi] [float] NULL,
	[matkhau] [varchar](50) NULL,
 CONSTRAINT [PK_tblHocVien] PRIMARY KEY CLUSTERED 
(
	[mahocvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhoaHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhoaHoc](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](50) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](50) NULL,
	[makhoahoc] [varchar](50) NOT NULL,
	[tenkhoahoc] [nvarchar](150) NULL,
	[thoigianbatdau] [float] NULL,
	[thoigianketthuc] [float] NULL,
	[sotien] [float] NULL,
 CONSTRAINT [PK_tblKhoaHoc] PRIMARY KEY CLUSTERED 
(
	[makhoahoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKiemTra]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKiemTra](
	[mabaikiemtra] [varchar](50) NOT NULL,
	[deso] [int] NULL,
	[de] [varchar](max) NULL,
	[cauhoi1] [varchar](max) NULL,
	[cauhoi2] [varchar](max) NULL,
	[cauhoi3] [varchar](max) NULL,
	[cauhoi4] [varchar](max) NULL,
	[dapan1] [varchar](50) NULL,
	[explain1] [nvarchar](max) NULL,
	[dapan2] [varchar](50) NULL,
	[explain2] [nvarchar](max) NULL,
	[dapan3] [varchar](50) NULL,
	[explain3] [nvarchar](max) NULL,
	[dapan4] [varchar](50) NULL,
	[explain4] [nvarchar](max) NULL,
	[malophoc] [varchar](50) NULL,
 CONSTRAINT [PK_tblKiemTra] PRIMARY KEY CLUSTERED 
(
	[mabaikiemtra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLopHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLopHoc](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](50) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](50) NULL,
	[malophoc] [varchar](50) NOT NULL,
	[makhoahoc] [varchar](50) NULL,
	[magiaovien] [varchar](50) NULL,
	[buoi1] [int] NULL,
	[buoi2] [int] NULL,
	[buoi3] [int] NULL,
	[daketthuc] [tinyint] NULL,
	[thoigianbatdau] [float] NULL,
	[thoigianketthuc] [float] NULL,
 CONSTRAINT [PK_tblLopHoc] PRIMARY KEY CLUSTERED 
(
	[malophoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThongBao]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThongBao](
	[mathongbao] [varchar](50) NOT NULL,
	[malophoc] [varchar](50) NOT NULL,
	[tieude] [nvarchar](max) NULL,
	[noidung] [nvarchar](max) NULL,
	[ngaygui] [datetime] NULL,
	[giaovienseen] [int] NULL,
	[hocvienseen] [int] NULL,
	[adminseen] [int] NULL,
	[manguoigui] [nchar](10) NULL,
 CONSTRAINT [PK_tblThongBao] PRIMARY KEY CLUSTERED 
(
	[mathongbao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([tentaikhoan], [note], [matkhau]) VALUES (N'admin', NULL, N'admin')
GO
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mahocvien], [malophoc], [lanhoc], [diemthigiuaki], [diemthicuoiki]) VALUES (CAST(N'2023-05-04T18:29:29.887' AS DateTime), N'23sv1111', CAST(N'2023-05-04T18:29:29.887' AS DateTime), N'admin', N'23SV1111', N'A1176', 1, 10, 9)
GO
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [diachi], [email], [dienthoai], [thuong], [luong], [note], [ielts], [toeic], [matkhau]) VALUES (CAST(N'2023-03-17T16:32:16.787' AS DateTime), N'admin', CAST(N'2023-03-17T16:32:16.787' AS DateTime), N'admin', N'23GV1111', N'Nguyễn', N'Thị Thu', N'Hương', CAST(N'1987-01-01' AS Date), 0, N'dsdsd', N'thumai@gmail.com', N'0123456789', 200, NULL, N' lop a1112 se tewewe uan nay ', 0, 112, N'123')
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [diachi], [email], [dienthoai], [thuong], [luong], [note], [ielts], [toeic], [matkhau]) VALUES (CAST(N'2023-03-17T16:32:16.790' AS DateTime), N'admin', CAST(N'2023-03-17T16:32:16.790' AS DateTime), N'admin', N'23GV1112', N'Trần', N'Trung', N'Quân', CAST(N'1987-01-01' AS Date), 1, N'Địa chỉ của thầy Quân', N'trungquan@gmail.com', N'0123456789', 0, NULL, N' ', NULL, NULL, N'123')
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [diachi], [email], [dienthoai], [thuong], [luong], [note], [ielts], [toeic], [matkhau]) VALUES (CAST(N'2023-03-17T16:32:16.790' AS DateTime), N'admin', CAST(N'2023-03-17T16:32:16.790' AS DateTime), N'admin', N'23GV1113', N'Nguyễn', N'Thị Thu', N'Hương', CAST(N'1987-01-01' AS Date), 0, N'Địa chỉ của cô giáo Thảo', N'thuthao@gmail.com', N'0123456789', 0, NULL, N' ', 0, 0, N'123')
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [diachi], [email], [dienthoai], [thuong], [luong], [note], [ielts], [toeic], [matkhau]) VALUES (CAST(N'2023-03-17T16:32:16.790' AS DateTime), N'admin', CAST(N'2023-03-17T16:32:16.790' AS DateTime), N'admin', N'23GV1114', N'Nguyễn', N'Đăng', N'Nhất', CAST(N'1987-01-01' AS Date), 1, N'Địa chỉ của thầy Nhất', N'dangnhat@gmail.com', N'0123456789', 0, NULL, N' ', NULL, NULL, N'123')
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [diachi], [email], [dienthoai], [thuong], [luong], [note], [ielts], [toeic], [matkhau]) VALUES (CAST(N'2023-03-17T16:32:16.790' AS DateTime), N'admin', CAST(N'2023-03-17T16:32:16.790' AS DateTime), N'admin', N'23GV1115', N'Nguyễn', N'Thị Đông', N'Hà', CAST(N'1987-01-01' AS Date), 0, N'Địa chỉ của cô giáo Đông Hà', N'dongha@gmail.com', N'0123456789', 0, NULL, N' ', 0, 0, N'123')
GO
INSERT [dbo].[tblHocVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mahocvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [diachi], [dienthoai], [email], [note], [hocbong], [hocphi], [matkhau]) VALUES (CAST(N'2023-05-10T22:49:29.367' AS DateTime), N'admin', CAST(N'2023-05-10T22:49:29.367' AS DateTime), N'admin', N'23SV1100', N'swsw', N'', N'', CAST(N'2000-12-12' AS Date), 1, N'', N'', N'', N' ', 100, NULL, N'123')
INSERT [dbo].[tblHocVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mahocvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [diachi], [dienthoai], [email], [note], [hocbong], [hocphi], [matkhau]) VALUES (CAST(N'2023-03-17T16:33:18.733' AS DateTime), N'admin', CAST(N'2023-03-17T16:33:18.733' AS DateTime), N'admin', N'23SV1107', N'Nguyễn', N'Như', N'Ngọc', CAST(N'2002-12-02' AS Date), 1, N'', N'', N'012345689', N' ', 0, NULL, N'123')
INSERT [dbo].[tblHocVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mahocvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [diachi], [dienthoai], [email], [note], [hocbong], [hocphi], [matkhau]) VALUES (CAST(N'2023-03-17T16:33:18.733' AS DateTime), N'admin', CAST(N'2023-03-17T16:33:18.733' AS DateTime), N'admin', N'23SV1108', N'Nguyễn', N'Trí', N'Thành', CAST(N'2002-12-02' AS Date), 1, NULL, NULL, N'012345689', N' ', 0, NULL, N'123')
INSERT [dbo].[tblHocVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mahocvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [diachi], [dienthoai], [email], [note], [hocbong], [hocphi], [matkhau]) VALUES (CAST(N'2023-03-17T16:33:18.733' AS DateTime), N'admin', CAST(N'2023-03-17T16:33:18.733' AS DateTime), N'admin', N'23SV1109', N'Trần', N'Văn', N'Khải', CAST(N'2002-12-02' AS Date), 1, N'', N'', N'@gmail', N' ', 0, NULL, N'123')
INSERT [dbo].[tblHocVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mahocvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [diachi], [dienthoai], [email], [note], [hocbong], [hocphi], [matkhau]) VALUES (CAST(N'2023-03-17T18:25:23.580' AS DateTime), N'admin', CAST(N'2023-03-17T18:25:23.580' AS DateTime), N'admin', N'23SV1111', N'Nguyễn', N'Ngọc', N'Quang', CAST(N'2001-03-12' AS Date), 1, N'dsdsd', N'1212313131', N'vinh@gmail', N'tuan3 kiem', 100000, 7200000, N'123')
INSERT [dbo].[tblHocVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mahocvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [diachi], [dienthoai], [email], [note], [hocbong], [hocphi], [matkhau]) VALUES (CAST(N'2023-03-17T18:26:04.370' AS DateTime), N'admin', CAST(N'2023-03-17T18:26:04.370' AS DateTime), N'admin', N'23SV1112', N'Nguyễn ', N'Quang', N'Thiện', CAST(N'2001-03-12' AS Date), 1, N'', N'', N'', N' ', 0, NULL, N'123')
GO
INSERT [dbo].[tblKhoaHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [makhoahoc], [tenkhoahoc], [thoigianbatdau], [thoigianketthuc], [sotien]) VALUES (CAST(N'2023-03-25T07:54:24.507' AS DateTime), N'admin', CAST(N'2023-03-25T07:54:24.507' AS DateTime), N'admin', N'Speaking_3', N'Khóa học Speaking cho người lớn', 21, 22.3, 11500000)
INSERT [dbo].[tblKhoaHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [makhoahoc], [tenkhoahoc], [thoigianbatdau], [thoigianketthuc], [sotien]) VALUES (CAST(N'2023-03-17T16:50:57.960' AS DateTime), N'admin', CAST(N'2023-04-10T00:09:16.420' AS DateTime), N'admin', N'Toeic_1', N'Khóa học Toeic Level 1', NULL, NULL, 4600000)
INSERT [dbo].[tblKhoaHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [makhoahoc], [tenkhoahoc], [thoigianbatdau], [thoigianketthuc], [sotien]) VALUES (CAST(N'2023-03-17T16:50:33.927' AS DateTime), N'admin', CAST(N'2023-03-17T16:50:33.927' AS DateTime), N'admin', N'Toeic_2', N'Khóa học Toeic Level 2', NULL, NULL, 3700000)
INSERT [dbo].[tblKhoaHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [makhoahoc], [tenkhoahoc], [thoigianbatdau], [thoigianketthuc], [sotien]) VALUES (CAST(N'2023-04-25T14:45:44.997' AS DateTime), N'admin', CAST(N'2023-04-25T14:45:44.997' AS DateTime), N'admin', N'toiec-900', N'toiec-900', NULL, NULL, 3000000)
GO
INSERT [dbo].[tblKiemTra] ([mabaikiemtra], [deso], [de], [cauhoi1], [cauhoi2], [cauhoi3], [cauhoi4], [dapan1], [explain1], [dapan2], [explain2], [dapan3], [explain3], [dapan4], [explain4], [malophoc]) VALUES (N'KT1165', 1, N'Exercise 1:Read the reading below carefully, and then complete it with the best option A, B, C or D given below:

Voluntary work helps foster independence 
and imparts the ability to deal with different situations, 
often simulaneously, thus teaching people how to (1)____ their way through 
different systems. It therefore brings people into touch with the real worls; and, hence, equips them for the future. Initially, young adults in 
their late teens might not seem to have the expertise or 
knowledge to impart to others that say a teacher or an agriculturalist
or a nurse would have, (2)____ they do have many skills that can help 
others. And in the absence of any particular talent, their energy and 
enthusiasm can be harnessed for the benefit (3) ____ their fellow human 
beings, and ultimately themselves. From all this, the gain to any community
no matter how many voluntees are involved is (4)_____ Employers will generally 
look favorably on people (5)_____ have shown an ability to work as part of a team. 
It demonstrates a willingness to learn and an independent spirit, which would be desirable
qualities in any employee.', N'Question 1: A. take     B. work     C. put     D. give', N'Question 2: A. but     B. so     C. or     D. for', N'Question 3: A. under     B. of     C. on     D. out', N'Question 4: A. impassable     B. unattainable    C. undetectable    D. immeasurable', N'B', N'Giải thích: work one’s way through: gắn bó với công việc trong 1 thời gian dài.', N'A', N'Giải thích: but nối 2 vế tương phản.', N'B', N'Giải thích: benefit of st: lợi ích của cái gì.', N'D', N'Giải thích: immeasurable: không đo được.', N'A1112')
GO
INSERT [dbo].[tblLopHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [malophoc], [makhoahoc], [magiaovien], [buoi1], [buoi2], [buoi3], [daketthuc], [thoigianbatdau], [thoigianketthuc]) VALUES (CAST(N'2023-04-07T11:16:10.940' AS DateTime), N'admin', CAST(N'2023-05-11T12:16:49.803' AS DateTime), N'23GV1111', N'A1112', N'Toeic_2', N'23GV1114', 3, 5, 7, 0, 9, 13)
INSERT [dbo].[tblLopHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [malophoc], [makhoahoc], [magiaovien], [buoi1], [buoi2], [buoi3], [daketthuc], [thoigianbatdau], [thoigianketthuc]) VALUES (CAST(N'2023-04-09T18:31:44.793' AS DateTime), N'admin', CAST(N'2023-04-11T20:35:23.317' AS DateTime), N'admin', N'A1118', N'Speaking_3', N'23GV1112', 4, 3, 6, 0, 12, 14)
INSERT [dbo].[tblLopHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [malophoc], [makhoahoc], [magiaovien], [buoi1], [buoi2], [buoi3], [daketthuc], [thoigianbatdau], [thoigianketthuc]) VALUES (CAST(N'2023-04-11T15:22:09.733' AS DateTime), N'admin', CAST(N'2023-04-11T15:22:09.733' AS DateTime), N'admin', N'A1123', N'Toeic_1', N'23GV1111', 2, 3, 4, 0, 20, 22)
INSERT [dbo].[tblLopHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [malophoc], [makhoahoc], [magiaovien], [buoi1], [buoi2], [buoi3], [daketthuc], [thoigianbatdau], [thoigianketthuc]) VALUES (CAST(N'2023-04-11T18:56:54.100' AS DateTime), N'admin', CAST(N'2023-05-09T14:55:00.293' AS DateTime), N'admin', N'A1124', N'Toeic_1', N'23GV1111', 3, 4, 5, 0, 8, 9)
INSERT [dbo].[tblLopHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [malophoc], [makhoahoc], [magiaovien], [buoi1], [buoi2], [buoi3], [daketthuc], [thoigianbatdau], [thoigianketthuc]) VALUES (CAST(N'2023-04-25T14:46:11.090' AS DateTime), N'admin', CAST(N'2023-04-25T14:46:11.090' AS DateTime), N'admin', N'A1176', N'toiec-900', N'23GV1113', 2, 4, 6, 0, 12, 14)
GO
INSERT [dbo].[tblThongBao] ([mathongbao], [malophoc], [tieude], [noidung], [ngaygui], [giaovienseen], [hocvienseen], [adminseen], [manguoigui]) VALUES (N'TB1164', N'A1124', N'dsdsds    ', N'dsdsdsd', CAST(N'2023-04-23T11:09:17.240' AS DateTime), 0, 0, 0, N'23gv1111  ')
GO
ALTER TABLE [dbo].[tblDaDoc] ADD  CONSTRAINT [DF_tblDaDoc_dadoc]  DEFAULT ((0)) FOR [dadoc]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_diemthigiuaki]  DEFAULT ((0)) FOR [diemthigiuaki]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_diemthicuoiki]  DEFAULT ((0)) FOR [diemthicuoiki]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_thuong]  DEFAULT ((0)) FOR [thuong]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_luong]  DEFAULT ((0)) FOR [luong]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_note]  DEFAULT (' ') FOR [note]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_matkhau]  DEFAULT ('123') FOR [matkhau]
GO
ALTER TABLE [dbo].[tblHocVien] ADD  CONSTRAINT [DF_tblHocVien_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblHocVien] ADD  CONSTRAINT [DF_tblHocVien_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblHocVien] ADD  CONSTRAINT [DF_tblHocVien_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblHocVien] ADD  CONSTRAINT [DF_tblHocVien_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblHocVien] ADD  CONSTRAINT [DF_tblHocVien_note]  DEFAULT (' ') FOR [note]
GO
ALTER TABLE [dbo].[tblHocVien] ADD  CONSTRAINT [DF_tblHocVien_hocbong]  DEFAULT ((0)) FOR [hocbong]
GO
ALTER TABLE [dbo].[tblHocVien] ADD  CONSTRAINT [DF_tblHocVien_matkhau]  DEFAULT ('123') FOR [matkhau]
GO
ALTER TABLE [dbo].[tblKhoaHoc] ADD  CONSTRAINT [DF_tblKhoaHoc_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblKhoaHoc] ADD  CONSTRAINT [DF_tblKhoaHoc_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblKhoaHoc] ADD  CONSTRAINT [DF_tblKhoaHoc_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblKhoaHoc] ADD  CONSTRAINT [DF_tblKhoaHoc_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblKiemTra] ADD  CONSTRAINT [DF_tblKiemTra_de]  DEFAULT ('') FOR [de]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_buoi1]  DEFAULT ((30)) FOR [buoi1]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_buoi2]  DEFAULT ((30)) FOR [buoi2]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_buoi3]  DEFAULT ((30)) FOR [buoi3]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_daketthuc]  DEFAULT ((0)) FOR [daketthuc]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_thoigianbatdau]  DEFAULT ((0)) FOR [thoigianbatdau]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_thoigianketthuc]  DEFAULT ((0)) FOR [thoigianketthuc]
GO
ALTER TABLE [dbo].[tblThongBao] ADD  CONSTRAINT [DF_tblThongBao_tieude]  DEFAULT (' ') FOR [tieude]
GO
ALTER TABLE [dbo].[tblThongBao] ADD  CONSTRAINT [DF_tblThongBao_noidung]  DEFAULT (' ') FOR [noidung]
GO
ALTER TABLE [dbo].[tblThongBao] ADD  CONSTRAINT [DF_tblThongBao_ngaygui]  DEFAULT (getdate()) FOR [ngaygui]
GO
ALTER TABLE [dbo].[tblThongBao] ADD  CONSTRAINT [DF_tblThongBao_giaovienseen]  DEFAULT ((0)) FOR [giaovienseen]
GO
ALTER TABLE [dbo].[tblThongBao] ADD  CONSTRAINT [DF_tblThongBao_hocvienseen]  DEFAULT ((0)) FOR [hocvienseen]
GO
ALTER TABLE [dbo].[tblThongBao] ADD  CONSTRAINT [DF_tblThongBao_adminseen]  DEFAULT ((0)) FOR [adminseen]
GO
ALTER TABLE [dbo].[tblThongBao] ADD  CONSTRAINT [DF_tblThongBao_manguoigui]  DEFAULT (' ') FOR [manguoigui]
GO
ALTER TABLE [dbo].[tblDaDoc]  WITH CHECK ADD  CONSTRAINT [FK_tblDaDoc_TaiKhoan] FOREIGN KEY([manguoidoc])
REFERENCES [dbo].[TaiKhoan] ([tentaikhoan])
GO
ALTER TABLE [dbo].[tblDaDoc] CHECK CONSTRAINT [FK_tblDaDoc_TaiKhoan]
GO
ALTER TABLE [dbo].[tblDaDoc]  WITH CHECK ADD  CONSTRAINT [FK_tblDaDoc_tblGiaoVien] FOREIGN KEY([manguoidoc])
REFERENCES [dbo].[tblGiaoVien] ([magiaovien])
GO
ALTER TABLE [dbo].[tblDaDoc] CHECK CONSTRAINT [FK_tblDaDoc_tblGiaoVien]
GO
ALTER TABLE [dbo].[tblDaDoc]  WITH CHECK ADD  CONSTRAINT [FK_tblDaDoc_tblHocVien] FOREIGN KEY([manguoidoc])
REFERENCES [dbo].[tblHocVien] ([mahocvien])
GO
ALTER TABLE [dbo].[tblDaDoc] CHECK CONSTRAINT [FK_tblDaDoc_tblHocVien]
GO
ALTER TABLE [dbo].[tblDaDoc]  WITH CHECK ADD  CONSTRAINT [FK_tblDaDoc_tblThongBao] FOREIGN KEY([mathongbao])
REFERENCES [dbo].[tblThongBao] ([mathongbao])
GO
ALTER TABLE [dbo].[tblDaDoc] CHECK CONSTRAINT [FK_tblDaDoc_tblThongBao]
GO
ALTER TABLE [dbo].[tblDiem]  WITH CHECK ADD  CONSTRAINT [FK_tblDiem_tblHocVien1] FOREIGN KEY([mahocvien])
REFERENCES [dbo].[tblHocVien] ([mahocvien])
GO
ALTER TABLE [dbo].[tblDiem] CHECK CONSTRAINT [FK_tblDiem_tblHocVien1]
GO
ALTER TABLE [dbo].[tblDiem]  WITH CHECK ADD  CONSTRAINT [FK_tblDiem_tblLopHoc] FOREIGN KEY([malophoc])
REFERENCES [dbo].[tblLopHoc] ([malophoc])
GO
ALTER TABLE [dbo].[tblDiem] CHECK CONSTRAINT [FK_tblDiem_tblLopHoc]
GO
ALTER TABLE [dbo].[tblKiemTra]  WITH CHECK ADD  CONSTRAINT [FK_tblKiemTra_tblLopHoc] FOREIGN KEY([malophoc])
REFERENCES [dbo].[tblLopHoc] ([malophoc])
GO
ALTER TABLE [dbo].[tblKiemTra] CHECK CONSTRAINT [FK_tblKiemTra_tblLopHoc]
GO
ALTER TABLE [dbo].[tblLopHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLopHoc_tblGiaoVien] FOREIGN KEY([magiaovien])
REFERENCES [dbo].[tblGiaoVien] ([magiaovien])
GO
ALTER TABLE [dbo].[tblLopHoc] CHECK CONSTRAINT [FK_tblLopHoc_tblGiaoVien]
GO
ALTER TABLE [dbo].[tblLopHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLopHoc_tblKhoaHoc] FOREIGN KEY([makhoahoc])
REFERENCES [dbo].[tblKhoaHoc] ([makhoahoc])
GO
ALTER TABLE [dbo].[tblLopHoc] CHECK CONSTRAINT [FK_tblLopHoc_tblKhoaHoc]
GO
ALTER TABLE [dbo].[tblThongBao]  WITH CHECK ADD  CONSTRAINT [FK_tblThongBao_tblLopHoc] FOREIGN KEY([malophoc])
REFERENCES [dbo].[tblLopHoc] ([malophoc])
GO
ALTER TABLE [dbo].[tblThongBao] CHECK CONSTRAINT [FK_tblThongBao_tblLopHoc]
GO
/****** Object:  StoredProcedure [dbo].[AdminSelectDiemHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AdminSelectDiemHocVien]
	 
	 
as
	select 
		lh.malophoc,
		kh.makhoahoc,
		kh.tenkhoahoc,
		hv.mahocvien,
		case
			when LEN(hv.tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(hv.ho, ' ', hv.tendem, ' ', hv.ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(hv.ho, ' ', hv.ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		d.diemthigiuaki, d.diemthicuoiki,(d.diemthigiuaki + d.diemthicuoiki)/ 2 as dtb
	from tblGiaoVien gv inner join tblLopHoc lh on gv.magiaovien = lh.magiaovien 
	inner join tblDiem d on lh.malophoc = d.malophoc inner join tblHocVien hv on d.mahocvien  =  hv.mahocvien
	inner join tblKhoaHoc kh on lh.makhoahoc = kh.makhoahoc

GO
/****** Object:  StoredProcedure [dbo].[AdminSelectHocPhiHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[AdminSelectHocPhiHocVien]
as
begin
	select 
		hv.mahocvien,
		sum(kh.sotien) as TienHocPhi,
		case when len(hv.tendem) > 0 then concat (hv.ho, ' ', hv.tendem, ' ', hv.ten)
		else concat(hv.ho, ' ', hv.ten) end as hvien
	from tblHocVien hv
	inner join tblDiem d on hv.mahocvien = d.mahocvien inner join tblLopHoc l on d.malophoc = l.malophoc
	inner join tblKhoaHoc kh on l.makhoahoc = kh.makhoahoc
	group by hv.mahocvien ,hv.ho, hv.tendem, hv.ten
end
GO
/****** Object:  StoredProcedure [dbo].[CountSvTheoDiem]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CountSvTheoDiem]
	@diembe varchar(50),
	@diemlon varchar(50)
as
begin
	select		
		case
			when LEN(tblGiaoVien.tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.tendem, ' ', tblGiaoVien.ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		COUNT(tblDiem.mahocvien) as sohocvien
	from tblDiem
	inner join tblLopHoc on tblLopHoc.malophoc = tblDiem.malophoc
	inner join tblGiaoVien on tblGiaoVien.magiaovien = tblLopHoc.magiaovien
	where (tblDiem.diemthicuoiki + tblDiem.diemthigiuaki)/2 >= CONVERT(float, @diembe) and (tblDiem.diemthicuoiki + tblDiem.diemthigiuaki)/2 <=  CONVERT(float, @diemlon)
	group by tblGiaoVien.ho, tblGiaoVien.tendem, tblGiaoVien.ten
end
GO
/****** Object:  StoredProcedure [dbo].[DangKyHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DangKyHoc]
	@mahocvien varchar(50),
	@malophoc varchar(30)
as
begin
	declare @v_lanhoc int,
			@v_makhoahoc varchar(30),
			@v_dadangki int
	select @v_makhoahoc = makhoahoc
	from tblLopHoc
	where malophoc = @malophoc

	select @v_lanhoc = count(*)
	from tblDiem d
	inner join tblLopHoc l on d.malophoc = l.malophoc
	where l.daketthuc = 1
	and d.mahocvien = @mahocvien
	and l.makhoahoc = @v_makhoahoc

	select @v_dadangki = count(*)
	from tblDiem d
	inner join tblLopHoc l on d.malophoc = l.malophoc
	where l.daketthuc = 0	
	and l.makhoahoc = @v_makhoahoc
	and d.mahocvien = @mahocvien

	if @v_dadangki>0 return -1

	set @v_lanhoc = @v_lanhoc + 1

	insert into tblDiem(nguoitao, mahocvien, malophoc, lanhoc) values
	(@mahocvien, @mahocvien, @malophoc, @v_lanhoc)
	if @@ROWCOUNT>0 return 1 else return 0
end
GO
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DangNhap]
	@loaitaikhoan varchar(30),
	@taikhoan varchar(50),
	@matkhau varchar(50)
as
begin
	if @loaitaikhoan = 'admin'  
			select *from TaiKhoan 
			where tentaikhoan = @taikhoan 
			and matkhau = @matkhau
		else if @loaitaikhoan = 'teacher' 
			select *from tblGiaoVien where
			magiaovien = @taikhoan
			and matkhau= @matkhau
		else
			select *from tblHocVien where mahocvien = @taikhoan and matkhau = @matkhau
end
GO
/****** Object:  StoredProcedure [dbo].[DanhSachLopChuaDangKy]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DanhSachLopChuaDangKy]
	@tukhoa varchar(50)
as
begin
	select 
		l.malophoc,
		l.makhoahoc,
		m.tenkhoahoc,
		m.sotien,
		COUNT(d.mahocvien) as siso,
		case when len(g.tendem)>0 then concat(g.ho, ' ', g.tendem, ' ',g.ten)
			else concat(g.ho,' ', g.ten) end as gvien,
		l.thoigianbatdau,
		l.thoigianketthuc,
		l.buoi1,
		l.buoi2,
		l.buoi3
	from tblLopHoc l
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	inner join tblKhoaHoc m on l.makhoahoc = m.makhoahoc
	left join tblDiem d on l.malophoc = d.malophoc
	where l.daketthuc = 0
	and l.malophoc not in (select malophoc from tblDiem where mahocvien = @tukhoa)
	group by l.malophoc, l.makhoahoc, m.tenkhoahoc, m.sotien, g.ho, g.tendem, g.ten,l.thoigianbatdau,
		l.thoigianketthuc,
		l.buoi1,
		l.buoi2,
		l.buoi3
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteGiaoVien]
	@tukhoa varchar(30)
as
begin
	delete from tblDiem where malophoc in (select malophoc from tblLopHoc where magiaovien = @tukhoa)
	delete from tblLopHoc where magiaovien = @tukhoa
	delete from tblGiaoVien where magiaovien = @tukhoa

	if(@@ROWCOUNT > 0) return 1
	else return 0
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteHocVien]
	@tukhoa varchar(30)
as
begin
	delete from tblDiem where malophoc in (select malophoc from tblLopHoc where mahocvien = @tukhoa)
	delete from tblHocVien where mahocvien = @tukhoa

	if(@@ROWCOUNT > 0) return 1
	else return 0
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteKhoaDaDangKy]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteKhoaDaDangKy]
	@malophoc varchar(50),
	@tukhoa varchar(30)
AS
BEGIN
	DECLARE @CourseIDs TABLE (ID varchar(30))
	INSERT INTO @CourseIDs(ID)
	SELECT value FROM STRING_SPLIT(@malophoc, ',')

	DECLARE @DiemIDs TABLE (ID varchar(30))
	INSERT INTO @DiemIDs(ID)
	SELECT malophoc FROM tblDiem WHERE malophoc IN (SELECT ID FROM @CourseIDs)

	DELETE FROM tblDiem WHERE malophoc IN (SELECT ID FROM @DiemIDs)
	EXEC [dbo].[KhoaDaDangKy] @tukhoa
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteKhoaHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteKhoaHoc]
	@tukhoa varchar(30)
as
begin
delete from tblDiem  where malophoc in (select malophoc from tblLopHoc  where tblLopHoc.makhoahoc = @tukhoa)
	delete from tblLopHoc where tblLopHoc.makhoahoc in (select makhoahoc from tblKhoaHoc where tblLophoc.makhoahoc = @tukhoa)
	delete from tblKhoaHoc where makhoahoc = @tukhoa

	if(@@ROWCOUNT > 0) return 1
	else return 0
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteLopHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteLopHoc]
	@tukhoa varchar(30)
as
begin
	delete from tblDiem where malophoc in (select malophoc from tblLopHoc where malophoc = @tukhoa)
	delete from tblLopHoc where malophoc = @tukhoa
	delete from tblThongBao where tblThongBao.malophoc = @tukhoa

	if(@@ROWCOUNT > 0) return 1
	else return 0
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteThongBao]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteThongBao]
	@tukhoa varchar(30)
as
begin
	delete from tblThongBao where mathongbao = @tukhoa
	if(@@ROWCOUNT > 0) return 1
	else return 0
end
GO
/****** Object:  StoredProcedure [dbo].[GiaoVienSelectDiemHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GiaoVienSelectDiemHocVien]
@tukhoa varchar(50)
as
	select 
		lh.malophoc,
		kh.makhoahoc,
		hv.mahocvien,
		case
			when LEN(hv.tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(hv.ho, ' ', hv.tendem, ' ', hv.ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(hv.ho, ' ', hv.ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		
		d.diemthigiuaki, d.diemthicuoiki,(d.diemthigiuaki+ d.diemthicuoiki)/2 as dtb
	from tblGiaoVien gv inner join tblLopHoc lh on gv.magiaovien = lh.magiaovien inner join tblDiem d on lh.malophoc = d.malophoc inner join tblHocVien hv on d.mahocvien  =  hv.mahocvien inner join tblKhoaHoc kh on lh.makhoahoc = kh.makhoahoc
	where 
		lh.magiaovien = @tukhoa
GO
/****** Object:  StoredProcedure [dbo].[HocBongHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[HocBongHocVien]
	@mahocvien varchar(50),
	@diem float,
	@phantram float
as
begin
	UPDATE tblHocVien
	SET hocbong = (
		SELECT SUM(kh.sotien)
		FROM tblDiem d
		INNER JOIN tblLopHoc l ON d.malophoc = l.malophoc
		INNER JOIN tblKhoaHoc kh ON l.makhoahoc = kh.makhoahoc
		WHERE d.mahocvien = tblHocVien.mahocvien and (d.diemthigiuaki + d.diemthicuoiki)/2 > @diem
	)*@phantram
end
GO
/****** Object:  StoredProcedure [dbo].[HocPhiHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[HocPhiHocVien]
as
begin
	UPDATE tblHocVien
	SET hocphi = (
		SELECT SUM(kh.sotien)
		FROM tblDiem d
		INNER JOIN tblLopHoc l ON d.malophoc = l.malophoc
		INNER JOIN tblKhoaHoc kh ON l.makhoahoc = kh.makhoahoc
		WHERE d.mahocvien = tblHocVien.mahocvien
	)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertBaiKiemTra]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertBaiKiemTra]
	@malophoc varchar(50),
	@deso int,
	@de varchar(max),
	@cauhoi1 varchar(max),
	@cauhoi2 varchar(max),
	@cauhoi3 varchar(max),
	@cauhoi4 varchar(max),
	@dapan1 varchar(max),
	@explain1 nvarchar(max),
	@dapan2 varchar(max),
	@explain2 nvarchar(max),
	@dapan3 varchar(max),
	@explain3 nvarchar(max),
	@dapan4 varchar(max),
	@explain4 nvarchar(max)
as
begin
	 insert into tblKiemTra(
		mabaikiemtra, malophoc,
		deso, de,
		cauhoi1, cauhoi2, cauhoi3, cauhoi4,
		dapan1, explain1,dapan2, explain2, dapan3, explain3, dapan4, explain4
		)values(
		'KT'+cast(next value for giaovienSeq as varchar(30)), @malophoc,
		@deso , @de,
		@cauhoi1 ,@cauhoi2 ,@cauhoi3 ,@cauhoi4 ,
		@dapan1, @explain1 ,@dapan2, @explain2, @dapan3, @explain3, @dapan4 , @explain4
	)
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end
GO
/****** Object:  StoredProcedure [dbo].[InsertGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertGiaoVien]
	@nguoitao varchar(30),
	@ho nvarchar(10),
	@tendem nvarchar(30),
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date, 
	@diachi nvarchar(150),
	@email varchar(100),
	@dienthoai varchar(30),
	@toeic varchar(5),
	@ielts varchar(5)
as
begin
	 insert into tblGiaoVien(
		nguoitao, 
		ho, tendem, ten,
		gioitinh, ngaysinh, 
		dienthoai, diachi, email,toeic,ielts
		)values(
		@nguoitao, 
		@ho, @tendem, @ten,
		@gioitinh, @ngaysinh, 
		@dienthoai, @diachi, @email,@toeic,@ielts
	)
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end
GO
/****** Object:  StoredProcedure [dbo].[InsertKhoaHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertKhoaHoc]
	@nguoithuchien varchar(30),
	@makhoahoc varchar(30),
	@tenkhoahoc nvarchar(30),
	@sotien float
as
begin
	insert into tblKhoaHoc
	(
		nguoitao,
		makhoahoc,
		tenkhoahoc,
		sotien
	)values(
		@nguoithuchien, 
		@makhoahoc,
		@tenkhoahoc,
		@sotien
	);

	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end 
GO
/****** Object:  StoredProcedure [dbo].[InsertLopHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertLopHoc]
	@nguoithuchien varchar(30),
	@makhoahoc varchar(50),
	@magiaovien varchar(30),
	@thoigianbatdau varchar(4),
	@thoigianketthuc varchar(4),
	@buoi1 varchar(1),
	@buoi2 varchar(1),
	@buoi3 varchar(1)
as
begin
	insert into tblLopHoc(
	nguoitao, malophoc, makhoahoc, magiaovien,thoigianbatdau,
	thoigianketthuc ,
	buoi1 ,
	buoi2 ,
	buoi3)
	values(@nguoithuchien,
	'A'+cast(next value for giaovienSeq as varchar(30)),
	@makhoahoc, @magiaovien,@thoigianbatdau ,
	@thoigianketthuc ,
	@buoi1 ,
	@buoi2 ,
	@buoi3 )
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[InsertThongBao]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertThongBao]
	@nguoigui varchar(50),
	@malophoc varchar(50),
	@tieude nvarchar(max),
	@noidung nvarchar(max)
as
begin
	insert into tblThongBao
	(
		mathongbao,
		manguoigui,
		malophoc,
		tieude,
		noidung
	)values(
		'TB'+cast(next value for giaovienSeq as varchar(30)),
		@nguoigui,
		@malophoc,
		@tieude,
		@noidung
	);

	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end 
GO
/****** Object:  StoredProcedure [dbo].[KhoaDaDangKy]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[KhoaDaDangKy]
	@tukhoa varchar(30)
as
begin
	select 
		d.malophoc,
		m.tenkhoahoc,
		m.sotien,
		case when len(trim(g.tendem)) > 0 then CONCAT(g.ho, ' ', g.tendem, ' ', g.ten)
		else CONCAT(g.ho, ' ', g.ten) end as gvien,
		l.thoigianbatdau,
		l.thoigianketthuc,
		l.buoi1,
		l.buoi2,
		l.buoi3

	from tblDiem d
	inner join tblLopHoc l on d.malophoc = l.malophoc
	inner join tblKhoaHoc m on l.makhoahoc = m.makhoahoc
	inner join	tblGiaoVien g on l.magiaovien = g.magiaovien
	where d.mahocvien = @tukhoa
	--and l.daketthuc = 0
end
GO
/****** Object:  StoredProcedure [dbo].[NoteGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[NoteGiaoVien]
	@tukhoa varchar(50),
	@noidung nvarchar(MAX)
as
begin
	update tblGiaoVien
	set note = @noidung
	where tblGiaoVien.magiaovien = @tukhoa
end
GO
/****** Object:  StoredProcedure [dbo].[NoteHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[NoteHocVien]
	@tukhoa varchar(50),
	@noidung nvarchar(MAX)
as
begin
	update tblHocVien
	set note = @noidung
	where tblHocVien.mahocvien = @tukhoa
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectAllGiaoVien]
@tukhoa nvarchar(50)
as
	select 
		magiaovien,
		case
			when LEN(tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(ho, ' ', tendem, ' ', ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(ho, ' ', ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		CONVERT(varchar(10), ngaysinh, 103) as ngaysinh,
		case 
			when gioitinh  = 1 then N'Nam'
			else N'Nữ'
		end as gioitinh, 
		
		diachi,
		dienthoai,
		email,
		toeic,
		ielts
	from  tblGiaoVien
	where 
		ho like '%'+lower(trim(@tukhoa))+'%'
		or lower(tendem) like '%'+lower(trim(@tukhoa))+'%'
		or lower(ten) like '%'+lower(trim(@tukhoa))+'%'
		or dienthoai like '%'+lower(trim(@tukhoa))+'%'
		or magiaovien like '%'+lower(trim(@tukhoa))+'%'
		or email like '%'+lower(trim(@tukhoa))+'%'
	order by ten;
GO
/****** Object:  StoredProcedure [dbo].[SelectAllGiaoVienFromMaKhoa]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectAllGiaoVienFromMaKhoa]
	@tukhoa nvarchar(50)
as
begin
	select
		tblLophoc.magiaovien,
		case
			when LEN(tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(ho, ' ', tendem, ' ', ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(ho, ' ', ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		CONVERT(varchar(10), ngaysinh, 103) as ngaysinh,
		case 
			when gioitinh  = 1 then N'Nam'
			else N'Nữ'
		end as gioitinh, 
		
		diachi,
		dienthoai,
		email,
		toeic,
		ielts
	from  tblGiaoVien 
	inner join tblLopHoc on tblGiaoVien.magiaovien = tblLopHoc.magiaovien
	
	where lower(tblLophoc.makhoahoc) like '%'+LOWER(@tukhoa)+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllGiaoVienFromTime]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectAllGiaoVienFromTime]
	@thoigianbatdau varchar(30),
	@thoigianketthuc varchar(30)
as
begin

select
		tblGiaoVien.magiaovien,
		tblLopHoc.malophoc,
		case
			when LEN(tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(ho, ' ', tendem, ' ', ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(ho, ' ', ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		CONVERT(varchar(10), ngaysinh, 103) as ngaysinh,
		case 
			when gioitinh  = 1 then N'Nam'
			else N'Nữ'
		end as gioitinh, 
		diachi,
		dienthoai,
		email
	from tblGiaoVien
	inner join tblLopHoc on tblGiaoVien.magiaovien = tblLopHoc.magiaovien
	inner join tblThoiKhoaBieu on tblThoiKhoaBieu.malophoc = tblLopHoc.malophoc
	where CONVERT(float, tblThoiKhoaBieu.thoigianketthuc) <= convert(float, @thoigianbatdau) or convert(float, tblThoiKhoaBieu.thoigianbatdau) >= convert(float, @thoigianketthuc) 
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectAllHocVien]
	@tukhoa nvarchar(50)
as
	select 
		mahocvien,
		case
			when LEN(tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(ho, ' ', tendem, ' ', ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(ho, ' ', ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		CONVERT(varchar(10), ngaysinh, 103) as ngaysinh,
		case 
			when gioitinh  = 1 then N'Nam'
			else N'Nữ'
		end as gioitinh, 
		diachi,
		dienthoai,
		email
	from tblHocVien
	where 
		ho like '%'+lower(trim(@tukhoa))+'%'
		or lower(tendem) like '%'+lower(trim(@tukhoa))+'%'
		or lower(ten) like '%'+lower(trim(@tukhoa))+'%'
		or dienthoai like '%'+lower(trim(@tukhoa))+'%'
		or mahocvien like '%'+lower(trim(@tukhoa))+'%'
		or email like '%'+lower(trim(@tukhoa))+'%'
	order by ten;
GO
/****** Object:  StoredProcedure [dbo].[SelectAllHocVienFromMaKhoa]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectAllHocVienFromMaKhoa]
	@tukhoa nvarchar(50)
as
begin
	select
		tblHocVien.mahocvien,
		tblLopHoc.malophoc,
		tblKhoaHoc.tenkhoahoc,
		case
			when LEN(tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(ho, ' ', tendem, ' ', ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(ho, ' ', ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		CONVERT(varchar(10), ngaysinh, 103) as ngaysinh,
		case 
			when gioitinh  = 1 then N'Nam'
			else N'Nữ'
		end as gioitinh, 
		diachi,
		dienthoai,
		email
	from tblHocVien
	inner join tblDiem on tblHocVien.mahocvien = tblDiem.mahocvien inner join tblLopHoc on tblDiem.malophoc = tblLopHoc.malophoc
	inner join tblKhoaHoc on tblLopHoc.makhoahoc = tblKhoaHoc.makhoahoc
	where lower(tblKhoaHoc.makhoahoc) like '%'+LOWER(@tukhoa)+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllHocVienFromMaLop]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectAllHocVienFromMaLop]
	@tukhoa nvarchar(50)
as
begin
	select
		tblHocVien.mahocvien,
		case
			when LEN(tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(ho, ' ', tendem, ' ', ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(ho, ' ', ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		CONVERT(varchar(10), ngaysinh, 103) as ngaysinh,
		case 
			when gioitinh  = 1 then N'Nam'
			else N'Nữ'
		end as gioitinh, 
		diachi,
		dienthoai,
		email
	from tblHocVien
	inner join tblDiem on tblHocVien.mahocvien = tblDiem.mahocvien
	where lower(tblDiem.malophoc) like '%'+LOWER(@tukhoa)+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllKhoaHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectAllKhoaHoc]
	@tukhoa nvarchar(30)
as
begin
	select 
		makhoahoc,
		tenkhoahoc,
		sotien
	from tblKhoaHoc
	where makhoahoc like '%'+lower(trim(@tukhoa))+'%'
	or LOWER(tenkhoahoc) like '%'+lower(trim(@tukhoa))+'%'
	order by tenkhoahoc
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllLopHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectAllLopHoc]
	@tukhoa nvarchar(50)
as
begin
	select
		l.malophoc,
		m.tenkhoahoc,		
		COUNT(d.mahocvien) as siso,
		g.magiaovien,
		case when len(trim(g.tendem))>0 then concat(g.ho, ' ', g.tendem, ' ', g.ten)
		else concat(g.ho, ' ', g.ten) end as gv,
		l.thoigianbatdau,l.thoigianketthuc,l.buoi1,l.buoi2,l.buoi3

		
	from tblLopHoc l
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	inner join tblKhoaHoc m on l.makhoahoc = m.makhoahoc
	left join tblDiem d on l.malophoc = d.malophoc
	where lower(m.makhoahoc) like '%'+LOWER(@tukhoa)+'%'
	or LOWER(g.ten) like '%'+LOWER(@tukhoa)+'%'
	or LOWER(g.tendem) like '%'+LOWER(@tukhoa)+'%'
	or LOWER(g.ho) like '%'+LOWER(@tukhoa)+'%'
	or LOWER(concat(g.ho, ' ', g.tendem, ' ', g.ten)) like '%'+LOWER(@tukhoa)+'%'
	group by l.malophoc, g.ho, g.tendem, g.ten,m.tenkhoahoc,g.magiaovien,l.thoigianbatdau,l.thoigianketthuc,l.buoi1,l.buoi2,l.buoi3
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllLopHocFromMaKhoa]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectAllLopHocFromMaKhoa]
	@tukhoa nvarchar(50)
as
begin
	select
		l.malophoc,
		m.tenkhoahoc,		
		COUNT(d.mahocvien) as siso,
		g.magiaovien,
		case when len(trim(g.tendem))>0 then concat(g.ho, ' ', g.tendem, ' ', g.ten)
		else concat(g.ho, ' ', g.ten) end as gv,
		l.thoigianbatdau,l.thoigianketthuc,l.buoi1,l.buoi2,l.buoi3
	from tblLopHoc l
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	inner join tblKhoaHoc m on l.makhoahoc = m.makhoahoc
	left join tblDiem d on l.malophoc = d.malophoc
	where lower(m.makhoahoc) like '%'+LOWER(@tukhoa)+'%'
	group by l.malophoc, g.ho, g.tendem, g.ten,m.tenkhoahoc,g.magiaovien,l.thoigianbatdau,l.thoigianketthuc,l.buoi1,l.buoi2,l.buoi3
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllMaKhoaForGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectAllMaKhoaForGiaoVien]
	@tukhoa nvarchar(50)
as
begin
	select
		distinct tblLopHoc.makhoahoc
		
	from  tblGiaoVien 
	inner join tblLopHoc   on tblGiaoVien.magiaovien = tblLopHoc.magiaovien
	where @tukhoa = tblGiaoVien.magiaovien
	
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllMaLopForGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectAllMaLopForGiaoVien]
	@tukhoa nvarchar(50)
as
begin
	select
		tblLopHoc.malophoc
		
	from  tblGiaoVien 
	inner join tblLopHoc   on tblGiaoVien.magiaovien = tblLopHoc.magiaovien
	where @tukhoa = tblGiaoVien.magiaovien
	
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllMaLopForHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectAllMaLopForHocVien]
	@tukhoa nvarchar(50)

as
begin
	select 
		d.malophoc
	from tblHocVien hv
	inner join tblDiem d on hv.mahocvien = d.mahocvien 
	where
	hv.mahocvien = @tukhoa
	
end
GO
/****** Object:  StoredProcedure [dbo].[SelectBaiKiemTraFromMaLop]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectBaiKiemTraFromMaLop]
	@malophoc varchar(50),
	@deso int
as
begin
	select
		tblKiemTra.mabaikiemtra,
		tblKiemTra.malophoc,
		tblKiemTra.deso,
		tblKiemTra.de,
		tblKiemTra.cauhoi1,
		tblKiemTra.cauhoi2,
		tblKiemTra.cauhoi3,
		tblKiemTra.cauhoi4,
		tblKiemTra.dapan1,
		tblKiemTra.explain1,
		tblKiemTra.dapan2,
		tblKiemTra.explain2,
		tblKiemTra.dapan3,
		tblKiemTra.explain3,
		tblKiemTra.dapan4,
		tblKiemTra.explain4
		
	from tblKiemTra
	where lower(tblKiemTra.malophoc) like '%'+LOWER(@malophoc)+'%' and @deso = tblKiemTra.deso
end
GO
/****** Object:  StoredProcedure [dbo].[SelectDiemFromMaHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectDiemFromMaHocVien]
	@tukhoa nvarchar(50)
as
begin
	select 
		tblKhoaHoc.makhoahoc,
		tblLopHoc.malophoc,
		case
			when LEN(tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(ho, ' ', tendem, ' ', ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(ho, ' ', ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		tblHocVien.mahocvien,
		diemthigiuaki,
		diemthicuoiki,
		(diemthigiuaki + diemthicuoiki)/2 as diemtrungbinh
	from tblDiem
	inner join tblHocVien on tblDiem.mahocvien = tblHocVien.mahocvien
	inner join tblLopHoc on tblDiem.malophoc = tblLopHoc.malophoc
	inner join tblKhoaHoc on tblLopHoc.makhoahoc = tblKhoaHoc.makhoahoc
	where lower(tblHocVien.mahocvien) like '%'+LOWER(@tukhoa)+'%' 
		or Lower(ho) like '%'+lower(trim(@tukhoa))+'%'
		or lower(tendem) like '%'+lower(trim(@tukhoa))+'%'
		or lower(ten) like '%'+lower(trim(@tukhoa))+'%'
		or email like '%'+lower(trim(@tukhoa))+'%'
		or dienthoai like '%'+lower(trim(@tukhoa))+'%'
	order by ten;
end
GO
/****** Object:  StoredProcedure [dbo].[SelectDiemFromMaKhoa]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectDiemFromMaKhoa]
	
	@magiaovien varchar(50),
	@makhoahoc varchar(50)
as
begin
	select 
	tblKhoaHoc.tenkhoahoc,
	tblKhoaHoc.makhoahoc,
		tblLopHoc.malophoc,
		tblHocVien.mahocvien,
		case
			when LEN(tblHocVien.tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(tblHocVien.ho, ' ', tblHocVien.tendem, ' ', tblHocVien.ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(tblHocVien.ho, ' ', tblHocVien.ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		diemthigiuaki,
		diemthicuoiki,
		(diemthigiuaki + diemthicuoiki)/2 as dtb
	from tblDiem
	inner join tblHocVien on tblDiem.mahocvien = tblHocVien.mahocvien
	inner join tblLopHoc on tblDiem.malophoc = tblLopHoc.malophoc
	inner join tblGiaoVien on tblLopHoc.magiaovien = tblGiaoVien.magiaovien
	inner join tblKhoaHoc on tblLopHoc.makhoahoc = tblKhoaHoc.makhoahoc
	where lower(tblKhoaHoc.makhoahoc) like '%'+LOWER(@makhoahoc)+'%' and lower(tblGiaoVien.magiaovien) like '%'+LOWER(@magiaovien)+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SelectDiemFromMaKhoaByAdmin]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectDiemFromMaKhoaByAdmin]
	
	@tukhoa varchar(50)
as
begin
	select 
	tblKhoaHoc.tenkhoahoc,
	tblKhoaHoc.makhoahoc,
	
		tblLopHoc.malophoc,
		tblHocVien.mahocvien,
		case
			when LEN(tblHocVien.tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(tblHocVien.ho, ' ', tblHocVien.tendem, ' ', tblHocVien.ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(tblHocVien.ho, ' ', tblHocVien.ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		diemthigiuaki,
		diemthicuoiki,
		(diemthigiuaki + diemthicuoiki)/2 as dtb
	from tblDiem
	inner join tblHocVien on tblDiem.mahocvien = tblHocVien.mahocvien
	inner join tblLopHoc on tblDiem.malophoc = tblLopHoc.malophoc
	inner join tblKhoaHoc on tblLopHoc.makhoahoc = tblKhoaHoc.makhoahoc
	where lower(tblKhoaHoc.makhoahoc) like '%'+LOWER(@tukhoa)+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SelectDiemFromMaLop]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectDiemFromMaLop]
	@tukhoa nvarchar(50)
as
begin
	select
	tblKhoaHoc.tenkhoahoc,
		tblKhoaHoc.makhoahoc,
		tblLopHoc.malophoc,
		case
			when LEN(tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(ho, ' ', tendem, ' ', ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(ho, ' ', ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		tblHocVien.mahocvien,
		diemthigiuaki,
		diemthicuoiki,
		(diemthigiuaki + diemthicuoiki)/2 as dtb
	from tblDiem
	inner join tblHocVien on tblDiem.mahocvien = tblHocVien.mahocvien
	inner join tblLopHoc on tblDiem.malophoc = tblLopHoc.malophoc
	inner join tblKhoaHoc on tblLopHoc.makhoahoc = tblKhoaHoc.makhoahoc
	where lower(tblDiem.malophoc) like '%'+LOWER(@tukhoa)+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SelectGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectGiaoVien]
	@magiaovien varchar(50)
As
begin
	select ho, tendem, ten, gioitinh, convert(varchar(10), ngaysinh, 103) as ngsinh,
		 diachi, dienthoai, email,toeic,ielts
	from tblGiaoVien
	where magiaovien = @magiaovien
end
GO
/****** Object:  StoredProcedure [dbo].[SelectGiaoVienInFo]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectGiaoVienInFo]
	@magiaovien varchar(50)
as
begin
	select  convert(varchar(10), ngaysinh, 103) as ngsinh,
		case
			when LEN(tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(ho, ' ', tendem, ' ', ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(ho, ' ', ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		case
			when gioitinh = 1 then 'Nam' else N'Nữ'
		end as gioitinh,
		 diachi, dienthoai, email, ngaytao, ngaycapnhat,toeic,ielts
	from tblGiaoVien
	where magiaovien = @magiaovien
end
GO
/****** Object:  StoredProcedure [dbo].[SelectHocBong1HocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectHocBong1HocVien]
	@tukhoa varchar(50)
as
begin
	select 
		hv.hocbong
	from tblHocVien hv
	where
	hv.mahocvien = @tukhoa
end
GO
/****** Object:  StoredProcedure [dbo].[SelectHocPhiHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectHocPhiHocVien]
	@tukhoa varchar(50)
as
begin
	select 
		kh.tenkhoahoc,
		kh.sotien,
		case
			when LEN(gv.tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(gv.ho, ' ', gv.tendem, ' ', gv.ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(gv.ho, ' ', gv.ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten
	from tblHocVien hv
	inner join tblDiem d on hv.mahocvien = d.mahocvien inner join tblLopHoc l on d.malophoc = l.malophoc
	inner join tblGiaoVien gv on l.magiaovien = gv.magiaovien
	inner join tblKhoaHoc kh on l.makhoahoc = kh.makhoahoc
	where
	hv.mahocvien = @tukhoa
	group by gv.ho, gv.tendem, gv.ten, kh.tenkhoahoc, kh.sotien
end
GO
/****** Object:  StoredProcedure [dbo].[SelectHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectHocVien]
	@mahocvien varchar(50)
as
begin
	select ho, tendem, ten, convert(varchar(10), ngaysinh, 103) as ngsinh,
		case
			when gioitinh = 1 then 'Nam' else N'Nữ'
		end as gioitinh,
		 diachi, dienthoai, email
	from tblHocVien
	where mahocvien = @mahocvien
end
GO
/****** Object:  StoredProcedure [dbo].[SelectHocVienInFo]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectHocVienInFo]
	@mahocvien varchar(50)
as
begin
	select  convert(varchar(10), ngaysinh, 103) as ngsinh,
		case
			when LEN(tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(ho, ' ', tendem, ' ', ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(ho, ' ', ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		case
			when gioitinh = 1 then 'Nam' else N'Nữ'
		end as gioitinh,
		 diachi, dienthoai, email, ngaytao, ngaycapnhat
	from tblHocVien
	where mahocvien = @mahocvien
end
GO
/****** Object:  StoredProcedure [dbo].[SelectKhoaHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectKhoaHoc]
	@mamonhoc varchar(50)
as
begin
	select
		tenkhoahoc, sotien
	from tblKhoaHoc
	where makhoahoc = @mamonhoc

	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end  
GO
/****** Object:  StoredProcedure [dbo].[SelectLopHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectLopHoc]
	@malophoc varchar(50)
as
begin
	select magiaovien, makhoahoc, thoigianbatdau,thoigianketthuc, buoi1,buoi2,buoi3 from tblLopHoc where malophoc = @malophoc
end
GO
/****** Object:  StoredProcedure [dbo].[SelectLuongGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectLuongGiaoVien]
	@tukhoa varchar(50)
as
begin
	select 
		l.malophoc,
		kh.makhoahoc,
		COUNT(hv.mahocvien) as siso ,
		sum(kh.sotien)*COUNT(hv.mahocvien)*0.2 as TienLuong
		
	from tblGiaoVien gv
	inner join tblLopHoc l on gv.magiaovien = l.magiaovien 
	inner join tblKhoaHoc kh on l.makhoahoc = kh.makhoahoc
	left join tblDiem d on d.malophoc = l.malophoc
	inner join tblHocVien hv on d.mahocvien = hv.mahocvien
	where
	gv.magiaovien = @tukhoa
	group by l.malophoc,kh.makhoahoc
end
GO
/****** Object:  StoredProcedure [dbo].[SelectMaTenGiaovien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectMaTenGiaovien]
as
begin
	select  magiaovien ,
	case
			when LEN(tblGiaoVien.tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.tendem, ' ', tblGiaoVien.ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten

	from tblGiaoVien
	
	
end
GO
/****** Object:  StoredProcedure [dbo].[SelectNoteGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectNoteGiaoVien]
	@tukhoa varchar(50)
as
	select note
	from tblGiaoVien
	where magiaovien = @tukhoa
GO
/****** Object:  StoredProcedure [dbo].[SelectNoteHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectNoteHocVien]
	@tukhoa varchar(50)
as
	select note
	from tblHocVien
	where mahocvien = @tukhoa
GO
/****** Object:  StoredProcedure [dbo].[SelectSoBaiKiemTraFromMaLop]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectSoBaiKiemTraFromMaLop]
	@malophoc varchar(50)
as
begin
	select
		tblKiemTra.deso
	from tblKiemTra
	where lower(tblKiemTra.malophoc) like '%'+LOWER(@malophoc)+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SelectThoiKhoaBieuGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SelectThoiKhoaBieuGiaoVien]
	@tukhoa varchar(50)
AS
BEGIN
	select		
		distinct lh.malophoc as hoten ,
		lh.makhoahoc,
		
		lh.thoigianbatdau,
		lh.thoigianketthuc,
		lh.buoi1,
		lh.buoi2,
		lh.buoi3
	from 
		 tblLopHoc lh 
		inner JOIN tblGiaoVien gv ON lh.magiaovien = gv.magiaovien		
		--inner join tblDiem d on lh.malophoc = d.malophoc
WHERE 
    gv.magiaovien = @tukhoa
	ORDER BY
        lh.thoigianbatdau DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[SelectThoiKhoaBieuHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectThoiKhoaBieuHocVien]
	@tukhoa varchar(50)
AS
BEGIN
	select		
		lh.malophoc AS 'Mã lớp học',
		lh.makhoahoc,
		case
			when LEN(tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(ho, ' ', tendem, ' ', ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(ho, ' ', ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		lh.thoigianbatdau,
		lh.thoigianketthuc,
		lh.buoi1,
		lh.buoi2,
		lh.buoi3
	from 
		 tblLopHoc lh 
		LEFT JOIN tblGiaoVien gv ON lh.magiaovien = gv.magiaovien
		
		left join tblDiem d on lh.malophoc = d.malophoc
WHERE 
    d.mahocvien = @tukhoa
		ORDER BY
        lh.thoigianbatdau DESC ;
END
GO
/****** Object:  StoredProcedure [dbo].[SelectThongBaoByAdmin]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SelectThongBaoByAdmin]
as
	select 
	tblThongBao.maNguoiGui,
	tblThongBao.ngaygui,
		tblThongBao.mathongbao,
		tblGiaoVien.magiaovien,
		case
			when LEN(tblGiaoVien.tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.tendem, ' ', tblGiaoVien.ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		noidung,
		tieude,
		adminseen,
		tblKhoaHoc.makhoahoc,
		tblThongBao.malophoc,
		tblThongBao.ngaygui
	from  tblThongBao
	inner join tblLopHoc on tblThongBao.malophoc = tblLopHoc.malophoc
	inner join tblGiaoVien on tblLopHoc.magiaovien = tblGiaoVien.magiaovien
	inner join tblKhoaHoc on tblLopHoc.makhoahoc = tblKhoaHoc.makhoahoc
	ORDER BY
        tblThongBao.ngaygui ASC;
GO
/****** Object:  StoredProcedure [dbo].[SelectThongBaoByGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectThongBaoByGiaoVien]
	@tukhoa varchar(50)
as
	select 
		tblThongBao.manguoigui,
		tblThongBao.ngaygui,
		tblGiaoVien.magiaovien,
		tblThongBao.mathongbao,
		case
			when LEN(tblGiaoVien.tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.tendem, ' ', tblGiaoVien.ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		tieude,
		noidung,
		giaovienseen,
		tblKhoaHoc.makhoahoc,
		tblThongBao.malophoc,
		tblThongBao.ngaygui
	from  tblThongBao
	inner join tblLopHoc on tblThongBao.malophoc = tblLopHoc.malophoc
		inner join tblGiaoVien on tblLopHoc.magiaovien = tblGiaoVien.magiaovien
	inner join tblKhoaHoc on tblLopHoc.makhoahoc = tblKhoaHoc.makhoahoc
	where tblGiaoVien.magiaovien = @tukhoa
		ORDER BY
        tblThongBao.ngaygui ASC
GO
/****** Object:  StoredProcedure [dbo].[SelectThongBaoByHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectThongBaoByHocVien]
@tukhoa nvarchar(50)
as
	select 
		tblThongBao.manguoigui,
		tblThongBao.ngaygui,
		tblThongbao.mathongbao,
		tblGiaoVien.magiaovien,
		case
			when LEN(tblGiaoVien.tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.tendem, ' ', tblGiaoVien.ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		noidung,
		tieude,
		hocvienseen,
		tblKhoaHoc.makhoahoc,
		tblThongBao.malophoc,
		tblThongBao.ngaygui
	from  tblThongBao
	inner join tblLopHoc on tblThongBao.malophoc = tblLopHoc.malophoc
	inner join tblGiaoVien on tblLopHoc.magiaovien = tblGiaoVien.magiaovien
	inner join tblKhoaHoc on tblLopHoc.makhoahoc = tblKhoaHoc.makhoahoc
	inner join tblDiem on tblLopHoc.malophoc = tblDiem.malophoc
	inner join tblHocVien on tblDiem.mahocvien = tblHocVien.mahocvien
	where tblHocVien.mahocvien = @tukhoa
	ORDER BY
        tblThongBao.ngaygui ASC
GO
/****** Object:  StoredProcedure [dbo].[SelectThongBaoByLop]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectThongBaoByLop]
	@tukhoa varchar(50)
as
	select 
	tblThongBao.manguoigui,
		tblThongBao.ngaygui,
		tblGiaoVien.magiaovien,
		tblThongBao.mathongbao,
		case
			when LEN(tblGiaoVien.tendem) > 0 then --neu do dai ten dem > 0 tuc co ten dem
				CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.tendem, ' ', tblGiaoVien.ten) --thi noi ho + tendem + ten bang cac khoang trong
			else CONCAT(tblGiaoVien.ho, ' ', tblGiaoVien.ten) -- nguoc lai neu khong co ten dem -> noi ho va ten bang khoang trong
		end as hoten,
		ngaygui,
		noidung,
		tieude,
		hocvienseen,
		giaovienseen,
		adminseen,
		tblKhoaHoc.makhoahoc,
		tblThongBao.malophoc
	from  tblThongBao
	inner join tblLopHoc on tblThongBao.malophoc = tblLopHoc.malophoc
	inner join tblGiaoVien on tblLopHoc.magiaovien = tblGiaoVien.magiaovien
	inner join tblKhoaHoc on tblLopHoc.makhoahoc = tblKhoaHoc.makhoahoc
	where tblLopHoc.malophoc = @tukhoa
GO
/****** Object:  StoredProcedure [dbo].[SelectThuong]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectThuong]	
	@tukhoa varchar(50)
as
begin
	select thuong
	from tblGiaoVien where magiaovien = @tukhoa
end
GO
/****** Object:  StoredProcedure [dbo].[SelectThuong1GiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectThuong1GiaoVien]
	@tukhoa varchar(50)
as
begin
	select 
		thuong
	from tblGiaoVien
	where
	magiaovien = @tukhoa
end
GO
/****** Object:  StoredProcedure [dbo].[SelectTienCacMonHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectTienCacMonHoc]
	@mahocvien varchar(50)
as
begin
	select 
		kh.tenkhoahoc,
		kh.sotien,
		case when len(hv.tendem) > 0 then concat (hv.ho, ' ', hv.tendem, ' ', hv.ten)
		else concat(hv.ho, ' ', hv.ten) end as hvien
	from tblHocVien hv
	inner join tblDiem d on hv.mahocvien = d.mahocvien inner join tblLopHoc l on d.malophoc = l.malophoc
	inner join tblKhoaHoc kh on l.makhoahoc = kh.makhoahoc
	where
	hv.mahocvien = @mahocvien
	group by hv.ho, hv.tendem, hv.ten, kh.tenkhoahoc, kh.sotien
end
GO
/****** Object:  StoredProcedure [dbo].[SelectTienMoiKhoaHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectTienMoiKhoaHoc]
	@makhoahoc varchar(50)
as
begin
select 
		tenkhoahoc,
		sotien
	from tblKhoaHoc
	where
	tblKhoaHoc.makhoahoc = @makhoahoc
end
GO
/****** Object:  StoredProcedure [dbo].[SLHocVienTheoDiemTbBykhoa]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SLHocVienTheoDiemTbBykhoa]

	@makhoahoc varchar(50)
as
BEGIN

    SELECT '0-3' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem inner join tblLopHoc on tblDiem.malophoc = tblLopHoc.malophoc WHERE makhoahoc = @makhoahoc and (diemthigiuaki + diemthicuoiki) / 2 >= 0 AND (diemthigiuaki + diemthicuoiki) / 2 <= 3
    UNION ALL
    SELECT '3-5' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem inner join tblLopHoc on tblDiem.malophoc = tblLopHoc.malophoc WHERE makhoahoc = @makhoahoc and(diemthigiuaki + diemthicuoiki) / 2 > 3 AND (diemthigiuaki + diemthicuoiki) / 2 <= 5
    UNION ALL
    SELECT '5-7' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem inner join tblLopHoc on tblDiem.malophoc = tblLopHoc.malophoc WHERE makhoahoc = @makhoahoc and(diemthigiuaki + diemthicuoiki) / 2 > 5 AND (diemthigiuaki + diemthicuoiki) / 2 <= 7
    UNION ALL
    SELECT '7-8' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem inner join tblLopHoc on tblDiem.malophoc = tblLopHoc.malophoc WHERE makhoahoc = @makhoahoc and(diemthigiuaki + diemthicuoiki) / 2 > 7 AND (diemthigiuaki + diemthicuoiki) / 2 <= 8
    UNION ALL
    SELECT '8-9' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem inner join tblLopHoc on tblDiem.malophoc = tblLopHoc.malophoc WHERE makhoahoc = @makhoahoc and(diemthigiuaki + diemthicuoiki) / 2 > 8 AND (diemthigiuaki + diemthicuoiki) / 2 <= 9
    UNION ALL
    SELECT '9-10' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem inner join tblLopHoc on tblDiem.malophoc = tblLopHoc.malophoc   WHERE makhoahoc = @makhoahoc and (diemthigiuaki + diemthicuoiki) / 2 > 9 AND (diemthigiuaki + diemthicuoiki) / 2 <= 10;

END
GO
/****** Object:  StoredProcedure [dbo].[SoLuongHocVienTheoDiemTb]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SoLuongHocVienTheoDiemTb]
as
BEGIN

    SELECT '0-3' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem WHERE (diemthigiuaki + diemthicuoiki) / 2 >= 0 AND (diemthigiuaki + diemthicuoiki) / 2 <= 3
    UNION ALL
    SELECT '3-5' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem WHERE (diemthigiuaki + diemthicuoiki) / 2 > 3 AND (diemthigiuaki + diemthicuoiki) / 2 <= 5
    UNION ALL
    SELECT '5-7' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem WHERE (diemthigiuaki + diemthicuoiki) / 2 > 5 AND (diemthigiuaki + diemthicuoiki) / 2 <= 7
    UNION ALL
    SELECT '7-8' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem WHERE (diemthigiuaki + diemthicuoiki) / 2 > 7 AND (diemthigiuaki + diemthicuoiki) / 2 <= 8
    UNION ALL
    SELECT '8-9' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem WHERE (diemthigiuaki + diemthicuoiki) / 2 > 8 AND (diemthigiuaki + diemthicuoiki) / 2 <= 9
    UNION ALL
    SELECT '9-10' AS KhoangDiem, COUNT(*) as SoLuongHocVien FROM tblDiem WHERE (diemthigiuaki + diemthicuoiki) / 2 > 9 AND (diemthigiuaki + diemthicuoiki) / 2 <= 10;

END
GO
/****** Object:  StoredProcedure [dbo].[ThemMoiGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ThemMoiGiaoVien]
	@ho nvarchar(10),
	@tenDem nvarchar(20),
	@ten nvarchar(10),
	@ngaysinh date,
	@gioitinh tinyint,
	@diachi nvarchar(50),
	@dienthoai varchar(30),
	@email varchar(150),
	@toeic varchar(5),
	@ielts varchar(5)
as
begin
	insert into tblGiaoVien
	(
		magiaovien,
		ho, tendem, ten,
		ngaysinh, gioitinh, diachi, 
		dienthoai, email,toeic,ielts
	)values(
		'23GV'+cast(next value for giaovienSeq as varchar(30)),
		@ho, @tenDem, @ten, 
		@ngaysinh, @gioitinh, @diachi,
		@dienthoai, @email,@toeic ,
	@ielts
		)

		if @@rowcount > 0 begin return 1 end
		else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[ThemMoiHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ThemMoiHocVien]
	@ho nvarchar(10),
	@tenDem nvarchar(20),
	@ten nvarchar(10),
	@ngaysinh date,
	@gioitinh tinyint,
	@diachi nvarchar(50),
	@dienthoai varchar(30),
	@email varchar(150)
as
begin
	insert into tblHocVien
	(
		mahocvien,
		ho, tendem, ten,
		ngaysinh, gioitinh, diachi, 
		dienthoai, email
	)values(
		'23SV'+cast(next value for sinhvienSeq as varchar(30)),
		@ho, @tenDem, @ten, 
		@ngaysinh, @gioitinh, @diachi,
		@dienthoai, @email
		)

		if @@rowcount > 0 begin return 1 end
		else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[ThuongGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ThuongGiaoVien]
	@magiaovien varchar(50),
	@sotien float
as
begin
	UPDATE tblGiaoVien
	SET thuong = @sotien
	where @magiaovien = magiaovien
end
GO
/****** Object:  StoredProcedure [dbo].[TraCuuDiem]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TraCuuDiem] 
	@mahocvien varchar(50),
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = LOWER(@tukhoa)
	select 
		m.makhoahoc,
		m.tenkhoahoc,
		case when len(g.magiaovien) > 0 then concat (g.ho, ' ', g.tendem, ' ', g.ten)
		else concat(g.ho, ' ', g.ten) end as gvien,
		d.diemthigiuaki,
		d.diemthicuoiki,
		(d.diemthigiuaki + d.diemthicuoiki)/ 2 as dtb,
		d.lanhoc
	from tblDiem d
	inner join tblLopHoc l on d.malophoc = l.malophoc
	inner join tblKhoaHoc m on l.makhoahoc = m.makhoahoc
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	where
d.mahocvien = @mahocvien
	and LOWER(m.tenkhoahoc) like '%' + @tukhoa + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[TraCuuLop]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TraCuuLop]
	@magiaovien varchar(50),
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa)
	select 
		tb.malophoc,
		tb.makhoahoc,
		tb.tenkhoahoc,
		tb.sotien,
		COUNT(d.mahocvien) as siso
	from
	(
	select 
		l.makhoahoc, l.malophoc, m.tenkhoahoc, m.sotien
	from tblLopHoc l
	inner join tblKhoaHoc m on l.makhoahoc = m.makhoahoc
	where daketthuc = 0 
	and magiaovien = @magiaovien
	and m.tenkhoahoc like '%' + @tukhoa + '%'
	) as tb inner join tblDiem d on d.malophoc = tb.malophoc
	group by tb.malophoc, tb.makhoahoc, tb.tenkhoahoc, tb.sotien
end
GO
/****** Object:  StoredProcedure [dbo].[TruTienHocBong]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TruTienHocBong]
	@mahocvien varchar(50),
	@makhoahoc varchar(50),
	@phantram float,
	@diem float
as
begin
	UPDATE tblKhoaHoc
	SET sotien = tblKhoaHoc.sotien - tblKhoaHoc.sotien*@phantram
	from tblKhoaHoc inner join tblLopHoc on tblKhoaHoc.makhoahoc = tblLopHoc.makhoahoc
	left join tblDiem on tblLophoc.malophoc = tblDiem.malophoc
	inner join tblHocVien on tblDiem.mahocvien = tblHocVien.mahocvien
	WHERE tblKhoahoc.makhoahoc = @makhoahoc and tblHocVien.mahocvien = @mahocvien and (tblDiem.diemthicuoiki + tblDiem.diemthigiuaki)/2 > @diem
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateBaiKiemTra]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateBaiKiemTra]
	@malophoc varchar(50),
	@deso int,
	@de varchar(max),
	@cauhoi1 varchar(max),
	@cauhoi2 varchar(max),
	@cauhoi3 varchar(max),
	@cauhoi4 varchar(max),
	@dapan1 varchar(max),
	@explain1 nvarchar(max),
	@dapan2 varchar(max),
	@explain2 nvarchar(max),
	@dapan3 varchar(max),
	@explain3 nvarchar(max),
	@dapan4 varchar(max),
	@explain4 nvarchar(max)
as
begin
	update tblKiemTra
	set
		de = @de,
		cauhoi1 = @cauhoi1,
		cauhoi2 = @cauhoi1,
		cauhoi3 = @cauhoi1,
		cauhoi4 = @cauhoi1,
		dapan1 = @dapan1,
		explain1 = @explain1,
		dapan2 = @dapan2,
		explain2 = @explain2,
		dapan3 = @dapan3,
		explain3 = @explain3,
		dapan4 = @dapan4,
		explain4 = @explain4
	where malophoc = @malophoc and deso = @deso;
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateDiemHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateDiemHocVien]
	@mahocvien varchar(50),
	@diemthigiuaki varchar(5),
	@diemthicuoiki varchar(5),
	@malophoc varchar(30)
as
begin
	update tblDiem
	set
		mahocvien = @mahocvien,
		malophoc = @malophoc,
		diemthigiuaki =convert (float, @diemthigiuaki),
		diemthicuoiki =convert(float, @diemthicuoiki)
	where mahocvien = @mahocvien and malophoc = @malophoc;
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateGiaoVien]
	@magiaovien varchar(50),
	@ho nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@ngaysinh date,
	@gioitinh tinyint,
	@diachi nvarchar(50),
	@dienthoai varchar(20),
	@email varchar(30),
	@toeic varchar(30),
	@ielts varchar(30)

as
begin
	update tblGiaoVien
	set
		ho = @ho,
		tendem = @tendem,
		ten = @ten,
		ngaysinh = @ngaysinh,
		gioitinh = @gioitinh,
		diachi = @diachi,
		dienthoai = @dienthoai,
		email = @email,
		toeic = @toeic,
		ielts = @ielts
	where magiaovien = @magiaovien;
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateHocBong1HocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateHocBong1HocVien]
	@tukhoa varchar(50),
	@sotien varchar(50)
as
begin
	update tblHocVien set hocbong = CONVERT(float,@sotien) where mahocvien =@tukhoa
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateHocVien]
	@mahocvien varchar(50),
	@ho nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@ngaysinh date,
	@gioitinh tinyint,
	@diachi nvarchar(50),
	@dienthoai varchar(20),
	@email varchar(30)

as
begin
	update tblHocVien
	set
		ho = @ho,
		tendem = @tendem,
		ten = @ten,
		ngaysinh = @ngaysinh,
		gioitinh = @gioitinh,
		diachi = @diachi,
		dienthoai = @dienthoai,
		email = @email
	where mahocvien = @mahocvien;
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateKhoaHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateKhoaHoc]
	@nguoithuchien varchar(30),
	@makhoahoc varchar(50),
	@tenkhoahoc nvarchar(30),
	@sotien varchar(50)
as
begin
	update tblKhoaHoc
	set
		nguoicapnhat = @nguoithuchien,
		ngaycapnhat = GETDATE(),
		tenkhoahoc = @tenkhoahoc,
		sotien =CONVERT(int, @sotien)
	where makhoahoc = @makhoahoc

	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end 
GO
/****** Object:  StoredProcedure [dbo].[UpdateLopHoc]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateLopHoc]
	@nguoithuchien varchar(30),
	@malophoc varchar(30),
	@makhoahoc varchar(30), 
	@magiaovien varchar(30),
	@thoigianbatdau varchar(4),
	@thoigianketthuc varchar(4),
	@buoi1 varchar(1),
	@buoi2 varchar(1),
	@buoi3 varchar(1)
as
begin
	update tblLopHoc
	set nguoicapnhat = @nguoithuchien,
		ngaycapnhat = GETDATE(),
		magiaovien = @magiaovien,
		makhoahoc = @makhoahoc,
		thoigianbatdau = CONVERT(float, @thoigianbatdau),
		thoigianketthuc = CONVERT(float, @thoigianketthuc),
		buoi1 =CONVERT(int, @buoi1),
		buoi2 =CONVERT(int, @buoi2),
		buoi3 =CONVERT(int, @buoi3)
	where malophoc = @malophoc
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateSeenThongBaoByAdmin]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateSeenThongBaoByAdmin]
	@mathongbao varchar(50)
AS
BEGIN
	UPDATE tblThongBao
	SET adminseen = 1
	FROM tblThongBao
	WHERE tblThongBao.mathongbao = @mathongbao

	IF @@ROWCOUNT > 0
		RETURN 1;
	ELSE
		RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateSeenThongBaoByGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateSeenThongBaoByGiaoVien]
	@magiaovien VARCHAR(50),
	@mathongbao VARCHAR(50)
AS
BEGIN
	UPDATE tblThongBao
	SET giaovienseen = 1
	FROM tblThongBao
	INNER JOIN tblLophoc ON tblLophoc.malophoc = tblThongBao.malophoc
	INNER JOIN tblGiaoVien ON tblLopHoc.magiaovien = tblGiaoVien.magiaovien
	WHERE tblThongBao.mathongbao = @mathongbao AND tblGiaoVien.magiaovien = @magiaovien;

	IF @@ROWCOUNT > 0
		RETURN 1;
	ELSE
		RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateSeenThongBaoByHocVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateSeenThongBaoByHocVien]
	@mahocvien VARCHAR(50),
	@mathongbao VARCHAR(50)
AS
BEGIN
	UPDATE tblThongBao
	SET hocvienseen = 1
	FROM tblThongBao
	INNER JOIN tblLophoc ON tblLophoc.malophoc = tblThongBao.malophoc
	INNER JOIN tblDiem ON tblLophoc.malophoc = tblDiem.malophoc
	INNER JOIN tblHocVien ON tblHocVien.mahocvien = tblDiem.mahocvien
	WHERE tblThongBao.mathongbao = @mathongbao AND tblHocVien.mahocvien = @mahocvien;

	IF @@ROWCOUNT > 0
		RETURN 1;
	ELSE
		RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateSeenThongBaoByHocVienOrGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[UpdateSeenThongBaoByHocVienOrGiaoVien]
    @maUser VARCHAR(50),
    @mathongbao VARCHAR(50)
AS
BEGIN
    UPDATE tblThongBao
    SET hocvienseen = CASE
            WHEN tblHocVien.mahocvien = @maUser THEN 1
            ELSE hocvienseen
        END,
        giaovienseen = CASE
            WHEN tblGiaoVien.magiaovien = @maUser THEN 1
            ELSE giaovienseen
        END
    FROM tblThongBao
    INNER JOIN tblLophoc ON tblLophoc.malophoc = tblThongBao.malophoc
    INNER JOIN tblGiaoVien ON tblLopHoc.magiaovien = tblGiaoVien.magiaovien
    INNER JOIN tblDiem ON tblLophoc.malophoc = tblDiem.malophoc
    INNER JOIN tblHocVien ON tblHocVien.mahocvien = tblDiem.mahocvien
    WHERE (tblThongBao.mathongbao = @mathongbao AND tblHocVien.mahocvien = @maUser)
        OR (tblThongBao.mathongbao = @mathongbao AND tblGiaoVien.magiaovien = @maUser);

    IF @@ROWCOUNT > 0
        RETURN 1;
    ELSE
        RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateThongBaoByGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateThongBaoByGiaoVien]
	@noidung nvarchar(max),
	@mathongbao varchar(50)
as
begin
	update tblThongBao
	set
		noidung = @noidung
	where mathongbao = @mathongbao 

	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end 
GO
/****** Object:  StoredProcedure [dbo].[UpdateThuongGiaoVien]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateThuongGiaoVien]
	@tukhoa varchar(50),
	@sotien varchar(50)
as
begin
	update tblGiaoVien set thuong = CONVERT(float,@sotien) where magiaovien =@tukhoa
end
GO
/****** Object:  StoredProcedure [dbo].[XoaDanhSachLopHocDaDangKy]    Script Date: 5/15/2023 10:17:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[XoaDanhSachLopHocDaDangKy]
	@tukhoa varchar(30),
	@malophoc varchar(10)
AS
BEGIN
	DELETE FROM tblDiem
	WHERE mahocvien = @tukhoa
	AND malophoc = @malophoc

	IF @@ROWCOUNT > 0
	BEGIN
		PRINT 'Đã xóa lớp học ' + @malophoc + ' của học viên ' + @tukhoa
	END
	ELSE
	BEGIN
		PRINT 'Không tìm thấy lớp học ' + @malophoc + ' của học viên ' + @tukhoa
	END
END
GO
USE [master]
GO
ALTER DATABASE [QL_EnglishCenter_Test] SET  READ_WRITE 
GO
