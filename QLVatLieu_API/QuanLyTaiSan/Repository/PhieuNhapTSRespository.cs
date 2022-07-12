using Dapper;
using QuanLyTaiSan.Context;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Entities;
using System.Data;

namespace QuanLyTaiSan.Repository
{
    public class PhieuNhapTSRepository : IPhieuNhapTSRepository
    {
        private readonly DapperContext _context;
        public PhieuNhapTSRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PhieuNhapTS>> GetPhieuNhapTS()
        {
            var procedureName = "get_PhieuNhapTS";
            var parameters = new DynamicParameters();

            using (var connection = _context.CreateConnection())
            {
                var PhieuNhapTS = await connection.QueryAsync<PhieuNhapTS>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return PhieuNhapTS;
            }
        }

        public async Task<PhieuNhapTS> CreatePhieuNhapTS(PhieuNhapTS PhieuNhapTS)
        {
            var procedureName = "insert_PhieuNhapTS";
            var parameters = new DynamicParameters();
            parameters.Add("nguoigiaohang", PhieuNhapTS.NguoiGiaoHang, DbType.String);
            parameters.Add("idkho", PhieuNhapTS.IDKho, DbType.Int64);
            parameters.Add("idnguoithem", PhieuNhapTS.IDNguoiThem, DbType.Int64);
            parameters.Add("soluong", PhieuNhapTS.SoLuong, DbType.Int64);
            parameters.Add("tentaisan", PhieuNhapTS.TenTaiSan, DbType.String);
            parameters.Add("dongia", PhieuNhapTS.DonGia, DbType.Int64);
            parameters.Add("nguoiThem", PhieuNhapTS.NguoiThem, DbType.String);




            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<PhieuNhapTS>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }

        }
        public async Task<PhieuNhapTS> GetPhieuNhapTS(int id)
        {
            var procedureName = "get_PhieuNhapTSid";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<PhieuNhapTS>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }
        public async Task<PhieuNhapTS> UpdatePhieuNhapTS(int id, PhieuNhapTS PhieuNhapTS)
        {
            var query = "update_PhieuNhapTS";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            parameters.Add("nguoigiaohang", PhieuNhapTS.NguoiGiaoHang, DbType.String);
            parameters.Add("idkho", PhieuNhapTS.IDKho, DbType.Int64);
            parameters.Add("idnguoithem", PhieuNhapTS.IDNguoiThem, DbType.Int64);
            parameters.Add("soluong", PhieuNhapTS.SoLuong, DbType.Int64);
            parameters.Add("tentaisan", PhieuNhapTS.TenTaiSan, DbType.String);
            parameters.Add("dongia", PhieuNhapTS.DonGia, DbType.Int64);
            parameters.Add("nguoiThem", PhieuNhapTS.NguoiThem, DbType.String);

            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<PhieuNhapTS>
                    (query, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }




    }
}
