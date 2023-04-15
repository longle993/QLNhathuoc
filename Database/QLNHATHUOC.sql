﻿CREATE DATABASE QUANLYBANTHUOC
GO

USE QUANLYBANTHUOC
GO
CREATE TABLE HOA_DON --Đã sửa xong
(
MA_HD CHAR(50) PRIMARY KEY ,
NGAY_HD DATE NOT NULL,
MA_NV CHAR(50) NOT NULL,
TEN_KH NVARCHAR(50) NOT NULL,
MA_PTTT CHAR(50) NOT NULL,
TRI_GIA MONEY NOT NULL,
GHI_CHU NVARCHAR(500) default '',
)
GO
CREATE TABLE CT_HOA_DON --Đã sửa xong
(
MA_HD CHAR(50),
MA_SP CHAR(50),
SO_LO CHAR(50),
DVT NVARCHAR(200) NOT NULL,
SO_LUONG INT NOT NULL,
CHIET_KHAU MONEY NOT NULL,
PRIMARY KEY(MA_HD,MA_SP,SO_LO)
)
GO
GO 
CREATE TABLE PHIEU_NHAP --Đã sửa xong
(
MA_PHIEU CHAR(50) PRIMARY KEY,
NGAY_NHAP DATETIME NOT NULL,
TRI_GIA MONEY NOT NULL,
GHI_CHU NVARCHAR(500)
)
GO 
CREATE TABLE CT_PHIEU_NHAP --Đã sửa xong
(
MA_PHIEU CHAR(50) ,
MA_SP CHAR(50) ,
MA_NCC CHAR(50) NOT NULL,
SO_LO CHAR(50),
HSD DATE NOT NULL,
DON_VI_NHAP NVARCHAR(200) NOT NULL,
QUY_DOI SMALLINT,
SO_LUONG INT NOT NULL,
DON_GIA MONEY NOT NULL,
CHIET_KHAU MONEY default 0,
VAT_NHAP TINYINT NOT NULL,
PRIMARY KEY (MA_PHIEU,MA_SP,SO_LO)
)
GO
CREATE TABLE DON_VI_TINH
(
MA_SP CHAR(50),
SO_LO CHAR(50),
DVT_KHAC NVARCHAR(200) ,
QUY_DOI SMALLINT NOT NULL,
GIA_BAN MONEY NOT NULL,
PRIMARY KEY (MA_SP,SO_LO,DVT_KHAC)
)

GO
CREATE TABLE PHIEU_XUAT_HUY --Đã sửa xong
(
MA_PHIEU CHAR(50) PRIMARY KEY,
NGAY_XUAT DATETIME NOT NULL,
TRI_GIA MONEY NOT NULL,
GHI_CHU NVARCHAR(500) default '',
)

GO
CREATE TABLE CT_PHIEU_XUAT_HUY --Đã sửa xong
(
MA_PHIEU CHAR(50),
MA_SP CHAR(50),
SO_LO CHAR(50),
DVT NVARCHAR(200) NOT NULL,
SO_LUONG INT NOT NULL,
LY_DO NVARCHAR(500) NOT NULL,
PRIMARY KEY(MA_PHIEU,MA_SP,SO_LO)
)

GO
CREATE TABLE KHACH_HANG --Đã sửa xong
(
SDT CHAR(50) PRIMARY KEY,
TEN_KH NVARCHAR(50) NOT NULL,
GIOI_TINH NVARCHAR(50) default''
)
GO
CREATE TABLE HANG_HOA --Đã sửa xong
(
MA_SP CHAR(50),
SO_LO CHAR(50),
TEN_SP NVARCHAR(50),
LOAI_SP NVARCHAR(50) NOT NULL,
HAM_LUONG NVARCHAR(50) default '',
QUY_CACH_DONG_GOI NVARCHAR(500) default '',
MO_TA NVARCHAR(500) default'',
DVT_CO_BAN NVARCHAR(200) NOT NULL,
VAT_BAN TINYINT NOT NULL ,
GIA_BAN MONEY NOT NULL,
TONG_TON INT default 0,
PRIMARY KEY(MA_SP,SO_LO)
)
GO
CREATE TABLE GIA_VON --Đã sửa xong
(
MA_SP CHAR(50),
SO_LO CHAR(50),
GIAVON MONEY NOT NULL,
PRIMARY KEY (MA_SP,SO_LO)
)
GO
CREATE TABLE PTTT  --Đã sửa xong
(
MA_PTTT CHAR(50) PRIMARY KEY,
TEN_PTTT NVARCHAR(500) NOT NULL
)
GO 
CREATE TABLE NHA_CUNG_CAP --Đã sửa xong
(
MA_NCC CHAR(50) PRIMARY KEY,
TEN_NCC NVARCHAR(500) NOT NULL,
MA_SO_THUE CHAR(50) NOT NULL,
SDT CHAR(50) default '',
GHI_CHU NVARCHAR(500) default '',
)
GO
CREATE TABLE NHAN_VIEN  --Đã sửa xong
(
MA_NV CHAR(50) PRIMARY KEY,
SDT CHAR(50) default '',
TEN_NV NVARCHAR(500) NOT NULL,
)

CREATE TABLE TAI_KHOAN  --Đã sửa xong
(
TEN_TK NVARCHAR(50) NOT NULL PRIMARY KEY,
PASSWORD NVARCHAR(1000) NOT NULL,
)

-------------KHOA NGOAI---------------
---TABLE HOA_DON
ALTER TABLE HOA_DON ADD FOREIGN KEY (MA_PTTT) REFERENCES PTTT(MA_PTTT)

