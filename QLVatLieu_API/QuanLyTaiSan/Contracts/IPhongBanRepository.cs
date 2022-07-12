using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Contracts
{
    public interface IPhongBanRepository
    {

        public Task<IEnumerable<PhongBan>> GetPhongBan();
        public Task<PhongBan> CreatePhongBan(PhongBanForCreationDto PhongBan);
        public Task<PhongBan> GetPhongBan(int id);
        public Task<PhongBan> UpdatePhongBan(PhongBan PhongBan);
        public Task DeletePhongBan(int id);
    }
}

