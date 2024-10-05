# CongNgheNet/PhanMemQuanLyQuanCaPhe
 Xây dựng phần mềm quản lý quán cà phê bằng winform
**Nghiệp vụ (Business Requirements) cho phần mềm quản lý quán cà phê bằng WinForms:**

### 1. Mục tiêu của hệ thống:
- **Quản lý bán hàng**: Quản lý thông tin các đơn hàng, các sản phẩm bán ra, và quá trình thanh toán của khách hàng.
- **Quản lý nhân viên**: Quản lý ca làm việc, thông tin nhân viên và tiền lương.
- **Quản lý kho**: Theo dõi số lượng nguyên liệu nhập và xuất, kiểm kê tồn kho định kỳ.
- **Quản lý khách hàng**: Quản lý thông tin khách hàng thường xuyên (như thành viên, khách VIP) và cung cấp các chương trình ưu đãi.
- **Báo cáo doanh thu**: Thống kê doanh thu, số lượng đơn hàng theo ngày, tháng, năm.
- **Tối ưu hóa trải nghiệm khách hàng**: Đơn giản hóa quy trình gọi món, thanh toán và chăm sóc khách hàng.

### 2. Các đối tượng sử dụng hệ thống:
- **Quản lý cửa hàng**: Quản lý tất cả hoạt động của quán, tạo báo cáo doanh thu, quản lý nhân viên và kho.
- **Nhân viên phục vụ**: Nhập thông tin đơn hàng, xử lý thanh toán.
- **Nhân viên kho**: Quản lý nhập xuất kho.
- **Khách hàng**: Có thể cung cấp thông tin để được nhận ưu đãi.

---

### **Sơ đồ Use Case:**

```plaintext
+--------------------------------------+
|            Hệ thống quản lý          |
+--------------------------------------+
      |                   |               |
      v                   v               v
+-------------+   +---------------+   +-------------+
| Quản lý     |   | Nhân viên      |   | Khách hàng  |
|             |   | phục vụ        |   |             |
+-------------+   +---------------+   +-------------+
      |                   |               |
      v                   v               v
+---------------------------+ +-----------------+
| Quản lý doanh thu, báo cáo | | Nhập thông tin  |
| Quản lý nhân viên, kho     | | đơn hàng, xử lý |
+---------------------------+ | thanh toán      |
                               +-----------------+
```

---

### 3. Các biểu mẫu cần có:

#### 3.1. **Biểu mẫu quản lý nhân viên**:
- **Trường thông tin**: 
  - Tên nhân viên
  - Mã nhân viên
  - Số điện thoại
  - Vị trí (phục vụ, quản lý, kho)
  - Ca làm việc
  - Lương cơ bản

#### 3.2. **Biểu mẫu quản lý sản phẩm**:
- **Trường thông tin**: 
  - Mã sản phẩm
  - Tên sản phẩm
  - Giá
  - Số lượng trong kho
  - Nguyên liệu sử dụng
  - Ảnh sản phẩm (nếu có)

#### 3.3. **Biểu mẫu quản lý đơn hàng**:
- **Trường thông tin**: 
  - Mã đơn hàng
  - Thời gian đặt hàng
  - Số bàn
  - Sản phẩm đã gọi
  - Số lượng từng sản phẩm
  - Tổng giá trị đơn hàng
  - Nhân viên phụ trách
  - Trạng thái thanh toán

#### 3.4. **Biểu mẫu quản lý kho**:
- **Trường thông tin**: 
  - Mã nguyên liệu
  - Tên nguyên liệu
  - Số lượng nhập
  - Số lượng tồn
  - Đơn vị tính
  - Ngày nhập hàng
  - Hạn sử dụng

#### 3.5. **Biểu mẫu báo cáo doanh thu**:
- **Trường thông tin**:
  - Tổng doanh thu ngày
  - Tổng doanh thu theo tháng
  - Số lượng đơn hàng
  - Sản phẩm bán chạy

---

### **Sơ đồ lớp (Class Diagram):**

```plaintext
+---------------------+        +---------------------+        +---------------------+
|      Nhân viên      |        |      Sản phẩm       |        |      Đơn hàng       |
+---------------------+        +---------------------+        +---------------------+
| + Mã nhân viên      |        | + Mã sản phẩm       |        | + Mã đơn hàng       |
| + Tên nhân viên     |        | + Tên sản phẩm      |        | + Thời gian         |
| + Vị trí            |        | + Giá               |        | + Tổng giá trị      |
| + Ca làm việc       |        | + Số lượng trong kho|        | + Sản phẩm          |
+---------------------+        +---------------------+        +---------------------+
      ^                                      |                           ^
      |                                      v                           |
      +--------------------------+   +----------------------+   +----------------------+
                                |   |     Chi tiết đơn hàng  |   |
                                |   +-----------------------+   |
                                |                             v   |
                        +---------------------+        +----------------------+
                        |      Khách hàng     |        |     Quản lý kho      |
                        +---------------------+        +----------------------+
                        | + Mã khách hàng     |        | + Mã nguyên liệu     |
                        | + Tên khách hàng    |        | + Tên nguyên liệu    |
                        | + SĐT               |        | + Số lượng nhập      |
                        | + Ưu đãi            |        | + Hạn sử dụng        |
                        +---------------------+        +----------------------+
```

---

### 4. Các tính năng chính:
- **Quản lý sản phẩm**: Thêm, sửa, xóa các sản phẩm cà phê, đồ ăn kèm.
- **Quản lý nhân viên**: Cập nhật thông tin nhân viên, quản lý ca làm việc, tính lương.
- **Quản lý kho**: Nhập hàng, kiểm kê, theo dõi lượng nguyên liệu.
- **Bán hàng**: Tạo đơn hàng, thêm món, thanh toán.
- **Báo cáo doanh thu**: Thống kê doanh thu, lượng đơn hàng, sản phẩm bán chạy.

Hệ thống sẽ dễ dàng tùy chỉnh và phát triển thêm tính năng để phù hợp với yêu cầu thực tế của quán cà phê.
