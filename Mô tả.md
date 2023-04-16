## Medical Pharmacy Management
***
Ứng dụng quản lý nhà thuốc cơ bản được xây dựng trên WinForms với giao diện hiện đại.

### Tính năng
***
Phần mềm quản lý nhà thuốc này sẽ bao gồm các tính năng sau:
* Quản lý Bán hàng
* Nhập kho
* Xuất kho
* Tồn kho
* Quản lý hàng hoá
* Quản lý nhân viên
* Quản lý khách hàng
* Quản lý tài khoản

Ngôn ngữ: Tiếng Việt

### Cài đặt
***
Môi trường:
* Windows 8.1+
* .NET Framework 4.7.2
* Microsoft SQL Sever Management Studio 2021+
* Microsoft Visual Studio 2019+

Phát triển phần mềm:
* Microsoft SQL Sever Management Studio 2021.
* Microsoft Visual Studio 2019.

### Sử dụng
***
1. Khởi động Microsoft SQL Sever Management Studio:
* B1: Lấy Sever name trước khi kết nối
* B2: Đảm bảo Sever type là *Database Engine*
* B3: Đảm bảo Authentication là *Windows Authentication*
* B4: Chạy một loạt dữ liệu từ Database bằng cách nhấn F5

2. Khởi động Visual Studio:
* B1: Chạy file NTSF.sln bằng Visual Studio
* B2: Tại thanh Solution Explorer tìm kiếm file có tên App.Config và thực hiện mở file
* B3: Tìm kiếm đoạn có tên: *data source=DESKTOP-JSUCTMT* thay DESKTOP-JSUCTMT thành sever name được lấy ở bước 1

3. Hoàn tất cài đặt, bạn đã có thể sử dụng và chạy chương trình như thông thường

### Lưu ý
***
1. Về phần giao diện, trong quá trình thiết kế nhóm đã không chú ý khi chạy trên local giao diện sẽ hiển thị như bình thường
nhưng chạy trên các máy khác giao diện sẽ bị lệch do bị lỗi độ phân giải

2. Vì mục đích thực hiện demo vì vậy các tính năng nâng cao ở mục Tổng quan và một số mục khác sẽ "Coming soon"

3. Hiện tại, hệ thống chưa tích hợp phân quyền cho ứng dụng, nếu bạn muốn thêm việc phần quyền giữa các tính năng thì liên hệ
cho nhóm qua:
* email: le.duclong0909@gmail.com

### Đóng góp
***
Nhóm rất hoan nghênh các đóng góp của mọi người vào dự án. Vì vậy, nếu bạn có bất kỳ ý tưởng hoặc góp ý nào, vui lòng tạo một issue
hoặc pull request hoặc có thể gửi góp ý qua mail trên để nhóm có thể cùng nhau phát triển dự án.

### Tác giả
***
[Lê Đức Long](https://github.com/longle993)
Dương Khả Minh
Lê Quốc Thịnh
Nguyễn Trọng Hùng
Trần Văn Tuấn
