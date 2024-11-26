CREATE DATABASE QLCF
USE QLCF
GO

-- Bảng Mon (Món)
CREATE TABLE Mon (
    IDMon CHAR(10) PRIMARY KEY,
    TenMon NVARCHAR(100),
    Gia DECIMAL,
    Loai CHAR(5)
);


-- Bảng NguyenLieu (Nguyên Liệu)
CREATE TABLE NguyenLieu (
    IDNguyenLieu CHAR(10) PRIMARY KEY,
    TenNL NVARCHAR(100),
    SLTon INT,
	DVTinh NVARCHAR(10)
);

-- Bảng CongThuc (Công Thức)
CREATE TABLE CongThuc (
    IDMon CHAR(10),
    IDNguyenLieu CHAR(10),
    SoLuong DECIMAL(10, 2),
    PRIMARY KEY (IDMon, IDNguyenLieu),
    FOREIGN KEY (IDMon) REFERENCES Mon(IDMon),
    FOREIGN KEY (IDNguyenLieu) REFERENCES NguyenLieu(IDNguyenLieu)
);

-- Bảng NhanVien (Nhân Viên)
CREATE TABLE NhanVien (
    IDNhanVien CHAR(5) PRIMARY KEY,   -- Khóa chính nhân viên
    Ten NVARCHAR(100),                 -- Tên nhân viên
    SDT NVARCHAR(20),                  -- Số điện thoại
    GTinh NVARCHAR(10),                -- Giới tính
    NgSinh DATE,                       -- Ngày sinh
    TrangThai BIT,                     -- Check xem nhân viên có còn làm việc hay không
    ChucVu NVARCHAR(10),                   -- Chức vụ nhân viên (mới đổi tên)
    Pass NVARCHAR(255),                -- Mật khẩu người dùng (có thể mã hóa)
    
    -- Khóa ngoại tự tham chiếu
    -- CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY (ChucVu) REFERENCES NhanVien(IDNhanVien)    -- Tham chiếu đến IDNhanVien trong cùng bảng
);

-- Bảng HoaDon (Hóa Đơn)
CREATE TABLE HoaDon (
    IDHoaDon CHAR(16) PRIMARY KEY,  -- Khóa chính hóa đơn
    NgayLap DATE,                   -- Ngày lập hóa đơn
    IDNhanVien CHAR(5),            -- Khóa ngoại từ bảng NhanVien
    TongTien DECIMAL(10, 2),       -- Tổng số tiền trong hóa đơn
    FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(IDNhanVien)
);


-- Bảng ChiTietHD (Chi Tiết Hóa Đơn)
CREATE TABLE ChiTietHD (
    IDHoaDon CHAR(16),              -- Khóa ngoại từ bảng HoaDon
    IDMon CHAR(10),                 -- Khóa ngoại từ bảng Mon
    SoLuong INT,                    -- Số lượng món
    DonGia DECIMAL(10, 2),          -- Đơn giá của món
	ThanhTien DECIMAL(10,2),
	TinhTrang_PhucVu BIT            -- Xem món ăn đã được phục vụ hay chưa
    PRIMARY KEY (IDHoaDon, IDMon),  -- Khóa chính kết hợp
    FOREIGN KEY (IDHoaDon) REFERENCES HoaDon(IDHoaDon),
    FOREIGN KEY (IDMon) REFERENCES Mon(IDMon)
);


-- Bảng CaTruc (Ca Trực)
CREATE TABLE CaTruc (
    IDCa CHAR(10) PRIMARY KEY,      -- Khóa chính ca trực
    TenCa NVARCHAR(100),            -- Tên ca trực

);
CREATE TABLE LichTruc(
	IDLichTruc CHAR(10) PRIMARY KEY,
	NgayTruc DATE,
	IDCa CHAR(10),
	FOREIGN KEY (IDCa) REFERENCES CaTruc(IDCa)
);
-- Bảng ChiTietCaTruc (Chi Tiết Ca Trực)
CREATE TABLE ChiTietLichTruc (
    IDLichTruc CHAR(10),            -- Khóa ngoại từ bảng CaTruc
    IDNhanVien CHAR(5),            -- Khóa ngoại từ bảng NhanVien
	TrangThai NVARCHAR(50),
    PRIMARY KEY (IDLichTruc, IDNhanVien), -- Khóa chính kết hợp
    FOREIGN KEY (IDLichTruc) REFERENCES LichTruc(IDLichTruc),
    FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(IDNhanVien)
);


