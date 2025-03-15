PHẦN MỀM QUẢN LÝ TRUNG TÂM TIẾNG ANH

1. Giới thiệu

Phần mềm Quản lý Trung tâm Tiếng Anh giúp quản lý thông tin học viên, giáo viên, khóa học, lớp học, điểm số, học phí, và lương thưởng. Phần mềm được phát triển bằng C# và SQL Server.

2. Hướng dẫn cài đặt

2.1 Cài đặt cơ sở dữ liệu

Mở SQL Server Management Studio.

Kết nối với máy chủ: (localdb)\mssqllocaldb.

Chạy tập lệnh create database.

Sau đó, chạy các lệnh SQL còn lại để tạo bảng và dữ liệu mẫu.

2.2 Cài đặt phần mềm

Mở file QL_TTTA_01.sln bằng Visual Studio.

Chuột phải vào project, chọn Properties.

Đổi Value thành datasource của bạn.

Build và chạy chương trình.

2.3 Cài đặt thư viện Bunifu (nếu gặp lỗi)

Vào Solution Explorer -> QL_TTTA_01 -> References.

Chuột phải chọn Add Reference.

Chọn Browse, tìm đến thư viện Bunifu.

Chọn toàn bộ file và nhấn OK.

3. Chức năng chính

3.1 Đăng nhập

Admin: admin/admin

Giáo viên: 23GV1111/123, 23GV1112/123...

Học viên: 23SV1100/123, 23SV1101/123...

3.2 Tài khoản Admin

Student: Quản lý danh sách học viên, điểm số.

Teacher: Quản lý danh sách giáo viên.

Money: Quản lý học bổng, lương thưởng.

Class: Quản lý khóa học, lớp học.

Notice: Quản lý thông báo.

3.3 Tài khoản Giáo viên

Xem danh sách học viên, thêm học viên vào lớp.

Xem lương thưởng và số lớp đang dạy.

Gửi thông báo đến học viên.

3.4 Tài khoản Học viên

Xem thông tin cá nhân, đổi mật khẩu.

Đăng ký khóa học, xem điểm số.

Xem học phí, lịch học, thông báo.
