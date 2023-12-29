Create database DeAnCongTy
go

use DeAnCongTy
go

--Tao bang NHANVIEN
Create table NHANVIEN
(  HONV char(15)  not null, 
   TENLOT  char(15) not null,
   TENNV char(15) not null,
   MANV  char(9) not null,
   NGSINH DAtetime null,
   DCHI   char(30) null,
   PHAI   char(10) null,
   LUONG  decimal(10,2) null,
   MA_NQL char(9) null,
   PHG int null,
   check (PHAI = 'Nam' or PHAI = 'Nu'),
   Constraint PK_MANV Primary key (MANV),
)
go

--Tao bang PHONGBAN
Create table PHONGBAN
(
  TENPHG char(15) not null,
  MAPHG int not null,
  TRPHG char(9) null,
  NG_NHANCHUC DAtetime,
  Constraint PK_MAPHG Primary key (MAPHG), 
)
go

--Tao bang DIADIEM_PHG
Create table DIADIEM_PHG
( 
 MAPHG int not null, 
 DIADIEM char(15) not null,
 Constraint PK_MAPHG_DIADIEM Primary key (MAPHG,DIADIEM),
)
go


--Tao bang THANNHAN
Create table THANNHAN
(
 MA_NVIEN char(9) not null,
 TENTN char(15) not null,
 PHAI  char(10),
 NGSINH DAtetime,
 QUANHE char(8) not null,
 check (PHAI = 'Nam' or PHAI = 'Nu'), 
 Constraint PK_NV_QH Primary key (MA_NVIEN,QUANHE),
)
go


--Tao bang DEAN
Create table DEAN
(
 TENDA char(15) not null,
 MADA int not null,
 DDIEM_DA char(15) null,
 PHONG int null,
 Constraint PK_MADA Primary key(MADA),
)
go


--Tao bang PHANCONG
Create table PHANCONG
(
 MA_NVIEN char(9) not null,
 SODA int not null,
 THOIGIAN DECIMAL(5,1),
 Constraint PK_NV_DA Primary key (MA_NVIEN,SODA),
)
go

--PHAN THEM VAO CAC KHOA NGOAI
--Them khoa ngoai cho bang NHANVIEN
Alter table NHANVIEN
ADD
  Constraint FK_MA_NQL foreign key (MA_NQL) references NHANVIEN(MANV),
  Constraint  FK_PHG foreign key (PHG) references PHONGBAN(MAPHG)
go  


--Them khoa ngoai cho bang PHONGBAN
Alter table PHONGBAN
ADD
   Constraint  FK_TRPHG foreign key (TRPHG) references NHANVIEN(MANV)
go

-- Them khoa ngoai cho bang DIADIEM_PHG
Alter table DIADIEM_PHG
ADD
   Constraint  FK_DIADIEM_PHG foreign key (MAPHG) references PHONGBAN(MAPHG)
go

-- Them khoa ngoai cho bang THANNHAN
Alter table THANNHAN
ADD
   Constraint  FK_MA_NVIEN foreign key (MA_NVIEN) references NHANVIEN(MANV) 
go

--Then khoa ngoai cho bang DEAN
Alter table DEAN
ADD
   Constraint  FK_PHONG  foreign key (PHONG) references PHONGBAN(MAPHG)
go
   
--Them khoa ngoai cho bang PHANCONG
Alter table PHANCONG
ADD
   Constraint  FK_MANVIEN foreign key (MA_NVIEN) references NHANVIEN(MANV),
   Constraint  FK_SODA foreign key (SODA) references DEAN(MADA)
go
 

--Nhap lieu cho bang NHANVIEN
insert into NHANVIEN(HONV,TENLOT,TENNV,MANV,NGSINH,DCHI,PHAI,LUONG)
values('Dinh','Ba','Tien','123456789','09/01/1965','731 Tran Hung DAo,Q1,TPHCM','Nam',30000) 

insert into NHANVIEN(HONV,TENLOT,TENNV,MANV,NGSINH,DCHI,PHAI,LUONG)
values('Nguyen','Thanh','Tung','333445555','08/12/1955','638 Nguyen Van cu,Q5,TPHCM','Nam',40000)

insert into NHANVIEN(HONV,TENLOT,TENNV,MANV,NGSINH,DCHI,PHAI,LUONG)
values('Bui','Ngoc','Vu','999887777','07/19/1968','332 Nguyen Thai hoc,Q1,TPHCM','Nam',25000)

insert into NHANVIEN(HONV,TENLOT,TENNV,MANV,NGSINH,DCHI,PHAI,LUONG)
values('Le','Thi','Nhan','987654321','06/20/1941','291 Ho Van Hue,QPN,TPHCM','Nu',43000)

insert into NHANVIEN(HONV,TENLOT,TENNV,MANV,NGSINH,DCHI,PHAI,LUONG)
values('Nguyen','Manh','Hung','666884444','06/15/1962','975 Ba Ria Vung Tau','Nam',38000)

