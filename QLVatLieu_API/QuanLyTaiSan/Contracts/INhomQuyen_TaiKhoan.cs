using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Contracts
{
    public interface INhomQuyen_TaiKhoanRepository
    {
        public Task<IEnumerable<NhomQuyen_TaiKhoan>> GetNhomQuyen_TaiKhoan();
/*        public Task<NhomQuyen_TaiKhoan> CreateNhomQuyen_TaiKhoan(NhomQuyen_TaiKhoanForCreationDto NhomQuyen_TaiKhoan);
        public Task<NhomQuyen_TaiKhoan> GetNhomQuyen_TaiKhoan(int id);
        public Task<NhomQuyen_TaiKhoan> UpdateNhomQuyen_TaiKhoan(NhomQuyen_TaiKhoan NhomQuyen_TaiKhoan);
        public Task DeleteNhomQuyen_TaiKhoan(int id);*/
    }
}