create table QuanLy
(
	TenDangNhap varchar(20),
	MatKhau varchar(20)
	primary key (TenDangNhap)
)

create table ChiNhanh
(
	MaChiNhanh varchar(10),
	TenChiNhanh nvarchar(20),
	DiaChi nvarchar(50),
	DoanhThu float,
	primary key (MaChiNhanh)
)

create table NhanVien 
(
	MaNhanVien varchar(10),
	TenNhanVien nvarchar(50),
	SDT varchar(10),
	NgaySinh datetime,
	MaChiNhanh varchar(10),
	MatKhau varchar(20),
	SoLuongBan int 
	primary key (MaNhanVien),
	constraint FK_NhanVien_ChiNhanh foreign key (MaChiNhanh) references ChiNhanh(MaChiNhanh)

)

create table KhachHang
(
	SoDienThoai varchar(10),
	TenKhachHang nvarchar(50),
	DiaChi nvarchar(50),
	DaMua int 
	primary key (SoDienThoai),
)

create table Menu
(
	MaMon varchar(10),
	TenMon nvarchar(50),
	GiaTien float,
	AnhMinhHoa varchar(50),
	DaBan int ,
	primary key (MaMon)
)


create table HoaDon
(
	MaHoaDon varchar(10),
	SoDT_KhachHang varchar(10),
	MaNV varchar(10),
	MaChiNhanh varchar(10),
	NgayBan date,
	TongGia float
	primary key (MaHoaDon),
	constraint FK_HoaDon_KhachHang foreign key (SoDT_KhachHang) references KhachHang(SoDienThoai),
	constraint FK_HoaDon_NhanVien foreign key (MaNV) references NhanVien(MaNhanVien),
	constraint FK_HoaDon_ChiNhanh foreign key (MaChiNhanh) references ChiNhanh(MaChiNhanh)
)

create table ChiTietHoaDon
(
	MaHD varchar(10),
	MaMon varchar(10),
	SoLuong int,
	Gia float,
	primary key (MaHD,MaMon),
	constraint FK_ChiTietHoaDon_HoaDon foreign key (MaHD) references HoaDon(MaHoaDon),
	constraint FK_ChiTietHoaDon_Menu foreign key (MaMon) references Menu(MaMon)
)


insert into QuanLy values ('AdminQuynh','1234')
insert into QuanLy values ('AdminAn','1234')

insert into ChiNhanh values ('CN01',N'Chi Nhánh 1',N'Quận 1',0)
insert into ChiNhanh values ('CN02',N'Chi Nhánh 2',N'Quận 2',0)
insert into ChiNhanh values ('CN03',N'Chi Nhánh 3',N'Quận 3',0)
insert into ChiNhanh values ('CN04',N'Chi Nhánh 4',N'Quận 4',0)
insert into ChiNhanh values ('CN05',N'Chi Nhánh 5',N'Quận 5',0)
insert into ChiNhanh values ('CN06',N'Chi Nhánh 6',N'Quận 6',0)
insert into ChiNhanh values ('CN07',N'Chi Nhánh 7',N'Quận 7',0)

insert into  NhanVien  values ('NV01',N'Nguyễn Cước Thiên','0984728234','01-10-2000','CN01','thien',0)
insert into  NhanVien values ('NV02',N'Lâm Hoàng An','0912348234','2000-01-01','CN02','an',0)
insert into  NhanVien values ('NV03',N'Tu Ngọc Yến Vy','0984724567','2000-01-01','CN03','vy',0)
insert into  NhanVien values ('NV04',N'Nguyễn Hữu Tường','0984325790','2000-01-01','CN04','tuong',0)
insert into  NhanVien values ('NV05',N'Đặng Nguyễn Hoài Thư','0984712367','2000-01-01','CN05','thu',0)
insert into  NhanVien values ('NV06',N'Nguyễn Thị Như Quỳnh','0985194510','2000-01-01','CN06','quynh',0)
insert into  NhanVien values ('NV07',N'Phạm Duy Khôi','0998728678','2000-01-01','CN07','khoi',0)