---TABLE CT_HOA_DON
ALTER TABLE CT_HOA_DON ADD FOREIGN KEY (MA_HD) REFERENCES HOA_DON(MA_HD)
ALTER TABLE CT_HOA_DON ADD FOREIGN KEY (MA_SP,SO_LO) REFERENCES HANG_HOA(MA_SP,SO_LO)

---TABLE CT_PHIEU_NHAP
ALTER TABLE CT_PHIEU_NHAP ADD FOREIGN KEY (MA_PHIEU) REFERENCES PHIEU_NHAP(MA_PHIEU)
ALTER TABLE CT_PHIEU_NHAP ADD FOREIGN KEY (MA_SP,SO_LO) REFERENCES HANG_HOA(MA_SP,SO_LO)
ALTER TABLE CT_PHIEU_NHAP ADD FOREIGN KEY (MA_NCC) REFERENCES NHA_CUNG_CAP(MA_NCC)

---TABLE CT_PHIEU_XUAT_HUY
ALTER TABLE CT_PHIEU_XUAT_HUY ADD FOREIGN KEY (MA_PHIEU) REFERENCES PHIEU_XUAT_HUY(MA_PHIEU)
ALTER TABLE CT_PHIEU_XUAT_HUY ADD FOREIGN KEY (MA_SP,SO_LO) REFERENCES HANG_HOA(MA_SP,SO_LO)

---TABLE GIA_VON
ALTER TABLE GIA_VON ADD FOREIGN KEY (MA_SP,SO_LO) REFERENCES HANG_HOA(MA_SP,SO_LO)

ALTER TABLE DON_VI_TINH ADD FOREIGN KEY (MA_SP,SO_LO) REFERENCES HANG_HOA(MA_SP,SO_LO)


---Trigger-----
GO
CREATE TRIGGER InsertGiavon on dbo.CT_PHIEU_NHAP
FOR UPDATE, INSERT
AS
BEGIN
	declare @Soluong int
	select @Soluong = SO_LUONG from inserted

	declare @Dongia money
	select @Dongia = DON_GIA from inserted

	declare @Chietkhau money
	select @Chietkhau = CHIET_KHAU from inserted

	declare @VATNhap tinyint
	select @VATNhap = VAT_NHAP from inserted

	declare @Masp char(50)
	select @Masp = MA_SP from inserted

	declare @Solo char(50)
	select @Solo = SO_LO from inserted

	declare @gia_von money
	set @gia_von = ((@Soluong * @Dongia - @Chietkhau) * (1 + @VATNhap))/@Soluong
	insert into GIA_VON values (@Masp,@Solo,@gia_von)
END

select * from PHIEU_NHAP

-------INSERT

-----TAI_KHOAN------
GO
INSERT INTO TAI_KHOAN VALUES (N'le.duclong0909@gmail.com','202cb962ac59075b964b07152d234b70')

---- KHACH_HANG ----
GO
INSERT INTO KHACH_HANG VALUES ('0879511207',N'Long',N'Nam')
INSERT INTO KHACH_HANG VALUES ('0778876979',N'Thịnh',N'Nam')

----- NHAN_VIEN ----
GO
INSERT INTO NHAN_VIEN VALUES (N'NV01','0333789993',N'Khả Minh')


----PTTT------------
GO
INSERT INTO PTTT VALUES('PT01',N'Tiền mặt')

