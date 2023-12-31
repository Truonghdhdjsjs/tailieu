--Tao CSDL va cau truc bang
CREATE DATABASE QUANLYSINHVIEN;
GO

USE QUANLYSINHVIEN;
GO

--Tao bang KHOA
CREATE TABLE KHOA
(
	MaKhoa		varchar(10) not null,
	TenKhoa		nvarchar(30) not null,
	NamThanhLap	int,
	PRIMARY KEY (MaKhoa)
);
GO

--Tao bang SINHVIEN
CREATE TABLE SINHVIEN
(
	MaSV		varchar(10) not null,
	TenSV		nvarchar(30) not null,
	NgaySinh	datetime,
	DiaChi		nvarchar(50),
	Phai		nvarchar(6),
	MaKhoa		varchar(10),
	PRIMARY KEY (MaSV)
);
GO

--Tao bang MONHOC
CREATE TABLE MONHOC
(
	MaMH		varchar(10) not null,
	TenMH		nvarchar(50) not null,
	SoTC		int,
	HocKy		int,
	GV			nvarchar(30),
	MaKhoa		varchar(10),
	PRIMARY KEY (MaMH)	
);
GO

--Tao bang DIEM
CREATE TABLE DIEMSV
(
	MaSV		varchar(10) not null,
	MaMH		varchar(10) not null,
	Diem		int,
	PRIMARY KEY (MaSV, MaMH)
);
GO

--Tao tham chieu cac khoa ngoai
ALTER TABLE SINHVIEN ADD FOREIGN KEY(MaKhoa) REFERENCES KHOA(MaKhoa);
ALTER TABLE MONHOC ADD FOREIGN KEY(MaKhoa) REFERENCES KHOA(MaKhoa);
ALTER TABLE DIEMSV ADD FOREIGN KEY(MaSV) REFERENCES SINHVIEN(MaSV),
FOREIGN KEY(MaMH) REFERENCES MONHOC(MaMH);
GO

--Insert dữ liệu bang KHOA
INSERT INTO KHOA(MaKhoa,TenKhoa,NamThanhLap) VALUES ('CNTT',N'Khoa Công nghệ thông tin',2017)
INSERT INTO KHOA(MaKhoa,TenKhoa,NamThanhLap) VALUES ('KINHTE', N'Khoa Kinh tế', 2015)
INSERT INTO KHOA(MaKhoa,TenKhoa,NamThanhLap) VALUES ('DIENDT', N'Khoa Điện - điện tử', 2015)
INSERT INTO KHOA(MaKhoa,TenKhoa,NamThanhLap) VALUES ('COKHI', N'Khoa Cơ khí', 2016)
INSERT INTO KHOA(MaKhoa,TenKhoa,NamThanhLap) VALUES ('CNSH', N'Khoa Công nghệ sinh học', 2018)
INSERT INTO KHOA(MaKhoa,TenKhoa,NamThanhLap) VALUES ('CHTRI', N'Khoa Chính trị', 2015)
INSERT INTO KHOA(MaKhoa,TenKhoa,NamThanhLap) VALUES ('COBAN', N'Khoa Cơ bản', 2015)

