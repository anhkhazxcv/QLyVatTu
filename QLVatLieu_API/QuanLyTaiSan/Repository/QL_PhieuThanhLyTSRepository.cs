using Dapper;
using QuanLyTaiSan.Context;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Entities;
using System.Data;

namespace QuanLyTaiSan.Repository
{
    public class QL_PhieuThanhLyTSRepository : IQL_PhieuThanhLyTSRepository
    {
        private readonly DapperContext _context;
        public QL_PhieuThanhLyTSRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<QL_PhieuThanhLyTS>> GetQL_PhieuThanhLyTS()
        {
            var procedureName = "get_PhieuThanhLy";
            var parameters = new DynamicParameters();

            using (var connection = _context.CreateConnection())
            {
                var QL_PhieuThanhLyTS = await connection.QueryAsync<QL_PhieuThanhLyTS>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return QL_PhieuThanhLyTS;
            }
        }

        public async Task<QL_PhieuThanhLyTS> CreateQL_PhieuThanhLyTS(QL_PhieuThanhLyTS QL_PhieuThanhLyTS)
        {
            var procedureName = "insert_PhieuThanhLy";
            var parameters = new DynamicParameters();
            parameters.Add("idnguoixuat", QL_PhieuThanhLyTS.IDNguoiXuat, DbType.UInt64);
            parameters.Add("tennguoimua", QL_PhieuThanhLyTS.TenNguoiMua, DbType.String);
            parameters.Add("nguoithem", QL_PhieuThanhLyTS.NguoiThem, DbType.String);
            




            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<QL_PhieuThanhLyTS>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }

        }
        public async Task<QL_PhieuThanhLyTS> GetQL_PhieuThanhLyTSid(int id)
        {
            var procedureName = "get_QL_PhieuThanhLyTSid";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<QL_PhieuThanhLyTS>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }
        




    }
}
