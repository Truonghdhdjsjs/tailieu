--Tạo CSDL test PhepKet
CREATE DATABASE PHEPKET;
--Sử dụng CSDL PHEPKET
USE PHEPKET;

--Tạo bảng R
CREATE TABLE R
(
	A int primary key,
	B int
);
--Tạo bảng S
CREATE TABLE S
(
	C int primary key,
	D int
);

--Bổ sung dữ liệu cho các bảng R và S
INSERT INTO R VALUES(1,4)
INSERT INTO R VALUES(2,5)
INSERT INTO R VALUES(3,6)

INSERT INTO S VALUES(5,8)
INSERT INTO S VALUES(6,9)
INSERT INTO S VALUES(7,0)

--Kiểm tra dữ liệu vừa chèn vào bảng R và S
SELECT * FROM R
SELECT * FROM S

--Kết quả Tích Decac khi kết bảng R và S
???

--Kết quả Phép kết bằng (Kết tự nhiên), Kết trong (INNER JOIN)
--Dùng cú pháp SQL chuẩn
???
--Dùng cú pháp JOIN ON
???
--Có thể bỏ "INNER" trong cú pháp JOIN ON
???

--Kết quả Phép kết ngoài: LEFT OUTER JOIN 
-- => bảo toàn thông tin bảng R
???

--Kết quả Phép kết ngoài: RIGHT OUTER JOIN 
-- => bảo toàn thông tin bảng S
???

--Kết quả Phép kết ngoài: FULL OUTER JOIN 
-- => bảo toàn thông tin cả 2 bảng R và S
???


--Ví dụ: truy vấn trên CSDL QUANLYSINHVIEN
USE QUANLYSINHVIEN

--Quan sát dữ liệu đang có của 2 bảng KHOA và MONHOC
SELECT * FROM KHOA
SELECT * FROM MONHOC

--1. Cho biết Danh sách các môn học và tên khoa quản lý các môn đó nếu có.
--("nếu có": môn học có thuộc về 1 khoa hoặc không thuộc về 1 khoa nào thì cũng kết xuất thông tin) 
--Thông tin hiển thị bao gồm MaMH,TenMH,MaKhoa,TenKhoa
???
--Cách khác
???

--2. Cho biết danh sách các Khoa và tên các môn học mà khoa quản lý (nếu có)
--("nếu có": nếu khoa có quản lý các môn học hoặc không quản lý thì đều có kết xuất thông tin) 
--Thông tin hiển thị bao gồm MaKhoa,TenKhoa,MaMH,TenMH
???
--Cách khác
???

--3. Cho biết danh sách các Khoa và danh sách các môn học liên quan (nếu có)
--("nếu có": đảm bảo đầy đủ thông tin của bảng KHOA và bảng MONHOC)
???