--Dữ liệu bảng SINHVIEN
INSERT INTO SINHVIEN (MaSV, TenSV, NgaySinh, DiaChi, Phai, MaKhoa) VALUES ('0721001000', N'Võ Bình An', '05/20/2001', N'Quận 12, Tp. HCM', 'Nam', 'CNSH')
INSERT INTO SINHVIEN (MaSV, TenSV, NgaySinh, DiaChi, Phai, MaKhoa) VALUES ('0721002000', N'Lê Thị Mỹ Dung', '03/24/2002', N'Xuyên Mộc, Bà Rịa Vũng Tàu', N'Nữ', 'COKHI')
INSERT INTO SINHVIEN (MaSV, TenSV, NgaySinh, DiaChi, Phai, MaKhoa) VALUES ('0521003210', N'Nguyễn Thị Hạnh', '01/12/2002', N'Cai Lậy, Tiền Giang', N'Nữ', 'CNTT')
INSERT INTO SINHVIEN (MaSV, TenSV, NgaySinh, DiaChi, Phai, MaKhoa) VALUES ('0521001234', N'Trần Văn Minh', '03/15/2003', N'Thị xã Vĩnh Long', 'Nam', 'KINHTE')
INSERT INTO SINHVIEN (MaSV, TenSV, NgaySinh, DiaChi, Phai, MaKhoa) VALUES ('0621009876', N'Huỳnh Minh Thư', '02/02/2001', N'Gò Vấp, TP. HCM', N'Nữ', 'CNTT')
INSERT INTO SINHVIEN (MaSV, TenSV, NgaySinh, DiaChi, Phai, MaKhoa) VALUES ('0621004567', N'Nguyễn Đình Chiến', '06/01/2002', N'Mỹ Tho, Tiền Giang', 'Nam', 'CNTT')
INSERT INTO SINHVIEN (MaSV, TenSV, NgaySinh, DiaChi, Phai, MaKhoa) VALUES ('0621004566', N'Nguyễn Đình Huy', '06/01/2003', N'Mỹ Tho, Tiền Giang', 'Nam', 'CNTT')

-- Dữ liệu bảng Môn học
INSERT INTO MONHOC(MaMH, TenMH, SoTC, HocKy, GV, MaKhoa)VALUES ('THDC', N'Tin học đại cương', 4, 1, N'Lý Thiên Bình', 'CNTT')
INSERT INTO MONHOC(MaMH, TenMH, SoTC, HocKy, GV, MaKhoa)VALUES ('KTLT', N'Kỹ thuật lập trình',4,2,N'Lê Viết Tuấn', 'CNTT')
INSERT INTO MONHOC(MaMH, TenMH, SoTC, HocKy, GV, MaKhoa)VALUES ('CNXHKH', N'Chủ nghĩa xã hội khoa học',3,1, N'Nguyễn Thị Phương', 'CHTRI')
INSERT INTO MONHOC(MaMH, TenMH, SoTC, HocKy, GV, MaKhoa)VALUES ('TOANCC',N'Toán cao cấp',4,1, N'Nguyễn Quảng', 'COBAN')
INSERT INTO MONHOC(MaMH, TenMH, SoTC, HocKy, GV, MaKhoa)VALUES ('TKWEBCB', N'Thiết kế web căn bản',4,4,N'Hà Đồng Hưng','CNTT')
INSERT INTO MONHOC(MaMH, TenMH, SoTC, HocKy)VALUES ('DOANMH',	N'Đồ án môn học',2,5)

-- Dữ liệu bảng DIEMSV
INSERT INTO DIEMSV VALUES ('0721001000','THDC',5)
INSERT INTO DIEMSV VALUES ('0721001000','CNXHKH',8)
INSERT INTO DIEMSV VALUES ('0721001000','TOANCC',6)
INSERT INTO DIEMSV VALUES ('0521003210','THDC',9)
INSERT INTO DIEMSV VALUES ('0521003210','KTLT',7)
INSERT INTO DIEMSV VALUES ('0521003210','TKWEBCB',4)
INSERT INTO DIEMSV VALUES ('0521001234','THDC',3)
INSERT INTO DIEMSV VALUES ('0521001234','CNXHKH',5)
INSERT INTO DIEMSV VALUES ('0521001234','TOANCC',8)
INSERT INTO DIEMSV VALUES ('0621009876','THDC',	2)
INSERT INTO DIEMSV VALUES ('0621009876','KTLT',	7)
INSERT INTO DIEMSV VALUES ('0621004567','THDC',	6)
INSERT INTO DIEMSV VALUES ('0621004567','KTLT',	5)
INSERT INTO DIEMSV VALUES ('0621004567','TOANCC',7)
INSERT INTO DIEMSV VALUES ('0621004567','CNXHKH',4)
INSERT INTO DIEMSV VALUES ('0621004567','TKWEBCB',8)
