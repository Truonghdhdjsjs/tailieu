--Tạo CSDL QUANLYBANHANG dùng để test tham chiếu
CREATE DATABASE QUANLYBANHANG

--Sử dụng CSDL QUANLYBANHANG
USE QUANLYBANHANG

--Tạo bảng LOAIHANG
CREATE TABLE LOAIHANG
(
	MaLoai	int primary key,
	TenLoai nvarchar(50)	
)
--Tạo bảng MATHANG
CREATE TABLE MATHANG
(
	MaHang varchar(10) primary key,
	TenHang nvarchar(50),
	SoLuong int,
	DonViTinh nvarchar(20),
	GiaBan money,
	MaLoai int
)

--Tạo tham chiếu từ khóa ngoại đến khóa chính giữa bảng MATHANG và LOAIHANG
ALTER TABLE MATHANG ADD
FOREIGN KEY(MALOAI) REFERENCES LOAIHANG(MALOAI)

--Bổ sung dữ liệu cho các bảng LOAIHANG và MATHANG
INSERT INTO LOAIHANG VALUES(1,N'MAY MẶC')
INSERT INTO LOAIHANG VALUES(2,N'GIA DỤNG')
INSERT INTO LOAIHANG VALUES(3,N'THỰC PHẨM')

INSERT INTO MATHANG VALUES('CF',N'CÀ PHÊ',10,N'HỘP',200000,3)
INSERT INTO MATHANG VALUES('DU',N'ĐƯỜNG BIÊN HÒA',20,N'KG',500000,3)
INSERT INTO MATHANG VALUES('SU',N'SỮA LONG THÀNH',30,N'LÍT',300000,3)

--Kiểm tra dữ liệu vừa chèn vào bảng LOAIHANG và MATHANG
SELECT * FROM LOAIHANG
SELECT * FROM MATHANG

--Đặt vấn đề: các bất thường xảy ra khi cập nhật lại dữ liệu đang có.
--Lệnh Update bị xung đột khóa ngoại
--The UPDATE statement conflicted with the REFERENCE constraint "FK__MATHANG__MALOAI".
UPDATE LOAIHANG
SET MALOAI = 5
WHERE MALOAI = 3

--Lệnh Delete bị xung đột khóa ngoại
--The DELETE statement conflicted with the REFERENCE constraint "FK__MATHANG__MALOAI".
DELETE FROM LOAIHANG
WHERE MALOAI = 3

--Giải quyết: bổ sung tính chất ON UPDATE CASCADE ON DELETE CASCADE lúc tạo tham chiếu giữa các bảng
--Xóa cấu trúc bảng để tạo lại bảng và tham chiếu
???
???

--Tạo lại cấu trúc 2 bảng LOAIHANG và MATHANG
--Tạo bảng LOAIHANG
???

--Tạo bảng MATHANG
???

--Tạo lại tham chiếu từ khóa ngoại đến khóa chính giữa bảng MATHANG và LOAIHANG
--có bổ sung thêm các tính chất ON UPDATE CASCADE ON DELETE CASCADE
???

--Insert lại dữ liệu cho 2 bảng LOAIHANG và MATHANG
???

--Kiểm tra dữ liệu đang có
???

--Kiểm tra lại lệnh cập nhật dữ liệu liên quan đến khóa ngoại 
???

--Kiểm tra kết quả cập nhật bảng LOAIHANG 
--và kết quả cập nhật khóa ngoại của bảng MATHANG
???

--Kiểm tra lại lệnh cập nhật dữ liệu liên quan đến khóa ngoại 
???
--Kiểm tra kết quả xóa dữ liệu trên bảng LOAIHANG và MATHANG
???
