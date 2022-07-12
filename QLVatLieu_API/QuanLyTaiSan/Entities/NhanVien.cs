namespace QuanLyTaiSan.Entities
{
    public class NhanVien
    {
        public int IDNV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
        public int IDPhongBan { get; set; }
        public int IDNhomQuyen { get; set; } 
        public string NguoiThem { get; set; }
        public DateTime NgayThem { get; set; }
        public String NguoiSua { get; set; }
        public DateTime NgaySua { get; set; }
        public Boolean TrangThai { get; set; }
       

    }
}
