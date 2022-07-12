using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Contracts
{
    public interface IPhieuNhapTSRepository
    {
        public Task<IEnumerable<PhieuNhapTS>> GetPhieuNhapTS();
        public Task<PhieuNhapTS> CreatePhieuNhapTS(PhieuNhapTS PhieuNhapTS);
        public Task<PhieuNhapTS> GetPhieuNhapTS(int id);
        public Task<PhieuNhapTS> UpdatePhieuNhapTS(int id, PhieuNhapTS PhieuNhapTS);
    }
}
