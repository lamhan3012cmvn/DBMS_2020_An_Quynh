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
	MatKhau varchar(20),
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

insert into KhachHang values ('0985194510',N'Trần Ngọc Anh',N'01 Trần Hưng Đạo, Quận 1','anh',15)
insert into KhachHang values ('0947699623',N'Đặng Quốc Việt',N'02 Võ Thị Sáu, Quận 3','viet',15)
insert into KhachHang values ('0987654321',N'Phan Như Ý',N'10 Đường 12, Quận 2','nhuy',15)
insert into KhachHang values ('0912674906',N'Nguyễn Mai Hoa',N'99 Nguyễn Thị Thập, Quận 7','hoa',15)
insert into KhachHang values ('0912674006',N'Võ Văn Thiên',N'01 Đường 9, Quận 4','thien',15)
insert into KhachHang values ('0912674001',N'Nguyễn Gia Bảo',N'02 Đường 10, Quận 5','bao',15)

insert into Menu values ('BINGSU01','Special BingSu',null,55000,null,'5')
insert into Menu values ('BINGSU02','Cheese Cake BingSu',null,50000,null,'10')
insert into Menu values ('BINGSU03','Passion Cheese BingSu',null,45000,null,'4')
insert into Menu values ('BINGSU04','Choco BingSu',null,40000,null,'5')
insert into Menu values ('BINGSU05','Oreo BingSu',null,45000,null,'7')
insert into Menu values ('BINGSU06','Mango BingSo',null,45000,null,'10')
insert into Menu values ('BINGSU07','Strawberry BingSu',null,50000,null,'8')
insert into Menu values ('BINGSU08','Green Tea BingSu',null,40000,null,'2')
insert into Menu values ('BINGSU09','Peach BingSu',null,45000,null,'1')
insert into Menu values ('BINGSU10','Water Melon BingSu',null,40000,null,'6')

go
create or alter trigger auto_MaChiNhanh on ChiNhanh
for insert 
as
declare @i int, @max int, @machinhanh int
set @i =0 
select @max = Max(MaChiNhanh) from ChiNhanh
select @machinhanh = MaChiNhanh from inserted
while (@i <= @max)
	begin
		if(not exists (select * from ChiNhanh where MaChiNhanh = @i))
		begin
			update ChiNhanh set MaChiNhanh = @i where MaChiNhanh = @machinhanh
			return

		end
		else 
			if(@i <> @max)
				set @i =@i+1
			else 
			begin 
				update ChiNhanh set MaChiNhanh = @max +1 where MaChiNhanh = @machinhanh
				return
			end
	end

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
--tìm kiếm theo tên nhân viên

create function timkiemNV_func (@tenNV nvarchar(50))
returns table 
as
return(select* from NhanVien where NhanVien.TenNhanVien like N'%' + @tenNV+'%')
go 

--tìm kiếm món ăn
create function timkiemMonAn_func (@tenMonAn nvarchar(50))
returns table as
return(select* from Menu where Menu.TenMon like N'%' + @tenMonAn)
go

-- tìm kiếm chi nhánh
create function timkiemCN_func (@tenCN nvarchar(50))
returns table 
as
return(select* from ChiNhanh where ChiNhanh.TenChiNhanh like N'%' + @tenCN+'%')
go

--tìm kiếm khách hàng
create function timkiemKH_func (@tenKH nvarchar(50))
returns table 
as
return(select* from KhachHang where KhachHang.TenKhachHang like N'%' + @tenKH+'%')
go

--top 3 món bán chạy
create function top3MonAn_func()
returns table
as
return (select Top(3) * FROM Menu ORDER BY DaBan DESC)
go

-- top 3 khách hàng mua nhiều nhất
create function top3KhachHang_func()
returns table
as
return (select Top(3) * FROM KhachHang ORDER BY DaMua DESC)
go

