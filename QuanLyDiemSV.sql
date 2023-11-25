create database QuanLyDiemSV;


--  Lệnh tạo bảng sinh viên: 

CREATE TABLE DiemSV(
        MaSV varchar(10) primary key ,
        HoTen varchar(30) not null,
        NgaySinh date ,
        GioiTinh varchar(10),
		Email nvarchar(90),
		Lop varchar(10) not null,
        DiemIT  float not null,
        DiemTiengAnh  float not null,
        DiemDuAn  float not null,
        DiemTB  float not null,
)

-- Thêm dữ liệu vào bảng DiemSV
INSERT INTO DiemSV (MaSV, HoTen, NgaySinh, GioiTinh, Email, Lop, DiemIT, DiemTiengAnh, DiemDuAn, DiemTB)
VALUES
    ('SV001', 'Nguyen Van A', '1990-01-01', 'Nam', 'nguyenvana@gmail.com', 'A01', 8.5, 7.5, 9.0, 8.3),
    ('SV002', 'Tran Thi B', '1992-05-15', 'Nu', 'tranthib@gmail.com', 'B02', 7.0, 8.0, 8.5, 7.8),
    ('SV003', 'Le Van C', '1991-08-22', 'Nam', 'levanc@gmail.com', 'C03', 9.0, 6.5, 7.0, 7.5),
    ('SV004', 'Pham Thi D', '1993-03-10', 'Nu', 'phamthid@gmail.com', 'D04', 6.5, 9.0, 8.0, 7.8),
    ('SV005', 'Hoang Van E', '1994-12-05', 'Nam', 'hoangvane@gmail.com', 'E05', 8.0, 7.8, 9.0, 8.3);

	delete from DiemSV