insert into NHANVIEN(HONV,TENLOT,TENNV,MANV,NGSINH,DCHI,PHAI,LUONG)
values('Tran','Thanh','Tam','453453453','07/31/1972','453 Mai Thi Luu ,Q1,TPHCM','Nam',25000)

insert into NHANVIEN(HONV,TENLOT,TENNV,MANV,NGSINH,DCHI,PHAI,LUONG)
values('Tran','Hong','Quang','987987987','03/29/1969','980 Le Hong Phong,Q10,TPHCM','Nam',25000)  

insert into NHANVIEN(HONV,TENLOT,TENNV,MANV,NGSINH,DCHI,PHAI,LUONG)
values('Pham','Ngoc','Quyen','888665555','10/10/1937','480 Trung Vuong ,Ha Noi','Nu',55000) 
go


--NhaP lieu cho bang PHONGBAN
insert into PHONGBAN values('Nghien cuu',5,'333445555',05/22/1978)
insert into PHONGBAN values('Dieu hanh',4,'987987987',01/01/1985)
insert into PHONGBAN values('Quan ly',1,'888665555',06/19/1971)
go


-- NhaP lieu tiep cho NHANVIEN
uPDAte NHANVIEN 
set   MA_NQL = '333445555',PHG =5
WHERE MANV = '123456789'
go 

uPDAte NHANVIEN 
set   MA_NQL = '888665555',PHG =5
WHERE MANV = '333445555'
go

uPDAte NHANVIEN 
set   MA_NQL = '987654321',PHG =4
WHERE MANV = '999887777'
go

uPDAte NHANVIEN 
set   MA_NQL = '888665555',PHG =4
WHERE MANV = '987654321'
go

uPDAte NHANVIEN 
set   MA_NQL = '333445555',PHG =5
WHERE MANV = '666884444'
go

uPDAte NHANVIEN 
set   MA_NQL = '333445555',PHG =5
WHERE MANV = '453453453'
go

uPDAte NHANVIEN 
set   MA_NQL = '987654321',PHG =4
WHERE MANV = '987987987' 
go

uPDAte NHANVIEN 
set   PHG =1
WHERE MANV = '888665555' 
go


--NhaP lieu chong bang DIADIEM_PHG
insert into DIADIEM_PHG values(1,'TPHCM') 
insert into DIADIEM_PHG values(4,'HA NOI')
insert into DIADIEM_PHG values(4,'TPHCM')
insert into DIADIEM_PHG values(5,'VUNG TAU')
insert into DIADIEM_PHG values(5,'NHA TRANG')
insert into DIADIEM_PHG values(5,'TPHCM') 
go


--NhaP lieu cho bang THANNHAN
insert into THANNHAN values ('333445555','Quang','Nu','05/04/1976','Con gai')
insert into THANNHAN values ('333445555','Khang','Nam','10/25/1973','Con trai')
insert into THANNHAN values ('333445555','Duong','Nu','03/05/1948','Vo chong')
insert into THANNHAN values ('987654321','DAng','Nam','03/25/1932','Vo chong')
insert into THANNHAN values ('123456789','Duy','Nam','01/01/1978','Con trai')
insert into THANNHAN values ('123456789','Chau','Nu','12/31/1978','Con gai')
insert into THANNHAN values ('123456789','Phuong','Nu','05/05/1957','Vo chong') 
go


-- NhaP lieu cho bang DEAN
insert into DEAN values ('San Pham X',1,'VUNG TAU',5)
insert into DEAN values ('San Pham Y',2,'NHA TRANG',5)
insert into DEAN values ('San Pham Z',3,'TPHCM',5)
insert into DEAN values ('Tin hoc hoa',10,'HA NOI',4)
insert into DEAN values ('Cap quang',20,'TPHCM',1)
insert into DEAN values ('Dao tao',30,'HA NOI',4)
go


--NhaP lieu cho bang PHANCONG
insert into PHANCONG values ('123456789',1,32.5)
insert into PHANCONG values ('123456789',2,7.5)
insert into PHANCONG values ('666884444',3,40.0)
insert into PHANCONG values ('453453453',1,20.0)
insert into PHANCONG values ('453453453',2,20.0)
insert into PHANCONG values ('333445555',3,10.0)
insert into PHANCONG values ('333445555',10,10.0)
insert into PHANCONG values ('333445555',20,10.0)
insert into PHANCONG values ('999887777',30,30.0)
insert into PHANCONG values ('999887777',10,10.0)
insert into PHANCONG values ('987987987',10,30.5)
insert into PHANCONG values ('987987987',30,5.0)
insert into PHANCONG values ('987654321',30,20.0)
insert into PHANCONG values ('987654321',20,15.0)
insert into PHANCONG values ('888665555',20,Null)
go




