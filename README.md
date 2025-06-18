ĐỒ ÁN MÔN CÔNG NGHỆ .NET
---
# **Phần Mềm Quản Lý Quán Cà Phê**
### I. Nội dung
Đề tài "Xây dựng ứng dụng quản lý quán cà phê bằng " tập trung vào việc phát triển một hệ thống phần mềm nhằm hỗ trợ quản lý toàn diện các hoạt động của quán cà phê, bao gồm quản lý nhân viên, thực đơn, ca trực, bán hàng, và kho nguyên liệu. Mục tiêu của hệ thống là giúp tự động hóa quy trình vận hành hàng ngày, đảm bảo việc lưu trữ và truy xuất thông tin nhanh chóng, chính xác. Ứng dụng sẽ cung cấp các chức năng chính như thêm, sửa, xóa thông tin nhân viên, quản lý ca làm việc, tạo hóa đơn, xử lý thanh toán, quản lý kho và nhập xuất nguyên liệu. Hệ thống yêu cầu giao diện người dùng thân thiện, dễ sử dụng, bảo mật dữ liệu và phân quyền rõ ràng cho người dùng. Về mặt công nghệ, hệ thống sẽ được xây dựng bằng ngôn ngữ lập trình C# trên nền tảng .NET, sử dụng SQL Server để lưu trữ dữ liệu, và công cụ ADO.NET để tương tác với cơ sở dữ liệu. Phạm vi của ứng dụng không chỉ áp dụng cho một quán cà phê đơn lẻ mà có thể mở rộng cho chuỗi quán trong tương lai, với tiềm năng tích hợp các hệ thống thanh toán và mở rộng thêm nhiều chức năng khác. Nhờ hệ thống này, quán cà phê có thể giảm thiểu sai sót, tiết kiệm thời gian và chi phí, đồng thời tăng cường hiệu quả quản lý.
### II. Lý do chọn đề tài
Xuất phát từ thực tế rằng phần lớn các quán cà phê tại Việt Nam vẫn quản lý thủ công. Việc tính toán và ghi chép bằng tay không chỉ tốn thời gian mà còn tiềm ẩn nhiều rủi ro về sai sót, thất thoát trong doanh thu và chi phí. Sự phát triển của công nghệ thông tin và máy tính tạo cơ hội cho việc xây dựng một hệ thống quản lý hiện đại, tối ưu hóa quy trình và mang lại lợi ích to lớn cho hoạt động kinh doanh. Mô hình quản lý quán cà phê “DPS COFFEE” sẽ là một giải pháp hữu ích để giải quyết các vấn đề trên.
### III. Phạm vi đề tài
Thiết kế giao diện người dùng: Tạo ra một giao diện trực quan, dễ sử dụng cho người quản lý và nhân viên quán cà phê.
Xây dựng cơ sở dữ liệu: Thiết kế mô hình cơ sở dữ liệu để lưu trữ thông tin về nhân viên, món ăn, ca trực, hóa đơn, nguyên liệu và công thức chế biến.
Phát triển các chức năng quản lý: Bao gồm các chức năng quản lý nhân viên, ca trực, thực đơn, hóa đơn, nguyên liệu và công thức món ăn, đảm bảo các quy trình này hoạt động một cách mượt mà và tự động hóa.
Báo cáo và thống kê: Phát triển các tính năng cho phép quản lý có thể theo dõi doanh thu và các hoạt động trong quán cà phê một cách chi tiết và trực quan thông qua các báo cáo và thống kê.
Bảo mật và phân quyền: Hệ thống sẽ có chức năng đăng nhập và phân quyền người dùng (quản lý và nhân viên) để bảo vệ thông tin và đảm bảo rằng chỉ những người có quyền hạn nhất định mới có thể truy cập và thực hiện các thao tác quan trọng.
### IV. Mục tiêu đề tài
Xây dựng một ứng dụng chạy trên nền tảng Windows, cho phép người sử dụng quản lý tổng quát các hoạt động trong quán cà phê một cách hiệu quả. 
Ứng dụng không chỉ mang lại các chức năng thiết yếu cho việc quản lý quán cà phê mà còn cải thiện giao diện người dùng, tạo điều kiện thuận lợi cho người sử dụng trong việc thao tác, tiết kiệm thời gian và tăng cường hiệu suất làm việc. Bên cạnh đó, đề tài cũng chú trọng vào việc hoàn thiện báo cáo đồ án với nội dung và yêu cầu đầy đủ, tạo cơ hội cho người thực hiện áp dụng kiến thức đã học vào thực tiễn, từ đó nâng cao kỹ năng thiết kế và phát triển phần mềm.
Phần mềm này là giải pháp toàn diện giúp cải thiện quy trình vận hành, nâng cao trải nghiệm khách hàng, và hỗ trợ chủ quán quản lý quán cà phê một cách hiệu quả, từ đó giúp mở rộng và phát triển kinh doanh trong tương lai.
## Chương II. Qui Trình Nghiệp Vụ
### I. Qui Trình Quản Lý Nhân Viên

Bắt đầu khi quản lý đăng nhập bằng tài khoản có quyền truy cập quản trị. Sau khi đăng nhập, quản lý có thể vào mục quản lý nhân viên, nơi họ có thể thực hiện các thao tác như thêm mới, cập nhật, hoặc xóa thông tin nhân viên. Để thêm nhân viên mới, quản lý cần nhập các thông tin như tên, số điện thoại, giới tính, ngày sinh, và chức vụ. Hệ thống sẽ tự động kiểm tra các thông tin này; nếu hợp lệ, thông tin sẽ được lưu vào cơ sở dữ liệu. Trong trường hợp thông tin không hợp lệ hoặc còn thiếu, hệ thống sẽ hiển thị thông báo yêu cầu người dùng sửa đổi. Ngoài ra, quản lý cũng có quyền chỉnh sửa hoặc xóa nhân viên hiện tại nếu cần thiết, đảm bảo thông tin nhân sự luôn được cập nhật và chính xác.

