namespace QuanLyTaiSan.Entities
{
    public class NhomQuyen
    {
        public int ID { get; set; }
        public String TenNhomQuyen { get; set; }
        public String NguoiThem { get; set; }
        public DateTime NgayThem { get; set; }
        public String NguoiSua { get; set; }
        public String NgaySua { get; set; }
        public Boolean TrangThai { get; set; }
    }
}
