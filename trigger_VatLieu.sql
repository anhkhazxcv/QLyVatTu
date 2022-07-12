create proc them_DanhMuc
@TenDanhMuc nvarchar(255)
as 

begin
INSERT INTO [dbo].[DanhMucTaiSan]
           ([TenDanhMuc])
     VALUES
             ( @TenDanhMuc)

end

exec them_DanhMuc N'Laptop'
exec them_DanhMuc N'ban sat'

--================================

create proc sua_DanhMuc
@IDDanhMucTaiSan int,
@TenDanhMuc nvarchar(255)

as

begin 
UPDATE [dbo].[DanhMucTaiSan]
   SET [TenDanhMuc] = @TenDanhMuc  
 WHERE [IDDanhMucTaiSan] = @IDDanhMucTaiSan

end
--==========================
--tự động thêm ngày và người thêm thi thêm nhân viên

create trigger trigger_insert_nhanvien
on NhanVien
for insert
as
update NhanVien set  NgayThem = GETDATE(), NguoiThem = 'Kha' where IDNV=(select IDNV from inserted)
drop trigger trigger_insert_nhanvien

--==================================

insert into NhanVien(HoTen, GioiTinh, NgaySinh, DiaChi, SDT, CMND)
values (N'Kha bo cua hung', N'Nam', '2000-12-06', N'Ninh Binh', 0123456789, N'22222')
select * from NhanVien

insert into PhongBan
values (N'Phong Hop 1'), ('Phong Lam Viec 1')


--=======================================

create trigger trigger_update_nhanvien 
on NhanVien
for update
as 
update NhanVien 
set NgaySua = GETDATE() where IDNV = (select IDNV from inserted)

--======================

create trigger trigger_insert_quanly
on QuanLy
for insert
as
update QuanLy set  NgayThem = GETDATE(), NguoiThem = 'Kha' where IDQL=(select IDQL from inserted)

--=====================

create trigger trigger_insert_phieunhap
on PhieuNhapTaiSan
for insert
as
update PhieuNhapTaiSan set  NgayNhap = GETDATE() where IDPhieuNhap=(select IDPhieuNhap from inserted)

--===========================

create trigger trigger_insert_phieuthanhly
on PhieuThanhLyTaiSan
for insert
as
update PhieuThanhLyTaiSan set  NgayThanhLy = GETDATE() where IDPhieuThanhLy=(select IDPhieuThanhLy from inserted)

--===========================


create trigger trigger_insert_phieuthuhoi
on PhieuThuHoiTaiSan
for insert
as
update PhieuThuHoiTaiSan set  NgayThuHoi = GETDATE() where IDPhieuThuHoi=(select IDPhieuThuHoi from inserted)

--==============================

create trigger trigger_insert_phieuxuat
on PhieuXuatTaiSan
for insert
as
update PhieuXuatTaiSan set  NgayXuat = GETDATE() where IDPhieuXuat=(select IDPhieuXuat from inserted)

