Chương I. Giới Thiệu Đề Tài
I. Nội dung
Đề tài "Xây dựng ứng dụng quản lý quán cà phê bằng " tập trung vào việc phát triển một hệ thống phần mềm nhằm hỗ trợ quản lý toàn diện các hoạt động của quán cà phê, bao gồm quản lý nhân viên, thực đơn, ca trực, bán hàng, và kho nguyên liệu. Mục tiêu của hệ thống là giúp tự động hóa quy trình vận hành hàng ngày, đảm bảo việc lưu trữ và truy xuất thông tin nhanh chóng, chính xác. Ứng dụng sẽ cung cấp các chức năng chính như thêm, sửa, xóa thông tin nhân viên, quản lý ca làm việc, tạo hóa đơn, xử lý thanh toán, quản lý kho và nhập xuất nguyên liệu. Hệ thống yêu cầu giao diện người dùng thân thiện, dễ sử dụng, bảo mật dữ liệu và phân quyền rõ ràng cho người dùng. Về mặt công nghệ, hệ thống sẽ được xây dựng bằng ngôn ngữ lập trình C# trên nền tảng .NET, sử dụng SQL Server để lưu trữ dữ liệu, và công cụ ADO.NET để tương tác với cơ sở dữ liệu. Phạm vi của ứng dụng không chỉ áp dụng cho một quán cà phê đơn lẻ mà có thể mở rộng cho chuỗi quán trong tương lai, với tiềm năng tích hợp các hệ thống thanh toán và mở rộng thêm nhiều chức năng khác. Nhờ hệ thống này, quán cà phê có thể giảm thiểu sai sót, tiết kiệm thời gian và chi phí, đồng thời tăng cường hiệu quả quản lý.
II. Lý do chọn đề tài
Xuất phát từ thực tế rằng phần lớn các quán cà phê tại Việt Nam vẫn quản lý thủ công. Việc tính toán và ghi chép bằng tay không chỉ tốn thời gian mà còn tiềm ẩn nhiều rủi ro về sai sót, thất thoát trong doanh thu và chi phí. Sự phát triển của công nghệ thông tin và máy tính tạo cơ hội cho việc xây dựng một hệ thống quản lý hiện đại, tối ưu hóa quy trình và mang lại lợi ích to lớn cho hoạt động kinh doanh. Mô hình quản lý quán cà phê “DPS COFFEE” sẽ là một giải pháp hữu ích để giải quyết các vấn đề trên.
III. Phạm vi đề tài
Thiết kế giao diện người dùng: Tạo ra một giao diện trực quan, dễ sử dụng cho người quản lý và nhân viên quán cà phê.
Xây dựng cơ sở dữ liệu: Thiết kế mô hình cơ sở dữ liệu để lưu trữ thông tin về nhân viên, món ăn, ca trực, hóa đơn, nguyên liệu và công thức chế biến.
Phát triển các chức năng quản lý: Bao gồm các chức năng quản lý nhân viên, ca trực, thực đơn, hóa đơn, nguyên liệu và công thức món ăn, đảm bảo các quy trình này hoạt động một cách mượt mà và tự động hóa.
Báo cáo và thống kê: Phát triển các tính năng cho phép quản lý có thể theo dõi doanh thu và các hoạt động trong quán cà phê một cách chi tiết và trực quan thông qua các báo cáo và thống kê.
Bảo mật và phân quyền: Hệ thống sẽ có chức năng đăng nhập và phân quyền người dùng (quản lý và nhân viên) để bảo vệ thông tin và đảm bảo rằng chỉ những người có quyền hạn nhất định mới có thể truy cập và thực hiện các thao tác quan trọng.
IV. Mục tiêu đề tài
Xây dựng một ứng dụng chạy trên nền tảng Windows, cho phép người sử dụng quản lý tổng quát các hoạt động trong quán cà phê một cách hiệu quả. 
Ứng dụng không chỉ mang lại các chức năng thiết yếu cho việc quản lý quán cà phê mà còn cải thiện giao diện người dùng, tạo điều kiện thuận lợi cho người sử dụng trong việc thao tác, tiết kiệm thời gian và tăng cường hiệu suất làm việc. Bên cạnh đó, đề tài cũng chú trọng vào việc hoàn thiện báo cáo đồ án với nội dung và yêu cầu đầy đủ, tạo cơ hội cho người thực hiện áp dụng kiến thức đã học vào thực tiễn, từ đó nâng cao kỹ năng thiết kế và phát triển phần mềm.
Phần mềm này là giải pháp toàn diện giúp cải thiện quy trình vận hành, nâng cao trải nghiệm khách hàng, và hỗ trợ chủ quán quản lý quán cà phê một cách hiệu quả, từ đó giúp mở rộng và phát triển kinh doanh trong tương lai.
Chương II. Qui Trình Nghiệp Vụ
I. Qui Trình Quản Lý Nhân Viên
1. Mô tả qui trình
Bắt đầu khi quản lý đăng nhập bằng tài khoản có quyền truy cập quản trị. Sau khi đăng nhập, quản lý có thể vào mục quản lý nhân viên, nơi họ có thể thực hiện các thao tác như thêm mới, cập nhật, hoặc xóa thông tin nhân viên. Để thêm nhân viên mới, quản lý cần nhập các thông tin như tên, số điện thoại, giới tính, ngày sinh, và chức vụ. Hệ thống sẽ tự động kiểm tra các thông tin này; nếu hợp lệ, thông tin sẽ được lưu vào cơ sở dữ liệu. Trong trường hợp thông tin không hợp lệ hoặc còn thiếu, hệ thống sẽ hiển thị thông báo yêu cầu người dùng sửa đổi. Ngoài ra, quản lý cũng có quyền chỉnh sửa hoặc xóa nhân viên hiện tại nếu cần thiết, đảm bảo thông tin nhân sự luôn được cập nhật và chính xác.
2. Các bước cụ thể
•	Nhập thông tin nhân viên mới.
•	Hệ thống kiểm tra thông tin hợp lệ.
•	Lưu thông tin vào cơ sở dữ liệu.
•	Chỉnh sửa hoặc xóa thông tin nếu cần.
II. Quy Trình Quản Lý Ca Trực
1. Mô tả quy trình
Được thực hiện khi quản lý phân bổ thời gian làm việc cho nhân viên. Quy trình này bao gồm việc chọn ngày, thời gian ca trực, và chọn nhân viên phù hợp để phân công vào ca đó. Sau khi thông tin được nhập, hệ thống sẽ kiểm tra các ràng buộc về thời gian để đảm bảo không có sự trùng lặp hoặc mâu thuẫn với các ca trực khác. Nếu mọi thứ hợp lệ, thông tin ca trực sẽ được lưu vào cơ sở dữ liệu. Quản lý cũng có quyền điều chỉnh hoặc hủy các ca trực nếu lịch làm việc thay đổi, giúp đảm bảo quá trình phân ca được sắp xếp hợp lý, tránh chồng chéo và duy trì lịch làm việc rõ ràng cho nhân viên.
2. Các bước cụ thể
•	Chọn ca trực (thời gian và ngày).
•	Chọn các nhân viên trực.
•	Hệ thống kiểm tra tính hợp lệ (không trùng lặp).
•	Lưu thông tin ca trực vào cơ sở dữ liệu.
III. Quy Trình Quản Lý Thực Đơn
1. Mô tả quy trình
Cho phép quản lý thêm, sửa, hoặc xóa các món trong menu. Khi thêm món mới, quản lý nhập tên món, giá cả, và các chi tiết liên quan. Sau khi thông tin được kiểm tra và xác nhận, hệ thống sẽ lưu món mới vào cơ sở dữ liệu. Khi cần cập nhật hoặc xóa món, quản lý có thể vào danh sách thực đơn và thực hiện thay đổi; hệ thống sẽ kiểm tra các ràng buộc để đảm bảo không ảnh hưởng đến các hóa đơn hoặc đơn hàng đã lưu. Quy trình này giúp thực đơn luôn được duy trì chính xác, giá cả cập nhật, và sẵn sàng phục vụ khách hàng..
2. Các bước cụ thể
•	Nhập tên món và giá.
•	Hệ thống kiểm tra và lưu thông tin vào cơ sở dữ liệu.
•	Chỉnh sửa hoặc xóa thông tin món nếu cần.
•	Kiểm tra ràng buộc trước khi xóa món.
IV. Quy Trình Lập Hóa Đơn
1. Mô tả quy trình
Bắt đầu khi nhân viên chọn các món mà khách hàng đã gọi, sau đó hệ thống sẽ tự động tính tổng giá, áp dụng các ưu đãi hoặc chiết khấu nếu có. Khi thanh toán được xác nhận, hóa đơn sẽ được lưu vào cơ sở dữ liệu và in cho khách hàng. Quy trình này giúp đảm bảo mọi giao dịch đều được ghi lại chính xác và hóa đơn được cung cấp cho khách hàng ngay lập tức, đồng thời tạo điều kiện dễ dàng để theo dõi doanh thu.
2. Các bước cụ thể
•	Nhân viên chọn các món mà khách hàng đã gọi.
•	Hệ thống tính tổng tiền và chiết khấu.
•	Xác nhận thanh toán và lưu hóa đơn vào cơ sở dữ liệu.
•	In hóa đơn và giao cho khách hàng.
V. Quy Trình Quản Lý Nguyên Liệu & Công Thức
1. Mô tả quy trình
Cho phép quản lý theo dõi tồn kho nguyên liệu và kiểm soát công thức cho từng món trong thực đơn. Quản lý nhập thông tin nguyên liệu gồm tên nguyên liệu và số lượng tồn kho hiện tại. Khi nguyên liệu mới được nhập kho hoặc sử dụng, hệ thống sẽ tự động cập nhật số lượng tồn kho, đảm bảo rằng các nguyên liệu luôn sẵn có và phù hợp với yêu cầu pha chế của từng món. Mỗi món trong thực đơn được liên kết với một công thức pha chế chi tiết, bao gồm tên và định lượng nguyên liệu. Quy trình này đảm bảo quán cà phê luôn duy trì đủ nguyên liệu và chất lượng pha chế đồng nhất cho mỗi món.
2. Các bước cụ thể
•	Nhập thông tin nguyên liệu (tên nguyên liệu, số lượng).
•	Hệ thống lưu thông tin vào cơ sở dữ liệu.
•	Nhập công thức cho các món (liên kết món với nguyên liệu).
•	Cập nhật tồn kho khi có sự thay đổi số lượng.
VI. Quy Trình Đăng Nhập & Quản Lý Tài Khoản
1. Mô tả quy trình
Được thực hiện khi nhân viên hoặc quản lý truy cập hệ thống. Người dùng nhập tên đăng nhập và mật khẩu, sau đó hệ thống xác thực và phân quyền (quản lý hoặc nhân viên) cho người dùng. Quản lý có thể thêm, chỉnh sửa hoặc xóa tài khoản nhân viên nếu cần, đảm bảo quyền truy cập chỉ dành cho những người được phép, và đảm bảo dữ liệu nhạy cảm luôn được bảo vệ.
2. Các bước cụ thể
•	Người dùng nhập tên đăng nhập và mật khẩu.
•	Hệ thống kiểm tra tính hợp lệ của tài khoản.
•	Cấp quyền tương ứng cho người dùng (quản trị viên hoặc nhân viên).
•	Quản lý thêm, sửa hoặc xóa tài khoản nếu cần.
VII. Quy Trình Báo Cáo Doanh Thu và Phân Tích Kinh Doanh
1. Mô tả quy trình
Nhằm cung cấp cho quản lý các báo cáo chi tiết về hoạt động kinh doanh của quán, từ đó hỗ trợ việc ra quyết định. Hàng ngày, tuần, tháng hoặc theo khoảng thời gian tuỳ chọn, quản lý có thể yêu cầu hệ thống tạo báo cáo doanh thu. Các báo cáo này bao gồm các chỉ số như tổng doanh thu, số lượng hóa đơn, doanh thu từng món, và mức giảm giá đã áp dụng. Hệ thống sẽ lấy dữ liệu từ cơ sở dữ liệu, tính toán và trình bày các thông tin này dưới dạng bảng biểu hoặc đồ thị để giúp quản lý dễ dàng phân tích.
Ngoài ra, quy trình cũng bao gồm phân tích xu hướng kinh doanh như các món bán chạy, thời điểm quán có doanh thu cao, và lợi nhuận theo từng khung giờ trong ngày. Dựa trên dữ liệu này, hệ thống có thể cung cấp gợi ý về việc điều chỉnh thực đơn, giá cả, và thời gian phục vụ nhằm tối ưu hoá lợi nhuận. Quy trình này giúp quản lý nắm bắt được tình hình kinh doanh tổng quan, xác định các điểm mạnh và yếu của quán, từ đó đưa ra các chiến lược phát triển và nâng cao hiệu quả kinh doanh.
2. Các bước cụ thể
•	Chọn khoảng thời gian báo cáo.
•	 Hệ thống truy xuất và tính toán doanh thu, số hóa đơn, doanh thu từng món, xu hướng kinh doanh.
•	 Trình bày dữ liệu dưới dạng bảng và biểu đồ.
•	Đưa ra gợi ý điều chỉnh (bổ sung món, điều chỉnh giá, sắp xếp ca trực).
•	Xuất báo cáo dưới dạng PDF hoặc Excel.
•	Quản lý xem xét và quyết định các chiến lược cải thiện kinh doanh.
Chương III. Phân Tích Thiết Kế
I. Các Chức Năng Chính
•	Quản lý nhân viên: Cho phép thêm, sửa, xóa thông tin nhân viên.
•	Quản lý ca trực: Cho phép sắp xếp và quản lý các ca trực của nhân viên.
•	Quản lý nguyên liệu: Thêm, sửa, xóa và quản lý số lượng tồn kho của nguyên liệu.
•	Quản lý món: Thêm, sửa, xóa thông tin về món và giá cả.
•	Quản lý hóa đơn: Tạo hóa đơn, chi tiết hóa đơn và tính tổng thành tiền.
•	Quản lý doanh thu: Thống kê doanh thu theo thời gian (ngày, tháng, năm).
•	Quản lý người dùng: Xác thực người dùng và phân quyền theo chức vụ (quản trị viên, nhân viên).
•	Báo Cáo Doanh Thu và Phân Tích Kinh Doanh: Tối ưu hoá quản lý tài chính và tăng cường hiệu quả kinh doanh thông qua các công cụ trực quan và thông tin chi tiết.
II. Thiết Kế Cơ Sở Dữ Liệu
1. Các bảng chính trong cơ sở dữ liệu:
•	Bảng Mon (Món)
Chức năng: Lưu thông tin về các món trong menu.
Các cột:
o	IDMon (CHAR(10), PK): Mã món, định danh duy nhất cho mỗi món.
o	TenMon (NVARCHAR(100)): Tên của món.
o	price (DECIMAL(10, 2)): Giá của món.
•	Bảng NguyenLieu (Nguyên Liệu)
Chức năng: Lưu thông tin về các nguyên liệu được sử dụng trong quán.
Các cột:
o	IDNguyenLieu (CHAR(10), PK): Mã nguyên liệu, định danh duy nhất cho mỗi nguyên liệu.
o	TenNL (NVARCHAR(100)): Tên của nguyên liệu.
o	SLTon (INT): Số lượng tồn kho của nguyên liệu.
Bảng CongThuc (Công Thức)
Chức năng: Liên kết món với nguyên liệu và định lượng cho mỗi món, tạo công thức pha chế.
Các cột:
o	IDMon (CHAR(10), PK, FK): Mã món, liên kết với bảng Mon.
o	IDNguyenLieu (CHAR(10), PK, FK): Mã nguyên liệu, liên kết với bảng NguyenLieu.
o	SoLuong (DECIMAL(10, 2)): Số lượng nguyên liệu cần thiết cho món.
•	Bảng NhanVien (Nhân Viên)
Chức năng: Lưu thông tin về nhân viên làm việc trong quán.
Các cột:
o	IDNhanVien (CHAR(10), PK): Mã nhân viên, định danh duy nhất cho mỗi nhân viên.
o	Ten (NVARCHAR(100)): Tên nhân viên.
o	SDT (NVARCHAR(20)): Số điện thoại của nhân viên.
o	GTinh (NVARCHAR(10)): Giới tính của nhân viên.
o	NgSinh (DATE): Ngày sinh của nhân viên.
o	TrangThai (BIT): Trạng thái làm việc của nhân viên (1: đang làm việc, 0: không làm việc).
o	IDQuanLy (CHAR(10), FK): Mã nhân viên quản lý trực tiếp của nhân viên này.
o	Pass (NVARCHAR(255)): Mật khẩu (có thể đã mã hóa).
•	Bảng HoaDon (Hóa Đơn)
Chức năng: Lưu thông tin về các hóa đơn được tạo.
Các cột:
o	IDHoaDon (CHAR(10), PK): Mã hóa đơn, định danh duy nhất cho mỗi hóa đơn.
o	NgayLap (DATE): Ngày lập hóa đơn.
o	IDNhanVien (CHAR(10), FK): Mã nhân viên tạo hóa đơn, liên kết với bảng NhanVien.
o	ThanhTien (DECIMAL(10, 2)): Tổng số tiền trong hóa đơn.
•	Bảng ChiTietHD (Chi Tiết Hóa Đơn)
Chức năng: Lưu chi tiết của từng món trong hóa đơn.
Các cột:
o	IDHoaDon (CHAR(10), PK, FK): Mã hóa đơn, liên kết với bảng HoaDon.
o	IDMon (CHAR(10), PK, FK): Mã món, liên kết với bảng Mon.
o	SoLuong (INT): Số lượng của món trong hóa đơn.
o	DonGia (DECIMAL(10, 2)): Đơn giá của món.
o	TinhTrang_PhucVu (BIT): Trạng thái phục vụ của món (1: đã phục vụ, 0: chưa phục vụ).
•	Bảng CaTruc (Ca Trực)
Chức năng: Lưu thông tin về các ca làm việc.
Các cột:
o	IDCa (CHAR(10), PK): Mã ca trực, định danh duy nhất cho mỗi ca.
o	TenCa (NVARCHAR(100)): Tên của ca trực.
•	Bảng LichTruc (Lịch Trực)
Chức năng: Lưu thông tin về lịch làm việc của từng ca trực trong ngày.
Các cột:
o	IDLichTruc (CHAR(10), PK): Mã lịch trực, định danh duy nhất cho mỗi lịch trực.
o	NgayTruc (DATE): Ngày trực.
o	IDCa (CHAR(10), FK): Mã ca trực, liên kết với bảng CaTruc.
•	Bảng ChiTietLichTruc (Chi Tiết Lịch Trực)
Chức năng: Liên kết nhân viên với lịch trực và theo dõi trạng thái của nhân viên trong ca làm việc.
Các cột:
o	IDLichTruc (CHAR(10), PK, FK): Mã lịch trực, liên kết với bảng LichTruc.
o	IDNhanVien (CHAR(10), PK, FK): Mã nhân viên, liên kết với bảng NhanVien.
o	TrangThai (BIT): Trạng thái của nhân viên trong ca (1: có mặt, 0: vắng mặt).

 
2. Mối quan hệ giữa các bảng:
•	Một món có thể gồm nhiều nguyên liệu (Mon – CongThuc – NguyenLieu).
•	Một nhân viên có thể lập nhiều hóa đơn (NhanVien – HoaDon).
•	Một hóa đơn có thể chứa nhiều chi tiết món (HoaDon – ChiTietHD).
•	Một món có thể xuất hiện trong nhiều chi tiết hóa đơn (Mon – ChiTietHD).
•	Một ca trực có thể được lên nhiều lịch trực trong ngày (CaTruc – LichTruc).
•	Một lịch trực có thể bao gồm nhiều nhân viên (LichTruc – ChiTietLichTruc – NhanVien).
3. Thiết kế giao diện:
•	Giao diện đăng nhập: Cho phép người dùng đăng nhập vào hệ thống bằng tài khoản và phân quyền (quản lý hoặc nhân viên).
•	Giao diện quản lý nhân viên: Hiển thị danh sách nhân viên, cho phép thêm, sửa, xóa nhân viên.
•	Giao diện quản lý ca trực: Hiển thị lịch làm việc và cho phép sắp xếp ca trực.
•	Giao diện quản lý món: Hiển thị danh sách món ăn, cho phép thêm, sửa, xóa món.
•	Giao diện quản lý hóa đơn: Cho phép tạo mới hóa đơn và quản lý các hóa đơn đã lập.
•	Giao diện thống kê doanh thu: Hiển thị doanh thu theo ngày, tháng, hoặc khoảng thời gian tùy chọn