---- NHA_CUNG_CAP ----
GO
INSERT INTO NHA_CUNG_CAP (MA_NCC,TEN_NCC,MA_SO_THUE,SDT,GHI_CHU)
VALUES 
('NCC000001', N'Công ty TNHH Dược phẩm Gigamed', '316417470', '1800545446', ''),
('NCC000002', N'Công ty TNHH Dược phẩm Trúc Chi', '1600511985', '02963841429', ''),
('NCC000003', N'Công ty cổ phần Dược phẩm OPC', '0302560110-006','02923837799', ''),
('NCC000004', N'Công ty TNHH Thương mại Dược phẩm Đông Á', '0100274124-003', '02837657999', ''),
('NCC000005', N'Chi nhánh Công ty Cổ phần Traphaco', '0100108656-004', '', ''),
('NCC000006', N'Công ty Cổ phần Tập đoàn MERAP', '0101400572', '02562651638', ''),
('NCC000007', N'Công ty Cổ phần Dược phẩm Việt Hà', '0302375710', '02839703695', ''),
('NCC000008', N'Công ty TNHH Dược phẩm KHẢ THY', '1600708452', '', ''),
('NCC000009', N'Công ty cổ phần dược - trang thiết bị y tế BÌNH ĐỊNH ( BIDIPHAR)', '4100259564-023', '', ''),
('NCC000010', N'Công ty TNHH Dược phẩm Trường Tín', '0309537209', '', ''),
('NCC000011', N'Công ty Cổ phần Dược phẩm Imexpharm', '1400384433-012', '', ''),
('NCC000012', N'Công ty Dược phẩm Hasan', '0309561353', '', ''),
('NCC000013', N'Công ty cổ phần xuất nhập khẩu y tế DOMESCO-chi nhánh An Giang', '1400460395-028', '', ''),
('NCC000014', N'Công ty Dược Hậu Giang', '1800156801-012', '', ''),
('NCC000015', N'Công ty cổ phần Pymepharco', '4400116704', '', '');


 
-----DANH_MUC_SP-----
GO
INSERT INTO HANG_HOA(MA_SP,SO_LO,TEN_SP,LOAI_SP,HAM_LUONG,QUY_CACH_DONG_GOI,MO_TA,DVT_CO_BAN,VAT_BAN,GIA_BAN,TONG_TON)
VALUES 
 ('SP000001','DVH0272', N'Panadol extra 180', N'Thuốc không kê đơn', '500mg', N'Hộp 15 vỉ x 12 viên', '', N'Viên',0, 1500, 0), 
 ('SP000002','71122', N'Kem đánh răng Sensodyne Rapid Action 100g', N'Mỹ phẩm', '100g', N'Tuýp', '', N'Tuýp',0, 88000, 0), 
 ('SP000003','AEA604', N'Gaviscon Suspension', N'Thuốc kê đơn', '10ml', N'Hộp 24 gói', '', N'Gói',0, 7000, 0), 
 ('SP000004','A5746', N'Efferalgan 500', N'Thuốc không kê đơn', '500mg', N'Hộp 4 vỉ x 4 viên', '', N'Viên',0, 3000, 0), 
 ('SP000005','22C32', N'Daktarin Oral gel 10g', N'Thuốc kê đơn', '10g', N'Tuýp', '', N'Tuýp', 0,50000, 0), 
 ('SP000006','058322', N'Efticol 0,9%', N'Thuốc không kê đơn', '10ml', N'Lọ', '', N'Lọ',0, 2500, 0), 
 ('SP000007','171022', N'Enalapril Stella 5mg', N'Thuốc kê đơn', '5mg', N'Hộp 3 vỉ x 10 viên', '', N'Viên',0, 700, 0), 
 ('SP000008','2283016', N'Fugacar (Choco),', N'Thuốc không kê đơn', '500mg', N'Hộp 1 viên', '', N'Hộp',0, 21000, 0), 
 ('SP000009','1012214', N'Homtamin Ginseng', N'Thuốc không kê đơn', '40mg', N'Hộp 12 vỉ x 5 viên', '', N'Viên',0, 2200, 0), 
 ('SP000010','218541', N'Kremil-S', N'Thuốc không kê đơn', '', N'Hộp 10 vỉ x 10 viên', '', N'Viên',0, 1100, 0), 
 ('SP000011','D97204', N'Mobic 7,5mg', N'Thuốc kê đơn', '7,5mg', N'Hộp 2 vỉ x 10 viên', '', N'Viên',0, 100000, 0), 
 ('SP000012','14501222', N'(Mắt), Natri Clorid 0,9%', N'Thuốc không kê đơn', '10ml', N'Chai', '', N'Chai',0, 3000, 0), 
 ('SP000013','22D94', N'Nizoral Cream 5g', N'Thuốc không kê đơn', '5g', N'Tuýp', '', N'Tuýp',0, 23000, 0), 
 ('SP000014','U22042', N'Smecta', N'Thuốc không kê đơn', '3g', N'Hộp 30 gói', '', N'Gói',0, 4100, 0), 
 ('SP000015','CVH2824', N'Sorbitol Sanofi 5g', N'Thuốc không kê đơn', '5g', N'Hộp 20 gói', '', N'Gói',0, 2200, 0), 
 ('SP000016','6522', N'Sorbitol Đỏ Bình Thuận', N'Thuốc không kê đơn', '5g', N'Hộp 20 gói', '', N'Gói',0, 900, 0), 
 ('SP000017','MGL6Y00', N'Sporal', N'Thuốc kê đơn', '100mg', N'Hộp 1 vỉ x 4 viên', '', N'Viên',0, 19500, 0), 
 ('SP000018','7422', N'Tetra 1%', N'Thuốc kê đơn', '5g', N'Tuýp', '', N'Tuýp',0, 5000, 0), 
 ('SP000019','DVH0219', N'Theralene Siro', N'Thuốc không kê đơn', '90ml', N'Chai', '', N'Chai',0, 18000, 0), 
 ('SP000020','FV0747', N'Ventolin Neb 2,5mg', N'Thuốc kê đơn', '2,5mg', N'Hộp 6 vỉ x 5 ống', '', N'Ống',0, 6400, 0), 
 ('SP000021','HM8W', N'Ventolin INH 100mg', N'Thuốc kê đơn', '100mg', N'Hộp', '', N'Hộp',0, 100000, 0), 
 ('SP000022','22080', N'Dầu khuynh diệp OPC', N'Thuốc không kê đơn', '25ml', N'Chai', '', N'Chai',0, 66000, 0), 
 ('SP000023','22007', N'NCortonyl OPC', N'Thuốc kê đơn', '25ml', N'Chai', '', N'Chai',0, 25000, 0), 
 ('SP000024','22007', N'Dung dịch MILIAN', N'Thuốc không kê đơn', '20ml', N'Chai', '', N'Chai',0, 12000, 0), 
 ('SP000025','22062', N'Nước oxy già 3% 60ml', N'Thuốc không kê đơn', '60ml', N'Chai', '', N'Chai',0, 3000, 0), 
 ('SP000026','0071222', N'Vedanal Fort', N'Thuốc kê đơn', '10g', N'Hộp 1 tuýp', '', N'Hộp',0, 80000, 0), 
 ('SP000027','2222', N'Levigatus', N'Thuốc không kê đơn', '20g', N'Tuýp', '', N'Tuýp',0, 21000, 0), 
 ('SP000027','2022', N'Levigatus', N'Thuốc không kê đơn', '20g', N'Tuýp', '', N'Tuýp',0, 21000, 0), 
 ('SP000028','0522', N'Ofloxacin 0,3%', N'Thuốc kê đơn', '6ml', N'Lọ', '', N'Lọ',0, 11000, 0), 
 ('SP000029','0722', N'Tobramycin 0,3%', N'Thuốc kê đơn', '6ml', N'Lọ', '', N'Lọ',0, 15000, 0), 
 ('SP000030','0431222', N'Nước biển sâu sạch thông mũi Xisat trẻ em', N'Thuốc không kê đơn', '75ml', N'Hộp 1 chai', '', N'Chai',0, 30000, 0), 
 ('SP000031','0051122', N'Dung dịch vệ sinh Shema Lá Đôi (hồng),', N'Mỹ phẩm', '200ml', N'Hộp 1 chai', '', N'Chai',0, 28000, 0), 
 ('SP000032','0061022', N'Dung dịch vệ sinh Shema Lá Đôi (xanh),', N'Mỹ phẩm', '200ml', N'Hộp 1 chai', '', N'Chai',0, 28000, 0), 
 ('SP000033','0020123', N'Nước biển sâu sạch thông mũi Xisat người lớn', N'Mỹ phẩm', '75ml', N'Hộp 1 chai', '', N'Chai',0, 29000, 0), 
 ('SP000034','0721222', N'Ebysta', N'Thuốc không kê đơn', '10ml', N'Hộp 20 gói', '', N'Gói',0, 4200, 0), 
 ('SP000035','060522', N'Dạ dày Nhất Nhất', N'Thuốc không kê đơn', '', N'Hộp 2 vỉ x 10 viên', '', N'Hộp',0, 120000, 0), 
 ('SP000036','060522', N'Đại tràng Nhất Nhất', N'Thuốc không kê đơn', '', N'Hộp 2 vỉ x 10 viên', '', N'Hộp',0, 95000, 0), 
 ('SP000037','861022', N'Hoạt huyết Nhất Nhất', N'Thuốc không kê đơn', '', N'Hộp 3 vỉ x 10 viên', '', N'Vỉ',0, 37000, 0), 
 ('SP000038','120123', N'Tonka', N'Thuốc không kê đơn', '', N'Hộp 2 vỉ x 10 viên', '', N'Hộp',0, 68000, 0), 
 ('SP000039','120123', N'Xịt họng Nhất Nhất', N'Thuốc không kê đơn', '20ml', N'Chai', '', N'Chai',0, 70000, 0), 
 ('SP000040','200223', N'Xương khớp Nhất Nhất', N'Thuốc không kê đơn', '', N'Hộp 2 vỉ x 10 viên', '', N'Hộp',0, 105000, 0), 
 ('SP000041','22DO3029', N'Grafort', N'Thuốc không kê đơn', '20ml', N'Hộp 20 gói', '', N'Gói',0, 8500, 0), 
 ('SP000042','1886', N'Neo-Codion', N'Thuốc kê đơn', '', N'Hộp 2 vỉ x 10 viên', '', N'Viên',0, 8000, 0), 
 ('SP000043','21005A', N'Berlthyrox 100', N'Thuốc kê đơn', '100mg', N'Hộp 4 vỉ x 25 viên', '', N'Viên',0, 1000, 0), 
 ('SP000044','E583A0122', N'Piracetam-Egis 800', N'Thuốc kê đơn', '800mg', N'Hộp 30 viên', '', N'Viên',0, 2500, 0), 
 ('SP000045','1422', N'Avicrem', N'Thuốc không kê đơn', '5g', N'Tuýp', '', N'Tuýp',0, 25000, 0), 
 ('SP000046','2623', N'Boganic Forte', N'Thuốc không kê đơn', '', N'Hộp 5 vỉ x 10 viên', '', N'Hộp',0, 102000, 0), 
 ('SP000047','27422', N'Hoạt huyết dưỡng não', N'Thuốc không kê đơn', '', N'Hộp 5 vỉ x 20 viên', '', N'Viên',0, 950, 0), 
 ('SP000048','16422', N'Thuốc ho Methorphan', N'Thuốc kê đơn', '', N'Hộp 2 vỉ x 10 viên', '', N'Viên',0, 1000, 0), 
 ('SP000049','1161222', N'Aquima', N'Thuốc không kê đơn', '10ml', N'Hộp 20 gói', '', N'Gói',0, 3500, 0), 
 ('SP000050','0061222', N'Benate Fort Ointment 0,05%', N'Thuốc kê đơn', '10g', N'Hộp 1 tuýp', '', N'Hộp',0, 25000, 0);
 

 
