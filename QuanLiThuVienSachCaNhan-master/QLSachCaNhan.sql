USE [QLSachCaNhan]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 9/11/2024 11:29:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[MaSach] [nvarchar](50) NOT NULL,
	[TenSach] [nvarchar](255) NOT NULL,
	[TacGia] [nvarchar](255) NULL,
	[ChuDe] [nvarchar](255) NULL,
	[ViTri] [nvarchar](255) NULL,
	[MaChuDe] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 9/11/2024 11:29:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[MaChuDe] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuDe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachMuon]    Script Date: 9/11/2024 11:29:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachMuon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaSach] [nvarchar](50) NULL,
	[TenSach] [nvarchar](255) NULL,
	[HoTen] [nvarchar](255) NULL,
	[TinhTrang] [bit] NOT NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
	[SDT] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](255) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S001', N'Tắt Đèn', N'Ngô Tất Tố', N'Văn học', N'Kệ A1', 1)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S002', N'Số Đỏ', N'Vũ Trọng Phụng', N'Văn học', N'Kệ A2', 1)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S003', N'Chí Phèo', N'Nam Cao', N'Văn học', N'Kệ A3', 1)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S004', N'Lão Hạc', N'Nam Cao', N'Văn học', N'Kệ A4', 1)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S005', N'Truyện Kiều', N'Nguyễn Du', N'Văn học', N'Kệ A5', 1)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S006', N'Vợ Nhặt', N'Kim Lân', N'Văn học', N'Kệ A6', 1)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S007', N'Bỉ Vỏ', N'Nguyên Hồng', N'Văn học', N'Kệ A7', 1)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S008', N'Đoạn Tuyệt', N'Nhất Linh', N'Văn học', N'Kệ A8', 1)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S009', N'Dế Mèn Phiêu Lưu Ký', N'Tô Hoài', N'Văn học', N'Kệ A9', 1)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S010', N'Những Ngày Thơ Ấu', N'Nguyên Hồng', N'Văn học', N'Kệ A10', 1)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S011', N'Lược Sử Thời Gian', N'Stephen Hawking', N'Khoa học', N'Kệ B1', 2)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S012', N'Vũ Trụ Từ Hư Không', N'Lawrence Krauss', N'Khoa học', N'Kệ B2', 2)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S013', N'Cấu Trúc Của Vũ Trụ', N'Brian Greene', N'Khoa học', N'Kệ B3', 2)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S014', N'Gien Ích Kỷ', N'Richard Dawkins', N'Khoa học', N'Kệ B4', 2)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S015', N'Lược Sử Loài Người', N'Yuval Noah Harari', N'Khoa học', N'Kệ B5', 2)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S016', N'Thế Giới Phẳng', N'Thomas Friedman', N'Kinh tế học', N'Kệ C1', 9)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S017', N'Kinh Tế Học Dành Cho Mọi Người', N'Robert Heilbroner', N'Kinh tế học', N'Kệ C2', 9)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S018', N'Nguyên Lý Kinh Tế Học', N'Paul Samuelson', N'Kinh tế học', N'Kệ C3', 9)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S019', N'Chiến Tranh Và Hòa Bình', N'Lev Tolstoy', N'Lịch sử', N'Kệ D1', 3)
INSERT [dbo].[Book] ([MaSach], [TenSach], [TacGia], [ChuDe], [ViTri], [MaChuDe]) VALUES (N'S020', N'Đại Việt Sử Ký Toàn Thư', N'Ngô Sĩ Liên', N'Lịch sử', N'Kệ D2', 3)
GO
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (1, N'Văn học')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (2, N'Khoa học')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (3, N'Lịch sử')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (4, N'Toán học')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (5, N'Triết học')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (6, N'Tâm lý học')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (7, N'Nghệ thuật')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (8, N'Chính trị')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (9, N'Kinh tế học')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (10, N'Y học')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (11, N'Văn hóa')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (12, N'Kỹ thuật')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (13, N'Xã hội học')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (14, N'Giáo dục')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (15, N'Địa lý')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (16, N'Công nghệ thông tin')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (17, N'Nông nghiệp')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (18, N'Thể thao')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (19, N'Ngoại ngữ')
INSERT [dbo].[Category] ([MaChuDe], [Name]) VALUES (20, N'Âm nhạc')
GO
SET IDENTITY_INSERT [dbo].[DanhSachMuon] ON 

INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (35, N'S001', N'Tắt Đèn', N'Nguyễn Văn A', 1, CAST(N'2024-08-01' AS Date), CAST(N'2024-08-15' AS Date), N'0912345678', N'Hà Nội')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (36, N'S002', N'Số Đỏ', N'Trần Văn B', 1, CAST(N'2024-08-02' AS Date), CAST(N'2024-08-17' AS Date), N'0912345679', N'Hồ Chí Minh')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (37, N'S003', N'Chí Phèo', N'Lê Thị C', 1, CAST(N'2024-08-03' AS Date), CAST(N'2024-08-18' AS Date), N'0912345680', N'Đà Nẵng')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (38, N'S004', N'Lão Hạc', N'Phạm Văn D', 1, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-19' AS Date), N'0912345681', N'Hải Phòng')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (39, N'S005', N'Truyện Kiều', N'Ngô Thị E', 1, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-20' AS Date), N'0912345682', N'Nghệ An')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (40, N'S006', N'Vợ Nhặt', N'Đào Văn F', 1, CAST(N'2024-08-06' AS Date), CAST(N'2024-08-21' AS Date), N'0912345683', N'Bắc Ninh')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (41, N'S007', N'Bỉ Vỏ', N'Nguyễn Văn G', 1, CAST(N'2024-08-07' AS Date), CAST(N'2024-08-22' AS Date), N'0912345684', N'Quảng Ninh')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (42, N'S008', N'Đoạn Tuyệt', N'Vũ Văn H', 1, CAST(N'2024-08-08' AS Date), CAST(N'2024-08-23' AS Date), N'0912345685', N'Thái Nguyên')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (43, N'S009', N'Dế Mèn Phiêu Lưu Ký', N'Trịnh Thị I', 1, CAST(N'2024-08-09' AS Date), CAST(N'2024-08-24' AS Date), N'0912345686', N'Huế')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (44, N'S010', N'Những Ngày Thơ Ấu', N'Đinh Văn K', 1, CAST(N'2024-08-10' AS Date), CAST(N'2024-08-25' AS Date), N'0912345687', N'Quảng Bình')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (45, N'S011', N'Lược Sử Thời Gian', N'Nguyễn Văn L', 1, CAST(N'2024-08-11' AS Date), CAST(N'2024-08-26' AS Date), N'0912345688', N'Cần Thơ')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (46, N'S012', N'Vũ Trụ Từ Hư Không', N'Trần Văn M', 1, CAST(N'2024-08-12' AS Date), CAST(N'2024-08-27' AS Date), N'0912345689', N'Nha Trang')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (47, N'S013', N'Cấu Trúc Của Vũ Trụ', N'Lê Văn N', 1, CAST(N'2024-08-13' AS Date), CAST(N'2024-08-28' AS Date), N'0912345690', N'Vũng Tàu')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (48, N'S014', N'Gien Ích Kỷ', N'Phạm Thị O', 1, CAST(N'2024-08-14' AS Date), CAST(N'2024-08-29' AS Date), N'0912345691', N'Bình Dương')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (49, N'S015', N'Lược Sử Loài Người', N'Nguyễn Văn P', 1, CAST(N'2024-08-15' AS Date), CAST(N'2024-08-30' AS Date), N'0912345692', N'Biên Hòa')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (50, N'S016', N'Thế Giới Phẳng', N'Lê Văn Q', 1, CAST(N'2024-08-16' AS Date), CAST(N'2024-08-31' AS Date), N'0912345693', N'Đà Lạt')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (51, N'S017', N'Kinh Tế Học Dành Cho Mọi Người', N'Trần Thị R', 1, CAST(N'2024-08-17' AS Date), CAST(N'2024-09-01' AS Date), N'0912345694', N'Hà Nam')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (52, N'S018', N'Nguyên Lý Kinh Tế Học', N'Ngô Văn S', 1, CAST(N'2024-08-18' AS Date), CAST(N'2024-09-02' AS Date), N'0912345695', N'Thanh Hóa')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (53, N'S019', N'Chiến Tranh Và Hòa Bình', N'Đào Văn T', 1, CAST(N'2024-08-19' AS Date), CAST(N'2024-09-03' AS Date), N'0912345696', N'Hải Dương')
INSERT [dbo].[DanhSachMuon] ([ID], [MaSach], [TenSach], [HoTen], [TinhTrang], [NgayMuon], [NgayTra], [SDT], [DiaChi]) VALUES (54, N'S020', N'Đại Việt Sử Ký Toàn Thư', N'Nguyễn Thị U', 1, CAST(N'2024-08-20' AS Date), CAST(N'2024-09-04' AS Date), N'0912345697', N'Hà Nội')
SET IDENTITY_INSERT [dbo].[DanhSachMuon] OFF
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([MaChuDe])
REFERENCES [dbo].[Category] ([MaChuDe])
GO
ALTER TABLE [dbo].[DanhSachMuon]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[Book] ([MaSach])
GO
