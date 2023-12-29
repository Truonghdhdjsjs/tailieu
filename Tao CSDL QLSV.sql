--drop database QLSV
create database QLSV
go 
use QLSV
--Tao bang KHOA
create table KHOA
(
	MAKHOA	varchar(6) not null,
	TENKHOA	nvarchar(30) not null,
	NAMTHANHLAP		int,
	primary key (MAKHOA)
)

--Tao bang SINHVIEN
create table SINHVIEN
(
	MASV	char(10) not null,
	TENSV	nvarchar(30) not null,
	NGAYSINH	datetime,
	DIACHI	nvarchar(50),
	PHAI	nvarchar(6),
	MAKH	varchar(6),
	primary key (MASV)
)
--Tao bang MONHOC
create table MONHOC
(
	MAMH	varchar(8) not null,
	TENMH	nvarchar(20) not null,
	SOTC	int,
	HOCKY	int,
	GV		nvarchar(30),
	MAKH	varchar(6),
	primary key (MAMH)	
)
--Tao bang DIEM
create table DIEMSV
(
	MASV	char(10) not null,
	MAMH	varchar(8) not null,
	DIEM	int,
	primary key (MASV, MAMH)
)
--Tao cac khoa ngoai
alter table SINHVIEN add constraint FK_SV_MAKH_KHOA foreign key (MAKH) references KHOA (MAKHOA)
alter table MONHOC add constraint FK_MH_MAKH_KHOA foreign key (MAKH) references KHOA(MAKHOA)
alter table DIEMSV add 
constraint FK_MASV_DIEM_SV foreign key (MASV) references SINHVIEN(MASV),
constraint FK_MAMH_DIEM_MH foreign key (MAMH) references MONHOC(MAMH)



--Insert dữ liệu

--Dữ liệu bảng KHOA
insert into KHOA(MAKHOA,TENKHOA, NAMTHANHLAP) values ('CNTT',N'Khoa Công nghệ thông tin',2007)
insert into KHOA(MAKHOA,TENKHOA, NAMTHANHLAP) values ('KINHTE', N'Khoa Kinh tế', 2005)
insert into KHOA(MAKHOA,TENKHOA, NAMTHANHLAP) values ('DIENDT', N'Khoa Điện - điện tử', 2005)
insert into KHOA(MAKHOA,TENKHOA, NAMTHANHLAP) values ('COKHI', N'Khoa Cơ khí', 2006)
insert into KHOA(MAKHOA,TENKHOA, NAMTHANHLAP) values ('CNSH', N'Khoa Công nghệ sinh học', 2008)
insert into KHOA(MAKHOA,TENKHOA, NAMTHANHLAP) values ('CHTRI', N'Khoa Chính trị', 2005)
insert into KHOA(MAKHOA,TENKHOA, NAMTHANHLAP) values ('COBAN', N'Khoa Cơ bản', 2005)

--Dữ liệu bảng SINHVIEN
insert into SINHVIEN (MASV, TENSV, NGAYSINH, DIACHI, PHAI, MAKH) values ('0721001000', N'Võ Bình An', '05/20/1989', N'Quận 12, Tp. HCM', 'Nam', 'CNSH')
insert into SINHVIEN (MASV, TENSV, NGAYSINH, DIACHI, PHAI, MAKH) values ('0721002000', N'Lê Thị Mỹ Dung', '03/24/1988', N'Xuyên Mộc, Bà Rịa Vũng Tàu', N'Nữ', 'COKHI')
insert into SINHVIEN (MASV, TENSV, NGAYSINH, DIACHI, PHAI, MAKH) values ('0521003210', N'Nguyễn Thị Hạnh', '01/12/1987', N'Cai Lậy, Tiền Giang', N'Nữ', 'CNTT')
insert into SINHVIEN (MASV, TENSV, NGAYSINH, DIACHI, PHAI, MAKH) values ('0521001234', N'Trần Văn Minh', '03/15/1986', N'Thị xã Vĩnh Long', 'Nam', 'KINHTE')
insert into SINHVIEN (MASV, TENSV, NGAYSINH, DIACHI, PHAI, MAKH) values ('0621009876', N'Huỳnh Minh Thư', '02/02/1988', N'Gò Vấp, TP. HCM', N'Nữ', 'CNTT')
insert into SINHVIEN (MASV, TENSV, NGAYSINH, DIACHI, PHAI, MAKH) values ('0621004567', N'Nguyễn Đình Chiến', '06/01/1988', N'Mỹ Tho, Tiền Giang', 'Nam', 'CNTT')