----PHIEU_NHAP----
GO
INSERT INTO PHIEU_NHAP (MA_PHIEU, NGAY_NHAP, TRI_GIA, GHI_CHU) VALUES
('PN230202001', '2023-02-02 8:40:14', 405007, ''),
('PN230222001', '2023-02-22 12:23:44', 2041227, ''),
('PN230223001', '2023-02-23 10:05:56', 1006352, ''),
('PN230223002', '2023-02-23 15:16:37', 1014004, ''),
('PN230227001', '2023-02-27 17:52:11', 2292912, ''),
('PN230228001', '2023-02-28 8:21:05', 799995, ''),
('PN230301001', '2023-03-01 18:34:12', 4847010, ''),
('PN230303001', '2023-03-03 18:34:12', 3594885, ''),
('PN230306001', '2023-03-06 9:25:03', 1974693, ''),
('PN230309001', '2023-03-09 10:48:27', 1500992, ''),
('PN230309002', '2023-03-09 14:10:50', 620081, '');
 -----CT_PHIEU_NHAP---- select * from CT_PHIEU_NHAP
GO
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230309002', 'SP000049', 'NCC000006', '1161222', '2025-12-29', N'Hộp 20 gói', 1, 4, 62857, 20114, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230309002', 'SP000050', 'NCC000006', '0061222', '2025-12-21', N'Hộp 1 tuýp', 1, 10, 21905, 17524, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230309002', 'SP000026', 'NCC000006', '0071222', '2025-12-25', N'Hộp 1 tuýp', 1, 3, 57143, 13714, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230309001', 'SP000027', 'NCC000005', '2222', '2024-11-25', N'Tuýp', 1, 10, 18095, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230309001', 'SP000045', 'NCC000005', '1422', '2025-12-08', N'Tuýp', 1, 10, 16190, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230309001', 'SP000046', 'NCC000005', '2623', '2025-01-11', N'Hộp', 1, 2, 98095, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230309001', 'SP000047', 'NCC000005', '27422', '2025-10-11', N'Hộp', 1, 5, 90476, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230309001', 'SP000048', 'NCC000005', '16422', '2025-12-10', N'Hộp', 1, 5, 87619, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230306001', 'SP000041', 'NCC000007', '22DO3029', '2025-08-16', N'Hộp', 1, 5, 150476, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230306001', 'SP000042', 'NCC000007', '1886', '2025-04-01', N'Hộp', 1, 1, 68285, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230306001', 'SP000043', 'NCC000007', '21005A', '2024-01-03', N'Hộp', 1, 5, 59619, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230306001', 'SP000044', 'NCC000007', 'E583A0122', '2025-01-25', N'Hộp', 1, 13, 76190, 228570, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230303001', 'SP000035', 'NCC000002', '060522', '2025-06-05', N'Hộp', 1, 1, 111300, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230303001', 'SP000036', 'NCC000002', '060522', '2025-06-05', N'Hộp', 1, 1, 106600, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230303001', 'SP000037', 'NCC000002', '861022', '2025-10-20', N'Hộp', 1, 20, 98100, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230303001', 'SP000038', 'NCC000002', '120123', '2026-01-13', N'Hộp', 1, 1, 78300, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230303001', 'SP000039', 'NCC000002', '120123', '2025-01-13', N'Chai', 1, 10, 68900, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230303001', 'SP000040', 'NCC000002', '200223', '2025-02-22', N'Hộp', 1, 5, 95300, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001', 'SP000005', 'NCC000002', '22C32', '2025-06-13', N'Tuýp', 1, 3, 42400, 0, 5) 
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001', 'SP000006', 'NCC000002', '058322', '2025-12-12', N'Lọ', 1, 100, 2430, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001', 'SP000007', 'NCC000002', '171022', '2025-10-09', N'Hộp', 1, 5, 18700, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001', 'SP000008', 'NCC000002', '2283016', '2025-08-19', N'Hộp', 1, 50, 18600, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001', 'SP000009', 'NCC000002', '1012214', '2025-06-12', N'Hộp', 1, 3, 80600, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001', 'SP000010', 'NCC000002', '218541', '2025-08-17', N'Hộp', 1, 3, 98400, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001', 'SP000011', 'NCC000002', 'D97204', '2025-05-10', N'Hộp', 1, 2, 167100, 0, 5)
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001','SP000012','NCC000002','14501222','6/17/2025',N'Chai','1','100','2,800',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001','SP000013','NCC000002','22D94','9/29/2025',N'Tuýp','1','10','20,400',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001','SP000014','NCC000002','U22042','11/23/2024',N'Hộp','1','2','108,400',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001','SP000015','NCC000002','CVH2824','1/10/2025',N'Hộp','1','5','36,000',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001','SP000016','NCC000002','6522','9/20/2025',N'Hộp','1','10','14,700',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001','SP000017','NCC000002','MGL6Y00','7/6/2025',N'Hộp','1','3','73,000',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001','SP000018','NCC000002','7422','11/28/2025',N'Tuýp','1','20','3,500',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001','SP000019','NCC000002','DVH0219','1/9/2025',N'Chai','1','5','14,800',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001','SP000020','NCC000002','FV0747','11/24/2024',N'Hộp','1','3','166,000',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230301001','SP000021','NCC000002','HM8W','9/26/2024',N'Hộp','1','5','92,500',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230228001','SP000034','NCC000006','0721222','12/23/2024',N'Hộp','1','11','76,190','76,190','5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230227001','SP000022','NCC000003','22080','11/18/2025',N'Chai','1','24','64,297',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230227001','SP000023','NCC000003','22007','10/8/2025',N'Chai','1','16','19,303',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230227001','SP000024','NCC000003','22007','12/1/2025',N'Chai','1','30','8,924',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230227001','SP000025','NCC000003','22062','12/8/2025',N'Chai','1','30','2,134',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230223002','SP000030','NCC000006','0431222','12/21/2024',N'Hộp','1','12','25,714',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230223002','SP000031','NCC000006','0051122','11/10/2025',N'Hộp','1','10','31,364',0,'10')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230223002','SP000032','NCC000006','0061022','10/7/2025',N'Hộp','1','10','31,364',0,'10')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230223002','SP000033','NCC000006','0020123','1/12/2025',N'Hộp','1','2','25,714','51,428','10')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230223001','SP000004','NCC000001','A5746','1/19/2025',N'Hộp','1','30','41,081','274,000','5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230222001','SP000001','NCC000001','DVH0272','2/27/2026',N'Hộp','1','4','203,333','0','5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230222001','SP000002','NCC000001','71122','11/2/2024',N'Tuýp','1','1','78,182','5,473','10')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230222001','SP000003','NCC000001','AEA604','10/21/2024',N'Hộp','1','8','140,229','67,310','5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230202001','SP000027','NCC000005','2022','11/23/2024',N'Tuýp','1','10','18,095',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230202001','SP000028','NCC000005','0522','5/2/2025',N'Lọ','1','10','9,048',0,'5')
INSERT INTO CT_PHIEU_NHAP VALUES ('PN230202001','SP000029','NCC000005','0722','11/11/2024',N'Lọ','1','10','11,429',0,'5')
-------DON_VI_TINH---------
GO  
INSERT INTO DON_VI_TINH (MA_SP,SO_LO,DVT_KHAC,QUY_DOI,GIA_BAN) VALUES
('SP000001','DVH0272', N'Hộp', 180, 270000),
('SP000001','DVH0272', N'Vỉ', 12, 18000),
('SP000003','AEA604', N'Gói', 24, 168000),
('SP000004','A5746', N'Hộp', 16, 48000),
('SP000004','A5746', N'Vỉ', 4, 12000),
('SP000007','171022', N'Hộp', 30, 20000),
('SP000007','171022', N'Vỉ', 10, 7000),
('SP000009','1012214', N'Hộp', 60, 132000),
('SP000009','1012214', N'Vỉ', 5, 11000),
('SP000010','218541', N'Hộp', 100, 110000),
('SP000010','218541', N'Vỉ', 10, 11000),
('SP000011','D97204', N'Hộp', 20, 200000),
('SP000011','D97204', N'Vỉ', 10, 100000),
('SP000014','U22042', N'Hộp', 30, 123000),
('SP000015','CVH2824', N'Hộp', 20, 44000),
('SP000016','6522', N'Hộp', 20, 18000),
('SP000017','MGL6Y00', N'Hộp', 4, 78000),
('SP000020','FV0747', N'Hộp', 30, 192000),
('SP000020','FV0747', N'Vỉ', 5, 32000),
('SP000026','0071222', N'Hộp', 100, 8000000),
('SP000026','0071222', N'Vỉ', 10, 800000),
('SP000034','0721222', N'Hộp', 20, 84000),
('SP000037','861022', N'Hộp', 3, 105000),
('SP000041','22DO3029', N'Hộp', 20, 170000),
('SP000042','1886', N'Hộp', 20, 160000),
('SP000042','1886', N'Vỉ', 10, 80000),
('SP000043','21005A', N'Hộp', 100, 100000),
('SP000043','21005A', N'Vỉ', 25, 25000),
('SP000044','E583A0122', N'Hộp', 30, 75000),
('SP000047','27422', N'Hộp', 100, 95000),
('SP000047','27422', N'Vỉ', 20, 19000),
('SP000048','16422', N'Hộp', 20, 20000),
('SP000048','16422', N'Vỉ', 10, 10000),
('SP000049','1161222', N'Hộp', 20, 70000);