insert into KhachHang values ('0985194510',N'Trần Ngọc Anh',N'01 Trần Hưng Đạo, Quận 1',0)
insert into KhachHang values ('0947699623',N'Đặng Quốc Việt',N'02 Võ Thị Sáu, Quận 3',0)
insert into KhachHang values ('0987654321',N'Phan Như Ý',N'10 Đường 12, Quận 2',0)
insert into KhachHang values ('0912674906',N'Nguyễn Mai Hoa',N'99 Nguyễn Thị Thập, Quận 7',0)
insert into KhachHang values ('0912674006',N'Võ Văn Thiên',N'01 Đường 9, Quận 4',0)
insert into KhachHang values ('0912674001',N'Nguyễn Gia Bảo',N'02 Đường 10, Quận 5',0)

insert into Menu values ('BINGSU01','Special BingSu',55000,'special.jpg','0')
insert into Menu values ('BINGSU02','Cheese Cake BingSu',50000,'Cheese.jpg','0')
insert into Menu values ('BINGSU03','Passion Cheese BingSu','45000,passioncheese.jpg','0')
insert into Menu values ('BINGSU04','Choco BingSu',40000,'Choco.jpg','0')
insert into Menu values ('BINGSU05','Oreo BingSu',45000,'Oreo.jpg','0')
insert into Menu values ('BINGSU06','Mango BingSo',45000,'mango.png','0')
insert into Menu values ('BINGSU07','Strawberry BingSu',50000,'strawberry.jpg','0')
insert into Menu values ('BINGSU08','Green Tea BingSu',40000,'GreenTea.jpg','0')
insert into Menu values ('BINGSU09','Peach BingSu',45000,'peach.jpg','0')
insert into Menu values ('BINGSU10','Black Sesame BingSu',40000,'black-sesame','0')

select * from Menu


--trigger 
--Trigger: Sau khi thanh toán thì Doanh thu cửa hang
go
create or alter trigger SoLuongMuaBan on HoaDon
after insert as
declare @chinhanh varchar(10), @khachhang nvarchar(50), @tonggia float
set @tonggia = (select inserted.TongGia from inserted)
select @chinhanh = inserted.MaChiNhanh, @khachhang= inserted.SoDT_KhachHang from inserted
begin 
	update ChiNhanh set DoanhThu = DoanhThu + @tonggia where ChiNhanh.MaChiNhanh = @chinhanh
end
go 
--Trigger: sau khi thanh toán thì số lượng đã mua của khách hàng tăng lên 

create or alter trigger SoLuongDaMua on ChiTietHoaDon
after insert as
declare @soluong int, @khachhang nvarchar(50)
set @soluong = (select inserted.SoLuong from inserted )
set @khachhang = (select HoaDon.SoDT_KhachHang from inserted, HoaDon where inserted.MaHD = HoaDon.MaHoaDon)
begin 
	update KhachHang set KhachHang.DaMua = KhachHang.DaMua +@soluong where KhachHang.SoDienThoai = @khachhang
end
go 

--trigger Sau khi thanh toán thì số lượng đã bán của món được mua tăng lên
create or alter trigger SoLuongDaBan on ChiTietHoaDon
after insert as
declare @mon varchar(10), @soluong int
select @mon =inserted.MaMon, @soluong = inserted.SoLuong from inserted
begin 
	update Menu set Menu.DaBan = Menu.DaBan + @soluong where Menu.MaMon = @mon
end
go

--Trigger: sau khi thanh toán thì số lượng đã bán của nhân viên tăng lên 

create or alter trigger SoLuongNVBan on ChiTietHoaDon
after insert as
declare @soluong int, @nhanvien nvarchar(50)
set @soluong = (select inserted.SoLuong from inserted )
set @nhanvien = (select HoaDon.MaNV from inserted, HoaDon where inserted.MaHD = HoaDon.MaHoaDon)
begin 
	update NhanVien set SoLuongBan = SoLuongBan +@soluong where MaNhanVien = @nhanvien
