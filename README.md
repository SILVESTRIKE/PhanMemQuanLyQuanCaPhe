ĐỒ ÁN MÔN CÔNG NGHỆ .NET
---
# **Phần Mềm Quản Lý Quán Cà Phê**

## **Chương I: Quy Trình Nghiệp Vụ**

### **I. Quy Trình Quản Lý Nhân Viên**

1. **Mô tả quy trình**  
   - Chỉ có quản lý mới có quyền đăng ký nhân viên mới thông qua việc đăng nhập bằng tài khoản quản trị viên.  
   - Quản lý sẽ nhập các thông tin cần thiết của nhân viên như: tên, số điện thoại, ngày sinh, giới tính, chức vụ.  
   - Hệ thống sẽ kiểm tra dữ liệu, nếu thông tin hợp lệ sẽ được lưu vào cơ sở dữ liệu, nếu thông tin thiếu hoặc không hợp lệ, hệ thống yêu cầu sửa đổi.  
   - Ngoài ra, quản lý có thể chỉnh sửa hoặc xóa thông tin nhân viên khi cần.

2. **Các bước cụ thể**
   - Nhập thông tin nhân viên mới.
   - Hệ thống kiểm tra tính hợp lệ của thông tin.
   - Lưu thông tin vào cơ sở dữ liệu.
   - Chỉnh sửa hoặc xóa thông tin nếu cần.

---

### **II. Quy Trình Quản Lý Ca Trực**

1. **Mô tả quy trình**  
   - Quản lý sẽ sắp xếp ca làm việc cho nhân viên bằng cách chọn ngày, giờ ca trực và chọn nhân viên phụ trách.  
   - Hệ thống sẽ tự động kiểm tra xem ca trực có bị trùng lặp hoặc có mâu thuẫn với các ca khác không.  
   - Quản lý có thể chỉnh sửa hoặc hủy ca trực khi cần.

2. **Các bước cụ thể**  
   - Chọn ngày và thời gian ca trực.
   - Chọn nhân viên phụ trách ca.
   - Hệ thống kiểm tra tính hợp lệ của ca trực.
   - Lưu thông tin ca trực vào cơ sở dữ liệu.

---

### **III. Quy Trình Quản Lý Thực Đơn**

1. **Mô tả quy trình**  
   - Khi có món mới, quản lý nhập tên món, giá cả và các thông tin liên quan.  
   - Hệ thống sẽ lưu thông tin món mới vào cơ sở dữ liệu.  
   - Khi cần sửa hoặc xóa món, hệ thống sẽ kiểm tra ràng buộc trước khi thực hiện thao tác.

2. **Các bước cụ thể**  
   - Nhập tên món và giá.
   - Hệ thống kiểm tra và lưu thông tin vào cơ sở dữ liệu.
   - Chỉnh sửa hoặc xóa món nếu cần.
   - Kiểm tra ràng buộc trước khi xóa món.

---

### **IV. Quy Trình Lập Hóa Đơn**

1. **Mô tả quy trình**  
   - Khi khách hàng yêu cầu thanh toán, nhân viên sẽ lập hóa đơn dựa trên các món mà khách đã gọi.  
   - Hệ thống sẽ tự động tính tổng số tiền bao gồm chiết khấu nếu có và tạo hóa đơn.  
   - Sau khi xác nhận thanh toán, hệ thống sẽ lưu hóa đơn vào cơ sở dữ liệu và in hóa đơn cho khách hàng.

2. **Các bước cụ thể**  
   - Nhân viên chọn các món mà khách đã gọi.
   - Hệ thống tính tổng tiền và chiết khấu (nếu có).
   - Xác nhận thanh toán và lưu hóa đơn vào cơ sở dữ liệu.
   - In hóa đơn và giao cho khách hàng.

---

### **V. Quy Trình Quản Lý Nguyên Liệu & Công Thức**

1. **Mô tả quy trình**  
   - Quản lý nhập thông tin về nguyên liệu bao gồm tên và số lượng tồn kho.  
   - Hệ thống sẽ lưu trữ thông tin để theo dõi tồn kho.  
   - Mỗi món trong thực đơn sẽ được liên kết với công thức pha chế bao gồm nguyên liệu và số lượng cụ thể.