---- HOA_DON ----
GO
INSERT INTO HOA_DON (MA_HD,NGAY_HD,MA_NV,TEN_KH,MA_PTTT,TRI_GIA,GHI_CHU) VALUES
('HD230314003', '2023-03-14', N'NV01', N'Khách lẻ', N'PT01', 19500, ''),
('HD230314002', '2023-03-14', N'NV01', N'Khách lẻ', N'PT01', 18000, ''),
('HD230314001', '2023-03-14', N'NV01', N'Khách lẻ', N'PT01', 70000, ''),
('HD230303004', '2023-03-03', N'NV01', N'Khách lẻ', N'PT01', 3500, ''),
('HD230303003', '2023-03-03', N'NV01', N'Khách lẻ', N'PT01', 28000, ''),
('HD230303002', '2023-03-03', N'NV01', N'Khách lẻ', N'PT01', 25000, ''),
('HD230303001', '2023-03-03', N'NV01', N'Khách lẻ', N'PT01', 12000, ''),
('HD230301002', '2023-03-01', N'NV01', N'Khách lẻ', N'PT01', 18000, ''),
('HD230301001', '2023-03-01', N'NV01', N'Khách lẻ', N'PT01', 70000, ''),
('HD230228003', '2023-02-28', N'NV01', N'Khách lẻ', N'PT01', 100000, ''),
('HD230228002', '2023-02-28', N'NV01', N'Khách lẻ', N'PT01', 3000, ''),
('HD230228001', '2023-02-28', N'NV01', N'Khách lẻ', N'PT01', 70000, ''),
('HD230225002', '2023-02-25', N'NV01', N'Khách lẻ', N'PT01', 10000, ''),
('HD230225001', '2023-02-25', N'NV01', N'Khách lẻ', N'PT01', 4200, ''),
('HD230213003', '2023-02-13', N'NV01', N'Khách lẻ', N'PT01', 18000, ''),
('HD230213002', '2023-02-13', N'NV01', N'Khách lẻ', N'PT01', 29000, ''),
('HD230213001', '2023-02-13', N'NV01', N'Khách lẻ', N'PT01', 15000, ''),
('HD230210007', '2023-02-10', N'NV01', N'Khách lẻ', N'PT01', 120000, ''),
('HD230210006', '2023-02-10', N'NV01', N'Khách lẻ', N'PT01', 7000, ''),
('HD230210005', '2023-02-10', N'NV01', N'Khách lẻ', N'PT01', 108500, ''),
('HD230210004', '2023-02-10', N'NV01', N'Khách lẻ', N'PT01', 15000, ''),
('HD230210003', '2023-02-10', N'NV01', N'Khách lẻ', N'PT01', 198000, ''),
('HD230210002', '2023-02-10', N'NV01', N'Khách lẻ', N'PT01', 75000, ''),
('HD230210001', '2023-02-10', N'NV01', N'Khách lẻ', N'PT01', 3000, ''),
('HD230208006', '2023-02-08', N'NV01', N'Khách lẻ', N'PT01', 25000, ''),
('HD230208005', '2023-02-08', N'NV01', N'Khách lẻ', N'PT01', 50000, ''),
('HD230208004', '2023-02-08', N'NV01', N'Khách lẻ', N'PT01', 73000, ''),
('HD230208003', '2023-02-08', N'NV01', N'Khách lẻ', N'PT01', 56400, ''),
('HD230208002', '2023-02-08', N'NV01', N'Khách lẻ', N'PT01', 125000, ''),
('HD230208001', '2023-02-08', N'NV01', N'Khách lẻ', N'PT01', 4200, ''),
('HD230206005', '2023-02-06', N'NV01', N'Khách lẻ', N'PT01', 25000, ''),
('HD230206004', '2023-02-06', N'NV01', N'Khách lẻ', N'PT01', 3000, ''),
('HD230206003', '2023-02-06', N'NV01', N'Khách lẻ', N'PT01', 33000, ''),
('HD230206002', '2023-02-06', N'NV01', N'Khách lẻ', N'PT01', 98000, ''),
('HD230206001','6/2/2023',N'NV01',N'Khách lẻ',N'PT01','14500',''),
('HD230205006','5/2/2023',N'NV01',N'Khách lẻ',N'PT01','700',''),
('HD230205005','5/2/2023',N'NV01',N'Khách lẻ',N'PT01','47000',''),
('HD230205004','5/2/2023',N'NV01',N'Khách lẻ',N'PT01','5000',''),
('HD230205003','5/2/2023',N'NV01',N'Khách lẻ',N'PT01','90500',''),
('HD230205002','5/2/2023',N'NV01',N'Khách lẻ',N'PT01','118000',''),
('HD230204001','5/2/2023',N'NV01',N'Khách lẻ',N'PT01','113000',''),
('HD230203010','3/2/2023',N'NV01',N'Khách lẻ',N'PT01','23000',''),
('HD230203009','3/2/2023',N'NV01',N'Khách lẻ',N'PT01','19500',''),
('HD230203008','3/2/2023',N'NV01',N'Khách lẻ',N'PT01','2200',''),
('HD230203007','3/2/2023',N'NV01',N'Khách lẻ',N'PT01','270000',''),
('HD230203006','3/2/2023',N'NV01',N'Khách lẻ',N'PT01','5000',''),
('HD230203005','3/2/2023',N'NV01',N'Khách lẻ',N'PT01','114000',''),
('HD230203004','3/2/2023',N'NV01',N'Khách lẻ',N'PT01','125000',''),
('HD230203003','3/2/2023',N'NV01',N'Khách lẻ',N'PT01','146000',''),
('HD230203002','3/2/2023',N'NV01',N'Khách lẻ',N'PT01','6000',''),
('HD230203001','3/2/2023',N'NV01',N'Khách lẻ',N'PT01','189000',''),
('HD230202006','2/2/2023',N'NV01',N'Khách lẻ',N'PT01','31000',''),
('HD230202005','2/2/2023',N'NV01',N'Khách lẻ',N'PT01','18000',''),
('HD230202004','2/2/2023',N'NV01',N'Khách lẻ',N'PT01','208500',''),
('HD230202003','2/2/2023',N'NV01',N'Khách lẻ',N'PT01','69200',''),
('HD230202002','2/2/2023',N'NV01',N'Khách lẻ',N'PT01','98700',''),
('HD230202001','2/2/2023',N'NV01',N'Khách lẻ',N'PT01','28000',''),
('HD230201005','1/2/2023',N'NV01',N'Khách lẻ',N'PT01','4200',''),
('HD230201004','1/2/2023',N'NV01',N'Khách lẻ',N'PT01','2200',''),
('HD230201003','1/2/2023',N'NV01',N'Khách lẻ',N'PT01','148200',''),
('HD230201002','1/2/2023',N'NV01',N'Khách lẻ',N'PT01','42000',''),
('HD230201001','1/2/2023',N'NV01',N'Khách lẻ',N'PT01','50000','');

