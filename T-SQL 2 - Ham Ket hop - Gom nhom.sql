--Hàm kết hợp - gom nhóm: COUNT,SUM,AVG,MIN,MAX

--COUNT(*) --> đếm số dòng
--COUNT(thuộc tính) --> đếm số lượng các giá trị khác null của thuộc tính
--SUM(thuộc tính) --> tổng giá trị của khác null trong tập hợp các phần tử của thuộc tính
--AVG(thuộc tính) --> tính trung bình cộng của các giá trị trong tập hợp các phần tử của thuộc tính
--MIN(thuộc tính) --> tìm giá trị thấp nhất trong tập hợp các phần tử của thuộc tính
--MAX(thuộc tính) --> tìm giá trị lớn nhất trong tập hợp các phần tử của thuộc tính

--Tạo CSDL QLNV để test các hàm kết hợp - gom nhóm
CREATE DATABASE QLNV;

--Sử dụng CSDL QLNV
USE QLNV;

--Tạo bảng NHANVIEN
CREATE TABLE NHANVIEN
(
	MaNV		varchar(10) primary key,
	Luong		money,
	Phong	nvarchar(50)
);

--Bổ sung dữ liệu cho bảng NHANVIEN
INSERT INTO NHANVIEN VALUES('A',4000000,N'Kinh doanh')
INSERT INTO NHANVIEN VALUES('B',5000000,N'Kinh doanh')
INSERT INTO NHANVIEN VALUES('C',6000000,N'Kinh doanh')
INSERT INTO NHANVIEN VALUES('D',null,null)
INSERT INTO NHANVIEN VALUES('E',6000000,N'Kế toán')
INSERT INTO NHANVIEN VALUES('F',5000000,N'Nghiên cứu')
INSERT INTO NHANVIEN VALUES('G',4000000,N'Nghiên cứu')

--Quan sát dữ liệu đang có
SELECT * FROM NHANVIEN

--1. Cho biết danh sách lương của các NV trong công ty 
--> mong muốn kết quả hiển thị [4,5,6,null,6,5,4]
???
--> mong muốn kết quả hiển thị [4,5,6,6,5,4]
???

--2. Cho biết danh sách các mức lương cơ bản của công ty 
--> mong muốn kết quả hiển thị [4,5,6]
???
--
???

--3. Cho biết số lượng nhân viên có trong công ty
--> mong muốn kết quả hiển thị [7]
SELECT * FROM NHANVIEN
--
???
--
???

--4. Số lượng nhân viên có lương
--> mong muốn kết quả hiển thị [6]
SELECT * FROM NHANVIEN
--
???

--5. Số lượng bậc lương
--> mong muốn kết quả hiển thị [3]
select * from NHANVIEN
--
???

--6. Tổng lương các nhân viên trong công ty
SELECT * FROM NHANVIEN
--
???

--7. Lương trung bình các nhân viên trong công ty
SELECT * FROM NHANVIEN
--
???

--8. Lương cao nhất các NV trong công ty
SELECT * FROM NHANVIEN
--
???

--9. Lương thấp nhất các NV trong công ty
SELECT * FROM NHANVIEN
--
???

--10. Các NV lương từ 3500000 đến 4500000
SELECT * FROM NHANVIEN
--
???
--Cách khác
???

--11a. Cho biết 3 NV có lương cao nhất là ai
SELECT MANV,LUONG FROM NHANVIEN
--
???

--11b. Cho biết 3 NV có lương thấp nhất là ai
SELECT MANV,LUONG FROM NHANVIEN
--
???

--12a. Cho biết các nhân viên có mức lương MAX
SELECT MANV,LUONG FROM NHANVIEN
--
SELECT MANV,LUONG 
FROM NHANVIEN
WHERE LUONG = 6000000
--
SELECT MANV,LUONG 
FROM NHANVIEN
WHERE LUONG IN (6000000)
--Cách khác
???
--Cách khác
???

--12b. Cho biết các nhân viên có mức lương MIN
SELECT MANV,LUONG FROM NHANVIEN
--
SELECT MANV,LUONG 
FROM NHANVIEN
WHERE LUONG IN (4000000)
--
SELECT MANV,LUONG 
FROM NHANVIEN
WHERE LUONG = 4000000
--Cách khác
???
--Cách khác
???

--13. Thống kê các thông tin sau đây của công ty: 
--Tổng lương,Lương Trung bình, Max Luong, Min Luong, 
--Số lượng các nhân viên, Số lượng các mức lương
???

--Bài tập:Hàm kết hợp + Gom nhóm

--14. Cho biết Tổng lương,Lương Trung bình, Max Luong, Min Luong, 
--số lượng các nhân viên, Số lượng các mức lương của từng phòng ban. 
--Thông tin hiển thị bao gồm: Tên phòng ban và thông tin thống kê trên.
--Kết quả sắp thứ tự theo tổng lương giảm dần
SELECT * FROM NHANVIEN
--
??? 

--15. Cho biết Tổng lương,Lương Trung bình, Max Luong, Min Luong, 
--số lượng các nhân viên của phòng Kinh Doanh 
SELECT * FROM NHANVIEN
--
???

--16. Cho biết các Phòng ban có Lương trung bình >= 5tr 
--Thông tin hiển thị bao gồm: Tên phòng ban và Lương TB.
SELECT * FROM NHANVIEN
--
???
--
???

--17. Cho biết các Phòng ban có Lương trung bình >= lương trung bình của phòng Kinh doanh
--Thông tin hiển thị bao gồm: Tên phòng ban và Lương TB.
???
--
???
--
???

--18. Cho biết phòng có tổng lương cao nhất
???
--
???
