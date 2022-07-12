using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Contracts
{
    public interface INhomQuyenRepository
    {
        public Task<IEnumerable<NhomQuyen>> GetNhomQuyen();
        public Task<NhomQuyen> CreateNhomQuyen(NhomQuyen NhomQuyen);
        public Task<NhomQuyen> GetNhomQuyen(int id);
        public Task<NhomQuyen> UpdateNhomQuyen(int id, NhomQuyen NhomQuyen);
    }
}
