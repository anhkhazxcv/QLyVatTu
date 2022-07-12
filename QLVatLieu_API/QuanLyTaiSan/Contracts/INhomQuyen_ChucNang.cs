using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Contracts
{
    public interface INhomQuyen_ChucNangRepository
    {
        public Task<IEnumerable<NhomQuyen_ChucNang>> GetNhomQuyen_ChucNang();
/*        public Task<NhomQuyen_ChucNang> CreateNhomQuyen_ChucNang(NhomQuyen_ChucNangForCreationDto NhomQuyen_ChucNang);
        public Task<NhomQuyen_ChucNang> GetNhomQuyen_ChucNang(int id);
        public Task<NhomQuyen_ChucNang> UpdateNhomQuyen_ChucNang(NhomQuyen_ChucNang NhomQuyen_ChucNang);
        public Task DeleteNhomQuyen_ChucNang(int id);*/
    }
}