end
go

--trigger: kiểm tra ngày sinh nhân viên
create or alter trigger ktNgaySinh on NhanVien
for insert, update as
	declare @ngaySinh datetime
	select @ngaySinh = YEAR(inserted.NgaySinh) from inserted
	if(YEAR(GETDATE()) - @ngaySinh < 18)
	begin 
		rollback tran;
		throw 50005,N'Ngày sinh không hợp lệ',1;
	end	
go
--function 

create or alter function autoID_func () returns varchar(10)
as
begin
	declare @preMaHD varchar(10)
	declare @nextMaHD varchar(10)
	select top(1) @preMaHD = MaHoaDon from HoaDon order by CONVERT(int,SUBSTRING(HoaDon.MaHoaDon,3,10)) desc
	set @nextMaHD = Cast(CONVERT(int,SUBSTRING(@preMaHD,3,10))+1 as varchar(10))
	return concat('HD', @nextMaHD)
end

go
-- Function lấy một nhân viên khi biết mã nhân viên đó
create or alter function pickNhanVien_func (@MaNV varchar(10)) returns table
as
	return select * from NhanVien where NhanVien.MaNhanVien=@MaNV 
go
--Function lấy một món khi biết mã
create or alter function pickMon_func(@MaMon varchar(10)) returns table
as
return (select * from Menu where MaMon = @MaMon)
go

--Function lấy một khách hàng khi biết số điện thoại khách hàng đó
create or alter function pickCustomer_func(@maKH varchar(10)) returns table
as
return (select * from KhachHang where SoDienThoai = @maKH)
go

--Function lấy 1 chi nhánh khi biết mã
create or alter function pickBranch_func(@maCN varchar(10)) returns table
as
return (select * from ChiNhanh where MaChiNhanh = @maCN)
go
-- Function lấy một chi nhánh khi biết mã nhân viên
create or alter function pickChiNhanh_NV_func (@MaNV varchar(10)) returns table
as
	return select TenChiNhanh,ChiNhanh.MaChiNhanh from ChiNhanh,NhanVien where NhanVien.MaNhanVien = @MaNV and NhanVien.MaChiNhanh =ChiNhanh.MaChiNhanh 
go

--tìm kiếm theo tên nhân viên
create or alter function timkiemNV_func (@tenNV nvarchar(50))
returns table 
as
return(select* from NhanVien where NhanVien.TenNhanVien like N'%' + @tenNV+'%' or NhanVien.MaNhanVien like N'%' + @tenNV+'%')
go 

--tìm kiếm theo tên món ăn
create or alter function timkiemMonAn_func (@tenMonAn nvarchar(50))
returns table as
return(select* from Menu where Menu.TenMon like N'%' + @tenMonAn or Menu.MaMon like N'%' + @tenMonAn)
go


-- tìm kiếm theo tên chi nhánh
create or alter function timkiemCN_func (@tenCN nvarchar(50))
returns table 
as
return(select* from ChiNhanh where ChiNhanh.TenChiNhanh like N'%' + @tenCN+'%' or ChiNhanh.MaChiNhanh like N'%' + @tenCN+'%'  )
go

--Function tìm kiếm khách hàng theo tên
create or alter function timkiemKH_func (@tenKH nvarchar(50))
returns table 
as
return(select* from KhachHang where KhachHang.TenKhachHang like N'%' + @tenKH+'%' or KhachHang.SoDienThoai like N'%' + @tenKH+'%')
go
--Function tìm kiếm khách hàng theo tên
create or alter function timkiemKHnotLike_func (@SDT nvarchar(50))
returns table 
as
return(select* from KhachHang where KhachHang.SoDienThoai = @SDT)
go


--top 3 món bán chạy
create or alter function top3MonAn_func()
returns table
as
return (select Top(3) * FROM Menu ORDER BY DaBan DESC)
go

