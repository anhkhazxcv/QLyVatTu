namespace QuanLyTaiSan.Entities
{
    public class NhanHieu
    {
        public int Id { get; set; }
        public string TenNhanHieu { get; set; }
        public string NguoiThem { get; set; }
        public DateTime NgayThem { get; set; }
        public string NguoiSua { get; set; }
        public DateTime NgaySua { get; set; }
        public Boolean TrangThai { get; set; }
    }
}
