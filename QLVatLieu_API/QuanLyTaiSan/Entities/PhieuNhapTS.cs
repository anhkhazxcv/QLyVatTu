namespace QuanLyTaiSan.Entities
{
    public class PhieuNhapTS
    {
        public int ID { get; set; }
        public string NguoiGiaoHang { get; set; }
        public int IDKho { get; set; }
        public int IDNguoiThem { get; set; }
        public int SoLuong { get; set; }
        public string TenTaiSan { get; set; }
        public int DonGia { get; set; }
        public string NguoiThem { get; set; }
        public DateTime NgayThem { get; set; }
        public string NguoiSua { get; set; }
        public DateTime NgaySua { get; set; }
        public Boolean TrangThai { get; set; }
    }
}