------- CT_HOA_DON ------
GO
 INSERT INTO CT_HOA_DON (MA_HD,MA_SP,SO_LO,DVT,SO_LUONG,CHIET_KHAU) VALUES
('HD230314001', 'SP000039','120123', N'Chai', 4,0),
('HD230314002', 'SP000001','DVH0272', N'Vỉ', 3,0),
('HD230314003', 'SP000017','MGL6Y00', N'Viên', 3,0),
('HD230303001', 'SP000004','A5746', N'Vỉ', 1,0),
('HD230303002', 'SP000023','22007', N'Chai', 2,0),
('HD230303003', 'SP000031','0051122', N'Chai', 2,0),
('HD230303004', 'SP000049','1161222', N'Gói', 4,0),
('HD230301001', 'SP000039','120123', N'Chai', 2,0),
('HD230301002', 'SP000019','DVH0219', N'Chai', 4,0),
('HD230228001', 'SP000039','120123', N'Chai', 3,0),
('HD230228002', 'SP000025','22062', N'Chai', 3,0),
('HD230228003', 'SP000011','D97204', N'Vỉ', 1,0),
('HD230225001', 'SP000034','0721222', N'Gói', 3,0),
('HD230225002', 'SP000011','D97204', N'Viên', 3,0),
('HD230213003', 'SP000019','DVH0219', N'Chai', 1,0),
('HD230213002', 'SP000033','0020123', N'Chai', 5,0),
('HD230213001', 'SP000029','0722', N'Lọ', 4,0),
('HD230210007', 'SP000029','0722', N'Lọ', 3,0),
('HD230210007', 'SP000021','HM8W', N'Hộp', 3,0),
('HD230210007', 'SP000018','7422', N'Tuýp', 1,0),
('HD230210006', 'SP000003','AEA604', N'Gói', 3,0),
('HD230210005', 'SP000040','200223', N'Hộp', 1,0),
('HD230210005', 'SP000049','1161222', N'Gói', 4,0),
('HD230210004', 'SP000029','0722', N'Lọ', 5,0),
('HD230210003', 'SP000017','MGL6Y00', N'Hộp', 1,0),
('HD230210003', 'SP000035','060522', N'Hộp', 1,0),
('HD230210002', 'SP000050','0061222', N'Hộp', 4,0),
('HD230210002', 'SP000005','22C32', N'Tuýp', 5,0),
('HD230210001', 'SP000012','14501222', N'Chai', 2,0),
('HD230208006', 'SP000045','1422', N'Tuýp', 4,0),
('HD230208005', 'SP000005','22C32', N'Tuýp', 4,0),
('HD230208004', 'SP000003','AEA604', N'Gói', 3,0),
('HD230208004', 'SP000022','22080', N'Chai', 5,0),
('HD230208003', 'SP000005','22C32', N'Tuýp', 1,0),
('HD230208003', 'SP000015','CVH2824', N'Gói', 2,0),
('HD230208003', 'SP000034','0721222', N'Gói', 3,0),
('HD230208002', 'SP000036','060522', N'Hộp', 5,0),
('HD230208002', 'SP000030','0431222', N'Chai', 3,0),
('HD230208001', 'SP000034','0721222', N'Gói', 3,0),
('HD230206005', 'SP000050','0061222', N'Hộp', 1,0),
('HD230206004', 'SP000012','14501222', N'Chai', 5,0),
('HD230206003', 'SP000030','0431222', N'Chai', 4,0),
('HD230206003', 'SP000025','22062', N'Chai', 2,0),
('HD230206002', 'SP000022','22080', N'Chai', 5,0),
('HD230206002', 'SP000008','2283016', N'Hộp', 3,0),-----Sửa
('HD230206002', 'SP000010','218541', N'Vỉ', 3,0),
('HD230206001', 'SP000024','22007', N'Chai', 4,0),
('HD230206001', 'SP000044','E583A0122', N'Viên', 3,0),
('HD230205006', 'SP000007','171022', N'Viên', 5,0),
('HD230205005','SP000033','0020123',N'Chai','2',0),
('HD230205005','SP000001','DVH0272',N'Vỉ','1',0),
('HD230205004','SP000018','7422',N'Tuýp','1',0),
('HD230205003','SP000006','058322',N'Lọ','1',0),
('HD230205003','SP000002','71122',N'Tuýp','2',0),
('HD230205002','SP000005','22C32',N'Tuýp','4',0),
('HD230205002','SP000019','DVH0219',N'Chai','1',0),
('HD230205002','SP000050','0061222',N'Hộp','4',0),
('HD230205002','SP000043','21005A',N'Vỉ','5',0),
('HD230204001','SP000010','218541',N'Vỉ','4',0),
('HD230204001','SP000046','2623',N'Hộp','1',0),
('HD230203010','SP000013','22D94',N'Tuýp','3',0),
('HD230203009','SP000017','MGL6Y00',N'Viên','2',0),
('HD230203008','SP000015','CVH2824',N'Gói','3',0),
('HD230203007','SP000001','DVH0272',N'Hộp','2',0),
('HD230203006','SP000018','7422',N'Tuýp','5',0),
('HD230203005','SP000024','22007',N'Chai','2',0),
('HD230203005','SP000046','2623',N'Hộp','4',0),
('HD230203004','SP000030','0431222',N'Chai','1',0),
('HD230203004','SP000036','060522',N'Hộp','1',0),
('HD230203003','SP000030','0431222',N'Chai','4',0),
('HD230203003','SP000028','0522',N'Lọ','2',0),
('HD230203003','SP000040','200223',N'Hộp','3',0),
('HD230203002','SP000006','058322',N'Lọ','2',0),
('HD230203002','SP000049','1161222',N'Gói','5',0),
('HD230203001','SP000034','0721222',N'Hộp','2',0),
('HD230203001','SP000040','200223',N'Hộp','4',0),
('HD230202006','SP000010','218541',N'Vỉ','4',0),
('HD230202006','SP000007','171022',N'Hộp','1',0),
('HD230202005','SP000001','DVH0272',N'Vỉ','3',0),
('HD230202004','SP000049','1161222',N'Gói','5',0),
('HD230202004','SP000003','AEA604',N'Hộp','2',0),
('HD230202004','SP000037','861022',N'Vỉ','3',0),
('HD230202003','SP000029','0722',N'Lọ','2',0),
('HD230202003','SP000034','0721222',N'Gói','4',0),
('HD230202003','SP000005','22C32',N'Tuýp','4',0),
('HD230202002','SP000016','6522',N'Hộp','2',0),
('HD230202002','SP000007','171022',N'Viên','5',0),
('HD230202002','SP000026','0071222',N'Hộp','2',0),
('HD230202001','SP000032','0061022',N'Chai','2',0),
('HD230201005','SP000034','0721222',N'Gói','3',0),
('HD230201004','SP000015','CVH2824',N'Gói','3',0),
('HD230201003','SP000043','21005A',N'Hộp','1',0),
('HD230201003','SP000015','CVH2824',N'Hộp','2',0),
('HD230201003','SP000034','0721222',N'Gói','4',0),
('HD230201002','SP000001','DVH0272',N'Vỉ','4',0),
('HD230201002','SP000004','A5746',N'Vỉ','3',0),
('HD230201002','SP000024','22007',N'Chai','2',0),
('HD230201001','SP000050','0061222',N'Hộp','2',0),
('HD230201001','SP000043','21005A',N'Vỉ','2',0);


