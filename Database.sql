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

create table Menu_ChiNhanh
(
	MaChiNhanh varchar(10),
	MaMon varchar(10),
	primary key (MaChiNhanh, MaMon),
	constraint FK_Menu_ChiNhanh_ChiNhanh foreign key (MaChiNhanh) references ChiNhanh(MaChiNhanh),
	constraint FK_Menu_ChiNhanh_Menu foreign key (MaMon) references Menu(MaMon)
)

create table TamOrder 
(
	ID_TamOrder int,
	SDT_KhachHang varchar(10),
	MaMon varchar(10),
	SoLuong int,
	Gia float,
	MaNV varchar(10),
	MaCN varchar(10),
	primary key (ID_TamOrder),
	constraint FK_TamOrder_KhachHang foreign key (SDT_KhachHang) references KhachHang(SoDienThoai),
	constraint FK_TamOrder_Menu foreign key (MaMon) references Menu(MaMon),
	constraint FK_TamOrder_NhanVien foreign key (MaNV) references NhanVien(MaNhanVien),
	constraint FK_TamOrder_ChiNhanh foreign key (MaCN) references ChiNhanh(MaChiNhanh),
)

create table HoaDon
(
	MaHoaDon int,
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
	MaHD int,
	MaMon varchar(10),
	SoLuong int,
	Gia float,
	primary key (MaHD,MaMon),
	constraint FK_ChiTietHoaDon_HoaDon foreign key (MaHD) references HoaDon(MaHoaDon),
	constraint FK_ChiTietHoaDon_Menu foreign key (MaMon) references Menu(MaMon)
)


insert into QuanLy values ('AdminQuynh','1234')
insert into QuanLy values ('AdminAn','1234')

insert into ChiNhanh values ('CN01',N'Chi Nhánh 1',N'Quận 1',1000000)
insert into ChiNhanh values ('CN02',N'Chi Nhánh 2',N'Quận 2',600000)
insert into ChiNhanh values ('CN03',N'Chi Nhánh 3',N'Quận 3',300000)
insert into ChiNhanh values ('CN04',N'Chi Nhánh 4',N'Quận 4',500000)
insert into ChiNhanh values ('CN05',N'Chi Nhánh 5',N'Quận 5',450000)
insert into ChiNhanh values ('CN06',N'Chi Nhánh 6',N'Quận 6',800000)
insert into ChiNhanh values ('CN07',N'Chi Nhánh 7',N'Quận 7',700000)

insert into  NhanVien  values ('NV01',N'Nguyễn Cước Thiên','0984728234','01-10-2000','CN01','thien',null)
insert into  NhanVien values ('NV02',N'Lâm Hoàng An','0912348234','2000-01-01','CN02','an',null)
insert into  NhanVien values ('NV03',N'Tu Ngọc Yến Vy','0984724567','2000-01-01','CN03','vy',null)
insert into  NhanVien values ('NV04',N'Nguyễn Hữu Tường','0984325790','2000-01-01','CN04','tuong',null)
insert into  NhanVien values ('NV05',N'Đặng Nguyễn Hoài Thư','0984712367','2000-01-01','CN05','thu',null)
insert into  NhanVien values ('NV06',N'Nguyễn Thị Như Quỳnh','0985194510','2000-01-01','CN06','quynh',null)
insert into  NhanVien values ('NV07',N'Phạm Duy Khôi','0998728678','2000-01-01','CN07','khoi',null)

insert into KhachHang values ('0985194510',N'Trần Ngọc Anh',N'01 Trần Hưng Đạo, Quận 1',15)
insert into KhachHang values ('0947699623',N'Đặng Quốc Việt',N'02 Võ Thị Sáu, Quận 3',15)
insert into KhachHang values ('0987654321',N'Phan Như Ý',N'10 Đường 12, Quận 2',15)
insert into KhachHang values ('0912674906',N'Nguyễn Mai Hoa',N'99 Nguyễn Thị Thập, Quận 7',15)
insert into KhachHang values ('0912674006',N'Võ Văn Thiên',N'01 Đường 9, Quận 4',15)
insert into KhachHang values ('0912674001',N'Nguyễn Gia Bảo',N'02 Đường 10, Quận 5',15)

