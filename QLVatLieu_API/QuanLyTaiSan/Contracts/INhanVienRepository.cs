using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Contracts
{
    public interface INhanVienRepository
    {
         
        public Task<IEnumerable<NhanVien>> GetNhanVien();
        public Task<NhanVien> CreateNhanVien(NhanVienForCreationDto NhanVien);
        public Task<NhanVien> GetNhanVien(int id);
        public Task<NhanVien> UpdateNhanVien(NhanVien NhanVien);
        public Task DeleteNhanVien(int id);
    }
}

