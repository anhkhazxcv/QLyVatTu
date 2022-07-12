using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Contracts
{
    public interface IDangNhapRepository
    {
        public Task<DangNhap> GetDangNhap(DangNhap DangNhap);
      /*  public Task<DangNhap> CreateDangNhap(DangNhapForCreationDto DangNhap);
        public Task<DangNhap> GetDangNhap(int id);
        public Task<DangNhap> UpdateDangNhap(int id, DangNhapForCreationDto DangNhap);
        public Task DeleteDangNhap(int id);*/
    }
}
