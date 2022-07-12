using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Contracts
{
    public interface INhanHieuRepository
    {
        public Task<IEnumerable<NhanHieu>> GetNhanHieu();
        public Task<NhanHieu> CreateNhanHieu(NhanHieu NhanHieu);
        public Task<NhanHieu> GetNhanHieu(int id);
    }
}