-- Dữ liệu bảng Môn học
insert into MONHOC(MAMH, TENMH, SOTC, HOCKY, GV, MAKH)values ('THDC', N'Tin học đại cương', 4, 1, N'Lý Thiên Bình', 'CNTT')
insert into MONHOC(MAMH, TENMH, SOTC, HOCKY, GV, MAKH)values ('KTLT', N'Kỹ thuật lập trình',4,2,N'Lê Viết Tuấn', 'CNTT')
insert into MONHOC(MAMH, TENMH, SOTC, HOCKY, GV, MAKH)values ('CNXHKH', N'Chủ nghĩa xã hội KH',3,1, N'Nguyễn Thị Phương', 'CHTRI')
insert into MONHOC(MAMH, TENMH, SOTC, HOCKY, GV, MAKH)values ('TOANCC',N'Toán cao cấp',4,1, N'Nguyễn Quảng', 'COBAN')
insert into MONHOC(MAMH, TENMH, SOTC, HOCKY, GV, MAKH)values ('TKWEBCB', N'Thiết kế web căn bản',4,4,N'Hà Đồng Hưng','CNTT')
insert into MONHOC(MAMH, TENMH, SOTC, HOCKY)values ('DOANMH',	N'Đồ án môn học',2,5)
-- Dữ liệu bảng DIEMSV
insert into DIEMSV values ('0721001000','THDC',	5)
insert into DIEMSV values ('0721001000','CNXHKH',	8)
insert into DIEMSV values ('0721001000','TOANCC',6)
insert into DIEMSV values ('0521003210','THDC',9)
insert into DIEMSV values ('0521003210','KTLT',7)
insert into DIEMSV values ('0521003210','TKWEBCB',4)
insert into DIEMSV values ('0521001234','THDC',3)
insert into DIEMSV values ('0521001234','CNXHKH',5)
insert into DIEMSV values ('0521001234','TOANCC',	8)
insert into DIEMSV values ('0621009876','THDC',	2)
insert into DIEMSV values ('0621009876','KTLT',	7)
insert into DIEMSV values ('0621004567','THDC',	6)
insert into DIEMSV values ('0621004567','KTLT',	5)
insert into DIEMSV values ('0621004567','TOANCC',7)
insert into DIEMSV values ('0621004567','CNXHKH',	4)
insert into DIEMSV values ('0621004567','TKWEBCB',	8)





--Các sinh viên đạt điểm môn có tên là ‘tin học đại cương’ trên 5
SELECT *FROM DIEMSV
SELECT *FROM MONHOC

SELECT MASV,A.MAMH,TENMH,DIEM
FROM DIEMSV as A,monhoc as B
WHERE a.MAMH = b. mamh
and tenmh=N'Tin học đại cương'
and DIEM >=6

--Họ tên SV và tên khoa của sinh viên đó
SELECT * FROM SINHVIEN
SELECT * FROM KHOA

SELECT TENSV,TENKHOA 
FROM SINHVIEN,KHOA
WHERE MAKH=MAKHOA

-- Tên môn học, số tín chỉ và tên khoa quản lý môn học đó
SELECT * FROM MONHOC
SELECT * FROM KHOA

SELECT TENMH,SOTC,TENKHOA 
FROM MONHOC,KHOA
WHERE MAKH=MAKHOA

--Họ tên sinh viên, tên môn học và điểm mà sinh viên đạt được tương ứng
SELECT * FROM SINHVIEN
SELECT * FROM DIEMSV
SELECT * FROM MONHOC

SELECT TENSV,TENMH,DIEM
FROM SINHVIEN A, DIEMSV B, MONHOC C
WHERE B.MAMH = C.MAMH
AND A.MASV = B.MASV

--thong tin cua sinh vien gom masv tensv tuoi tenkhoa sonamtl:
select * from sinhvien
select * from khoa

select MASV,TENSV,YEAR(getdate())-year(ngaysinh) as Tuoi, tenkhoa, year(getdate())- namthanhlap as SoNamTL
from sinhvien ,khoa 
where makh=makhoa


--ket qua hoc tap cua cac sv qua tien giang
select * from sinhvien
select * from diemsv
select * from monhoc

select c.mamh,tenmh,tensv,diem,diachi
from sinhvien a,diemsv b,monhoc c 
where diachi LIKE  N'%Tiền Giang%'
and a.masv=b.masv
and b.mamh=c.mamh


--ket qua hoc tap cua cac sv khoa cntt
select * from diemsv
select * from sinhvien
select * from khoa

select mamh,tensv,diem,tenkhoa
from diemsv a,sinhvien b,khoa c
where a.masv=b.masv
and makh=makhoa 
and tenkhoa=N'Khoa công nghệ thông tin'







