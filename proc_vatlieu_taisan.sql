  create proc delect_TaiSan
  @IDTaiSan int
  as
  begin
	DELETE FROM [dbo].[TaiSan]
      WHERE @IDTaiSan = IDTaiSan
	  print N'xoa thanh cong'
end



create proc insert_nhanvien
@HoTen nvarchar(255),
@GioiTinh nvarchar(20),
@NgaySinh date,
@DiaChi nvarchar(255),
@SDT int,
@CMND int,
@IDPhongBan int,

as begin
INSERT INTO [dbo].[NhanVien]
           ([HoTen]
           ,[GioiTinh]
           ,[NgaySinh]
           ,[DiaChi]
           ,[SDT]
           ,[CMND]
           ,[IDPhongBan]
           ,[NgayThem]
           ,[NgaySua]
           ,[NguoiThem]
           ,[NguoiSua])
     VALUES
           (<HoTen, nvarchar(255),>
           ,<GioiTinh, nvarchar(20),>
           ,<NgaySinh, date,>
           ,<DiaChi, nvarchar(255),>
           ,<SDT, int,>
           ,<CMND, int,>
           ,<IDPhongBan, int,>
           ,<NgayThem, date,>
           ,<NgaySua, date,>
           ,<NguoiThem, varchar(255),>
           ,<NguoiSua, varchar(255),>)

end

