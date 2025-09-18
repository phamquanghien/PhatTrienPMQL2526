1. Môi trường lập trình
   - C#, .Net, MVC
   - Visual Studio Code/Visual Studio (C# Dev Kit, C#, IntelliCode for C# Dev Kit...)
   - Git + Github (git add, git commit, git push, git pull, git branch...)
2. Nội dung học
   - Phát triển ứng dụng quản lý trên .net MVC
   - Tìm hiểu mô hình MVC, Cách thức hoạt động của Model, View, Controller
   - Nắm được cách gửi nhận dữ liệu giữa Model, View, Controller
   - Kế thừa... => Đủ điều kiện đạt
   - Làm việc với Excel, phân trang dữ liệu
   - Authentication và Authorization
   - HTML, CSS (W3.css/Bootstrap)
   - C# Code First, Entity Framework
3. Đánh giá kết quả học phần
   - Thi điểm A: Vấn đáp
   - Điểm B: Dựa vào điểm thi + Bài thực hành + Bài kiểm tra
   - Điểm C: Điểm danh + Làm bài thực hành
4. Bài thực hành buổi học số 1
   - HTML (https://www.w3schools.com/html/default.asp): làm hết phần html form => tạo file chạy thử nghiệm và điền thông tin cá nhân (Họ tên và mã sinh viên)
   - CSS (https://www.w3schools.com/bootstrap5/index.php): làm hết phần bootstrap form => tạo file chạy thử nghiệm và điền thông tin cá nhân (Họ tên và mã sinh viên) 
5. Tạo và chạy project:
   - Tạo mới project: "dotnet new mvc -o PROJECT_NAME" => tên project không được đặt bằng tiếng việt có dấu
   - Chạy project: dotnet run/dotnet watch
   - Lỗi "Could not find a MSBuild project file in..." => cd tới đúng thư mục gốc chứa project
6. Tạo Controller, Model, View, chú ý namespace
   - Tạo controller: có phần hậu tố Controlller => PersonController.cs => tạo thư mục tương ứng trong thư mục Views (ví dụ: /Views/Person)
   - Tạo view => tạo file ".cshtml"
   - Tạo class trong thư mục Models => Tạo file .cs
7. Gửi nhận dữ liệu giữa Controller và View
   - Để gửi dữ liệu từ Controller về View: ViewBag/ViewData/ViewTemplate
   - Để gửi dữ liệu từ view lên controller => submit form
8. Kết nối cơ sở dữ liệu
   - Cài đặt các package cần thiết
   - Cấu hình kết nối ở các file: appsettings.json, Program.cs
   - Tạo file ApplicationDbContext
   - Quản lý phiên bản cơ sở dữ liệu: sử dụng lệnh "dotnet ef migrations add MIGRATION_NAME" và "dotnet ef database update"
9. Sử dụng SQL Server trên docker (nếu cần)
   - Cài đặt docker desktop ở link: https://www.docker.com/get-started/
   - Kiểm tra phiên bản docker cài đặt trên máy: docker --version
   - Chạy lệnh để tải sql server image về: docker pull mcr.microsoft.com/mssql/server:2022-latest
   - Tạo Sql Server container: docker run -d --name sql_server_container -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=YourStrong!Passw0rd' -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest
10. Xây dựng chức năng CRUD
   - Hiểu cách hiển thị dữ liệu lên trên view Index
   - Hiểu cách thêm mới dữ liệu
   - Hiểu cách chỉnh sửa thông tin một bản ghi có sẵn
   - Hiểu cách xoá dữ liệu một bản ghi có sẵn
11. 