INSERT INTO NguyenLieu (IDNguyenLieu, TenNL, SLTon, DVTinh) VALUES
('NL001', N'Cà Phê', 50, N'kg'),
('NL002', N'Sữa Tươi', 200, N'L'),
('NL003', N'Đường', 50, N'kg'),
('NL004', N'Sốt Socola', 20, N'kg'),
('NL005', N'Bột Matcha', 10, N'kg'),
('NL006', N'Bạc Hà', 5, N'kg'),
('NL007', N'Trá Đào', 100, N'L'),
('NL008', N'Bột Milo', 15, N'kg'),
('NL009', N'Trá Xanh', 10, N'kg'),
('NL010', N'Đào Miếng', 30, N'kg'),
('NL011', N'Chanh', 300, N'quả'),
('NL012', N'Cam', 200, N'quả'),
('NL013', N'Cà Rốt', 100, N'quả'),
('NL014', N'Trá Đen', 15, N'kg'),
('NL015', N'Hạt Trân Châu', 50, N'kg'),
('NL016', N'Sinh Tố Bơ', 100, N'L'),
('NL017', N'Sinh Tố Dâu', 100, N'L'),
('NL018', N'Sinh Tố Chuối', 100, N'L'),
('NL019', N'Bột Cacao', 25, N'kg'),
('NL020', N'Mật Ong', 30, N'L');

INSERT INTO Mon (IDMon, TenMon, Gia, Loai) VALUES
('M001', N'Cà Phê Đen', 20000, 'CP'),
('M002', N'Cà Phê Sữa', 25000, 'CP'),
('M003', N'Cà Phê Đá Xay', 40000, 'CP'),
('M004', N'Trà Đào', 30000, 'TR'),
('M005', N'Trà Sữa Trân Châu', 35000, 'TR'),
('M006', N'Matcha Latte', 45000, 'TR'),
('M007', N'Sinh Tố Bơ', 50000, 'ST'),
('M008', N'Sinh Tố Dâu', 50000, 'ST'),
('M009', N'Nước Cam', 30000, 'NU'),
('M010', N'Nước Chanh', 25000, 'NU'),
('M011', N'Sữa Tươi Trân Châu Đường Đen', 40000, 'NU'),
('M012', N'Trà Sữa Matcha', 45000, 'TR'),
('M013', N'Soda Bạc Hà', 30000, 'NU'),
('M014', N'Milo Đá Xay', 35000, 'NU'),
('M015', N'Cà Phê Cốt Dừa', 40000, 'CP'),
('M016', N'Sinh Tố Chuối', 50000, 'ST'),
('M017', N'Trà Sữa Truyền Thống', 35000, 'TR'),
('M018', N'Sinh Tố Cam Cà Rốt', 50000, 'ST'),
('M019', N'Trà Sữa Hồng Trà', 40000, 'TR'),
('M020', N'Trà Chanh Mật Ong', 30000, 'TR');



INSERT INTO CongThuc (IDMon, IDNguyenLieu, SoLuong) VALUES
('M001', 'NL001', 0.02), -- Cà Phê Đen
('M002', 'NL001', 0.02), -- Cà Phê Sữa
('M002', 'NL002', 0.03), -- Sữa Tươi
('M003', 'NL001', 0.02), -- Cà Phê Đá Xay
('M003', 'NL004', 0.01), -- Sốt Socola
('M004', 'NL007', 0.25), -- Trà Đào
('M005', 'NL015', 0.05), -- Hạt Trân Châu
('M005', 'NL002', 0.1),  -- Sữa Tươi
('M006', 'NL005', 0.02), -- Bột Matcha
('M006', 'NL002', 0.15), -- Sữa Tươi
('M007', 'NL016', 0.2),  -- Sinh Tố Bơ
('M008', 'NL017', 0.2),  -- Sinh Tố Dâu
('M009', 'NL012', 0.3),  -- Cam
('M010', 'NL011', 0.2),  -- Chanh
('M011', 'NL015', 0.05), -- Hạt Trân Châu
('M011', 'NL002', 0.15), -- Sữa Tươi
('M012', 'NL009', 0.02), -- Trà Xanh
('M012', 'NL002', 0.1),  -- Sữa Tươi
('M013', 'NL006', 0.05), -- Bạc Hà
('M014', 'NL008', 0.02), -- Bột Milo
('M015', 'NL001', 0.02), -- Cà Phê
('M015', 'NL010', 0.05), -- Đào Miếng
('M016', 'NL018', 0.2),  -- Chuối
('M017', 'NL002', 0.1),  -- Sữa Tươi
('M018', 'NL012', 0.15), -- Cam
('M018', 'NL013', 0.1),  -- Cà Rốt
('M019', 'NL014', 0.15), -- Trà Đen
('M020', 'NL020', 0.02), -- Mật Ong
('M020', 'NL011', 0.1);  -- Chanh



INSERT INTO NhanVien Values
('NV001', N'Trần Văn A', '0900000001', N'Nam', '1990-05-15', 1, N'Quản Lý', '123');
--('NV002', N'Nguyễn Thị B', '0900000002', N'Nữ', '1992-08-22', 1, 'NV001', 'pass123'),
--('NV003', N'Lê Văn C', '0900000003', N'Nam', '1988-03-09', 1, 'NV001', 'pass123'),
--('NV004', N'Pham Thi D', '0900000004', N'Nữ', '1995-12-30', 1, 'NV002', 'pass123'),
--('NV005', N'Nguyen Van E', '0900000005', N'Nam', '1991-07-21', 1, 'NV002', 'pass123');

INSERT INTO CaTruc Values
('SA', N'Ca Sáng'),
('CH', N'Ca Chiều'),
('TO', N'Ca Tối');