-- top 3 khách hàng mua nhiều nhất
create or alter function top3KhachHang_func()
returns table
as
return (select Top(3) * FROM KhachHang ORDER BY DaMua DESC)
go

-- chi nhánh có doanh thu cao nhất
create or alter function topChiNhanh_func()
returns table
as
return (select Top(1) * from ChiNhanh ORDER BY DoanhThu DESC)
go
--top 3 nhân viên có số lượng bán nhiều nhất
create or alter function topNhanVien_func()
returns table
as
return (select Top(3) * from NhanVien ORDER BY SoLuongBan DESC)
go
--Function đăng nhập 
create or alter function ktDangNhap_func(@tk varchar(10),@mk varchar(20),@chucnang int) returns int
as
begin
declare @kq int
if (@chucnang=1)
	begin
		if(exists(select * from QuanLy where QuanLy.TenDangNhap=@tk and QuanLy.MatKhau=@mk))
		begin
			 set @kq=1
		end
		else set @kq=0
	end
else if (@chucnang=2)
	begin
		if(exists(select * from NhanVien where NhanVien.MaNhanVien=@tk and NhanVien.MatKhau=@mk))
		begin
			set @kq=1
		end
		else set @kq=0
	end
else if(@chucnang = -1 )
	set  @kq = 0
print @tk
return @kq
end
go
print dbo.ktDangNhap_func ('adminQuynh','1234',1)
go
--Function kiểm tra sđt
create or alter function ktSoDienThoai_func (@SDT varchar(10))
returns int 
as
begin
	declare @kq int, @dem int, @i int
	set @kq = 0
	set @dem =0
	set @i = 0
	while (@i<=LEN(@SDT))
	begin
		if(CHARINDEX(SUBSTRING(@SDT,@i,1),'0123456789')!=0)
			set @dem = @dem +1
		set @i = @i +1
	end
	if(@dem = 10)
		set @kq =1
	return @kq
end
go

-- Procedure
--thêm nhân viên
create or alter procedure themNV_proc @MaNV varchar(10),@TenNV nvarchar(50),@SDT varchar(10),@ngaySinh datetime,@MaChiNhanh varchar(10),@MatKhau varchar(20),@SoLuongBan int
as
begin
	insert into NhanVien values(@MaNV,@TenNV,@SDT,@ngaySinh,@MaChiNhanh,@MatKhau,@SoLuongBan)
end
go

-- thêm login,user cho nhân viên mới, thêm nhân viên mới vào RoleNhanVien
create or alter procedure ThemLoginNhanVien @tk varchar(10),@mk varchar(10)
as
begin
	declare @sql varchar(MAX)
	EXEC sp_addlogin @tk,@mk
	EXEC sp_adduser @tk,@tk
	set @sql= 'sp_addrolemember[RoleNhanVien],['+@tk+']' 
	EXEC sp_sqlexec @sql
end
go

-- Đăng kí nhân viên mới
Create or alter proc DangKiNV_Proc @tk varchar(10), @mk varchar(20),@tenNV nvarchar(50),@sdt nvarchar(50),@ngaySinh datetime,@machinhanh nvarchar(50),@soluongban int
as
begin
		execute ThemLoginNhanVien @tk, @mk
		execute themNV_proc @tk,@tenNV,@sdt,@ngaySinh,@machinhanh,@mk,@soluongban	
		
end
go

--Procedure Sửa Nhân Viên
create or alter procedure suaNV_proc @MaNV varchar(10),@TenNV nvarchar(50),@SDT varchar(10),@MaChiNhanh varchar(10)
as
begin
	update NhanVien set TenNhanVien=@TenNV,SDT=@SDT,MaChiNhanh=@MaChiNhanh where @MaNV=MaNhanVien
end
go


--Procedure Xóa các tài khoản login trong sql 
create or alter procedure XoaLogin @tk varchar(10)
as
begin
	EXEC sp_droplogin @tk
	EXEC sp_dropuser @tk
