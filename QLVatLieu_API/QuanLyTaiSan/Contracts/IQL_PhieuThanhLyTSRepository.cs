using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Contracts
{
    public interface IQL_PhieuThanhLyTSRepository
    {
        public Task<IEnumerable<QL_PhieuThanhLyTS>> GetQL_PhieuThanhLyTS();
        public Task<QL_PhieuThanhLyTS> CreateQL_PhieuThanhLyTS(QL_PhieuThanhLyTS QL_PhieuThanhLyTS);
        public Task<QL_PhieuThanhLyTS> GetQL_PhieuThanhLyTSid(int id);
       // public Task<QL_PhieuThanhLyTS> UpdateQL_PhieuThanhLyTS(int id, QL_PhieuThanhLyTS QL_PhieuThanhLyTS);
    }
}