2. **Các bước cụ thể**  
   - Nhập thông tin nguyên liệu (tên, số lượng tồn kho).
   - Hệ thống lưu thông tin vào cơ sở dữ liệu.
   - Nhập công thức cho các món (liên kết món với nguyên liệu).
   - Cập nhật tồn kho khi có thay đổi.

---

### **VI. Quy Trình Đăng Nhập & Quản Lý Tài Khoản**

1. **Mô tả quy trình**  
   - Khi người dùng (nhân viên hoặc quản lý) truy cập vào hệ thống, họ sẽ phải đăng nhập bằng tài khoản đã được cấp.  
   - Hệ thống sẽ kiểm tra thông tin đăng nhập và phân quyền tương ứng (quản lý hoặc nhân viên).  
   - Quản lý có thể thêm, sửa, xóa tài khoản người dùng khi cần thiết.

2. **Các bước cụ thể**  
   - Người dùng nhập tên đăng nhập và mật khẩu.
   - Hệ thống kiểm tra tính hợp lệ của tài khoản.
   - Cấp quyền cho người dùng dựa trên vai trò.
   - Quản lý thêm, sửa hoặc xóa tài khoản nếu cần.

---

## **Chương II: Phân Tích Thiết Kế**

### **I. Các Chức Năng Chính**

- **Quản lý nhân viên**: Thêm, sửa, xóa thông tin nhân viên.
- **Quản lý ca trực**: Sắp xếp và quản lý ca trực cho nhân viên.
- **Quản lý nguyên liệu**: Thêm, sửa, xóa và theo dõi tồn kho nguyên liệu.
- **Quản lý món**: Thêm, sửa, xóa món trong thực đơn.
- **Quản lý hóa đơn**: Tạo và quản lý các hóa đơn thanh toán.
- **Quản lý doanh thu**: Thống kê doanh thu theo ngày, tháng, năm.
- **Quản lý tài khoản người dùng**: Xác thực người dùng và phân quyền (quản lý hoặc nhân viên).

---

### **II. Thiết Kế Cơ Sở Dữ Liệu**

- **NhanVien (Nhân viên)**: IDNhanVien, Ten, SDT, GTinh, NgSinh, IDChucVu.  
- **ChucVu (Chức vụ)**: IDChucVu, Ten.  
- **NguoiDung (Người dùng)**: IDDN, Pass, IDChucVu.  
- **CaTruc (Ca trực)**: IDCa, TenCa, NgayTruc.  
- **ChiTietCaTruc (Chi tiết ca trực)**: IDCa, IDNhanVien.  
- **NguyenLieu (Nguyên liệu)**: IDNguyenLieu, TenNL, SLTon.  
- **Mon (Món)**: IDMon, TenMon, Gia.  
- **CongThuc (Công thức)**: IDMon, IDNguyenLieu, SoLuong.  
- **HoaDon (Hóa đơn)**: IDHoaDon, NgayLap, IDNhanVien, ThanhTien.  
- **ChiTietHD (Chi tiết hóa đơn)**: IDHoaDon, IDMon, SoLuong, DonGia.  
- **ThongKeDoanhThu (Thống kê doanh thu)**: IDThongKe, NgayLap, DoanhThu, IDHoaDon.

---

### **III. Thiết Kế Giao Diện**

- **Giao diện đăng nhập**: Nhập tài khoản và mật khẩu để phân quyền người dùng.
- **Giao diện quản lý nhân viên**: Hiển thị danh sách nhân viên, thêm, sửa, xóa nhân viên.
- **Giao diện quản lý ca trực**: Hiển thị lịch ca trực, sắp xếp ca làm việc.
- **Giao diện quản lý món**: Hiển thị và quản lý thông tin món ăn, giá cả.
- **Giao diện quản lý hóa đơn**: Tạo và quản lý hóa đơn thanh toán.
- **Giao diện thống kê doanh thu**: Thống kê doanh thu theo ngày, tháng, hoặc tùy chọn thời gian.

---