end
go
--Procedure Xóa Nhân Viên
create or alter procedure xoaNV_proc @MaNV varchar(10)
as
begin
	update HoaDon set HoaDon.MaNV = NULL where HoaDon.MaNV = @MaNV
	execute XoaLogin @MaNV
	delete from NhanVien where MaNhanVien=@MaNV	
end
go


--procedure đổi mật khẩu Nhân viên
create or alter procedure doiMatKhauNV_proc @tk varchar(10),@mkc varchar(20),@mkm varchar(20)
as
begin
	update NhanVien set MatKhau = @mkm where MaNhanVien = @tk
	exec sp_password @mkc,@mkm,@tk
end
go

-- procedure đổi mật khẩu quản lý
create or alter procedure doiMatKhauQL_proc @tk varchar(10),@mkc varchar(20),@mkm varchar(20)
as
begin
	update QuanLy set MatKhau = @mkm where TenDangNhap = @tk
	exec sp_password @mkc,@mkm,@tk
end
go
--Procedure Thêm món 
create or alter procedure themMon_proc @MaMon varchar(10),@TenMon nvarchar(50),@GiaTien float,@AnhMinhHoa varchar(50), @DaBan int
as
begin
	insert into Menu values(@MaMon,@TenMon,@GiaTien,@AnhMinhHoa,@DaBan)	
end
go


--Procedure Sửa món có kèm theo mã 
create or alter  procedure suaMon_proc @MaMon varchar(10),@TenMon nvarchar(50),@GiaTien float,@AnhMinhHoa varchar(50)
as
begin
	update Menu set TenMon=@TenMon,GiaTien=@GiaTien,AnhMinhHoa=@AnhMinhHoa where MaMon=@MaMon	
end
go
--Procedure Xóa món
create or alter  procedure xoaMon_proc @MaMon varchar(10)
as
begin
	delete from ChiTietHoaDon where MaMon = @MaMon
	delete from Menu where MaMon=@MaMon
end
go
--Procedure Thêm Khách Hàng 
create or alter  procedure themKH_proc @SDT varchar(10),@TenKH nvarchar(50),@DiaChi nvarchar(50), @DaMua int
as
declare @kt int
begin
	select @kt =  dbo.ktSoDienThoai_func (@SDT)
	if(exists(select * from KhachHang where SoDienThoai = @SDT))
		throw 50005,N'Số điện thoại đã tồn tại',1;
	else 
	begin 
		if(@kt =1)
			insert into KhachHang values(@SDT,@TenKH,@DiaChi,@DaMua)
		else 
			throw 50005,N'Số điện thoại không hợp lệ',1;
	end
end
go

--Procedure Sửa Khách Hàng
create or alter procedure suaKH_proc @SDT varchar(10),@TenKH nvarchar(50),@DiaChi nvarchar(50)
as
begin
	update KhachHang set TenKhachHang=@TenKH,DiaChi=@DiaChi where SoDienThoai= @SDT

end
go

--Procedure Thêm Chi Nhánh

create or alter procedure themCN_proc @MaChiNhanh varchar(10),@TenCN nvarchar(50),@DiaChi nvarchar(50), @DoanhThu float
as
begin
	insert into ChiNhanh values(@MaChiNhanh,@TenCN,@DiaChi,@DoanhThu)
end
go
--procedure sửa chi nhánh
create or alter procedure suaCN_proc @MaChiNhanh varchar(10),@TenCN nvarchar(50),@DiaChi nvarchar(50)
as
begin
	update ChiNhanh set TenChiNhanh=@TenCN,DiaChi=@DiaChi where @MaChiNhanh=MaChiNhanh
end
go

-- Procedure Thêm hóa đơn mới
create or alter procedure ThemHoaDon_proc @maHoaDon varchar(10),@SDT varchar(10),@maNV varchar(10), @maCN varchar(10),@tongGia float, @ngayBan datetime
as 
begin 
	insert into HoaDon values (@maHoaDon,@SDT,@maNV,@maCN,@ngayBan,@tongGia)
end
go

