namespace QuanLyTaiSan.Entities
{
    public class QL_PhieuThanhLyTS
    {
        public int ID { get; set; }
        public int IDNguoiXuat { get; set; }
        public String TenNguoiMua { get; set; }
        public String NguoiThem { get; set; }
        
        public DateTime NgayThem { get; set; }
        public String NguoiSua { get; set; }
        
        
        public DateTime NgaySua { get; set; }
        public Boolean TrangThai { get; set; }
        

    }
}