insert into Menu values ('BINGSU01','Special BingSu',55000,null,'5')
insert into Menu values ('BINGSU02','Cheese Cake BingSu',50000,null,'10')
insert into Menu values ('BINGSU03','Passion Cheese BingSu',45000,null,'4')
insert into Menu values ('BINGSU04','Choco BingSu',40000,null,'5')
insert into Menu values ('BINGSU05','Oreo BingSu',45000,null,'7')
insert into Menu values ('BINGSU06','Mango BingSo',45000,null,'10')
insert into Menu values ('BINGSU07','Strawberry BingSu',50000,null,'8')
insert into Menu values ('BINGSU08','Green Tea BingSu',40000,null,'2')
insert into Menu values ('BINGSU09','Peach BingSu',45000,null,'1')
insert into Menu values ('BINGSU10','Black Sesame BingSu',40000,null,'6')



--trigger 
go
create or alter trigger SoLuongMuaBan on HoaDon
after insert as
declare @chinhanh int, @khachhang nvarchar(50), @tonggia float
set @tonggia = (select inserted.TongGia from inserted)
select @chinhanh = inserted.MaChiNhanh, @khachhang= inserted.SoDT_KhachHang from inserted
begin 
	update ChiNhanh set DoanhThu = DoanhThu + @tonggia where ChiNhanh.MaChiNhanh = @chinhanh
	update KhachHang set KhachHang.DaMua = KhachHang.DaMua + @tonggia*0.1 where KhachHang.SoDienThoai = @khachhang
end

go 
create or alter trigger SoLuongDaBan on ChiTietHoaDon
after insert as
declare @mon int, @soluong int
select @mon =inserted.MaMon, @soluong = inserted.SoLuong from inserted
begin 
	update Menu set Menu.DaBan = Menu.DaBan + @soluong where Menu.MaMon = @mon
end
go
--function 
-- lấy NV khi biết mã
create function pickNhanVien_func (@MaNV varchar(10)) returns table
as
	return select * from NhanVien where NhanVien.MaNhanVien=@MaNV
go
--lấy 1 Mon khi biết mã
create or alter function pickMon_func(@MaMon varchar(10)) returns table
as
return (select * from Menu where MaMon = @MaMon)
go
--lấy 1 KH khi biết mã
create or alter function pickCustomer_func(@maKH varchar(10)) returns table
as
return (select * from KhachHang where SoDienThoai = @maKH)
go

-- lấy 1 chi nhanh khi biết mã
create or alter function pickBranch_func(@maCN varchar(10)) returns table
as
return (select * from ChiNhanh where MaChiNhanh = @maCN)
go
--tìm kiếm theo tên nhân viên

create or alter function timkiemNV_func (@tenNV nvarchar(50))
returns table 
as
return(select* from NhanVien where NhanVien.TenNhanVien like N'%' + @tenNV+'%')
go 

--tìm kiếm món ăn
create or alter function timkiemMonAn_func (@tenMonAn nvarchar(50))
returns table as
return(select* from Menu where Menu.TenMon like N'%' + @tenMonAn)
go

-- tìm kiếm chi nhánh
create or alter function timkiemCN_func (@tenCN nvarchar(50))
returns table 
as
return(select* from ChiNhanh where ChiNhanh.TenChiNhanh like N'%' + @tenCN+'%')
go

--tìm kiếm khách hàng
create or alter function timkiemKH_func (@tenKH nvarchar(50))
returns table 
as
return(select* from KhachHang where KhachHang.TenKhachHang like N'%' + @tenKH+'%')
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

-- đăng nhập 
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
declare @sql varchar(10)
EXEC sp_addlogin @tk,@mk
EXEC sp_adduser @tk,@tk
set @sql= 'sp_addrolemember[RoleNhanVien],['+@tk+']' 
EXEC sp_sqlexec @sql
End
go

-- Đăng kí nhân viên mới
Create or alter proc DangKiNV_Proc @tk varchar(10), @mk varchar(20),@tenNV nvarchar(50),@sdt nvarchar(50),@ngaySinh datetime,@machinhanh nvarchar(50),@soluongban int
as
begin
	
		execute themNV_proc @tk,@tenNV,@sdt,@ngaySinh,@machinhanh,@mk,@soluongban	
		execute ThemLoginNhanVien @tk, @mk
end
go
--Procedure Sửa Nhân Viên
create or alter procedure suaNV_proc @MaNV varchar(10),@TenNV nvarchar(50),@SDT varchar(10),@MaChiNhanh varchar(10),@MatKhau varchar(20)
as
begin
	update NhanVien set TenNhanVien=@TenNV,SDT=@SDT,MaChiNhanh=@MaChiNhanh,MatKhau=@MatKhau where @MaNV=MaNhanVien
end
go

--Procedure Xóa các tài khoản login trong sql 
create procedure XoaLogin @tk varchar(10)
as
begin
EXEC sp_droplogin @tk
EXEC sp_dropuser @tk
end
go
--Procedure Xóa Nhân Viên
create procedure xoaNV_proc @MaNV varchar(10)
as
begin
	execute XoaLogin @MaNV
	delete from NhanVien where MaNhanVien=@MaNV

