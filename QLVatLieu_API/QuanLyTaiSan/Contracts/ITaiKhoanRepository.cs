using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Contracts
{
    public interface ITaiKhoanRepository
    {
        public Task<IEnumerable<TaiKhoan>> GetTaiKhoan();
        public Task<TaiKhoan> CreateTaiKhoan(TaiKhoanForCreationDto TaiKhoan);
        public Task<TaiKhoan> GetTaiKhoan(int id);
        public Task<TaiKhoan> UpdateTaiKhoan(TaiKhoan TaiKhoan);
        public Task DeleteTaiKhoan(int id);
    }
}