-- chi nhánh có doanh thu cao nhất
create function topChiNhanh_func()
returns table
as
return (select Top(1) * from ChiNhanh)
go

-- đăng nhập


-- Procedure
--thêm nhân viên
create procedure themNV_proc @MaNV varchar(10),@TenNV nvarchar(50),@SDT varchar(10),@MaChiNhanh varchar(10),@MatKhau varchar(20),@SoLuongBan int
as
begin
	insert into NhanVien values(@MaNV,@TenNV,@SDT,@MaChiNhanh,@MatKhau,@SoLuongBan)
end
go
--Procedure Sửa Nhân Viên
create procedure suaNV_proc @MaNV varchar(10),@TenNV nvarchar(50),@SDT varchar(10),@MaChiNhanh varchar(10),@MatKhau varchar(20),@SoLuongBan int
as
begin
	update NhanVien set TenNhanVien=@TenNV,SDT=@SDT,MaChiNhanh=@MaChiNhanh,MatKhau=@MatKhau,SoLuongBan=@SoLuongBan where @MaNV=MaNhanVien
end
go
--Procedure Xóa Nhân Viên
create procedure xoaNV_proc @MaNV varchar(10)
as
begin
	delete from NhanVien where MaNhanVien=@MaNV
end
go
--Procedure Thêm món 
create procedure themMon_proc @MaMon varchar(10),@TenMon nvarchar(50),@GiaTien float,@AnhMinhHoa varchar(50), @DaBan int
as
begin
	
	insert into Menu values(@MaMon,@TenMon,@GiaTien,@AnhMinhHoa,@DaBan)	
end
go

--Procedure Sửa món có kèm theo mã chi nhánh có kết hợp transaction
create procedure suaMon_proc @MaMon varchar(10),@TenMon nvarchar(50),@GiaTien float,@AnhMinhHoa varchar(50), @DaBan int
as
begin
	Set XACT_ABORT ON
	begin TRANSACTION
	update Menu set MaMon=@MaMon,TenMon=@TenMon,GiaTien=@GiaTien,AnhMinhHoa=@AnhMinhHoa,DaBan=@DaBan where MaMon=@MaMon	
	commit
end
go

--Procedure Thêm Khách Hàng 
create procedure themKH_proc @SDT varchar(10),@TenKH nvarchar(50),@DiaChi nvarchar(50),@MatKhau varchar(20), @DaMua int
as
begin
	insert into KhachHang values(@SDT,@TenKH,@DiaChi,@MatKhau,@DaMua)
end
go

--Procedure Sửa Khách Hàng
create procedure suaKH_proc @SDT varchar(10),@TenKH nvarchar(50),@DiaChi nvarchar(50),@MatKhau varchar(20), @DaMua int
as
begin
	update KhachHang set TenKhachHang=@TenKH,DiaChi=@DiaChi,MatKhau=@MatKhau,DaMua=@DaMua where @SDT=SoDienThoai
end
go

--Procedure Xóa Khách hàng
create procedure xoaKH_proc @SDT varchar(20)
as
begin
	delete from KhachHang where SoDienThoai=@SDT
end
go
--Procedure THêm Chi Nhánh
create procedure themCN_proc @MaChiNhanh varchar(10),@TenCN nvarchar(50),@DiaChi nvarchar(50)
as
begin
	insert into ChiNhanh values(@MaChiNhanh,@TenCN,@DiaChi,0)
end
go
--procedure sửa chi nhánh
create procedure suaCN_proc @MaChiNhanh varchar(10),@TenCN nvarchar(50),@DiaChi nvarchar(50)
as
begin
	update ChiNhanh set TenChiNhanh=@TenCN,DiaChi=@DiaChi where @MaChiNhanh=MaChiNhanh
end
go
--Procedure Xóa chi nhánh
create procedure xoaCN_proc @MaCN varchar(10)
as
begin
	delete from ChiNhanh where MaChiNhanh=@MaCN
end
go