--Procedure thêm vào chi tiết hóa đơn
create or alter procedure ThemChiTietHoaDon_proc @maHD varchar(10),@maMon varchar(10), @soLuong int, @gia float
as
begin
	insert into ChiTietHoaDon values(@maHD,@maMon,@SoLuong,@Gia)
end
go
--View
create or alter View ChiNhanh_View as
select * from ChiNhanh 
go

create or alter View NhanVien_View as
select MaNhanVien,TenNhanVien,NgaySinh,MaChiNhanh,SoLuongBan from NhanVien
go

create or alter View Menu_View as
select MaMon,TenMon, GiaTien,AnhMinhHoa from Menu
go

create or alter View NhanVien_ChiNhanh_View as 
select MaNhanVien,TenNhanVien,SDT,NgaySinh,TenChiNhanh,SoLuongBan from NhanVien,ChiNhanh where NhanVien.MaChiNhanh = ChiNhanh.MaChiNhanh
go





-- Phân quyền
-- tạo login
sp_addlogin 'AdminQuynh','1234'
go
sp_addlogin 'AdminAn','1234'
go
sp_addlogin 'NV01','thien'
go
sp_addlogin 'NV02','an'
go
sp_addlogin 'NV03','vy'
go
sp_addlogin 'NV04','tuong'
go
sp_addlogin 'NV05','thu'
go
sp_addlogin 'NV06','quynh'
go
sp_addlogin 'NV07','khoi'
go

-- tạo user ứng với login 
sp_adduser 'NV01','NV01'
go
sp_adduser 'NV02','NV02'
go
sp_adduser 'NV03','NV03'
go
sp_adduser 'NV04','NV04'
go
sp_adduser 'NV05','NV05'
go
sp_adduser 'NV06','NV06'
go
sp_adduser 'NV07','NV07'
go
sp_adduser 'AdminAn','AdminAn'
go
sp_adduser 'AdminQuynh','AdminQuynh'
go
--Add quyền cho admin (toàn quyền)
sp_addsrvrolemember[AdminAn],[sysadmin]
go
sp_addsrvrolemember[AdminQuynh],[sysadmin]
go
--Tạo role nhân viên
sp_addrole [RoleNhanVien]
go
--Add nhân viên vào RoleNhanVien
sp_addrolemember [RoleNhanVien],[NV01]
go
sp_addrolemember [RoleNhanVien],[NV02]
go
sp_addrolemember [RoleNhanVien],[NV03]
go
sp_addrolemember [RoleNhanVien],[NV04]
go
sp_addrolemember [RoleNhanVien],[NV05]
go
sp_addrolemember [RoleNhanVien],[NV06]
go
sp_addrolemember [RoleNhanVien],[NV07]
go

--Add các quyền vào role của nhân viên (RoleNhanViên)
Grant select  on ChiNhanh to RoleNhanVien
Grant select, insert  on ChiTietHoaDon to RoleNhanVien
Grant select, insert  on HoaDon to RoleNhanVien
Grant select, insert  on KhachHang to RoleNhanVien 
Grant select   on Menu to RoleNhanVien 
Grant update  on NhanVien to RoleNhanVien 

--nhân viên

Grant exec on suaNV_proc to RoleNhanVien 
Grant select on pickChiNhanh_NV_func to RoleNhanVien
Grant select on pickNhanVien_func to RoleNhanVien
Grant exec on doiMatKhauNV_proc to RoleNhanVien

--Menu
Grant select on timkiemMonAn_func to RoleNhanVien 

--Chi Nhánh
Grant select on timkiemCN_func to RoleNhanVien 
--Hóa đơn
Grant exec on ThemHoaDon_proc to RoleNhanVien 		
Grant exec on autoID_func to RoleNhanVien 		
Grant exec on ThemChiTietHoaDon_proc to RoleNhanVien 	

go
--trên bảng KhachHang
Grant exec on themKH_proc to RoleNhanVien 
Grant select on timkiemKH_func to RoleNhanVien
Grant select on timkiemKHnotLike_func to RoleNhanVien


		











