------tao proc Chuc nang
drop proc insert_ChucNang
alter  proc insert_ChucNang
@TenChucNang nvarchar(255),
@NguoiThem nvarchar(255)
as begin
insert into PQ_ChucNang(TenChucNang
           ,NguoiThem
           )
     VALUES
           (@TenChucNang ,
			@NguoiThem
			)
end

exec insert_ChucNang 'XoaPhongBan','Nguyen Van Kha' 
---
alter  proc delete_ChucNang 
@id int
as
begin
delete from TK_ChucNang where @id = ID
end

exec delete_ChucNang 5
---
alter  proc get_ChucNang
as begin
select * from TK_ChucNang
end 

exec get_ChucNang

alter  proc update_ChucNang
@id int,
@TenChucNang nvarchar(255),
@NguoiSua nvarchar(255)
as 
begin
update TK_ChucNang set TenChucNang=@TenChucNang , NguoiSua = @NguoiSua   where ID = @id
end


------ tao proc kho tai san
alter proc insert_Kho
@TenKho nvarchar(255),
@NguoiThem nvarchar(255)
as 
begin
insert into TK_KhoTaiSan(TenKho, NguoiThem,NgayThem,TrangThai) values (@TenKho,@NguoiThem,GETDATE(),'True')
end 

alter proc delete_Kho
@id int
as 
begin
delete from TK_KhoTaiSan where IDKho = @id
end

alter proc get_Kho
as 
begin
select * from TK_KhoTaiSan 
end
---
alter proc update_kho
@id int,
@tenKho nvarchar(255),
@nguoiSua nvarchar(255)
as
begin
update TK_KhoTaiSan set TenKho = @tenKho, NguoiSua = @nguoiSua where IDKho = @id 
end

------=======Loai tai san
alter proc insert_loaiTaiSan
@tenLoaiTaiSan nvarchar(255),
@idparent int,
@nguoiThem nvarchar(255)
as
begin
 insert into TK_LoaiTaiSan(TenLoai, IDParent, NguoiThem, NgayThem, TrangThai) values (@tenLoaiTaiSan, @idparent,@nguoiThem,GETDATE(), 'True')
end

alter proc delete_LoaiTaiSan
@id int
as
begin
delete from TK_LoaiTaiSan where ID = @id 
end

alter proc get_LoaiTaiSan
as
begin
select * from TK_LoaiTaiSan
end

alter proc update_LoaiTaiSan
@id int,
@tenLoaiTaiSan nvarchar(255),
@idparent int,
@nguoiSua nvarchar(255)
as
begin
update TK_LoaiTaiSan set TenLoai = @tenLoaiTaiSan, IDParent = @idparent, NguoiSua = @nguoiSua,NgaySua = GETDATE() where ID = @id  
end

----------------=============== Nhan Hieu
alter proc insert_NhanHieu
@tenNhanHieu nvarchar(255),
@nguoiThem nvarchar(255)
as
begin
insert into TK_NhanHieu(TenNhanHieu,NguoiThem) values (@tenNhanHieu,@nguoiThem)
end

alter proc delete_NhanHieu
@id int
as
begin
delete from TK_NhanHieu where ID = @id
end

alter proc get_NhanHieu
as
begin
select * from TK_NhanHieu
end

alter proc get_NhanHieuid
@id int
as
begin
select * from TK_NhanHieu where ID = @id
end

alter proc update_NhanHieu
@id int,
@tenNhanHieu nvarchar(255),
@nguoiSua nvarchar(255)
as 
begin
update TK_NhanHieu set TenNhanHieu = @tenNhanHieu, NguoiSua = @nguoiSua, NgaySua = GETDATE() where ID = @id
end

------========== proc nhan vien

alter proc insert_Nhanvien
@hoten nvarchar(255),
@gioitinh nvarchar(20),
@ngaysinh date,
@diachi nvarchar(255),
@sdt varchar(10),
@CMND int,
@IDPhongBan int,
@nguoithem nvarchar(255),
@IDNhomquyen int
as
begin
insert into TK_NhanVien(HoTen, GioiTinh,NgaySinh,DiaChi,SDT,CMND,IDPhongBan,NguoiThem,IDNhomQuyen)
values (@hoten, @gioitinh,@ngaysinh,@diachi, @sdt,@CMND, @IDPhongBan, @nguoithem, @IDNhomquyen )
end

alter proc get_nhanVien
as
begin
select * from TK_NhanVien where TrangThai = 'false'
end