end
go
--Procedure Thêm món 
create or alter procedure themMon_proc @MaMon varchar(10),@TenMon nvarchar(50),@GiaTien float,@AnhMinhHoa varchar(50), @DaBan int
as
begin
	
	insert into Menu values(@MaMon,@TenMon,@GiaTien,@AnhMinhHoa,@DaBan)	
end
go

--Procedure Sửa món có kèm theo mã chi nhánh có kết hợp transaction
create or alter  procedure suaMon_proc @MaMon varchar(10),@TenMon nvarchar(50),@GiaTien float,@AnhMinhHoa varchar(50)
as
begin
	Set XACT_ABORT ON
	begin TRANSACTION
	update Menu set TenMon=@TenMon,GiaTien=@GiaTien,AnhMinhHoa=@AnhMinhHoa where MaMon=@MaMon	
	commit
end
go

--Procedure Thêm Khách Hàng 
create or alter  procedure themKH_proc @SDT varchar(10),@TenKH nvarchar(50),@DiaChi nvarchar(50), @DaMua int
as
begin
	insert into KhachHang values(@SDT,@TenKH,@DiaChi,@DaMua)
end
go


--Procedure Sửa Khách Hàng
create or alter procedure suaKH_proc @SDT varchar(10),@TenKH nvarchar(50),@DiaChi nvarchar(50)
as
begin
	update KhachHang set TenKhachHang=@TenKH,DiaChi=@DiaChi where @SDT=SoDienThoai
end
go

--Procedure Xóa Khách hàng
create or alter  procedure xoaKH_proc @SDT varchar(20)
as
begin
	delete from KhachHang where SoDienThoai=@SDT
end
go
--Procedure THêm Chi Nhánh
create or alter procedure themCN_proc @MaChiNhanh varchar(10),@TenCN nvarchar(50),@DiaChi nvarchar(50), @DoanhThu float
as
begin
	insert into ChiNhanh values(@MaChiNhanh,@TenCN,@DiaChi,@DoanhThu)
end
go
--procedure sửa chi nhánh
create or alter procedure suaCN_proc @MaChiNhanh varchar(10),@TenCN nvarchar(50),@DiaChi nvarchar(50), @DoanhThu float
as
begin
	update ChiNhanh set TenChiNhanh=@TenCN,DiaChi=@DiaChi, DoanhThu = @DoanhThu where @MaChiNhanh=MaChiNhanh
end
go
--Procedure Xóa chi nhánh
create or alter procedure xoaCN_proc @MaCN varchar(10)
as
begin
	delete from ChiNhanh where MaChiNhanh=@MaCN
end
go

--View
create View ChiNhanh_View as
select * from ChiNhanh 
go



-- Phân quyền
-- tạo login
sp_addlogin 'AdminQuynh','1234'
go
sp_addlogin 'AdminAn','1234'
go
sp_addlogin 'NV1','1'
go
sp_addlogin 'NV2','1'
go
sp_addlogin 'NV3','1'
go
sp_addlogin 'NV4','1'
go
sp_addlogin 'NV5','1'
go
sp_addlogin 'NV6','1'
go
sp_addlogin 'NV7','1'
go

-- tạo user ứng với login 
sp_adduser 'NV1','NV1'
go
sp_adduser 'NV2','NV2'
go
sp_adduser 'NV3','NV3'
go
sp_adduser 'NV4','NV4'
go
sp_adduser 'NV5','NV5'
go
sp_adduser 'NV6','NV6'
go
sp_adduser 'NV7','NV7'
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
sp_addrolemember [RoleNhanVien],[NV1]
go
sp_addrolemember [RoleNhanVien],[NV2]
go
sp_addrolemember [RoleNhanVien],[NV3]
go
sp_addrolemember [RoleNhanVien],[NV4]
go
sp_addrolemember [RoleNhanVien],[NV5]
go
sp_addrolemember [RoleNhanVien],[NV6]
go
sp_addrolemember [RoleNhanVien],[NV7]
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


--Menu
Grant select on timkiemMonAn_func to RoleNhanVien 

--Chi Nhánh
Grant select on timkiemCN_func to RoleNhanVien 
--Hóa đơn
Grant exec on ThemHoaDon_proce to RoleNhanVien 		
Grant select on LayHoaDonTruoc_func to RoleNhanVien 		
Grant exec on ThemChiTietHD_proce to RoleNhanVien 	











