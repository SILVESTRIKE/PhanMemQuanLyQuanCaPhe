

-- Bảng Mon (Món)
CREATE TABLE Mon (
    IDMon CHAR(10) PRIMARY KEY,
    TenMon NVARCHAR(100),
    Gia DECIMAL(10, 2)
);

-- Bảng NguyenLieu (Nguyên Liệu)
CREATE TABLE NguyenLieu (
    IDNguyenLieu CHAR(10) PRIMARY KEY,
    TenNL NVARCHAR(100),
    SLTon INT
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
    IDNhanVien CHAR(10) PRIMARY KEY,   -- Khóa chính nhân viên
    Ten NVARCHAR(100),                 -- Tên nhân viên
    SDT NVARCHAR(20),                  -- Số điện thoại
    GTinh NVARCHAR(10),                -- Giới tính
    NgSinh DATE,                       -- Ngày sinh
    TrangThai BIT,                     -- Check xem nhân viên có còn làm việc hay không
    IDQuanLy CHAR(10),                 -- Mã quản lý của nhân viên (có thể là chính họ)
    Pass NVARCHAR(255),                -- Mật khẩu người dùng (có thể mã hóa)
    
    -- Khóa ngoại tự tham chiếu
    CONSTRAINT FK_NhanVien_IDQuanLy FOREIGN KEY (IDQuanLy) REFERENCES NhanVien(IDNhanVien)    -- Tham chiếu đến IDNhanVien trong cùng bảng
);

-- Bảng HoaDon (Hóa Đơn)
CREATE TABLE HoaDon (
    IDHoaDon CHAR(10) PRIMARY KEY,  -- Khóa chính hóa đơn
    NgayLap DATE,                   -- Ngày lập hóa đơn
    IDNhanVien CHAR(10),            -- Khóa ngoại từ bảng NhanVien
    ThanhTien DECIMAL(10, 2),       -- Tổng số tiền trong hóa đơn
    FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(IDNhanVien)
);

-- Bảng ChiTietHD (Chi Tiết Hóa Đơn)
CREATE TABLE ChiTietHD (
    IDHoaDon CHAR(10),              -- Khóa ngoại từ bảng HoaDon
    IDMon CHAR(10),                 -- Khóa ngoại từ bảng Mon
    SoLuong INT,                    -- Số lượng món
    DonGia DECIMAL(10, 2),          -- Đơn giá của món
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
    IDNhanVien CHAR(10),            -- Khóa ngoại từ bảng NhanVien
	TrangThai BIT,
    PRIMARY KEY (IDLichTruc, IDNhanVien), -- Khóa chính kết hợp
    FOREIGN KEY (IDLichTruc) REFERENCES LichTruc(IDLichTruc),
    FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(IDNhanVien)
);

-- Nhập dữ liệu vào bảng Mon (Món)
INSERT INTO Mon (IDMon, TenMon, price) VALUES
('M001', 'Cà phê đen', 25000),
('M002', 'Cà phê sữa', 30000),
('M003', 'Trà đào', 35000),
('M004', 'Nước cam', 40000),
('M005', 'Sinh tố xoài', 45000);

-- Nhập dữ liệu vào bảng NguyenLieu (Nguyên Liệu)
INSERT INTO NguyenLieu (IDNguyenLieu, TenNL, SLTon) VALUES
('NL001', 'Cà phê hạt', 50),
('NL002', 'Sữa đặc', 30),
('NL003', 'Đào ngâm', 20),
('NL004', 'Cam tươi', 40),
('NL005', 'Xoài chín', 25);

-- Nhập dữ liệu vào bảng CongThuc (Công Thức)
INSERT INTO CongThuc (IDMon, IDNguyenLieu, SoLuong) VALUES
('M001', 'NL001', 10.0),
('M002', 'NL001', 8.0),
('M002', 'NL002', 2.0),
('M003', 'NL003', 5.0),
('M004', 'NL004', 4.0),
('M005', 'NL005', 3.0);