exec get_nhanVien

alter proc get_NhanVienid
@id int
as
begin
select * from TK_NhanVien where IDNV = @id
end

alter proc update_NhanVien
@id int,
@hoten nvarchar(255),
@gioitinh nvarchar(20),
@ngaysinh date,
@diachi nvarchar(255),
@sdt varchar(10),
@CMND int,
@IDPhongBan int,
@IDNhomquyen int,
@nguoiSua nvarchar(255),
@trangthai bit
as
begin
update TK_NhanVien set HoTen = @hoten, GioiTinh = @gioitinh, NgaySinh = @ngaysinh, DiaChi= @diachi, SDT = @sdt,
CMND = @CMND, IDPhongBan= @IDPhongBan, NguoiSua = @nguoiSua,IDNhomQuyen = @IDNhomquyen, NgaySua= GETDATE(),TrangThai=@trangthai where IDNV=@id
end

alter proc delete_NhanVien
@id int
as
begin
update TK_NhanVien set TrangThai ='true' where IDNV = @id
end

exec delete_NhanVien 1
------ - proc nhom quyen
alter proc insert_NhomQuyen
@tenNhom nvarchar(255),
@nguoiThem nvarchar(255)
as
begin
insert into PQ_NhomQuyen(TenNhomQuyen, NguoiThem, NgayThem,TrangThai) values (@tenNhom, @nguoiThem, getdate(), 'True')
end

alter proc get_NhomQuyen
as 
begin
select * from PQ_NhomQuyen
end

alter proc update_NhomQuyen
@id int,
@tenNhom nvarchar(255),
@nguoiSua nvarchar(255)
as
begin
update PQ_NhomQuyen set TenNhomQuyen = @tenNhom , NguoiSua = @nguoiSua, NgaySua= GETDATE() where ID = @id
end

alter proc get_NhomQuyenid
@id int
as
begin
select * from PQ_NhomQuyen where ID = @id
end

--------=====proc nhom quyen === chuc nang

alter proc insert_NQ_CN
@id_nq int,
@id_cn int,
@nguoithem nvarchar(255)
as
begin
insert into PQ_NhomQuyen_ChucNang(ID_CN,ID_NQ,NguoiThem,NgayThem,TrangThai) values (@id_cn,@id_nq,@nguoithem, GETDATE(), 'True')
end

create proc get_NQ_CN
as 
begin
select PQ_ChucNang.TenChucNang,PQ_NhomQuyen.TenNhomQuyen
from PQ_NhomQuyen_ChucNang
inner join PQ_ChucNang on PQ_ChucNang.ID = PQ_NhomQuyen_ChucNang.ID_CN
inner join PQ_NhomQuyen on PQ_NhomQuyen.ID = PQ_NhomQuyen_ChucNang.ID_NQ
end

exec get_NQ_CN

create proc get_NQ_TK
as
begin
select PQ_NhomQuyen.TenNhomQuyen, PQ_TaiKhoan.TenDangNhap
from PQ_NhomQuyen_TaiKhoan
inner join PQ_NhomQuyen on PQ_NhomQuyen.ID = PQ_NhomQuyen_TaiKhoan.ID_NQ
inner join PQ_TaiKhoan on PQ_TaiKhoan.ID = PQ_NhomQuyen_TaiKhoan.ID_TK
end

exec get_NQ_TK

alter proc update_NQ_CN
@id_nq int,
@id_cn int,
@nguoiSua nvarchar(255)
as
begin
update PQ_NhomQuyen_ChucNang set ID_CN = @id_cn, ID_NQ = @id_nq, NguoiSua = @nguoiSua, NgaySua = GETDATE()
end

----------===================proc nhom quyen tai khoan
alter proc insert_NQ_TK
@idNQ int,
@idTK int,
@nguoithem nvarchar(255)
as
begin
insert into PQ_NhomQuyen_TaiKhoan(ID_NQ,ID_TK,NguoiThem) values (@idNQ,@idTK,@nguoithem)
end

exec insert_NQ_TK 2,3,N'Nguyen Van Kha' 


--------=======proc phieu nhap tai san
alter proc insert_PhieuNhapTS
@nguoigiaohang nvarchar(255),
@idkho int,
@idnguoithem int,
@soluong int,
@tentaisan nvarchar(255),
@dongia int,
@nguoithem nvarchar(255)
as
begin
insert into QL_PhieuNhapTS( NguoiGiaoHang, IDnguoiThem,Soluong,TenTaiSan,DonGia,NguoiThem)
values (@nguoigiaohang,@idnguoithem,@soluong, @tentaisan,@dongia,@nguoithem)
end