### II. Quy Trình Quản Lý Ca Trực

Được thực hiện khi quản lý phân bổ thời gian làm việc cho nhân viên. Quy trình này bao gồm việc chọn ngày, thời gian ca trực, và chọn nhân viên phù hợp để phân công vào ca đó. Sau khi thông tin được nhập, hệ thống sẽ kiểm tra các ràng buộc về thời gian để đảm bảo không có sự trùng lặp hoặc mâu thuẫn với các ca trực khác. Nếu mọi thứ hợp lệ, thông tin ca trực sẽ được lưu vào cơ sở dữ liệu. Quản lý cũng có quyền điều chỉnh hoặc hủy các ca trực nếu lịch làm việc thay đổi, giúp đảm bảo quá trình phân ca được sắp xếp hợp lý, tránh chồng chéo và duy trì lịch làm việc rõ ràng cho nhân viên.

### III. Quy Trình Quản Lý Thực Đơn

Cho phép quản lý thêm, sửa, hoặc xóa các món trong menu. Khi thêm món mới, quản lý nhập tên món, giá cả, và các chi tiết liên quan. Sau khi thông tin được kiểm tra và xác nhận, hệ thống sẽ lưu món mới vào cơ sở dữ liệu. Khi cần cập nhật hoặc xóa món, quản lý có thể vào danh sách thực đơn và thực hiện thay đổi; hệ thống sẽ kiểm tra các ràng buộc để đảm bảo không ảnh hưởng đến các hóa đơn hoặc đơn hàng đã lưu. Quy trình này giúp thực đơn luôn được duy trì chính xác, giá cả cập nhật, và sẵn sàng phục vụ khách hàng..

### IV. Quy Trình Lập Hóa Đơn

Bắt đầu khi nhân viên chọn các món mà khách hàng đã gọi, sau đó hệ thống sẽ tự động tính tổng giá, áp dụng các ưu đãi hoặc chiết khấu nếu có. Khi thanh toán được xác nhận, hóa đơn sẽ được lưu vào cơ sở dữ liệu và in cho khách hàng. Quy trình này giúp đảm bảo mọi giao dịch đều được ghi lại chính xác và hóa đơn được cung cấp cho khách hàng ngay lập tức, đồng thời tạo điều kiện dễ dàng để theo dõi doanh thu.

### V. Quy Trình Quản Lý Nguyên Liệu & Công Thức

Cho phép quản lý theo dõi tồn kho nguyên liệu và kiểm soát công thức cho từng món trong thực đơn. Quản lý nhập thông tin nguyên liệu gồm tên nguyên liệu và số lượng tồn kho hiện tại. Khi nguyên liệu mới được nhập kho hoặc sử dụng, hệ thống sẽ tự động cập nhật số lượng tồn kho, đảm bảo rằng các nguyên liệu luôn sẵn có và phù hợp với yêu cầu pha chế của từng món. Mỗi món trong thực đơn được liên kết với một công thức pha chế chi tiết, bao gồm tên và định lượng nguyên liệu. Quy trình này đảm bảo quán cà phê luôn duy trì đủ nguyên liệu và chất lượng pha chế đồng nhất cho mỗi món.

### VI. Quy Trình Đăng Nhập & Quản Lý Tài Khoản

Được thực hiện khi nhân viên hoặc quản lý truy cập hệ thống. Người dùng nhập tên đăng nhập và mật khẩu, sau đó hệ thống xác thực và phân quyền (quản lý hoặc nhân viên) cho người dùng. Quản lý có thể thêm, chỉnh sửa hoặc xóa tài khoản nhân viên nếu cần, đảm bảo quyền truy cập chỉ dành cho những người được phép, và đảm bảo dữ liệu nhạy cảm luôn được bảo vệ.

### VII. Quy Trình Báo Cáo Doanh Thu và Phân Tích Kinh Doanh

Nhằm cung cấp cho quản lý các báo cáo chi tiết về hoạt động kinh doanh của quán, từ đó hỗ trợ việc ra quyết định. Hàng ngày, tuần, tháng hoặc theo khoảng thời gian tuỳ chọn, quản lý có thể yêu cầu hệ thống tạo báo cáo doanh thu. Các báo cáo này bao gồm các chỉ số như tổng doanh thu, số lượng hóa đơn, doanh thu từng món, và mức giảm giá đã áp dụng. Hệ thống sẽ lấy dữ liệu từ cơ sở dữ liệu, tính toán và trình bày các thông tin này dưới dạng bảng biểu hoặc đồ thị để giúp quản lý dễ dàng phân tích.
Ngoài ra, quy trình cũng bao gồm phân tích xu hướng kinh doanh như các món bán chạy, thời điểm quán có doanh thu cao, và lợi nhuận theo từng khung giờ trong ngày. Dựa trên dữ liệu này, hệ thống có thể cung cấp gợi ý về việc điều chỉnh thực đơn, giá cả, và thời gian phục vụ nhằm tối ưu hoá lợi nhuận. Quy trình này giúp quản lý nắm bắt được tình hình kinh doanh tổng quan, xác định các điểm mạnh và yếu của quán, từ đó đưa ra các chiến lược phát triển và nâng cao hiệu quả kinh doanh.