alter proc get_PhieuNhapTS
as
begin
select * from QL_PhieuNhapTS
end

alter proc get_PhieuNhapTSid
@id int
as
begin
select * from QL_PhieuNhapTS where ID = @id
end

alter proc update_PhieuNhapTS
@id int,
@nguoigiaohang nvarchar(255),
@idkho int,
@idnguoithem int,
@soluong int,
@tentaisan nvarchar(255),
@dongia int,
@nguoithem nvarchar(255)
as
begin
update QL_PhieuNhapTS set NguoiGiaoHang = @nguoigiaohang, IDKho = @idkho, IDnguoiThem=@idnguoithem,
Soluong = @soluong, TenTaiSan = @tentaisan, DonGia = @dongia , NguoiThem = @nguoithem, NgaySua = getdate() where ID = @id
end

---------============= proc phieu thanh ly
alter proc insert_PhieuThanhLy
@idnguoixuat int,
@tennguoimua nvarchar(255),
@nguoithem nvarchar(255)
as
begin
insert into QL_PhieuThanhLyTS(IDNguoiXuat,TenNguoiMua,NguoiThem ) values (@idnguoixuat,@tennguoimua,@nguoithem)
end

alter proc get_PhieuThanhLy
as
begin
select * from QL_PhieuThanhLyTS
end

create proc get_QL_PhieuThanhLyTSid
@id int
as
begin
select * from QL_PhieuThanhLyTS where id = @id
end

alter proc update_PhieuThanhLy
@idnguoixuat int,
@tennguoimua nvarchar(255),
@nguoithem nvarchar(255),
@trangthai bit
as
begin
update QL_PhieuThanhLyTS set IDNguoiXuat = @idnguoixuat, TenNguoiMua = @tennguoimua, NguoiThem = @nguoithem, TrangThai = @trangthai
end

---=============proc phieu thu hoi
alter proc insert_PhieuThuHoi
@idnguoithuhoi int,
@idnguoisudung int,
@idphongban int,
@nguoithem nvarchar(255)
as 
begin
insert into QL_PhieuThuHoiTS(IDNguoiThuHoi,IDNguoiSuDung,IDPhongBan,NguoiThem) values
(@idnguoithuhoi,@idnguoisudung,@idphongban,@nguoithem)
end

alter proc get_PhieuThuHoi 
as
begin
select * from QL_PhieuThuHoiTS 
end
-------------==== proc phieu xuat
create proc insert_PhieuXuat
@idnguoixuat int,
@idnguoinhan int,
@idphongban int,
@nguoithem nvarchar(255)
as
begin
insert into QL_PhieuXuatTS(IDNguoiXuat, IDNguoiNhan, IDPhongBan,NguoiThem )
values(@idnguoixuat, @idnguoinhan, @idphongban, @nguoithem)
end


alter proc get_Phieuxuat
as
begin
select * from QL_PhieuXuatTS
end

-----================proc phong ban
alter proc insert_PhongBan
@tenphongban nvarchar(255),
@nguoithem nvarchar(255)
as
begin
insert into TK_PhongBan(TenPhongBan,NguoiThem) values (@tenphongban,@nguoithem)
end

alter proc get_PhongBan
as
begin
select * from TK_PhongBan where TrangThai='false'
end

create proc get_PhongBanid 
@id int
as
begin 
select * from TK_PhongBan where IDPhongBan=@id
end

create proc update_PhongBan
@id int,
@tenphongban nvarchar(255),
@nguoisua nvarchar(255),
@trangthai bit
as
begin
update TK_PhongBan set TenPhongBan=@tenphongban, NguoiSua=@nguoisua, TrangThai=@trangthai where IDPhongBan = @id
end



create proc delete_PhongBan 
@id int
as
begin
update TK_PhongBan set TrangThai = 'true' where IDPhongBan = @id
end
-------=======================proc tai khoan
alter  proc insert_TaiKhoan
@tendangnhap nvarchar(255),
@matkhau nvarchar(255),
@nguoithem nvarchar(255)
as
begin
insert into PQ_TaiKhoan(TenDangNhap,MatKhau,NguoiThem,NgayThem) values(@tendangnhap,@matkhau,@nguoithem,GETDATE());

--select top 1 * from TaiKhoan
end

alter proc get_TaiKhoan
as
begin
select * from PQ_TaiKhoan where TrangThai='false'
end


alter proc get_DangNhap
@tendangnhap varchar(255),
@matkhau varchar(255)
as
begin
select TenDangNhap,MatKhau from PQ_TaiKhoan where TenDangNhap = @tendangnhap and MatKhau = @matkhau
end

exec get_DangNhap 'nguyenkha','123456'

alter proc delete_TaiKhoan
@id int
as
begin
update PQ_TaiKhoan set TrangThai='true' where ID = @id
end

exec delete_TaiKhoan 1

alter proc get_TaiKhoanid
@id int
as
begin
SELECT * FROM PQ_TaiKhoan WHERE ID = @id
end

alter proc update_TaiKhoan
@id int,
@tendangnhap nvarchar(255),
@matkhau nvarchar(255),
@nguoisua nvarchar(255)
as
begin
update PQ_TaiKhoan set  TenDangNhap = @TenDangNhap,MatKhau = @MatKhau,NguoiSua = @nguoisua where ID = @id
end


---=====================proc tai san
alter proc insert_TaiSan
@tentaisan nvarchar(255),
@mota nvarchar(255),
@soluong int,
@idloaitaisan int,
@idkho int,
@idnhanhieu int,
@nguoithem nvarchar(255)
as
begin
insert into TK_TaiSan(TenTaiSan,Mota,SoLuong,IDLoaiTaiSan,IDKho,IDNhanHieu,NguoiThem,NgayThem) 
values (@tentaisan,@mota,@soluong,@idloaitaisan,@idkho,@idnhanhieu,@nguoithem,GETDATE())
end

alter proc get_TaiSan
as
begin
select * from PQ_TaiKhoan
end

---===============proc chi tiet phieu thanh ly

alter proc insert_chiTietThanhLy
@idphieu int,
@idtaisan int,
@tentaisan nvarchar(255),
@soluong int,
@dongia int,
@nguoithem nvarchar(255)
as
begin
insert into QL_PhieuThanhLyTS_ChiTiet(IDPhieuThanhLy,IDTaiSan,TenTaiSan,SoLuong,DonGia,NguoiThem,NgayThem)
values(@idphieu,@idtaisan,@tentaisan,@soluong,@dongia,@nguoithem,GETDATE())
end

alter proc get_chiTietThanhLy
as
begin
select * from QL_PhieuThanhLyTS_ChiTiet
end

---============proc chi tiet phieu xuat
alter proc insert_chiTietXuat
@idphieu int,
@idtaisan int,
@tentaisan nvarchar(255),
@soluong int,
@dongia int,
@nguoithem nvarchar(255)
as
begin
insert into QL_PhieuXuatTS_ChiTiet(IDPhieuXuat,IDTaiSan,TenTaiSan,SoLuong,DonGia,NguoiThem,NgayThem)
values(@idphieu,@idtaisan,@tentaisan,@soluong,@dongia,@nguoithem,GETDATE())
end

alter proc get_chiTietXuat
as
begin
select * from QL_PhieuThanhLyTS_ChiTiet
end

---============= proc chi tiet phieu thu hoi
alter proc insert_chiTietThuHoi
@idphieu int,
@idtaisan int,
@tentaisan nvarchar(255),
@soluong int,
@dongia int,
@nguoithem nvarchar(255)
as
begin
insert into QL_PhieuThuHoiTS_ChiTiet(IDPhieuThuHoi,IDTaiSan,TenTaiSan,SoLuong,DonGia,NguoiThem,NgayThem)
values(@idphieu,@idtaisan,@tentaisan,@soluong,@dongia,@nguoithem,GETDATE())
end

alter proc get_chiTietThuHoi
as
begin
select * from QL_PhieuThuHoiTS_ChiTiet
end

--================
alter proc insert_update_NhanHieu
@id int,
@tennhanhieu nvarchar(255),
@nguoisua nvarchar(255)
as
begin
if (exists(select ID from TK_NhanHieu where id = @id))
update TK_NhanHieu set TenNhanHieu = @tennhanhieu, NguoiSua = @nguoisua where ID = @id
else
insert into TK_NhanHieu(TenNhanHieu,NguoiSua) values(@tennhanhieu, @nguoisua)
end

exec insert_update_NhanHieu 0,N'Acer',N'Bo Kha' 

select * from TK_NhanHieu
